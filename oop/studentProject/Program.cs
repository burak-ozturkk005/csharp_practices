namespace studentProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            Student s1 = new Student("Burak","Ozturk","123456",1);
            s1.GradeAdd(70);
            s1.GradeAdd(100);
            Student s2 = new Student("Mert", "Kaya", "2234", 2);
            s2.GradeAdd(40);
            s2.GradeAdd(45);
            Student s3 = new Student("Asli", "Demir", "23234", 3);
            s3.GradeAdd(89);
            s3.GradeAdd(56);
            manager.Addstudent(s1);
            manager.Addstudent(s2);
            manager.Addstudent(s3);
            manager.ListAllStudents();
        }
    }
}
