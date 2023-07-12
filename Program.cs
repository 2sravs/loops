using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConAppLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myNum = 12;
            var myString = "Sravs";
            var status = true;
            var grade = 'A';
            Console.WriteLine("value stored in myNum is : " + myNum + "\n Data Type :" + myNum.GetType());
            Console.WriteLine("value stored in myString is : " + myString + "\n Data Type :" + myString.GetType());
            Console.WriteLine("value stored in  is : " + status + "\n Data Type :" + status.GetType());
            Console.WriteLine("value stored in grade is : " + grade + "\n Data Type :" + grade.GetType());
            Console.ReadLine();




        }
    }
}
