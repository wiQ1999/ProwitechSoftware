import { addOptionalParameters } from "./helpers";
import { HttpMethodError } from "./errors";
import { json } from "@sveltejs/kit";

const apiAddress = "http://localhost:7186";

export async function genericPost(
  route,
  bodyToJsonize,
  optionalParameters = null
) {
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
  if (!response.ok) {
    let json = await response.clone().json();
    let message = `Kod błędu: ${json.status} | Szczegóły: ${json.title}`;
    if (json.title == "One or more validation errors occurred.") {
      throw new HttpMethodError(message, json.errors);
    }
    throw new HttpMethodError(message);
  }

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
  if (!response.ok) {
    let json = await response.clone().json();
    let message = `Kod błędu: ${json.status} | Szczegóły: ${json.title}`;
    if (json.title == "One or more validation errors occurred.") {
      throw new HttpMethodError(message, json.errors);
    }
    throw new HttpMethodError(message);
  }
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

  if (!response.ok) {
    let json = await response.clone().json();
    let message = `Kod błędu: ${json.status} | Szczegóły: ${json.title}`;
    if (json.title == "One or more validation errors occurred.") {
      throw new HttpMethodError(message, json.errors);
    }
    throw new HttpMethodError(message);
  }
  return response;
}
export async function genericDelete(route, id) {
  let halfUrl = route + "/" + id;
  let url = apiAddress.concat(halfUrl);
  let response;
  let fetchData = {
    method: "DELETE",
    headers: new Headers({
      "content-type": "application/json",
    }),
  };

  response = await fetch(url, fetchData);

  if (!response.ok) {
    let json = await response.clone().json();
    let message = `Kod błędu: ${json.status} | Szczegóły: ${json.title}`;
    if (json.title == "One or more validation errors occurred.") {
      throw new HttpMethodError(message, json.errors);
    }
    throw new HttpMethodError(message);
  }
  return response;
}
export async function genericPut(
  route,
  id,
  bodyToJsonize,
  optionalParameters = null
) {
  let response;
  let halfUrl = route + "/" + id;
  let url = apiAddress.concat(halfUrl);
  url = addOptionalParameters(url, optionalParameters);

  let fetchData = {
    method: "PUT",
    body: JSON.stringify(bodyToJsonize),
    headers: new Headers({
      "content-type": "application/json",
    }),
  };

  response = await fetch(url, fetchData);

  if (!response.ok) {
    let json = await response.clone().json();
    let message = `Kod błędu: ${json.status} | Szczegóły: ${json.title}`;
    if (json.title == "One or more validation errors occurred.") {
      throw new HttpMethodError(message, json.errors);
    }
    throw new HttpMethodError(message);
  }

  return response;
}
