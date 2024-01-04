
Console.WriteLine("This is a basic calculator");
Console.Write("Enter a number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter an Operator: ");
string op = Console.ReadLine();

Console.Write("Enter the second number: ");
double num2  = Convert.ToDouble(Console.ReadLine());

if(op == "+")
{
    Console.WriteLine(num2  + num1);
} else if(op == "-")
{
    Console.WriteLine(num1 - num2);
} else if (op == "*")
{
   Console.WriteLine(num1 * num2);
}else if (op == "/")
{
    Console.WriteLine(num1 / num2);
}
else
{
    Console.WriteLine("Invalid Operator");
}
