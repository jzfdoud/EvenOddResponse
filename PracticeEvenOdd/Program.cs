using System;

namespace PracticeEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter an integer : ");
            //var ans = Console.ReadLine();
            //var nbr = Convert.ToInt32(ans);
            //if (nbr % 2 == 0)
            //{
            //    Console.WriteLine($"The number {nbr} is even");
            //} else {
            //    Console.WriteLine($"The number {nbr} is odd");
            //}


            // var nbr= int;
            //Console.ReadLine();
            //if (nbr = 2 % 2) {
            //    Console.WriteLine("Number is even");
            //    if (nbr != 2 % 2) { Console.WriteLine("Number is odd"); }


            //var total = 0;
            //for (var idx = 0; idx <= 25; idx++)
            //{
            //    total += idx; /* += instead of t = t +idx*/
            //}
            //Console.WriteLine($"The sum of 1 o 25 is {total}");

            int[] nbrs = { 946, 881, 509, 535, 589 };
            var total = 0;
                foreach(var i in nbrs) {
                    total += i;
            }
            Console.WriteLine($"The sum of random numbers is {total}");
            }


        }
    }

