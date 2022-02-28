Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int rem = 0;
rem = number % 2;
if (rem == 0)
{
    Console.Write(number);
    Console.Write(" число чётное");
}
else
{
    Console.Write(number);
    Console.Write(" число не чётное");
}
