using System;


namespace Homework
{
    class Program
    {

        // sorting an array
        public void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
        }
        //print array 
        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        //search number 
        public void searchInAray(int[] arrray, int number)
        {
            bool flag = false;
            for (int i = 0; i < arrray.Length; i++)
            {
                if (arrray[i] == number)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                Console.WriteLine($"number {number} ,Yes ");
            }
            else
            {
                Console.WriteLine($"number {number} ,We can't found your number in array ");
            }
        }

        public static void Main()
        {

            Program sort = new Program();
            int[] array = { 1, 5, 2, 3, 4, 67, 7, 8, 9, 5, 5768, 569 };
            Console.WriteLine("To sort");
            sort.PrintArray(array);
            sort.BubbleSort(array);
            Console.WriteLine("after sorting");
            sort.PrintArray(array);
            sort.searchInAray(array, 8);
            sort.searchInAray(array, 1000);
            Console.ReadLine();

        }


    }

}
