//switch statements are used to check for condtions/ cases
Console.Write("Enter a dayNumber of a week: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
GetDate(dayOfTheWeek);

static void GetDate(int dayNumber)
{
    switch(dayNumber)
    {
        case 1:
            {
                Console.WriteLine("Today is on Monday");
                break;
            }
        case 2:
            {
                Console.WriteLine("Today is on Tuesday");
                break;
            }
        case 3:
            {
                Console.WriteLine("Today is on Wednesday");
                break;
            }
        case 4:
            {
                Console.WriteLine("Today is on Thursday");
                break;
            }
        case 5:
            {
                Console.WriteLine("Today is on Friday");
                break;
            }
        case 6:
            {
                Console.WriteLine("Today is on Saturday");
                break;
            }
        case 7:
            {
                Console.WriteLine("Today is on Sunday");
                break;
            }
            default:
            {
                Console.WriteLine("Invalid DayNumber");
                break;
            }
    }
}
