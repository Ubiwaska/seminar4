//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
int Prompt(string message)
{
    System.Console.Write(message);
    string RealInput = System.Console.ReadLine();
    int result = int.Parse(RealInput);
    return result;
}
int Sum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Prompt("Enter number: ");
 System.Console.WriteLine($"Sum of all digits in number {number} is {Sum(number)}");
