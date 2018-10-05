using System;
using System.Collections.Generic;

namespace list_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>()
            {
                "Mercury", 
                "Mars"
            };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            
            List<string> endPlanets = new List<string>() {
                "Uranus",
                "Neptune"
            };

            List<string> allPlanets = new List<string>(){};

            allPlanets.AddRange(planetList);
            allPlanets.AddRange(endPlanets);

            allPlanets.Insert(1, "Venus");
            allPlanets.Insert(2, "Earth");
            allPlanets.Insert(8, "Pluto");

            var rockyPlanets = allPlanets.GetRange(0, 4);

            allPlanets.ForEach( planet => 
                Console.WriteLine(planet)
            );

            Console.WriteLine("rockyPlanets:");

            rockyPlanets.ForEach( planet => 
                Console.WriteLine(planet)
            );

            allPlanets.Remove("Pluto");

            Console.WriteLine("After removing Pluto");

            allPlanets.ForEach( planet => 
                Console.WriteLine(planet)
            );

            // Dictionary<string, string> probes = new Dictionary<string, string>(){

            // };

            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>(){
                new Dictionary<string, string>(){
                    {"Probe 1", "Mars"},
                    {"Venture 12", "Mars"},
                    {"Discovery 2", "Mars"},
                    {"Apollo 2.3", "Mars"}
                },
                new Dictionary<string, string>(){
                    {"Explorer 1", "Mercury"},
                    {"Explorer 3", "Mercury"}
                },
                new Dictionary<string, string>(){
                    {"VExplorer 1", "Venus"}
                },
                new Dictionary<string, string>(){
                    {"Jupiter 1", "Jupiter"},
                    {"Titan 1", "Jupiter"},
                    {"Ascendant 12", "Jupiter"},
                    {"Explorer 16", "Jupiter"}
                },
                new Dictionary<string, string>(){
                    {"Saturn 1", "Saturn"},
                    {"Saturn 2", "Saturn"},
                    {"Saturn 5", "Saturn"},
                    {"Saturn V", "Saturn"},
                    {"Saturn X12", "Saturn"}
                },
                new Dictionary<string, string>(){
                    {"Neptune Explorer 1", "Neptune"},
                    {"Neptune Voyager 1", "Neptune"},
                    {"Starship Enterprize 1", "Neptune"}
                },
                new Dictionary<string, string>(){
                    {"Uranus Probe 1", "Uranus"},
                    {"Uranus Explorer 2", "Uranus"},
                    {"Uranus Examiner 3", "Uranus"}
                }
            };

            foreach (var planet in allPlanets)
            {
                List<string> planetsProbes = new List<string>();
                foreach (Dictionary<string, string> probeList in probes) 
                {
                    if(probeList.ContainsValue(planet)){
                        foreach (KeyValuePair<string, string> probe in probeList)
                        {
                            planetsProbes.Add(probe.Key);
                            // Console.WriteLine($"{planet}: {probe.Key}");
                        }
                    }
                }
                Console.WriteLine($"{planet}: {String.Join(", ", planetsProbes)}");
            }
        }
    }
}
