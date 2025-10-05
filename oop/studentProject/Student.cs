using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentProject
{
    internal class Student
    {
        
        public List<int> grades = new List<int>();

        public Student(string name, string surname, string studentNo,int id)
        {
            Name = name;
            Surname = surname;
            StudentNo = studentNo;
            Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string StudentNo { get; set; }
        public void GradeAdd(int grade)
        {
            grades.Add(grade);
        }

        public double  GradeAverage()
        {
            double sum = 0;
            if (grades.Count == 0)
            {
                return 0;
            }else
            {
                foreach (int g in grades) sum += g;
                
            }
            return sum / grades.Count;
        }
        public override string ToString()
        {
            string allGrades = string.Join(",", grades);
            return $"[{Id}] {Name} {Surname} - Grades: [{allGrades}] | Average: {GradeAverage():F2}";
            
        }
    }
}
