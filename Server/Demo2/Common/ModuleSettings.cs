using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Settings;

namespace Bring2mind.Demo2025Mvc.Demo2.Common
{
    public class ModuleSettings
    {
        [ModuleSetting]
        public string View { get; set; } = "Index";

        public static ModuleSettings GetSettings(ModuleInfo module)
        {
            var repo = new ModuleSettingsRepository();
            return repo.GetSettings(module);
        }

        public void SaveSettings(ModuleInfo module)
        {
            var repo = new ModuleSettingsRepository();
            repo.SaveSettings(module, this);
        }
    }
    public class ModuleSettingsRepository : SettingsRepository<ModuleSettings>
    {
    }
}