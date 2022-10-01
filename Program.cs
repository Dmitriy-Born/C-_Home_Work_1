//Задание №1
Console.WriteLine("Введите первое число: ");
int Num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine()!);

if (Num1 > Num2){
    Console.WriteLine($"Максимальное число из {Num1} и {Num2} - это {Num1}");
}
else
{
    Console.WriteLine($"Максимальное число из {Num1} и {Num2} - это {Num2}");
}