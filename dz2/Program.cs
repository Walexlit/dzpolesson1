Console.WriteLine("введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите третье число");
int numberС = Convert.ToInt32(Console.ReadLine());

int max=numberA;

if (numberA>numberB) max=numberA;

if (numberB>numberA) max=numberB;

if (numberС>max) max=numberС;

Console.WriteLine("максимальное число");
Console.WriteLine(max);

