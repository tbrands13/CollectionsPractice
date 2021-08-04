using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 Basic Arrays

            int [] starterNums = {0,1,2,3,4,5,6,7,8,9};
            for(int i = 0; i < starterNums.Length; i++){
                Console.WriteLine(starterNums[i]);
            }

            string [] peopleNames = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            foreach (string name in peopleNames)
            {
                Console.WriteLine($"My name is {name}");
            }

            bool [] guessTorF = new bool [] {true, false, true, false, true, false, true, false, true, false};
            foreach (bool guess in guessTorF)
            {
                Console.WriteLine($"{guess}");
            }

            // List of Flavors

            List<string> favoriteIceCreams = new List<string>();

            favoriteIceCreams.Add("cookies and cream");
            favoriteIceCreams.Add("strawberry");
            favoriteIceCreams.Add("chunky monkey");
            favoriteIceCreams.Add("cookie dough");
            favoriteIceCreams.Add("vanilla");
            
            //     Console.WriteLine($"There are {favoriteIceCreams.Count} flavors");
            //     Console.WriteLine(favoriteIceCreams[2]);
            //     favoriteIceCreams.RemoveAt(2);
            //     Console.WriteLine("Updated list of flavors:");
            //     foreach (string flavor in favoriteIceCreams)
            //     {
            //         Console.WriteLine("-" + flavor);
            //     }
            //     Console.WriteLine($"There are {favoriteIceCreams.Count} flavors");

            // User Info Dictionary
            Random rand = new Random();


            Dictionary<string,string> desserts = new Dictionary<string, string>();
            desserts.Add("Tim",favoriteIceCreams[rand.Next(5)]);
            Console.WriteLine("Tim's favorite flavor is - " + desserts["Tim"]);

            desserts.Add("Martin",favoriteIceCreams[rand.Next(5)]);
            Console.WriteLine("Martin's favorite flavor is - " + desserts["Martin"]);

            desserts.Add("Nikki",favoriteIceCreams[rand.Next(5)]);
            Console.WriteLine("Nikki's favorite flavor is - " + desserts["Nikki"]);

            desserts.Add("Sara",favoriteIceCreams[rand.Next(5)]);
            Console.WriteLine("Sara's favorite flavor is - " + desserts["Sara"]);

        
        }
    }
}
