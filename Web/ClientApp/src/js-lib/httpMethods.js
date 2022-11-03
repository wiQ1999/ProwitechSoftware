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
  let json = await response.clone().json();

  if (!response.ok) throw new HttpMethodError(json);

  return response;
}

export async function genericGetAll(route) {
  let url = apiAddress.concat(route);
  let response;

  let fetchData = {
    method: "GET",
    headers: new Headers({
      "content-type": "application/json",
    }),
  };

  response = await fetch(url, fetchData);
  let json = await response.clone().json();

  if (!response.ok) throw new HttpMethodError(json);
  return response;
}
export async function genericGetById(route, id) {
  let halfUrl = route + "/" + id;
  let url = apiAddress.concat(halfUrl);
  let response;
  let fetchData = {
    method: "GET",
    headers: new Headers({
      "content-type": "application/json",
    }),
  };

  response = await fetch(url, fetchData);

  let json = await response.clone().json();

  if (!response.ok) throw new HttpMethodError(json);
  return response;
}
