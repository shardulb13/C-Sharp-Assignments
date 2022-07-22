using System;
using System.Collections;
namespace NonGenericCollections
{
   class Program
    {
        static void Main(string[] args)
        {
            //HashTableDemo hashtbobj = new HashTableDemo();
            //hashtbobj.AddHashTableDemo();

            //stackDemo stackobj = new stackDemo();
            //stackobj.stackmethods();

            QueueDemo queueobj = new QueueDemo();
            queueobj.stackmethods();
        }
    }

    class HashTableDemo
    {
        public void AddHashTableDemo()
        {
            //Creating a Hashtable of mynumbersname 
            Hashtable mynumbersname = new Hashtable();
            mynumbersname.Add(1, "one");
            mynumbersname.Add(2, "two");
            mynumbersname.Add(3, "three");
            mynumbersname.Add(4, "four");

            foreach (DictionaryEntry htbl in mynumbersname)
            {
                Console.WriteLine("{0},{1}",htbl.Key, htbl.Value);
            }

            //ContainsValue method to check if the table contains a value or not.
            Console.WriteLine("Enter the value from the table:");
            string val = Console.ReadLine();

             if (mynumbersname.ContainsValue(val))
             {
                Console.WriteLine("This entry already exists in the table");
             }
             else
             {
                Console.WriteLine("Entry not found");
                mynumbersname.Add(5, val);
                Console.WriteLine("Entry added successfully");
             }

            Console.WriteLine();

            foreach(DictionaryEntry e in mynumbersname)
            {
                Console.WriteLine("{0}, {1}",e.Key, e.Value);
            }
            Console.WriteLine();

            //updating the value by key to Roman number one. 
            mynumbersname[1] = "I";
            Console.WriteLine("Updated value using indexer:");
            foreach (DictionaryEntry e in mynumbersname)
            {
                Console.WriteLine("{0}, {1}", e.Key, e.Value);
            }
            Console.WriteLine();

            //remove key
            Console.WriteLine("Enter the integer key you want to delete:");
            int enterkey = Convert.ToInt32(Console.ReadLine());
            if (mynumbersname.ContainsKey(enterkey))
            {
                mynumbersname.Remove(enterkey);
                Console.WriteLine("Item Removed Successfully");
            }
            else
            {
                Console.WriteLine("Key not found");
            }


            //add value using indexer

            mynumbersname[10] = "ten";
            Console.WriteLine("Added Value 10 using indexer");
            foreach (DictionaryEntry e in mynumbersname)
            {
                Console.WriteLine("{0}, {1}", e.Key, e.Value);
            }
        }
    }

    class stackDemo
    {
        Stack mynames = new Stack();

        public void stackmethods()
        {
            //Add elements into stack using push method
            mynames.Push("Shardul");
            mynames.Push("Parth");
            mynames.Push("Ajinkya");
            mynames.Push("Nitin");
            foreach (var i in mynames)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Total numbers in the stack:" + mynames.Count);
            Console.WriteLine();


            //Remove elements from stack using pop method
            mynames.Pop();

            //count method gives you the total number of items in the stack
            Console.WriteLine("Total numbers in the stack after removing one element:"+ mynames.Count);
          

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
            Stack stack2 = (Stack)mynames;
            Console.WriteLine("Clone Stack Example:");
            foreach (var i in stack2)
            {
                Console.WriteLine(i);
            }
        }
    }

    class QueueDemo
    {
        Queue citynames = new Queue();

        public void stackmethods()
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
            Console.WriteLine("Total numbers in the stack after removing one element:" + citynames.Count);


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
                Console.WriteLine("Entered element present in the stack");
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
}
