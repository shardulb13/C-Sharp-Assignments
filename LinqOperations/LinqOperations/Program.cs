using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOperations
{
    class Program
    {

        static void Main(string[] args)
        {
            Student stdobj1 = new Student(1, "John", 8);
            Student stdobj2 = new Student(2, "Alex", 5);
            Student stdobj3 = new Student(3, "Adam", 8);
            Student stdobj4 = new Student(4, "Krish", 10);
            Student stdobj5 = new Student(5, "Tom", 9);
            //Student stdobj6 = new Student(6, "BEN", 1);



            Teachers teacherobj1 = new Teachers(8, "Alexander", 8000);
            Teachers teacherobj2 = new Teachers(5, "Robert", 5000);
            Teachers teacherobj3 = new Teachers(7, "Michael", 5000);
            Teachers teacherobj4 = new Teachers(10, "Jacob", 10000);
            Teachers teacherobj5 = new Teachers(9, "Alexander", 8000);
            Teachers teacherobj6 = new Teachers(1, "Thomson", 3000);


            List<Student> studentlist = new List<Student>();
            studentlist.Add(stdobj1);
            studentlist.Add(stdobj2);
            studentlist.Add(stdobj3);
            studentlist.Add(stdobj4);
            studentlist.Add(stdobj5);
            //studentlist.Add(stdobj6);


            List<Teachers> teacherlist = new List<Teachers>();
            teacherlist.Add(teacherobj1);
            teacherlist.Add(teacherobj2);
            teacherlist.Add(teacherobj3);
            teacherlist.Add(teacherobj4);
            teacherlist.Add(teacherobj5);
            teacherlist.Add(teacherobj6);

            // ---------------------------------------------Using LinQ -------------------------------------------------// 

            //SQL QUERY FOR INNER JOIN
            // select student.rollno, student.name, teachers.teacherName, student.standard from students
            // INNER JOIN teachers ON teachers.standard = student.standard ORDERBY student.standard DESC;

            // Query Syntax 
            var mylinqQuery = from s in studentlist
                              join t in teacherlist
                              on s.Standard equals t.standard
                              orderby s.Standard descending
                              select new
                              {
                                  Rollno = s.Rollno,
                                  StudentName = s.Name,
                                  ClassTeacher = t.teachername,
                                  Standard = s.Standard
                              };

            //Method Syntax
            var mylinqMethod = studentlist.Join(teacherlist,
                                                s => s.Standard,
                                                t => t.standard,
                                                (s, t) => new
                                                {
                                                    Rollno = s.Rollno,
                                                    StudentName = s.Name,
                                                    ClassTeacher = t.teachername,
                                                    Standard = s.Standard
                                                }).OrderByDescending(obj => obj.Standard);

            Console.WriteLine("Student Teacher Details Using Query Syntax");
            foreach (var item in mylinqQuery)
            {
                Console.WriteLine("Rollno: {0} ,StudentName: {1}, TeacherName: {2}, Standard: {3}", item.Rollno, item.StudentName, item.ClassTeacher, item.Standard);
            }

            Console.WriteLine();

            Console.WriteLine("Student Teacher Details using Method Syntax");
            foreach (var item in mylinqMethod)
            {
                Console.WriteLine("Rollno: {0} ,StudentName: {1}, TeacherName: {2}, Standard: {3}", item.Rollno, item.StudentName, item.ClassTeacher, item.Standard);

            }

            Console.WriteLine();

            //Contains Method to check whether the name present in the list
            //Console.WriteLine("Enter a student name to find from list:");
            //string name = Console.ReadLine();
            //var mylinqcontains = (from s in studentlist
            //                      select s.Name).Contains(name);

            //if (mylinqcontains)
            //{
            //    Console.WriteLine("Name Present in the list");
            //}
            //else
            //{
            //    Console.WriteLine("Name not Present");
            //}
            //Console.WriteLine();


            //All data of student list
            Console.WriteLine("Print all Data of StudentList");
            //Query Syntax
            var alldata1 = from data in studentlist
                           select data;
            //Method Syntax
            var alldata = studentlist.Select(data => data);
            foreach(var data in alldata1)
            {
                Console.WriteLine("RollNo: {0}, StudentName: {1}, Standard: {2}", data.Rollno, data.Name, data.Standard);
            }
            Console.WriteLine();
;
            // --------------------------------------------Without Linq ---------------------------------------------
            Console.WriteLine("--------Without Linq -----------");
            //Console.WriteLine("Student and Teacher list:");
            //foreach (var std in studentlist)
            //{
            //    foreach (var te in teacherlist)
            //    {
            //        if (std.Standard == te.standard)
            //        {
            //            Console.WriteLine(" RollNo: {0}, StudentName: {1}, TeacherName: {2}, Standard: {3}",std.Rollno, std.Name, te.teachername, std.Standard);
            //        }
            //    }
            //}
            Console.WriteLine();

            //to find a name from the list
            //Console.WriteLine("Enter a student name to find from list:");
            //string nameval = Console.ReadLine();
            //int count = 0;
            //foreach (var da in studentlist)
            //{
            //    if (da.Name == nameval)
            //    {
            //        Console.WriteLine("Name Found" + da.Name);
            //        count++;
            //        break;
            //    }
            //}
            //if (count < 1)
            //{
            //    Console.WriteLine("Name not found");
            //}

            //Console.WriteLine("Sorted Student List By Ascending Order");
            //for (int i = 0; i < studentlist.Count; i++)
            //{
            //    for (int j = i + 1; j < studentlist.Count; j++)
            //    {
            //        if (studentlist[i].Standard > studentlist[j].Standard)
            //        {
            //            int temprollno = studentlist[i].Rollno;
            //            studentlist[i].Rollno = studentlist[j].Rollno;
            //            studentlist[j].Rollno = temprollno;

            //            string tempName = studentlist[i].Name;
            //            studentlist[i].Name = studentlist[j].Name;
            //            studentlist[j].Name = tempName;

            //            int tempstd = studentlist[i].Standard;
            //            studentlist[i].Standard = studentlist[j].Standard;
            //            studentlist[j].Standard = tempstd;
            //        }
            //    }

            //    Console.WriteLine("StudentRollno: {0}, StudentName: {1}, Standard: {2}", studentlist[i].Rollno, studentlist[i].Name, studentlist[i].Standard);
            //}
            Console.WriteLine();

            //Console.WriteLine("Sorted Student List By Descending Order");
            //for (int i = 0; i < studentlist.Count; i++)
            //{
            //    for (int j = i + 1; j < studentlist.Count; j++)
            //    {
            //        if (studentlist[i].Standard < studentlist[j].Standard)
            //        {
            //            int temprollno = studentlist[i].Rollno;
            //            studentlist[i].Rollno = studentlist[j].Rollno;
            //            studentlist[j].Rollno = temprollno;

            //            string tempName = studentlist[i].Name;
            //            studentlist[i].Name = studentlist[j].Name;
            //            studentlist[j].Name = tempName;

            //            int tempstd = studentlist[i].Standard;
            //            studentlist[i].Standard = studentlist[j].Standard;
            //            studentlist[j].Standard = tempstd;
            //        }
            //    }

            //    Console.WriteLine("StudentRollno: {0}, StudentName: {1}, Standard: {2}", studentlist[i].Rollno, studentlist[i].Name, studentlist[i].Standard);
            //}

            Console.WriteLine();


            //to print all data  of student list
            //Console.WriteLine("All Data");
            //foreach (var item in studentlist)
            //{
            //    Console.WriteLine("StudentRollno: {0}, StudentName: {1}, Standard: {2}", item.Rollno, item.Name, item.Standard);

            //}

            // ---------------------------------------Method Syntax --------------------------------------//


            ////GroupBy Example to show the name of students according to standard
            //var GroupByQueury = studentlist.GroupBy(s => s.Standard);

            //foreach (var item in GroupByQueury)
            //{
            //    Console.WriteLine("Standard: {0}", item.Key);

            //    foreach (Student s in item)
            //    {
            //        Console.WriteLine("Student Name: {0}", s.Name);
            //    }

            //}


            ////OrderBy and ThenBy to sort multiple columns in list.
            //var orderByQuery = studentlist.OrderBy(s => s.Name).ThenBy(o => o.Standard).ThenBy(r => r.Rollno);

            //foreach(var obj in orderByQuery)
            //{
            //    Console.WriteLine("StudentName: {0}, Standard: {1}, Rollno: {2}" , obj.Name, obj.Standard, obj.Rollno);
            //}



            ////// First method to show the first record in the list.
            //var firstQuery = studentlist.First( x => x.Standard == 11);
            //Console.WriteLine("First StudentName: {0}", firstQuery.Name);

            ////// Last method to show the last record in the list.
            //var firstQuery1 = studentlist.Last(x => x.Standard == 8);
            //Console.WriteLine("Last StudentName: {0}", firstQuery1.Name);

            //// FirstorDefault method. NOTE: Always Check not null condition while using this
            //var firstorDefaultQuery = studentlist.FirstOrDefault(x => x.Standard == 11);
            //if (firstorDefaultQuery != null)
            //{
            //    Console.WriteLine("StudentName: {0}", firstorDefaultQuery.Name);
            //}
            //else
            //{
            //    Console.WriteLine("Null Result");
            //}

            ////ShortWay to write above if condition
            //Console.WriteLine("StudentName:{0}", firstorDefaultQuery?.Name);

            ////LastorDefault Method.
            //var lastorDefaultQuery = studentlist.LastOrDefault(x => x.Standard == 8);
            //if (lastorDefaultQuery != null)
            //{
            //    Console.WriteLine("StudentName: {0}", lastorDefaultQuery.Name);
            //}
            //else
            //{
            //    Console.WriteLine("Null Result");
            //}


            ////simple add & addrange example
            //List<int> lst = new List<int>();
            //lst.Add(1);
            //lst.Add(2);


            //int[] arr = { 3, 4, 5 };

            //lst.AddRange(arr);

            //foreach(int i in lst)
            //{
            //    Console.WriteLine(i);
            //}


            //// Addrange using list
            //DuplicateList d1 = new DuplicateList
            //{
            //    Id = 1,
            //    name = "Shardul",

            //};

            //List<DuplicateList> dlist = new List<DuplicateList>();
            //dlist.Add(d1);

            //studentlist.AddRange((IEnumerable<Student>)dlist);

            //foreach (var item in studentlist.ToList())
            //{
            //    Console.WriteLine(item.Rollno + item.Name + item.Standard);
            //}


            //// Created Another list of duplicatelist class to add specific data from studentlist.
            //List<DuplicateList> L1 = new List<DuplicateList>();
            //L1 = studentlist.Select(x => new DuplicateList { Id = x.Rollno, name = x.Name }).ToList();

            //foreach (DuplicateList i in L1)
            //{
            //    Console.WriteLine(i.Id + " " + i.name);
            //}

            //// Distinct Method : returns new collection of unique elements from the given collection.
            List<int> numlist = new List<int>() { 1 ,3, 2, 1, 5, 3, 5, 3, 2, 4};
            var distinctItems = studentlist.Distinct();
            foreach(var item in distinctItems)
            {
                Console.WriteLine(item.Standard);
            }
            
        }
    }

    class DuplicateList
    {
        public int Id { get; set; }
        public string name { get; set; }

        
    }
}
