using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Globalization;
using ApexCare.Model.ServiceRequests;
using ApexCare.Model.Technicians;
using System.Diagnostics.Contracts;
using ApexCare.Model.ServiceContracts;

namespace ApexCare.Model.JobAssignment
{
    public class OSMGeocoding
    {
        public static async Task<(double lat, double lon)> GetCoordinates(string city)
        {
            string url = $"https://nominatim.openstreetmap.org/search?q={city},South+Africa&format=json&limit=1";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "YourAppName/1.0");
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);

                if (json.Count == 0)
                {
                    throw new Exception($"No coordinates found for suburb: {city}");
                }

                double lat = double.Parse(json[0].lat.ToString(), CultureInfo.InvariantCulture);
                double lon = double.Parse(json[0].lon.ToString(), CultureInfo.InvariantCulture);
                return (lat, lon);
            }
        }
    }

    public class OSMDistanceCalculator
    {
        public static async Task<double> GetDistanceBetweenCoordinates(double lat1, double lon1, double lat2, double lon2)
        {
            string url = $"https://router.project-osrm.org/route/v1/driving/{lon1.ToString(CultureInfo.InvariantCulture)},{lat1.ToString(CultureInfo.InvariantCulture)};" +
                     $"{lon2.ToString(CultureInfo.InvariantCulture)},{lat2.ToString(CultureInfo.InvariantCulture)}?overview=false";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);

                if (json.routes.Count == 0)
                {
                    throw new Exception("No route found between the given coordinates.");
                }

                double distanceInMeters = json.routes[0].distance;
                return distanceInMeters / 1000.0;
            }
        }
    }

    public class DistanceCalculator
    {
        public static async Task<double> GetDistanceBetweenSuburbs(string city1, string city2)
        {
            try
            {
                var (lat1, lon1) = await OSMGeocoding.GetCoordinates(city1);
                var (lat2, lon2) = await OSMGeocoding.GetCoordinates(city2);

                double distance = await OSMDistanceCalculator.GetDistanceBetweenCoordinates(lat1, lon1, lat2, lon2);

                return distance;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return -1;
            }
        }
    }
    
    public class SchedulingSystem
    {
        public Technician AssignTechnician(Repair request, ServiceContract contract, List<RepairTechnician> AvailableTechnicians)
        {
            List<RepairTechnician> suitableTechnician = AvailableTechnicians.Where(tech => request.ProblemEquipment.All(equipment => 
            tech.EquimentSpecialties.Contains(equipment))).ToList();

            suitableTechnician = suitableTechnician.OrderBy(tech => DistanceCalculator.GetDistanceBetweenSuburbs(tech.City, contract.City)).ToList();

            return suitableTechnician.FirstOrDefault();
        }
    }    
}
