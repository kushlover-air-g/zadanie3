using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double znamenatel=2, symm = 1.0;
            while(symm<1.644)
            {
                symm += 1 / (znamenatel * znamenatel);
                znamenatel++;
            }
            Console.WriteLine(symm);
        }
    }
}
