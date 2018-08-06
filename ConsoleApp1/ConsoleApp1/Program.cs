using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string score = "";
            do {
                Console.WriteLine("Please enter your final score, type 'done' to exit.");
                 score = Console.ReadLine();
                if (score == "done")
                {
                    break;
                }
                else
                {


                    int grade = Convert.ToInt32(score);
                    if (grade >= 90)
                    {
                        Console.WriteLine("A+");
                        Console.WriteLine("press any key for new input");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (grade >= 80 && grade <= 89)
                    {
                        Console.WriteLine("A");
                        Console.WriteLine("press any key for new input");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (grade >= 70 && grade <= 79)
                    {
                        Console.WriteLine("B+");
                        Console.WriteLine("press any key for new input");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (grade >= 60 && grade <= 69)
                    {
                        Console.WriteLine("B");
                        Console.WriteLine("press any key for new input");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (grade >= 50 && grade <= 59)
                    {
                        Console.WriteLine("C");
                        Console.WriteLine("press any key for new input");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("F");
                        Console.WriteLine("press any key for new input");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            } while (score != "done");
        }

    }
}
