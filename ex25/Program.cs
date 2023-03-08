//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
int Prompt(string message)
{
    System.Console.Write(message);
    string RealInput = System.Console.ReadLine();
    int result = int.Parse(RealInput);
    return result;
}
int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}
bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Exponent cannot be less than zero");
        return false;
    }
    return true;
}
int powerBase = Prompt("Enter number: ");
int exponent = Prompt("Enter exponent: ");
if(ValidateExponent(exponent))
{
    System.Console.WriteLine($"Number {powerBase}  to the power {exponent} equals {Power(powerBase, exponent)}");
}