using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one student object
            Student student = new Student();
            student.Firstname = "Seppo";
            student.Lastname = "Terävä";
            student.Address = "Kusipolku 1";
            student.Age = 24;
            student.PhoneNumber = "050 4040303030303";
            student.StudentID = "k1977";
            Console.WriteLine(student.ToString());

            Teacher teacher = new Teacher("kirsi", "kernel", "D666");
            teacher.Age = 35;
            teacher.Address = "Piippukatu 2";
            teacher.PhoneNumber = "404040404";
            Console.WriteLine(teacher.ToString());

            teacher.TeahcerMethod();
            student.StudentMethod();

            //Olio ei ole aliluokan sisällä
            //student.PersonMethod();
        }
    }
}
