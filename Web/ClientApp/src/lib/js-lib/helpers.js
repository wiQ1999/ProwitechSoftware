function isEmpty(obj) {
  return Object.keys(obj).length === 0;
}
export function addOptionalParameters(url, parametersDictionary) {
  let urlWithParameters = url + "?";
  if (parametersDictionary == null || isEmpty(parametersDictionary)) return url;
  for (var key in parametersDictionary) {
    urlWithParameters += `${key}=${parametersDictionary[key]}&`;
  }
  urlWithParameters = urlWithParameters.substring(
    0,
    urlWithParameters.length - 1
  );
  return urlWithParameters;
}
export const AddUpdateBuildingAddressRequestResult = {
  success: "success",
  error: "error",
  overQueryLimit: "overQueryLimit",
};
// export const PropertyManagerUpdatePartialResponse={
//   buildingAddress_updated:"buildingAddress_updated",

// }
export function prepareCoordinatesNotFoundMessage(
  addedBuildingAddress,
  buildingAddressJSON
) {
  let cityName = addedBuildingAddress.cityName;
  let streetName = addedBuildingAddress.streetName;
  let buildingNumber = addedBuildingAddress.buildingNumber;

  return `Nie znaleziono dokładnych współrzędnych dla adresu ${streetName} ${buildingNumber}, ${cityName}
  \nOdnaleziono współrzędne dla adresu: ${buildingAddressJSON.googleAPIFormattedAddress}.
  \nCzy chce je zachować?`;
}
export function chooseNewStringIfNewDiffersFromOld(oldStr, newStr) {
  if (oldStr != newStr) {
    return newStr;
  }
  return oldStr;
}

export function formatDate(
  inputDate,
  addTime = false,
  forGettingBiggestNumber = false
) {
  let date, month, year, hour, minutes;

  date = inputDate.getDate();
  month = inputDate.getMonth() + 1;
  year = inputDate.getFullYear();

  date = date.toString().padStart(2, "0");
  month = month.toString().padStart(2, "0");

  if (addTime) {
    hour = inputDate.getHours();
    minutes = inputDate.getMinutes();

    hour = hour.toString().padStart(2, "0");
    minutes = minutes.toString().padStart(2, "0");
    return `${year}-${month}-${date}T${hour}:${minutes}`;
  }
  if (forGettingBiggestNumber) return `${year}_${month}_${date}`;

  // return `${date}/${month}/${year}`;
  return `${year}-${month}-${date}`;
}
export function prepareDateTime(inputDate, initialDateTime = false) {
  if (initialDateTime) {
    let dateAsString = formatDate(inputDate);
    return dateAsString + "T08:00:00";
  } else {
    let dateAsString = formatDate(inputDate, true);
    return dateAsString;
  }
}
export function setResultFormatIfItIsDateTime(propertyName, propertyValue) {
  if (propertyName.includes("DateTime")) {
    if (propertyValue == "0001-01-01T00:00:00") return null;
    let d = new Date(propertyValue);
    return new Intl.DateTimeFormat("pl-PL", {
      dateStyle: "short",
      timeStyle: "short",
    }).format(d);
  }
  return propertyValue;
}
