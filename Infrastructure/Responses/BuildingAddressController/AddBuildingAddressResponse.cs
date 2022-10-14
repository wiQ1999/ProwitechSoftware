using Infrastructure.GoogleAPI.Responses;
using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Responses.BuildingAddressController
{
    public class AddBuildingAddressResponse
    {
        public BuildingAddress AddedBuildingAddress { get; set; }
        public string GoogleApiStatus { get; set; }
        public string CoordinateType { get; set; }
        public string HttpStatusResponse { get; set; }
        public int HttpStatusCode { get; set; }
        public string WebApiStatus { get; set; }
        public AddBuildingAddressResponse(GoogleGeocodeAPIData googleGeocodeAPIData, BuildingAddress buildingAddress, ProwitechWebAPIStatus status = ProwitechWebAPIStatus.UNKNOWN)
        {
            AddedBuildingAddress = buildingAddress.DeepCopy();
            AddedBuildingAddress.Longitude = googleGeocodeAPIData.Longitude;
            AddedBuildingAddress.Latitude = googleGeocodeAPIData.Latitude;
            AddedBuildingAddress.CoordinateType = googleGeocodeAPIData.CoordinateType;
            AddedBuildingAddress.PostalCode = googleGeocodeAPIData.PostalCode;

            GoogleApiStatus = googleGeocodeAPIData.GoogleApiStatus;
            CoordinateType = googleGeocodeAPIData.CoordinateType;
            HttpStatusResponse = googleGeocodeAPIData.HttpStatusCode.ToString();
            HttpStatusCode = (int)googleGeocodeAPIData.HttpStatusCode;
            WebApiStatus = status.ToString();
        }
        public AddBuildingAddressResponse()
        {

        }
    }
}
