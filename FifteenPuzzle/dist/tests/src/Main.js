import { render } from "react-dom";
import { createElement } from "react";
import { Components_Router } from "./Components.js";
import "../../../src/styles/global.scss";


render(createElement(Components_Router, null), document.getElementById("feliz-app"));

