import { openModal } from "svelte-modals";
import BasePopUp from "$lib/components/base/BasePopUp.svelte";

export class HttpMethodError extends Error {
  constructor(message, errors = null) {
    super(message);
    this.name = "HttpMethodError";
    this.message = message;
    this.errorsList = errors;
  }
}
export function handleError(error, actionName, reloadRequired = false) {
  let alert_message = "";
  if (error instanceof HttpMethodError) {
    let displayErrors = "";
    if (error.errorsList != null) {
      for (let key in error.errorsList) {
        displayErrors += error.errorsList[key];
        displayErrors += " ";
      }
    }
    alert_message = `Błąd HTTP przy wysyłaniu danych!\nWykonywana akcja: [${actionName}]\nInformacje o błędzie:\n${error.message}\n${displayErrors}`;
  } else if (error instanceof Error) {
    alert_message = `Wystąpił inny błąd: ${error.message}\n${error.stack}\nWykonywana akcja: [${actionName}]`;
  }
  // alert(alert_message);
  openModal(BasePopUp, {
    title: "Błąd",
    message: alert_message,
    reloadRequired: reloadRequired,
  });
}
