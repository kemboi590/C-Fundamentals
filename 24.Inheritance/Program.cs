namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.hasID();
            student.hasName();

            NewStudent newStudent = new NewStudent();
            newStudent.hasID();
            newStudent.hasMoreDetails();
            newStudent.hasBio();

        }
    }
}