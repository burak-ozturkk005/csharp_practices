using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicexp
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual string Introduce()
        {
            return $"Hello, my name is {Name} and I am {Age} years old.";
        }
    }
    public class Student : Person
    {
        public string StudentId { get; set; }
        public  override string Introduce()
        {
            return $"Hello, my name is {Name} and I am {Age} years old, and my student ID is {StudentId}";
        }
    }
}
