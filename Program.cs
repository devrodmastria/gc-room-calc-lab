//Day 1 - Lab 1
//Room Calculator Tool

Console.WriteLine("--- Room Calculator Tool ---");
Console.WriteLine("Enter Length (any unit)");
double roomLength = double.Parse(Console.ReadLine());

Console.WriteLine("Enter Width (any unit)");
double roomWidth = double.Parse(Console.ReadLine());

// assume input is valid
double roomPerimeter = roomWidth * 2 + roomLength * 2;
double roomArea = roomLength * roomWidth;

if (roomArea <= 250)
{
    Console.WriteLine("This is a small room");
} else if (roomArea < 650 && roomArea > 250)
{
    Console.WriteLine("This is a medium size room");
} else
{
    Console.WriteLine("This is a large room");
}

Console.WriteLine($"Area {roomArea}");
Console.WriteLine($"Perimeter {roomPerimeter}");
Console.WriteLine("------------------------------------------");
Console.WriteLine("Thanks for using the Room Calculator Tool!");