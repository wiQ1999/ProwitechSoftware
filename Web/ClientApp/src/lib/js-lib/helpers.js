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
