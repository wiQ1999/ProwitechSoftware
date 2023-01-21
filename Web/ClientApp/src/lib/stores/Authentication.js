import { apiAddress } from "../js-lib/httpMethods";
import { HttpMethodError } from "../js-lib/errors";

export async function getAuthenticated(login, password) {
    const url = apiAddress + `/Authentication?Login=${login}&Password=${password}`;
    const fetchData = {
        method: "GET",
        headers: new Headers({
            "content-type": "application/json",
        }),
    };

    const response = await fetch(url, fetchData);
    const json = await response.clone().json();

    if (!response.ok) {
        const message = `Kod błędu: ${json.status} | Szczegóły: ${json.title}`;

        if (json.title == "One or more validation errors occurred.")
            throw new HttpMethodError(message, json.errors);
        throw new HttpMethodError(message);
    }

    return json;
}
