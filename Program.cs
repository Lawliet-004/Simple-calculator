int firstNumber = 0;
int secondNumber = 0;
int finalResult = 0;
string? readInput1 = "";
string? readInput2 = "";
string? readChoice = "";

Console.Clear();
Console.WriteLine("Welcome to the Simple Calculator!");
Console.WriteLine("Choose the first number: ");
readInput1 = Console.ReadLine();

while (true)
{
    if (!int.TryParse(readInput1, out firstNumber))
    {
        Console.WriteLine("Please write an appropriate number: ");
        readInput1 = Console.ReadLine();
    }
    else
        break;
}

Console.WriteLine("Would you like to do addition or subtraction? (+/-): ");
readChoice = Console.ReadLine();

while (true)
{
    if (readChoice != "+" && readChoice != "-")
    {
        Console.WriteLine("Please choose addition or subtraction (+/-): ");
        readChoice = Console.ReadLine();
    }
    else
        break;
}

Console.WriteLine("Choose the second number: ");
readInput2 = Console.ReadLine();

while (true)
{
    if (!int.TryParse(readInput2, out secondNumber))
    {
        Console.WriteLine("Please write an appropriate number: ");
        readInput2 = Console.ReadLine();
    }
    else
        break;
}

if (readChoice == "+")
    finalResult = firstNumber + secondNumber;
else if (readChoice == "-")
    finalResult = firstNumber - secondNumber;

Console.WriteLine($"\nThe result is : {finalResult}\n");