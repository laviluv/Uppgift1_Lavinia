// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

namespace Uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> productList = new List<string>();
            int index = 0;
            Console.WriteLine("Skriv in produkter. Avsluta med att skriva 'exit'\n\n");


            while (true)
            {
                Console.Write("Ange produkt: ");
                string produkter = Console.ReadLine();

                //Niva 2 - exit 
                if (produkter.ToLower().Contains("exit"))
                {
                    // Console.WriteLine("Du skrev exit för att avsluta\n\n*******************************");
                    break;
                }

                else
                {

                    foreach (char produkt in produkter)
                    {
                        Console.Write("\r");
                        productList.Insert(index, produkter);

                    }
                    index++;

                }
            }


            var myArray = productList.ToArray();

            Console.WriteLine("\nDu angav foljande produkter (sorterade) Antal artiklar: (" + index + ") ");

            Array.Resize(ref myArray, index);
            Array.Sort(myArray);
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine("* {1}", i, myArray[i]);
            }

            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadLine();
        }

    }
}

