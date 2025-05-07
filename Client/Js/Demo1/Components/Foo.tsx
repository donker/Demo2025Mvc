import * as React from "react";
import { IAppModule } from "../Models/IAppModule";

interface IFooProps {
  module: IAppModule;
  bar: string;
};

const Foo: React.FC<IFooProps> = props => {
  return <div>{props.bar}</div>;
}

export default Foo;


