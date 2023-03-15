using ConsoleApp22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22.services
{
    internal class StudentService:IStudentService
    {
        Student[] students = { };
        public void Create()
        {
            Student student=new Student()
            {
                Console.WriteLine("enter name");
            student name=Console.ReadLine();

            Console.WriteLine("enters surname");
            student surname=Console.ReadLine();

            Console.WriteLine("enter groupno");
            student GroupNo=Console.ReadLine();

            Array.Resize(ref students, Students.Lenght+1);
            students[students.Length-1]=student;

            }
                
        }
    public VOID Show()
    {
        foreach  (Student in students)
        {
            Console.WriteLine(Student);
        }
    }
    }
}
