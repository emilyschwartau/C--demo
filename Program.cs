// See https://aka.ms/new-console-template for more information
//make a string
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);

string name = "Emily";
Console.WriteLine(name);

//make a number
//Int (whole number)
int age = 26;
Console.WriteLine(age);

//Floating point number
double example = 2.6e+1D;
Console.WriteLine(example);

//long - used when int isn't big enough to store number
long exampleOne = 15000000000L;
Console.WriteLine(exampleOne);

//float - can also be used for scientific notation
float exampleFloat = 5.75F;
Console.WriteLine(exampleFloat);

//boolean 
bool isLearning = false;
Console.WriteLine(isLearning);

//if else block
if (isLearning == true)
{
    Console.WriteLine("hi");
} 
else if (isLearning == false) 
{
    Console.WriteLine("bye");
} 
else
{
    Console.WriteLine("hello");
}

//switch block
string food = "lettuce";

switch(food)
{
    case "apple": 
        Console.WriteLine("Honeycrisp");
        break;
    case "lettuce":
        Console.WriteLine("Iceberg");
        break;

}

//array of strings






