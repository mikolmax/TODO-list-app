using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello!");

Console.WriteLine("Input the first number:");
var firstInput = Console.ReadLine();
var firstNum = int.Parse(firstInput);

Console.WriteLine("Input the second number:");
var secondInput = Console.ReadLine();
var secondNum = int.Parse(secondInput);

Console.WriteLine("What do you want to do with these numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
string userChoice = Console.ReadLine();


if (EqualsCaseInsensitive(userChoice, "A"))
{
    var sum = firstNum + secondNum;
    PrintFinalEquation(firstNum, secondNum, sum, "+");
}
else if (EqualsCaseInsensitive(userChoice, "S"))
{
    var difference = firstNum - secondNum;
    PrintFinalEquation(firstNum, secondNum, difference, "-");
}
else if (EqualsCaseInsensitive(userChoice, "M"))
{
    var multiplied = firstNum * secondNum;
    PrintFinalEquation(firstNum, secondNum, multiplied, "*");
}
else
{
    Console.WriteLine("Invalid Option!");
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();

void PrintFinalEquation (int num1, int num2, int result, string @operation)
{
    Console.WriteLine($"{num1} {@operation} {num2} = {result}");
}

bool EqualsCaseInsensitive (string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}
