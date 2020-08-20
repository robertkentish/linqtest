using System;
using System.Collections.Generic;

namespace LinqToTerraServerProvider
{
    internal static class WebServiceHelper
    {
        internal static Place[] GetPlacesFromTerraServer(List<string> locations)
        {
            // Limit the total number of Web service calls. 
            if (locations.Count > 5)
                throw new InvalidQueryException("This query requires more than five separate calls to the Web service. Please decrease the number of locations in your query.");

            List<Place> allPlaces = new List<Place>();

            // For each location, call the Web service method to get data. 
            foreach (string location in locations)
            {
                Place[] places = CallGetPlaceListMethod(location);
                allPlaces.AddRange(places);
            }

            return allPlaces.ToArray();
        }

        private static Place[] CallGetPlaceListMethod(string location)
        {
            try
            {
                var places = new Place[2];

                places[0] = new Place("Place1", "VIC", PlaceType.CityTown);
                places[0] = new Place("Place2", "VIC", PlaceType.CityTown);

                return places;
            }
            catch 
            {
                throw;
            }
        }
    }
}