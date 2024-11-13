using System;
namespace Upgift3_1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur gammal är du i heltal");
            int X = int.Parse(Console.ReadLine());
            if (X >= 16 && X <= 19)
            {
                Console.WriteLine("du får vara med i tävlingen");
            }
            else
            {
                Console.WriteLine("du är inte innom oldersgruppen");
            }
        }
    }
}