using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {   
           // avrage = x + z  + d 

           int num01;
           int num02;
           int num03;

           Console.Write("add first number: ");
            num01 = Convert.ToInt32(Console.ReadLine());

           Console.Write("add second number: ");
           num02 = Convert.ToInt32(Console.ReadLine());

           Console.Write("add third number: ");
           num03 = Convert.ToInt32(Console.ReadLine());

           int result = num01 + num02 + num03;

           Console.WriteLine("This is result: " + result);

            // wait before closing
            Console.ReadKey();
        }
    }
}
