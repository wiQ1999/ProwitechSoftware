export class HttpMethodError extends Error {
  constructor(json) {
    super(`Kod błędu: ${json.status} | Szczegóły: ${json.title}`);
    this.name = "HttpMethodError";
  }
}
