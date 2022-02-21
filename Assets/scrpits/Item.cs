using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
   class Program
    {
        static void Main(string[] args)
        {
            string[] armes = new string[3];

            Console.WriteLine("Type in three weapone");

            armes[1] = Console.ReadLine();
            armes[2] = Console.ReadLine();
            armes[3] = Console.ReadLine();

            Console.WriteLine("\nHere they are alphabetically: ");

            Array.Sort(armes); 

            Console.ReadKey();

           
        }
    }
}
