
//If statements in cs to check for conditions and && and || operators

bool isMale = true;
bool isTall = true;

if (isMale && isTall)
{
    Console.WriteLine("You are a tall male");
}
else if (isMale && !isTall)
{
    Console.WriteLine("You are a short male");
}
else if (!isMale && isTall)
{
    Console.WriteLine("You are not male but tall");
}
else
{
    Console.WriteLine("You are not male and not tall");
}