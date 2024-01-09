namespace Object_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Kemboi", 3.7, "Software");
            Student student2 = new Student("Jane", 2.4, "Bussiness");

            Console.WriteLine(student1.HasHonors());  //true
            Console.WriteLine(student2.HasHonors()); //false
        }
    }
}