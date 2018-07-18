using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Web;

namespace Calculator
{
    class Program
    {

        public static string Operator;
        public static int sleep = 7500;
        public static int waitTime = 5000;
        public static string title = "Jill's Calculator";
        public static string userSelection;

        public static int firstNumIntConverted;
        public static int secondNumIntConverted;

        public static double firstNumDoubleConverted;
        public static double secondNumDoubleConverted;

        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            Console.Title = title;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n       Jill's Calculator // Menu by Hackerexecute");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("+----------------------+");
            Console.WriteLine("|      MAIN MENU       |");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("|                      |");
            Console.WriteLine("|1.) Int Calculator    |");
            Console.WriteLine("|2.) Double Calculator |");
            Console.WriteLine("|3.) Exit              |");
            Console.WriteLine("|                      |");
            Console.WriteLine("+----------------------+");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nNOTE: Console will restart after 7,5 seconds.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEnter selection: ");
            userSelection = Console.ReadLine();


            if (userSelection == "1")
            {
                IntCalculator();
            }
            else if (userSelection == "2")
            {
                DoubleCalculator();
            }
            else if (userSelection == "3")
            {
                Environment.Exit(0);
            }
        }

        public static void IntCalculator()
        {
            Console.Title = "Int Calculator";


            Console.Clear();
            PrintOut("Only Full Numbers here. No Comma or anything.");
            Console.ForegroundColor = ConsoleColor.Red;
            PrintOut("\nNOTE: Console will restart after 7,5 seconds.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Thread.Sleep(waitTime);
            while (true) {

                Console.Clear();
                Console.Write("First Number: ");
                string firstNumInt = Console.ReadLine();

                Console.Write("Operator: ");
                Operator = Console.ReadLine();

                Console.Write("Second Number: ");
                string secondNumInt = Console.ReadLine();


                try
                {
                    firstNumIntConverted = int.Parse(firstNumInt);
                    secondNumIntConverted = int.Parse(secondNumInt);
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    PrintOut("Wrong Format. Only numbers/full numbers. No decimal or anything.\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    PrintOut("PLEASE WAIT..");
                    Thread.Sleep(waitTime);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    DoubleCalculator();
                }
                catch (OverflowException)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    PrintOut("Number overflow. Int32 max value is 2,147,483,647\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    PrintOut("PLEASE WAIT..");
                    Thread.Sleep(waitTime);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    DoubleCalculator();
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    PrintOut("Invalid Input. Only numbers/full numbers. No decimal or anything.\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    PrintOut("PLEASE WAIT..");
                    Thread.Sleep(waitTime);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    IntCalculator();
                }



                if (Operator == "+")
                {
                    //Console.WriteLine("Result: " + (firstNumIntConverted + secondNumIntConverted));
                    Console.WriteLine("Result: " + (AddInt(firstNumIntConverted, secondNumIntConverted)));
                } else if (Operator == "-")
                {
                    //Console.WriteLine("Result: " + (firstNumIntConverted - secondNumIntConverted));
                    Console.WriteLine("Result: " + (SubtractInt(firstNumIntConverted, secondNumIntConverted)));

                } else if (Operator == "*")
                {
                    //Console.WriteLine("Result: " + (firstNumIntConverted * secondNumIntConverted));
                    Console.WriteLine("Result: " + (MultiplyInt(firstNumIntConverted, secondNumIntConverted)));
                } else if (Operator == "/")
                {
                    //Console.WriteLine("Result: " + (firstNumIntConverted / secondNumIntConverted));
                    Console.WriteLine("Result: " + (DivideInt(firstNumIntConverted, secondNumIntConverted)));
                }
                Thread.Sleep(sleep);
                //Console.Read();
            }
        }

        public static void DoubleCalculator()
        {

            Console.Title = "Float Calculator";

            Console.Clear();
            PrintOut("Comma is allowed here. Use ',' if you're going to multiply numbers or anything.");
            Console.ForegroundColor = ConsoleColor.Red;
            PrintOut("\nNOTE: Console will restart after 7,5 seconds.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Thread.Sleep(waitTime);
            while (true)
            {
                Console.Clear();
                Console.Write("First Number: ");
                string firstNumDouble = Console.ReadLine();

                Console.Write("Operator: ");
                Operator = Console.ReadLine();

                Console.Write("Second Number: ");
                string secondNumDouble = Console.ReadLine();


                try
                {
                    firstNumDoubleConverted = double.Parse(firstNumDouble);
                    secondNumDoubleConverted = double.Parse(secondNumDouble);
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    PrintOut("Wrong Format. Full Numbers or decimal numbers. No Letters or symbols.\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    PrintOut("PLEASE WAIT..");
                    Thread.Sleep(waitTime);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    DoubleCalculator();
                }
                catch (OverflowException)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    PrintOut("Number overflow.\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    PrintOut("PLEASE WAIT..");
                    Thread.Sleep(waitTime);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    DoubleCalculator();
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    PrintOut("Invalid Input. Full Numbers or decimal numbers. No Letters or symbols.\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    PrintOut("PLEASE WAIT..");
                    Thread.Sleep(waitTime);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    DoubleCalculator();
                }


                if (Operator == "+")
                {
                    //Console.WriteLine("Result: " + (firstNumDoubleConverted + secondNumDoubleConverted));
                    Console.WriteLine("Result: " + (AddDouble(firstNumDoubleConverted, secondNumDoubleConverted)));
                }
                else if (Operator == "-")
                {
                    //Console.WriteLine("Result: " + (firstNumDoubleConverted - secondNumDoubleConverted));
                    Console.WriteLine("Result: " + (SubtractDouble(firstNumDoubleConverted, secondNumDoubleConverted)));
                }
                else if (Operator == "*")
                {
                    //Console.WriteLine("Result: " + (firstNumDoubleConverted * secondNumDoubleConverted));
                    Console.WriteLine("Result: " + (MultiplyDouble(firstNumDoubleConverted, secondNumDoubleConverted)));
                }
                else if (Operator == "/")
                {
                    //Console.WriteLine("Result: " + (firstNumDoubleConverted / secondNumDoubleConverted));
                    Console.WriteLine("Result: " + (DivideDouble(firstNumDoubleConverted, secondNumDoubleConverted)));
                }
                Thread.Sleep(sleep);
            }
        }

        public static void PrintOut(string printOutText)
        {
            Console.WriteLine(printOutText);
        }

        // Double Calculator Calculation
        public static double AddDouble(double a, double b) {
            return a + b;
        }
        public static double SubtractDouble(double a, double b)
        {
            return a - b;
        }
        public static double MultiplyDouble(double a, double b)
        {
            return a * b;
        }
        public static double DivideDouble(double a, double b)
        {
            return a / b;
        }

        // Int Calculator Calculation
        public static int AddInt(int a, int b)
        {
            return a + b;
        }
        public static int SubtractInt(int a, int b)
        {
            return a - b;
        }
        public static int MultiplyInt(int a, int b)
        {
            return a * b;
        }
        public static int DivideInt(int a, int b)
        {
            return a / b;
        }

    }
}