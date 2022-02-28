Console.Write("введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA>numberB)
{
Console.WriteLine(numberA);
Console.WriteLine(numberB);
}
else 
{
Console.WriteLine(numberB);
Console.WriteLine(numberA);
}