using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Student : Person
    {
        public string StudentID { get; set; }

        public Student()
        {

        }

        public Student(string firstname, string lastname, string studentid)
            : base(firstname, lastname)
        {
            StudentID = studentid;
        }

        public void StudentMethod()
        {
            Console.WriteLine("This method belongs to Student");
        }

        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }
    }
}
