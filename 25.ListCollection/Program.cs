

var names = new List<string> { "Zachariah", "Karen", "Felipe" };

//List<string> values = new List<string> { "kemboi", "Ana", "Felipe" }; 

names.Add("Jacob");
names.Add("Jane");

//for(int i = 0;  i < names.Count; i++)
//{
//    Console.WriteLine($"Hello {names[i].ToUpper()}");
//}

foreach (var name in names) // local variable type inference
{
    //Console.WriteLine($"Hello {name.ToUpper()}!");
}

//Console.WriteLine($"My name is {names[0]}.");
//Console.WriteLine($"I have added {names[3]} and {names[4]} to the list");

//checking how long the list is.
//Console.WriteLine($"The list has {names.Count} people in it");

//searching and sorting lists


/*
var index = names.IndexOf("Jane");  

if (index != -1)
{
    Console.WriteLine($"The name {names[index]} is at index {index} ");
}
else
{
    Console.WriteLine("The searched index was not found");
}

*/

//Sorting a list

/*
names.Sort();

foreach (var name in names)
{
    Console.WriteLine(name); //shall be sorted alphabetically
}

*/

//LIST OF OTHER TYPES

var myLuckyNumbers = new List<int> { 22,7,90,43,67};

foreach (var number in myLuckyNumbers)
{
    Console.WriteLine(number);
}

//add the luck numbers
int sum = myLuckyNumbers.Sum();
Console.WriteLine($"\nThe sum of lucky numbers are: {sum}");