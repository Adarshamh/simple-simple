using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace sample1
{
     class Class1
    {
        public void printOut(string name)
        {
            Console.WriteLine(name);
        }

        public void printOut(int age)
        {
            Console.WriteLine(age);
        }

        public void printOut()
        {
            Console.WriteLine("Adarshmh");
        }
    }

}
