using System.Collections.Generic;
using Lab4.Models;

namespace Lab4.Data
{
    public class SampleData {
        public static List<Province> GetProvinces() {
            List<Province> provinces = new List<Province>() {
                new Province() {
                    ProvinceCode="BC",
                    ProvinceName="British Columbia",
                },
                new Province() {
                    ProvinceCode="AB",
                    ProvinceName="Alberta",
                },
                new Province() {
                    ProvinceCode="MB",
                    ProvinceName="Manitoba",
                },
            };

            return provinces;
        }

        public static List<City> GetCities() {
            List<City> cities = new List<City>() {
                new City {
                    CityId = 1,
                    CityName = "Vancouver",
                    Population = 630000,
                    ProvinceCode = "BC",
                },
                new City {
                    CityId = 2,
                    CityName = "Victoria",
                    Population = 80000,
                    ProvinceCode = "BC",
                },
                new City {
                    CityId = 3,
                    CityName = "Kelowna",
                    Population = 140000,
                    ProvinceCode = "BC",
                },
                new City {
                    CityId = 4,
                    CityName = "Edmonton",
                    Population = 970000,
                    ProvinceCode = "AB",
                },
                new City {
                    CityId = 5,
                    CityName = "Calgary",
                    Population = 1200000,
                    ProvinceCode = "AB",
                },
                new City {
                    CityId = 6,
                    CityName = "Red Deer",
                    Population = 83000,
                    ProvinceCode = "AB",
                },
                new City {
                    CityId = 7,
                    CityName = "Winnipeg",
                    Population = 660000,
                    ProvinceCode = "MB",
                },
                new City {
                    CityId = 8,
                    CityName = "Selkirk",
                    Population = 10000,
                    ProvinceCode = "MB",
                },
                new City {
                    CityId = 9,
                    CityName = "Morden",
                    Population = 6600,
                    ProvinceCode = "MB",
                },
            };

            return cities;
        }
    }
}