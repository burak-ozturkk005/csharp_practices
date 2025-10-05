using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentProject
{
    internal class StudentManager
    {
        List<Student> students = new List<Student>();

        public void Addstudent(Student student)
        {
            students.Add(student);
        }
        public void ListAllStudents()
        {
            foreach(var s in students)
            {
                Console.WriteLine(s);
            }
        }
       public void StudentAverage(double min)
        {
            Console.WriteLine($"\n Average grade {min} and above students");
            bool found = false;
            foreach(var s in students)
            {
                double avg = s.GradeAverage();
                if(avg >= min)
                {
                    Console.WriteLine(s.ToString());
                    found = true;
                }
            }
            if(!found)
            {
                Console.WriteLine("Can not find a student with average.");
            }
        }
    }
}
