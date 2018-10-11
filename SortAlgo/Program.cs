using System;

namespace SortAlgo
{

    class Tableau
    {
        long[] T;   // the array to be sorted
        Random rnd = new Random();

        /// <summary>
        /// will instantiate a new Array with initial values according to mode
        /// </summary>
        /// <param name="size">The number of elements in the array</param>
        /// <param name="mode">Random = 0, Increasing = 1, Decreasing = 2</param>
        public void InitializeTab(int size, int mode=0)
        {
            T = new long[size];
            for (int i = 0; i < T.Length; i++)
                T[i] = rnd.Next();
        }

        /// <summary>
        /// Displays in Console the content of T between start and end indices (included)
        /// without index parameter, will display the complete array
        /// </summary>
        /// <param name="start">index of the first displayed element</param>
        /// <param name="end">index of the last displayed element</param>
        public void ShowTab(int start=0, int end=-1)
        {
            if (-1 == end)
                end = T.Length - 1;
            for (int i=start;i<=end;i++)
                Console.Write($"{T[i]} ");
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            Tableau T = new Tableau();
            T.InitializeTab(10, 0);
            T.ShowTab();

            Console.ReadKey();
        }
    }
}
