using System;

namespace Deliverable_3___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] elementArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

                for (int i = 0; i < elementArray.Length; i++)
                {
                    Console.WriteLine("Element value = " + elementArray[i]);
                }
            }
            catch
            {

            }
        }
    }
}
