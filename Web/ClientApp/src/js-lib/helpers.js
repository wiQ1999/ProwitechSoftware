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
