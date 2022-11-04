export class HttpMethodError extends Error {
  constructor(message, errors = null) {
    super(message);
    this.name = "HttpMethodError";
    this.message = message;
    this.errorsList = errors;
  }
}
export function handleError(error, actionName) {
  let alert_message = "";
  if (error instanceof HttpMethodError) {
    let displayErrors = "";
    if (error.errorsList != null) {
      for (let key in error.errorsList) {
        displayErrors += error.errorsList[key];
        displayErrors += " ";
      }
    }
    console.log(displayErrors);
    alert_message = `Błąd HTTP przy wysyłaniu danych!\nWykonywana akcja: [${actionName}]\nInformacje o błędzie:\n${error.message}\n${displayErrors}`;
  } else if (error instanceof Error) {
    console.log(error);
    alert_message = `Wystąpił inny błąd: ${error.message}\n${error.stack}\nWykonywana akcja: [${actionName}]`;
  }
  alert(alert_message);
}
