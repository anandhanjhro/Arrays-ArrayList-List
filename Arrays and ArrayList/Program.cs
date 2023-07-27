using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Arrays_and_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList()
            {
               // 6,5,2,1,4,7,8
               "Kanhia","Anand","Aakash","Harish",9.5,System.DateTime.Now
            };

            int[] arr = { 10, 20, 30, 40 };


            var arraylist2 = new ArrayList();
            arraylist2.AddRange(arraylist);//arraylist in arraylist
            arraylist2.AddRange(arr);//array in arraylist

            for (int i = 0; i < arraylist2.Count; i++)
                Console.WriteLine(arraylist2[i]);



            //===================================================

            int[] arr2 = { 100, 220, 302, 420 };

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.AddRange(arr2); // we have also put an array in a LIST
            numbers.Insert(1, 11);// inserts 11 at 1st index: after 1.


            numbers.ForEach(Console.WriteLine);
            Console.WriteLine($"List Numbers {numbers.Count} ");

            Console.WriteLine("List of numbers: ", numbers.Count);

            var cities = new List<string>();
            cities.Add("Karachi");
            cities.Add("Hyderabad");
            cities.Add("Kaloi");
            cities.Add("Golarchi");
            cities.Add(null);




            var bigCities = new List<string>()
            { "Karachi ", "Lahore", "Faisalabad" };
            bigCities.AddRange(cities); //here i have puit a list of cities in a LIST

            bigCities.ForEach(Console.WriteLine); // it will print all its values and list of cities.
            Console.WriteLine("String List: " + bigCities.Count);
            Console.WriteLine(System.DateTime.Now.ToString("dd-MMMM-yyyy hh:mm:ss tt"));


            int[] list = new int[10];
            list[0] = 1;
            list[2] = 12;
            list[3] = 15;
            list[4] = 45;
            list[5] = 54;
            list[6] = 75;
            list[7] = 77;
            list[8] = 88;
            list[9] = 96;

            for (int i = 0; i <= list.Length-1; i ++)
            {
                Console.WriteLine(list[i]);
            }
             for (int i = list.Length-1; i >= 0; i --)//reverse loop
            {
                Console.WriteLine(list[i]);
            }

            Console.ReadLine();
        }
    }
}
