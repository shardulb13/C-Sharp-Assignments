using System;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of Names:");
            string[] arr_of_Names = { "Shardul", "Parth", "Ajinkya", "Nitin", "Vedant" }; // created a string array of names
            ArrayMethods arrobj = new ArrayMethods();
            arrobj.displayarr(arr_of_Names);
            arrobj.arrsort(arr_of_Names);
            arrobj.reverseArr(arr_of_Names);
            arrobj.getlength(arr_of_Names);

        }
    }

    class ArrayMethods
    {
        public void displayarr(Array arrlist) // to print the array
        {
            foreach (string i in arrlist)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        public void arrsort(Array arrlist)
        {
            Array.Sort(arrlist); // to sort the list in ascending order
            Console.WriteLine("Sorted list");
            foreach (string i in arrlist)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        public void reverseArr(Array arrlist)
        {
            Array.Reverse(arrlist); // to reverse the list
            Console.WriteLine("Reversed list");
            foreach (string i in arrlist)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        public void getlength(Array arrlist)
        {
            Console.WriteLine("Length of Array is:"+ arrlist.Length);
        }

    }
}
