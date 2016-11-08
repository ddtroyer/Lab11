using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John Doe", "1232 Mockingbird Lane");
            Console.WriteLine($"{person.getName()} and their address {person.getAddress()}");
            Console.WriteLine(person.ToString());

            Student student = new Student("Jane Doe", "30 Rockefeller", "Bachelor", 2018, 25000);
            Staff staff = new Staff("Andrew Holtz", "1400 Lake Michigan Drive", "Saugatuck",45000);

            Console.WriteLine($"{student.getName()}, {student.getAddress()}, {student.getProgram()}, {student.getYear()}, {student.getFee()}");
            Console.WriteLine(student.ToString());
            Console.WriteLine($"{staff.getName()}, {staff.getAddress()}, {staff.getSchool()}, {staff.getPay()}");
            Console.WriteLine(staff.ToString());
        }
    }
}
