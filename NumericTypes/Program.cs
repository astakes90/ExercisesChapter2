Console.WriteLine("What is the length of the rectangle?");
string userInput1 = Console.ReadLine();
int length = int.Parse(userInput1);

Console.WriteLine("What is the width of the rectangle?");
string userInput2 = Console.ReadLine();
int width = int.Parse(userInput2);

int area = (width * length);

Console.WriteLine("The area of the rectangle is: " + area);

Console.WriteLine("How many miles have you driven?");
string userInput3 = Console.ReadLine();
int miles = int.Parse(userInput3);

Console.WriteLine("How many gallons of gas has your vehicle consumed?");
string userInput4 = Console.ReadLine();
int gallons = int.Parse(userInput4);

int milesPerGallon = (miles / gallons);

Console.WriteLine("You are currently at " + milesPerGallon + " mpg.");