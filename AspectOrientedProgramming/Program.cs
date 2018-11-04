using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***\r\n Begin program - no logging\r\n");
            //ICRUDRepository<Student> customerRepository =
            //  new CRUDRepository<Student>();
            ICRUDRepository<Student> studentRepository =
                    new StudentLoggerRepository<Student>(new CRUDRepository<Student>());

            var student = new Student
            {
                Id = 1,
                Name = "James Handshoe"
            };
            studentRepository.Create(student);

            studentRepository.Update(student);
            studentRepository.Delete(student);
            Console.WriteLine("\r\nEnd program - no logging\r\n***");
            Console.ReadLine();
        }
    }
}
