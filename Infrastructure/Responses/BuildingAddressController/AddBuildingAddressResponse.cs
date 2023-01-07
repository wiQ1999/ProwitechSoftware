using Infrastructure.GoogleAPI.Responses;
using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Responses.BuildingAddressController
{
    public class AddUpdateBuildingAddressReponse
    {
        public BuildingAddress AddedBuildingAddress { get; set; }
        public string GoogleApiStatus { get; set; }
        public string CoordinateType { get; set; }
        public string HttpStatusResponse { get; set; }
        public int HttpStatusCode { get; set; }
        public string WebApiStatus { get; set; }
        public string GoogleAPIFormattedAddress { get; set; }
        public AddUpdateBuildingAddressReponse(GoogleGeocodeAPIData googleGeocodeAPIData, BuildingAddress buildingAddress, ProwitechWebAPIStatus status = ProwitechWebAPIStatus.UNKNOWN)
        {
            AddedBuildingAddress = buildingAddress.DeepCopy();
            AddedBuildingAddress.Longitude = googleGeocodeAPIData.Longitude;
            AddedBuildingAddress.Latitude = googleGeocodeAPIData.Latitude;
            AddedBuildingAddress.CoordinateType = googleGeocodeAPIData.CoordinateType;
            AddedBuildingAddress.PostalCode = googleGeocodeAPIData.PostalCode;
            GoogleAPIFormattedAddress = googleGeocodeAPIData.FormattedAddress;

            GoogleApiStatus = googleGeocodeAPIData.GoogleApiStatus;
            CoordinateType = googleGeocodeAPIData.CoordinateType;
            HttpStatusResponse = googleGeocodeAPIData.HttpStatusCode.ToString();
            HttpStatusCode = (int)googleGeocodeAPIData.HttpStatusCode;
            WebApiStatus = status.ToString();
        }
        public AddUpdateBuildingAddressReponse()
        {

        }
    }
}
