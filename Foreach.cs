
// Amir Moeini Rad
// September 2025

// Main Concept: foreach loop in C#

using System;

namespace ForeachDemo
{
    class MyApp
    {
        public static void Main()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Foreach Loop in C#.NET.");
            Console.WriteLine("-----------------------\n");


            // Define an array of integers
            int[] myArray = { 1, 20, 15, 30 };
            // Define a string
            string name = "Amir";


            foreach (int i in myArray)
                Console.WriteLine(i);


            Console.WriteLine();


            foreach (char ch in name)
                Console.Write(ch);


            Console.WriteLine("\n\nDone.");
        }
    }
}
