using System;
using System.Collections;

namespace arrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Methods and ArrayList Demo");
            Console.WriteLine();
            //Created new arraylist with different types of data
            ArrayList arrList = new ArrayList(); 
            arrList.Add(1);
            arrList.Add("Shardul");
            arrList.Add(80);
            arrList.Add(true);
            arrList.Add("IncubXperts");

            Console.WriteLine("Array List Example:");
            foreach(var list in arrList)
            {
            Console.Write(list+ " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Length of ArrayList:" + arrList.Count); // gets the number of items in arraylist
            Console.WriteLine("Capacity of ArrayList:" + arrList.Capacity); // gets the number of items in arraylist

            arrList.TrimToSize(); // deletes the extra space of the array.
            Console.WriteLine("Capacity of Arraylist after trim method:" + arrList.Capacity); 


            //contains checks whether the element exists in arraylist or not.
            if (arrList.Contains("Shardul"))
            {
                Console.WriteLine("Value and Index of element:"+ " " + arrList.IndexOf("Shardul"));
            }
            else
            {
                Console.WriteLine("Value not found");
            }

            arrList.Remove(true); // give value present in array as a parameter to remove from the arraylist.
            arrList.RemoveAt(0); // removes item from the specified index
            Console.WriteLine("Array After removed item:");

            foreach (var arr in arrList)
            {
             Console.Write(arr + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            arraydemo arrobj = new arraydemo();
            arrobj.demo();
            arrobj.sortArray();
            arrobj.getArrayLength();
            arrobj.Copyarr();
            arrobj.reversearray();
                  
        }
    }

    class arraydemo
    {
        public int[] arrOfNumbers = { 14, 15, 16, 11, 12, 13 };
        int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };  // multidimensional array
        public void demo()
        {   
            Console.WriteLine("---Array of Numbers----");
            foreach(int arr in arrOfNumbers)
            {   
                Console.Write(arr +" ");
            }
            Console.WriteLine();
            Console.WriteLine();

        }
        public void sortArray()
        {
            Array.Sort(arrOfNumbers);
            Console.WriteLine("Sorted Array:");
            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                Console.Write(arrOfNumbers[i] + " ");
            }
            Console.WriteLine();
        }
        public void getArrayLength()
        {
            Console.WriteLine("Length of array is:" + " " + arrOfNumbers.Length);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + "");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Get length is:" + " " +  arr.GetLength(0)); // 0 gives you the entire length of the array.
            Console.WriteLine("Get length is:" + " " + arr.GetLength(1)); //1 gives you the length of items of an object.
        }
        public void Copyarr()
        {
            int[] copyarr = new int[8];
            Array.Copy(arrOfNumbers, copyarr, arrOfNumbers.Length); // Array.copy(sourcearray, destination array, length);
            Console.WriteLine("Copy of Array:");
            foreach(int arr in copyarr)
            {
                Console.Write(arr + " ");
            }
            Console.WriteLine();
        }
        public void reversearray()
        {
            Array.Reverse(arrOfNumbers);
            Console.WriteLine("Reversed Array:");
            foreach (int arr in arrOfNumbers)
            {
                Console.Write(arr + " ");
            }
            Console.WriteLine();
        }
    }
   
}
