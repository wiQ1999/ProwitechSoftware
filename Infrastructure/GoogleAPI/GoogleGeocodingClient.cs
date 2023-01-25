using Infrastructure.GoogleAPI.Responses;
using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.WebUtilities;
using Infrastructure.Responses.BuildingAddressController;
using Infrastructure.Responses;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.GoogleAPI
{
    public class GoogleGeocodingClient
    {
        private const string baseAddress = $"https://maps.googleapis.com/maps/api/geocode/";
        private string apiKey;
        //= "AIzaSyC5f4Vto2rwP0J72ANp6sWJAxlZvKqRmAw";

        private HttpClient client;
        private BuildingAddress postedAddress;

        public async Task<AddUpdateBuildingAddressReponse> SetCoordinatesAndPostalCode(bool force, string outputFormat = "json")
        {
            GoogleAPIResponse APIresult = await GeocodeGET(outputFormat);

            GoogleGeocodeAPIData googleGeocodeAPIData = GoogleGeocodeAPIData.GetData(APIresult);

            AddUpdateBuildingAddressReponse addBuildingAddressResponse = new AddUpdateBuildingAddressReponse();

            addBuildingAddressResponse = new AddUpdateBuildingAddressReponse(googleGeocodeAPIData, postedAddress);

            addBuildingAddressResponse.WebApiStatus = SetStatus(addBuildingAddressResponse, googleGeocodeAPIData, force).ToString();
            return addBuildingAddressResponse;
        }
        private ProwitechWebAPIStatus SetStatus(AddUpdateBuildingAddressReponse addBuildingAddressResponse, GoogleGeocodeAPIData googleGeocodeAPIData, bool force)
        {
            // błąd po stronie googleAPI
            if (googleGeocodeAPIData.HttpStatusCode != HttpStatusCode.OK || googleGeocodeAPIData.GoogleApiStatus != "OK")
            {
                return ProwitechWebAPIStatus.ERROR;
            }
            // wysłany przez użytkownika adres nie posiadał współrzędnych
            if (postedAddress.Longitude is null && postedAddress.Latitude is null)
            {
                // użytkownik podał dobry adres --> odnaleziono dokładne współrzędne w GoogleAPI
                if (addBuildingAddressResponse.CoordinateType == "ROOFTOP") return ProwitechWebAPIStatus.ADDED_TO_DB;

                // użytkownik wpisał niedokładny adres lub GoogleAPI nie znalazł dokładnego adresu
                // współrzędne będą przybliżone - zapytaj użytkownika czy to akceptuje
                else return ProwitechWebAPIStatus.NOT_ADDED_COORDINATES_TYPE_ISSUE;
            }
            // użytkownik wysłał adres ponownie mimo że jest niedokładny do dodania do bazy
            else
            {
                if (force
                    && addBuildingAddressResponse.AddedBuildingAddress.Longitude == postedAddress.Longitude
                    && addBuildingAddressResponse.AddedBuildingAddress.Latitude == postedAddress.Latitude)
                {
                    return ProwitechWebAPIStatus.ADDED_DESPITE_COORDINATE_ISSUE;
                }
                else return ProwitechWebAPIStatus.NOT_ADDED_ERROR;
            }
        }
        public GoogleGeocodingClient(BuildingAddress postedAddress, IConfiguration configuration)
        {
            client = new HttpClient();
            this.postedAddress = postedAddress;
            this.apiKey = configuration["googleGeocodingAPIkey"];
        }
        private Uri CreateUrl(BuildingAddress buildingAddress, string outputFormat)
        {
            string baseAddressWithFormat = String.Concat(baseAddress, outputFormat);
            string address = "";

            string streetName = StringNormalizer.ReturnStringWithoutDiacritics(buildingAddress.StreetName);
            string cityName = StringNormalizer.ReturnStringWithoutDiacritics(buildingAddress.CityName);


            if (streetName == cityName)
                address = String.Concat(cityName, " ", buildingAddress.BuildingNumber, " ", "Polska");
            else
                address = String.Concat(streetName, " ", buildingAddress.BuildingNumber, " ", cityName, " ", "Polska");

            var parameters = new Dictionary<string, string>()
            {
                {"address", HttpUtility.UrlEncode(address)},
                { "language", "pl"},
                {"key", apiKey }
            };
            var newUrl = new Uri(QueryHelpers.AddQueryString(baseAddressWithFormat, parameters));
            return newUrl;
        }
        private async Task<GoogleAPIResponse> GeocodeGET(string outputFormat)
        {
            GoogleAPIResponse googleAPIresponse = new GoogleAPIResponse();
            Uri url = CreateUrl(postedAddress, outputFormat);
            client.DefaultRequestHeaders.Accept.Clear();
            var response = await client.GetAsync(url);
            googleAPIresponse.HttpStatusCode = response.StatusCode;
            if (response.IsSuccessStatusCode) googleAPIresponse.Content = await response.Content.ReadAsStringAsync();
            else googleAPIresponse.Content = "";

            return googleAPIresponse;
        }
    }
}
