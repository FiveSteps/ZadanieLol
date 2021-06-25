using System;

namespace ZadanieLol
{
    class Program
    {
        static void Sort(int[] arr)
        {
            var items = new int[arr.Length];
            arr.CopyTo(items, 0);

            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if (items[j] > items[i])
                    {
                        var temp = items[j];
                        items[j] = items[i];
                        items[i] = temp;
                    }
                }
            }
            for (int i = 0; i < items.Length; i++) Console.Write(items[i] + " | ");
        }

        static void Main(string[] args)
        {
            //1
            Random rand = new Random();
            int[] arr1 = new int[50];
            int[] arr2 = new int[50];

            int[] arrMain = new int[100];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = 1 + rand.Next() % 7;
                arr2[i] = 1 + rand.Next() % 7;
            }

            for (int i = 0; i < arr1.Length; i++) Console.Write(arr1[i] + " | ");
            
            Console.WriteLine("\n");

            for (int i = 0; i < arr1.Length; i++) Console.Write(arr2[i] + " | ");

            Console.WriteLine("\n");

            for (int i = 0, j = 0; i < 100; i++)
            {
                if (i < 50) arrMain[i] = arr1[i];
                else
                {
                    arrMain[i] = arr2[j];
                    j++;
                }
                Console.Write(arrMain[i] + " | ");
            }
            Console.WriteLine("\n\n");

            Sort(arrMain);

            double sum = 0;

            for (int i = 0; i < arrMain.Length; i++)
            {
                sum += arrMain[i];
            }
            Console.WriteLine("\n\nAverage value: " + (sum) / arrMain.Length + "\n\n");



            //2
            int[] arrSecond = new int [100];
            int[] arrThird = new int [100];
            int[] arrEnd = new int [50];

            for (int i = 0; i < arrSecond.Length; i++)
            {
                arrSecond[i] = rand.Next() % 101;
                Console.Write(arrSecond[i] + " | ");
            }
            Console.WriteLine("\n\n");


            for (int i = 0; i < arrSecond.Length; i++)
            {
                for (int j = 0; j < arrSecond.Length; j++)
                {
                    if (arrSecond[j] > arrSecond[i])
                    {
                        var temp = arrSecond[j];
                        arrSecond[j] = arrSecond[i];
                        arrSecond[i] = temp;
                    }
                }
            }
            for (int i = 0; i < arrSecond.Length; i++) Console.Write(arrSecond[i] + " | ");

            Console.WriteLine("\n\n");

            for (int i = 0, j = 0; i < arrSecond.Length; i += 2, j++)
            {
                arrEnd[j] += arrSecond[i + 1] - arrSecond[i];
                Console.Write(arrEnd[j] + " | ");
            }
            Console.WriteLine("\n\n");
            Sort(arrEnd);

            sum = 0;

            for (int i = 0; i < arrEnd.Length; i++)
            {
                sum += arrEnd[i];
            }
            Console.WriteLine("\n\nAverage value: " + (sum) / arrEnd.Length + "\n\n");

        }
    }
}
