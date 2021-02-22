using System;

namespace ConsoleAppCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //string[] collectionOfNames = new string[2];

            //PrintStringArray(collectionOfNames);

            //AddNames(collectionOfNames);

            //PrintStringArray(collectionOfNames);

            AskUserForNumber("fuel prize");

            //ArrayEx();
            //PrimitiveNotChangeEx();
        }

        static double AskUserForNumber(string whatNumber)
        {
            bool notANumber = true;
            double number = 0;

            do
            {
                Console.Write($"Pleace enter {whatNumber}: ");
                string userInput = Console.ReadLine();

                try
                {
                    //number = double.Parse(userInput);
                    number = Convert.ToDouble(userInput);

                    notANumber = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was not a number i can read.\nPlease try once more.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number was too big for this program to handle.");
                }

            } while (notANumber);

            return number;
        }


        static void PrimitiveNotChangeEx()
        {
            string text = "original";

            ChangeText(text);

            Console.WriteLine("text is now: " + text);
        }

        /// <summary>
        /// This method lies, it can´t change the incoming string outside of its self
        /// </summary>
        /// <param name="originalText"></param>
        static void ChangeText(string originalText)
        {
            Console.Write("change text: ");
            originalText = Console.ReadLine();
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

            for (int index = 0; index < arrayOfNames.Length; index++)
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
