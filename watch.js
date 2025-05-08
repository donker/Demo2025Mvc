const chokidar = require("chokidar"),
  fs = require("fs-extra"),
  path = require("path"),
  deepmerge = require("deepmerge");

var pkg = require("./package.json"),
  pkgDemo1 = require("./Server/Demo1/dnn.json"),
  pkgDemo2 = require("./Server/Demo2/dnn.json");
if (fs.existsSync("./local.json")) {
  var local = require("./local.json");
  pkg = deepmerge(pkg, local);
}

var log = console.log.bind(console);

function copy(start, srcRelativePath, destDir) {
  if (!fs.existsSync(srcRelativePath)) {
    return null;
  }
  var relPath = path.relative(start, srcRelativePath);
  const fullDestPath = path.join(destDir, relPath);
  log("Copying: " + srcRelativePath);
  return fs
    .ensureDir(path.dirname(fullDestPath))
    .then(() => fs.copy(srcRelativePath, fullDestPath))
    .catch((err) => {
      console.error(err);
    });
}

const ignores = [
  "dnn.json",
  ".cs",
  "dnn.json",
  "launchSettings.json",
  ".csproj",
  ".vbproj",
  ".LICENSE.txt",
];

const ignoreFunc = (filePath) => {
  if (filePath.includes("/obj/") || filePath.includes("/bin/")) {
    return true;
  }
  if (ignores.some(ignore => filePath.endsWith(ignore))) {
    return true;
  }
  return false;
};

const allDlls = pkgDemo1.pathsAndFiles.assemblies
  .concat(pkgDemo2.pathsAndFiles.assemblies)
  .map((dll) => "bin/" + dll);

const watcher = (src, dest) =>
  chokidar
    .watch(src, {
      ignored: ignoreFunc,
      persistent: true,
    })
    .on("add", (path) => copy(src, path, dest))
    .on("change", (path) => copy(src, path, dest));
// Todo: delete events?

// Initialize watchers.
const Demo1Watcher = watcher(
  "Server/Demo1",
  pkg.dnn.pathsAndFiles.devSitePath + "\\DesktopModules\\MVC\\Bring2mind\\Demo1"
);

const Demo2Watcher = watcher(
  "Server/Demo2",
  pkg.dnn.pathsAndFiles.devSitePath + "\\DesktopModules\\MVC\\Bring2mind\\Demo2"
);

const DllWatcher = chokidar
  .watch(allDlls, {
    persistent: true,
  })
  .on("add", (path) => {
    copy("bin", path, pkg.dnn.pathsAndFiles.devSitePath + "\\bin");
    copy(
      "bin",
      path.replace(".dll", ".pdb"),
      pkg.dnn.pathsAndFiles.devSitePath + "\\bin"
    );
  })
  .on("change", (path) => {
    copy("bin", path, pkg.dnn.pathsAndFiles.devSitePath + "\\bin");
    copy(
      "bin",
      path.replace(".dll", ".pdb"),
      pkg.dnn.pathsAndFiles.devSitePath + "\\bin"
    );
  });
