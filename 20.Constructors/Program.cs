//Constructors are the special metod in a class that are going to be called
namespace Class_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Money First", "Karen", 400);
       
            Book book2 = new Book("5am Club","kemboi", 370);


            Console.WriteLine(book1.name);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            Console.WriteLine(book2.name);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);
        }
    }
}