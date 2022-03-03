using System;

namespace prime
{
    class Number
    {
        private int num;
        public int Num 
        { get { return num; }
          set { if (value <= 1) { Console.Write("Number should be greater than 1 \n"); Environment.Exit(0); } else {num = value; } }      
        }
        public Number (int num)
        {
            Num = num;
        }

        public void GetPrimeCheck(Number number)
        {
            Console.WriteLine("Start checking? \n \t Y for yes");
            if (Console.ReadKey(true).Key == ConsoleKey.Y)
            {

                int result = 0;
                bool isPrime;

                for (int count = 1; count <= number.Num; count++)
                {
                    
                    if (number.Num % count == 0)
                        result++;

                }
                isPrime = result == 2 ? true : false;
                Console.Write("{0} {1}",result, isPrime);

        
            }
            else
            {
                GetPrimeCheck(number);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input Number:");
            int num = Int32.Parse(Console.ReadLine());

            Number number = new Number(num);
            number.GetPrimeCheck(number);

        }
    }
}
