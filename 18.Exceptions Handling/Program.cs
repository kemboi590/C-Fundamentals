


try
{
    Console.Write("Enter the first Number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second Number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(num1 / num2);
}
catch(DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}
catch(FormatException e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Welcome again!");
}
