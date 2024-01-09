namespace Class_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.name = "Money First";
            book1.author = "Kemboi";
            book1.pages = 400;


            Book book2 = new Book();
            book2.name = "5am Club";
            book2.author = "Bruno";
            book2.pages = 300;

            Console.WriteLine(book1.name);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            Console.WriteLine(book2.name);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);
        }
    }
}