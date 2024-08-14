using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public static class PlayingWithCollection
    {
        //Arrays, Lists, Dictionaries
        public static void LearnArrays()
        {
            string[] empNames = new string[10]; // length of string is 10(0 to 9)
            empNames[0] = "binisha";

            //string[] names = ["Binisha","Bibita", "Biii"]; //here length of string is 3
            byte[] evenNumbers = [2, 4, 6, 8, 10, 14, 16, 18];

            int[][] mat1 = [[2, 3, 4],[3, 4]];// jagged arrays-no of rows and columns can be different in jagged arrays
            int[,] mat2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //Create an array of numbers from 1 to 100
            //from that collection, print the number of console if its multiple of 3 or 5

            int[] numbers = [100];
            int[] allNumbers = Enumerable.Range(1, 100).ToArray();

            foreach (int number in allNumbers)
            {
                if (number % 3 == 0 || number % 5 == 0)
                {
                    Console.WriteLine(number);
                }
            }
            }

        //List
        public static void LearnLists()
        {
            List<string> names = ["Binisha", "Bibita", "Biii"];
            names.Add("Ram"); // add 

            List<(string Country, string Capital)> countries = new();
            countries.Add(("Nepal", "Kathmandu"));
            countries.Add(("India", "Delhi"));
            countries.Add(("China", "Beijing"));

            //List<Student> student = new(); //Student is class name
            //Student student1 = new();
            //Student student2 = new();
            //Student student3 = new();

            //student.AddRange([new Student(), student1, student2, student3]);
        }

        //Dictionary : collection of key value pair
        public static  void LearnDictionary()
        {
            Dictionary<string,int> countryPopulation = new();
            countryPopulation.Add("Nepal", 1223234324);
            countryPopulation.Add("India", 243433524); //key must be unique
            countryPopulation.Add("China", 454523434);
        }
    }
}
