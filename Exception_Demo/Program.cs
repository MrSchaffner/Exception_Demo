using System;
using System.Collections.Generic;

namespace Exception_Demo
{
    class Program
    {
        static void Main()
        {
            divideByList();

            endProgram();
        }//MAIN()

        static void endProgram()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Program Over. Enter r to Restart.");
            string input = Console.ReadLine();
            if (input == "r" || input == "R")
            {
                Console.WriteLine("=======================");
                Main();
            }
        }

        static void divideByList()
        {
            try
            {
                List<int> myInts = new List<int>() { 23, 41, 52, 64, 75, 86 };
                Console.WriteLine("Hello. Enter a number to divide by.");
                int inputInt = Convert.ToInt32(Console.ReadLine());

                foreach (int myInt in myInts)
                {
                    float quotient = (float)myInt / (float)inputInt;
                    Console.WriteLine(myInt +" divided by "+ inputInt +" equals "+ quotient);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter an integer. Exception text:");
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex) //doesn't run even when it should.
            {
                Console.WriteLine("Can't Divide by Zero. Exception text:");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) // i don't know how to reach this.
            {
                Console.WriteLine("GENERAL Exception reached. Exception text:");
                Console.WriteLine(ex.Message);
            }
            finally //always runs, even if there is a break. Used for Logging errors or failed transactions
            {
                Console.ReadLine();
            }

        }


        static void ExceptionCatching()
        {
            try
            {
                Console.WriteLine("Pick number");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick number 2");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dividing now...");
                float number3 = (float)number / (float)number2;

                Console.WriteLine(number + " divided by " + number2 + " = " + number3);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Exception reached. Exception text:");
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception reached. Exception text:");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception reached. Exception text:");
                Console.WriteLine(ex.Message);
            }
            finally //always runs, even if there is a break. Used for Logging errors or failed transactions
            {
                Console.ReadLine();
            }
        }
    }
}