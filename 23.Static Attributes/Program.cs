namespace Static_Class_Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.SongCount);
            Song kashmir = new Song("Kasmir", "Led Zeppelin", 150);
            //Console.WriteLine(holiday.title);
            //Console.WriteLine(kashmir.title);

            //without the getter method the class has access to the static class attribute
            Console.WriteLine(Song.SongCount);

            //instance have access to the static attribute
            Console.WriteLine(kashmir.getSongCount());
        }
    }
}