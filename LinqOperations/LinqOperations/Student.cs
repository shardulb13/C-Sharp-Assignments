using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperations
{
    class Student
    {
        public int Rollno;
        public string Name;
        public int Standard;

        public Student(int id, string name, int std )
        {
            this.Rollno = id;
            this.Name = name;
            this.Standard = std;
        }
    }

}
