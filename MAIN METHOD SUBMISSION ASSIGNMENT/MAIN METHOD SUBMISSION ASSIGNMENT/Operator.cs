using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_METHOD_SUBMISSION_ASSIGNMENT
{
    class Operator
    {
        public int Add(int data)
        {
            return data + 6;
        }

        public int Add(decimal data)
        {
            return Convert.ToInt32(data + 5); 
        }

        public int Add(string data)
        {
            return Convert.ToInt32(data)+9;
        }//Added three methods, using the same name but different parameters. 
    } 
    }
}
