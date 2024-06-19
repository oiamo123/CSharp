// See[ https://aka.ms/new-console-template for more information
/*
string[] faudulentOrderIDs = new string[3];
faudulentOrderIDs[0] = "A123";
faudulentOrderIDs[1] = "B456";
faudulentOrderIDs[2] = "C789";
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string>();

        // Adding individual elements
        fruits.Add("Apple");
        fruits.Add("Banana");

        // Adding multiple elements using AddRange
        fruits.AddRange("Cherry", "Dates", "Elderberry" );

        // Displaying all fruits
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}



