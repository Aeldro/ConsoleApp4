using System.Linq.Expressions;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] firstArray = { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
            int[][] secondArray = new int[3][];

            for (int i = 0; i < secondArray.Length; i++)
            {
                int[] newArray = new int[3 - i];

                for (int j = 0; j < newArray.Length; j++)
                {
                    newArray[j] = firstArray[i, j + i];
                }
                secondArray[i] = newArray;
            }

            foreach (int[] el in secondArray)
            {
                foreach (int el2 in el)
                {
                    Console.WriteLine(el2);
                }

            }

        }
    }
}
