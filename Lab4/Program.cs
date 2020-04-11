using System;
//Both the for and while loop statements iterate based on conditions set. A for statement consists of three parts, the initialization, condition, and Increment/Decrement.
//You would use a do-while loop when you want to execute the body at least once.
class Program
    {
        static void Main(string[] args)
        {

            Counter.Counting();
            TempProgram.GetTemp();
            LooperProgram.Looper();
            LooperProgram2.Looper2();
           
        }
    }
    
    class Counter 
    {
        public static void Counting()
        {
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i + " Even");
                }
                else
                {
                    Console.WriteLine(i + " Odd");
                }
            }
        }
    }
    class TempProgram 
    {
        public static void GetTemp()
        {
            Console.WriteLine("Enter a Temperature");
            int temp;
            string input;
            input = Console.ReadLine();
            temp = Convert.ToInt32(input);

            if (temp < 10)
            {
                Console.WriteLine("Polar Bear");

            }
            else if (temp < 20) 
            {
                Console.WriteLine("Penguin");
            }
            
            else if (temp < 40) 
            {
                Console.WriteLine("Moose");
            }

            else if (temp < 50) 
            {
                Console.WriteLine("Reindeer");
            }

            else if (temp < 60) 
            {
                Console.WriteLine("Deer");
            }

            else if (temp < 70) 
            {
                Console.WriteLine("Turtle");
            }
            
            else if (temp < 80) 
            {
                Console.WriteLine("Lion");
            }

            else if (temp < 90) 
            {
                Console.WriteLine("Fish");
            }
        }
    }

    class LooperProgram 
    {
        public static void Looper() 
        {
            int i = 10;
            while (i < 21)
            {
                Console.WriteLine(i++);
            }
        }
    }

    class LooperProgram2 
    {
        public static void Looper2() 
        {
            for (int i = 0; i < 101; i++)
                Console.WriteLine(i + "\n************");

        }
    }

