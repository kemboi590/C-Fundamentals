Console.WriteLine("You are to enter 3 numbers for comparison: ");
Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int num2= Convert.ToInt32(Console.ReadLine());
 Console.Write("Enter third number: ");
int num3= Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MaxVal(num1, num2, num3));


static int MaxVal(int num1, int num2, int num3)
        {
            int result;

            if(num1 >= num2 && num1 >= num3)
            {
             result = num1;
            }
            else if(num2 >= num1 && (num2 >= num3))
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;

        }