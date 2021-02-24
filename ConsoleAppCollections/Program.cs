using System;
using System.Text;// needed to use StringBuilder

namespace ConsoleAppCollections
{
    class Program
    {
        static Random randomGenerator = new Random();

        static void Main(string[] args)
        {

            int[] numbers = new int[3];

            Console.WriteLine(numbers);

        }

        static void NameEx()
        {
            Console.WriteLine("Random first name generated: " + RandomFirstName());
            Console.WriteLine("Random last name generated: " + RandomLastName());
            Console.WriteLine("Random full name generated: " + RandomFullName());
        }

        static string RandomFullName()
        {
            return RandomFirstName() + ' ' + RandomLastName();
        }

        static string RandomLastName()
        {
            string[] names = { "Bengtsson", "Svensson", "Karlsson",};

            return names[randomGenerator.Next(names.Length)];
        }

        static string RandomFirstName()
        {
            string[] names = { "Ulf", "Eva", "Kent", "Anna", "Sven" };

            return names[randomGenerator.Next(names.Length)];
        }

        static void BasicRandom()
        {
            Random rng = new Random();

            for (int i = 0; i < 3; i++)
            {
                //Console.WriteLine(random.Next());//random next int 0 to int.max 2.1 B
                //Console.WriteLine(random.Next(500));//random next with max limit 0-499
                Console.WriteLine(rng.Next(100, 500));//random next with min/max limit 100-499
                // min is included to numbers possible, max is excluded f
            }
        }

            //string[] collectionOfNames = new string[2];

            //PrintStringArray(collectionOfNames);

            //AddNames(collectionOfNames);

            //PrintStringArray(collectionOfNames);

            //AskUserForNumber("fuel prize");

            //ArrayEx();
            //PrimitiveNotChangeEx();


        static void SpeedTestForString()
        {
            string manyStringStars = "";

            DateTime startStringTime = DateTime.Now;

            for (int i = 0; i < 10000; i++)
            {
                manyStringStars = manyStringStars + "*";
            }

            DateTime endStringTime = DateTime.Now;

            Console.WriteLine("String time was: " + (endStringTime - startStringTime).TotalMilliseconds);

            StringBuilder many_SB_Stars = new StringBuilder();

            DateTime startSBTime = DateTime.Now;

            for (int i = 0; i < 10000; i++)
            {
                many_SB_Stars.Append("*");
            }

            DateTime endSBTime = DateTime.Now;

            Console.WriteLine("StringBuilder time was: " + (endSBTime - startSBTime).TotalMilliseconds);
        }

        static void StringCompeareingV2()
        {
            string name = "ulf";

            StringBuilder sameName = new StringBuilder();

            sameName.Append('u');
            sameName.Append('l');
            sameName.Append('f');

            //if (name.Equals(sameName.ToString()))// == is not garenteed to work for string every time
            if (name == sameName.ToString())// == is not garenteed to work for string every time
            {
                Console.WriteLine("works");
            }
            else
            {
                Console.WriteLine("incorrect");
            }
        }
        static void StringCompeareing()
        {
            string name = Console.ReadLine();

            string sameName = Console.ReadLine();


            if (name.Equals(sameName))// == is not garenteed to work for string every time
            {
                Console.WriteLine("== works");
            }
            else
            {
                Console.WriteLine("== incorrect");
            }
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

            } while (notANumber);//end of do while loop
            
            return number;
        }// end of AskUserFor


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
