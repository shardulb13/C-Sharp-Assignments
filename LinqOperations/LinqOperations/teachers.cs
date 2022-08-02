using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperations
{
    class Teachers
    {
        public int standard;
        public string teachername;
        public int fees;

        public Teachers(int id, string name, int fee)
        {
            this.standard = id;
            this.teachername = name;
            this.fees = fee;
        }


    }
}
