using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countriesAndListCityAndPopulation = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine != "report")
                {
                    string[] inputList = inputLine.Split('|');
                    string country = inputList[1];
                    string city = inputList[0];
                    long population = long.Parse(inputList[2]);
                    
                    if(!countriesAndListCityAndPopulation.ContainsKey(country))
                    {
                        countriesAndListCityAndPopulation.Add(country, new Dictionary<string, long>());
                    }
                    if (!countriesAndListCityAndPopulation[country].ContainsKey(city))
                    {
                        countriesAndListCityAndPopulation[country].Add(city, 0);
                    }
                    countriesAndListCityAndPopulation[country][city] += population;

                }
                else
                {
                    Dictionary<string, long> countryAllPopulation = new Dictionary<string, long>();

                   
                    foreach (var countryAndListCityAndPopulation in countriesAndListCityAndPopulation)
                    {
                        long sumPopulation = 0;

                        foreach (var cityAndPopulation in countryAndListCityAndPopulation.Value)
                        {
                            sumPopulation += cityAndPopulation.Value;
                        }

                        countryAllPopulation.Add(countryAndListCityAndPopulation.Key, sumPopulation);


                    }



                    foreach (var countryAndPopulation in countryAllPopulation.OrderByDescending(key => key.Value))
                    {
                        Console.WriteLine("{0} (total population: {1})",countryAndPopulation.Key,countryAndPopulation.Value);

                        foreach (var cityAndPopulation in countriesAndListCityAndPopulation[countryAndPopulation.Key].OrderByDescending(key => key.Value))
                        {
                            Console.WriteLine("=>{0}: {1}",cityAndPopulation.Key,cityAndPopulation.Value);
                        }
                    }

                    break;
                }
            }

        }
    }
}
