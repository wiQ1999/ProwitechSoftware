import { addOptionalParameters } from "./helpers";
import { HttpMethodError } from "./errors";

const apiAddress = "https://localhost:7186";

export async function genericPost(route, bodyToJsonize, optionalParameters) {
  let response;
  let url = apiAddress.concat(route);
  url = addOptionalParameters(url, optionalParameters);

  let fetchData = {
    method: "POST",
    body: JSON.stringify(bodyToJsonize),
    headers: new Headers({
      "content-type": "application/json",
    }),
  };

  response = await fetch(url, fetchData);
  let json = await response.json();

  if (!response.ok) throw new HttpMethodError(json);

  return json;
}

export async function genericGet(route) {
  let url = apiAddress.concat(route);

  let fetchData = {
    method: "GET",
    headers: new Headers({
      "content-type": "application/json",
    }),
  };

  if (!response.ok)
    throw new HttpMethodError(response.status + " " + response.statusText);

  return await response.json();
}
