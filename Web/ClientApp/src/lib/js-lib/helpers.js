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

function formatDate(inputDate) {
  let date, month, year;

  date = inputDate.getDate();
  month = inputDate.getMonth() + 1;
  year = inputDate.getFullYear();

  date = date.toString().padStart(2, "0");

  month = month.toString().padStart(2, "0");

  // return `${date}/${month}/${year}`;
  return `${year}-${month}-${date}`;
}
export function prepareDateTime(inputDate) {
  let dateAsString = formatDate(inputDate);
  return dateAsString + "T08:00";
}
