using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.GoogleAPI.Responses
{
    public class GoogleGeocodeAPIData
    {
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string PostalCode { get; set; }
        public string GoogleApiStatus { get; set; }
        public string CoordinateType { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
        public GoogleGeocodeAPIData()
        {
            Longitude = -200;
            Latitude = -200;
            CoordinateType = "unknown";
            GoogleApiStatus = "unknown";
        }
        public static GoogleGeocodeAPIData GetData(GoogleAPIResponse APIresponse)
        {
            GoogleGeocodeAPIData googleGeocodeAPIData = new GoogleGeocodeAPIData();

            googleGeocodeAPIData.HttpStatusCode = APIresponse.HttpStatusCode;
            if (googleGeocodeAPIData.HttpStatusCode != HttpStatusCode.OK) return googleGeocodeAPIData;

            dynamic results = JsonConvert.DeserializeObject(APIresponse.Content);
            googleGeocodeAPIData.GoogleApiStatus = results.status;
            if (googleGeocodeAPIData.GoogleApiStatus == "OK")
            {
                googleGeocodeAPIData.CoordinateType = results.results[0].geometry.location_type;
                googleGeocodeAPIData.Latitude = results.results[0].geometry.location.lat;
                googleGeocodeAPIData.Longitude = results.results[0].geometry.location.lng;

                var addressComponents = results.results[0].address_components;
                List<GoogleAddressComponent> components = addressComponents.ToObject<List<GoogleAddressComponent>>();
                googleGeocodeAPIData.PostalCode = components.Where(o => o.types.Contains("postal_code")).FirstOrDefault().long_name;

            }
            return googleGeocodeAPIData;
        }
    }
}
