using System;

namespace ConsoleAppCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] collectionOfNames = new string[2];

            PrintStringArray(collectionOfNames);

            AddNames(collectionOfNames);

            PrintStringArray(collectionOfNames);


            //ArrayEx();
        }

        static void PrintStringArray(string[] collection)
        {
            Console.WriteLine("Print collection of strings:");

            foreach (string item in collection)
            {
                Console.WriteLine(item);
            }
        }

        static void AddNames(string[] arrayOfNames)
        {

            for(int index=0; index < arrayOfNames.Length; index++)
            {
                Console.Write("Type in a name: ");
                arrayOfNames[index] = Console.ReadLine();
            }
        }




        static void ArrayEx()
        {
            double[] fuelPrices = new double[5]; //5 slots in array

            fuelPrices[0] = 14.68; //first slot on index 0
            fuelPrices[1] = 15.32;
            fuelPrices[2] = 12.32;
            //fuelPrices[3] = -1;
            //fuelPrices[4] = -1;

            foreach (double fuel in fuelPrices)
            {
                Console.WriteLine("Price is: " + fuel);
            }

        }


    }
}
