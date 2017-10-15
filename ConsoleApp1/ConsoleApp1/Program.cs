using System;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            data[0] = 0; data[1] = 1; data[2] = 2; data[3] = 3; data[4] = 4;
            data[5] = 5; data[6] = 6; data[7] = 7; data[8] = 8; data[9] = 9;
            Console.WriteLine(data[7]);
            Console.WriteLine(data[4] + data[9]);
            if (data[2] == data[6])
            {
                Console.WriteLine("data[2] = data[6]");
            }
            else
            {
                Console.WriteLine("data[2] != data[6]");
            }
            Console.WriteLine("Sum : {0}", data [0] + data[1] + data[2] + data[3] 
                + data[4] + data[5] + data[6] + data[7] + data[8] + data[9]);
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i] + " ");
            }
            Console.ReadLine();

        }
    }
}