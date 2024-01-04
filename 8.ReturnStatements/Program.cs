//A method can retun any data type

//Cube 
static int Cube(int number)
{
    int result = (number * number * number);
    return result;
}

Console.Write("Enter a number: ");
int val = Convert.ToInt32(Console.ReadLine());

int cubedNumber = Cube(val);
Console.WriteLine("The cube of " + val + " is " + cubedNumber);

//Square

static int Square(int number)
{
    int result = (number * number);
    return result;
}

int squredNumber = Square(val);
Console.WriteLine("The square of " + val + " is " + squredNumber);
Console.WriteLine("Happy Coding...");