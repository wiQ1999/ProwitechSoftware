export class HttpMethodError extends Error {
  constructor(json) {
    console.log(json);
    super(`Kod błędu: ${json.status} | Szczegóły: ${json.title}`);
    this.name = "HttpMethodError";
  }
}
