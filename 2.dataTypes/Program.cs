// See https://aka.ms/new-console-template for more information



string characterName = "Brian";
int characterAge;
characterAge = 22;
Console.WriteLine(characterAge);

Console.WriteLine("There was a man name " + characterName);
Console.WriteLine("John was " + characterAge + " years old ");
Console.WriteLine("He really loved the name " + characterName);
Console.WriteLine("But he did not like being " + characterAge);



//Data Types in c#
//strings


string name = "Brian Kemboi";


//charaters
char character = 'A';

//integers
int number = 10;

// float  double decimal
double gpa = 3.4;

//bool
bool isMale =  false;
bool isFemale = true;



//Strings
//Console.WriteLine("Hello \n there");
//Console.WriteLine("Hello \" there");

//concatinating


string phrase = "Brian Kemboi" + " is an Engineer";
//Console.WriteLine(phrase);
//Console.WriteLine(phrase.Length);

//String methods


Console.WriteLine(phrase.ToUpper()); // to upper case
Console.WriteLine(phrase.ToLower()); // to lower case
Console.WriteLine(phrase.Contains("Kemboi")); //to check is a char is available
Console.WriteLine(phrase[0]); // indexing start at 0,1,2,3 ....
Console.WriteLine(phrase.IndexOf("Kemboi")); // checks the index of a string or a char and -1 when it is not available
Console.WriteLine(phrase.Substring(6, 6)); //getting a section of a string


//NUMBERS IN C#

Console.WriteLine( 5%2);
Console.WriteLine( 5 * 2);
Console.WriteLine( 5 / 2);
Console.WriteLine( 5 + 2);
Console.WriteLine( 5 - 2);

//Increament
int a = 10;
Console.WriteLine("Increament value " +  a );
a++;






//Math methods

Console.WriteLine("Absolute value: " + Math.Abs(-29));  //gives an absolute value

Console.WriteLine("Power value: " + Math.Pow(3,2));  //Power of a number

Console.WriteLine("Square root: " + Math.Sqrt(49));  // square root

Console.WriteLine("Max value: " + Math.Max(77, 90)); //maximum
Console.WriteLine("Min value: " + Math.Min(77, 90)); //minimum
Console.WriteLine("Round off: " + Math.Round(33.4)); //round off


//CONVERTING A STRING TO AN INT
int num1 = Convert.ToInt32("45");
int num2 = Convert.ToInt32("50");
int sum = num1 + num2;
Console.WriteLine( "Sum value is: " + sum);