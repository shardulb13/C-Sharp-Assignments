using System;
using System.Collections.Generic;

namespace Generic_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOTE: Uncomment the following lines to run the specific code.
            
            //stackDemo stackobj = new stackDemo();
            //stackobj.stackmethods();

            //QueueDemo queueobj = new QueueDemo();
            //queueobj.queuemethods();

            //SortedListDemo slistobj = new SortedListDemo();
            //slistobj.sortedlistmethods();

            DictionaryDemo dobj = new DictionaryDemo();
            dobj.dictionarymethods();

            ////Creating different objects of Student Class with different values.
            //Student studobj1 = new Student(1, "Shardul", "IT");
            //Student studobj2 = new Student(2, "Parth", "CS");
            //Student studobj3 = new Student(3, "Ajinkya", "MCA");
            //Student studobj4 = new Student(4, "Nitin", "CS");

            ////Created a list with Student class as a object
            //List<Student> studendlist = new List<Student>();
            //// add method to add student object to the list
            //studendlist.Add(studobj1); 
            //studendlist.Add(studobj2);
            //studendlist.Add(studobj3);
            //studendlist.Add(studobj4);

            //Console.WriteLine("List of Students:");
            //Console.WriteLine();

            ////to print the elements of the list
            //foreach (var std in studendlist)
            //{
            //    Console.WriteLine("ID:" + std.id);
            //    Console.WriteLine("Name:" + std.name);
            //    Console.WriteLine("Department:" + std.department);
            //    Console.WriteLine();
            //}


            ////insert(index, item) method to insert new object into list
            //Console.WriteLine("After inserting new Element into list:");
            //studendlist.Insert(4, new Student(5, "Vedant", "MCS")); // inserts studentobj after 4th index
            //foreach (var std in studendlist)
            //{
            //    Console.WriteLine("ID:" + std.id);
            //    Console.WriteLine("Name:" + std.name);
            //    Console.WriteLine("Department:" + std.department);
            //    Console.WriteLine();
            //}

            //Console.WriteLine("After removing element from the list:");
            //studendlist.Remove(studobj4); // removes the studentobj from the list
            //studendlist.RemoveAt(3); // removes object from the specified index
            //foreach (var std in studendlist)
            //{
            //    Console.WriteLine("ID:" + std.id);
            //    Console.WriteLine("Name:" + std.name);
            //    Console.WriteLine("Department:" + std.department);
            //    Console.WriteLine();
            //}
        }
    }


    class Student
    {
        public int id;
        public string name;
        public string department;
        public Student(int id, string name, string department)
        {
            this.id = id;
            this.name = name;
            this.department = department;
        }
    }


    class stackDemo
    {
        //created a stack of string type
        Stack<string> mynames = new Stack<string>();

        public void stackmethods()
        {
            //Add elements into stack using push method
            mynames.Push("Shardul");
            mynames.Push("Parth");
            mynames.Push("Ajinkya");
            mynames.Push("Nitin");

            foreach (string i in mynames)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Total numbers in the stack:" + mynames.Count);
            Console.WriteLine();


            //Remove elements from stack using pop method
            mynames.Pop();

            //count method gives you the total number of items in the stack
            Console.WriteLine("Total numbers in the stack after removing one element:" + mynames.Count);


            foreach (var i in mynames)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            //Peek method gives you the top element present in the stack
            Console.WriteLine("Top Element:" + mynames.Peek());

            Console.WriteLine("Enter the element you want to fetch:");
            string element = Console.ReadLine();

            if (mynames.Contains(element))
            {
                Console.WriteLine("Entered element present in the stack");
            }
            else
            {
                Console.WriteLine("Element not found");
            }
            Console.WriteLine();
            //Clone method to create the copy of stack
            Stack<string> stack2 = (Stack<string>)mynames;
            Console.WriteLine("Clone Stack Example:");
            foreach (var i in stack2)
            {
                Console.WriteLine(i);
            }
        }
    }

    class QueueDemo
    {
        // created a queue of string type.
        Queue<string> citynames = new Queue<string>();

        public void queuemethods()
        {
            //Add elements into stack using push method
            citynames.Enqueue("Mumbai");
            citynames.Enqueue("Pune");
            citynames.Enqueue("Delhi");
            citynames.Enqueue("Bangalore");
            foreach (var i in citynames)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Total numbers in the Queue:" + citynames.Count);
            Console.WriteLine();


            //Remove elements from stack using dequeue method
            citynames.Dequeue();

            //count method gives you the total number of items in the queue
            Console.WriteLine("Total numbers in the queue after removing one element:" + citynames.Count);


            foreach (var i in citynames)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            //Peek method gives you the top element present in the queue
            Console.WriteLine("Top Element:" + citynames.Peek());

            Console.WriteLine("Enter the element you want to fetch:");
            string element = Console.ReadLine();

            //contains method
            if (citynames.Contains(element))
            {
                Console.WriteLine("Entered element present in the Queue");
            }
            else
            {
                Console.WriteLine("Element not found");
            }
            Console.WriteLine();

            //clear method
            citynames.Clear();
            Console.WriteLine("Clear method executed:");
            foreach (var i in citynames)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Empty Stack");
        }
    }

    class SortedListDemo
    {
        SortedList<int, string> emplist = new SortedList<int, string>();

        public void sortedlistmethods()
        {
            // to add elements into the list
            emplist.Add(1, "John");
            emplist.Add(2, "Alex");
            emplist.Add(3, "Peter");

            //to print the sorted list
            foreach (KeyValuePair<int, string> kv in emplist)
            {
            Console.WriteLine("ID: {0}, Name: {1}", kv.Key, kv.Value);
            }

            Console.WriteLine("Enter an integer key to find the element from list: ");
            int keyval = Convert.ToInt32(Console.ReadLine());

            //containsKey checks whether the key is present in the list
            if (emplist.ContainsKey(keyval))
            {
                Console.WriteLine("Element Found");
                Console.WriteLine("Value Present At {0} key is: {1}", keyval , emplist[keyval]);
            }
            else
            {
                Console.WriteLine("Element not found");
            }

            Console.WriteLine();

            Console.WriteLine("Before Update Value:" + emplist[1]);
            emplist[1] = "Smith"; // to update the value of existing record using key
            Console.WriteLine("After Update Value:" + emplist[1]);
            Console.WriteLine();


            Console.WriteLine("Remaining Elements in the list after remove method:");
            emplist.Remove(1);// remove the element by specifying its key
            emplist.RemoveAt(1); // remove the element by specifying index

            foreach (KeyValuePair<int, string> kv in emplist)
            {
                Console.WriteLine("ID: {0}, Name: {1}", kv.Key, kv.Value);
            }

        }
    }

    class DictionaryDemo
    {
        //created a dictionary of string type
        Dictionary<string, string> citylist = new Dictionary<string, string>();

        public void dictionarymethods()
        {
            //to add element into the dictionary
            citylist.Add("India", "Pune, Mumbai");
            citylist.Add("UK", "London, Manchester");
            citylist.Add("USA", "NewYork , Washington");

            //to print the dictionary
            foreach (KeyValuePair<string, string> kv in citylist)
            {
                Console.WriteLine("Key: {0}  Value: {1}", kv.Key, kv.Value);
            }

            Console.WriteLine("Enter a country name to search from the dictionary: ");
            string val = Console.ReadLine();

            //containsKey checks whether the key is present in the dictionary
            if (citylist.ContainsKey(val))
            {
                Console.WriteLine("Country Found");
            }
            else
            {
                Console.WriteLine("Country not found");
            }

            Console.WriteLine();

            Console.WriteLine("Before Update Value of India:" + citylist["India"]);
            citylist["India"] = "Bangalore, Kerala, Punjab"; // to update the value of existing record using key
            Console.WriteLine("After Update Value of India:" + citylist["India"]);
            Console.WriteLine();


            Console.WriteLine("Remaining Elements in the list after remove method:");
            citylist.Remove("UK");// remove the element by specifying its key

            foreach (KeyValuePair<string, string> kv in citylist)
            {
                Console.WriteLine("ID: {0}, Name: {1}", kv.Key, kv.Value);
            }

        }
    }
}
