//Задание №1
// Console.WriteLine("Введите первое число: ");
// int Num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int Num2 = int.Parse(Console.ReadLine()!);

// if (Num1 > Num2){
//     Console.WriteLine($"Максимальное число из {Num1} и {Num2} - это {Num1}");
// }
// else
// {
//     Console.WriteLine($"Максимальное число из {Num1} и {Num2} - это {Num2}");
// }

//Задание №2
Console.WriteLine("Введите первое число: ");
int Num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int Num3 = int.Parse(Console.ReadLine()!);

if (Num1 > Num2) {
    if (Num1 > Num3){
        Console.WriteLine($"Максимальное число из {Num1}, {Num2} и {Num3} - это {Num1}");
    }
    else {
        Console.WriteLine($"Максимальное число из {Num1}, {Num2} и {Num3} - это {Num3}");
    }
}
else {
    if (Num2 > Num3){
        Console.WriteLine($"Максимальное число из {Num1}, {Num2} и {Num3} - это {Num2}");
    }
    else {
        Console.WriteLine($"Максимальное число из {Num1}, {Num2} и {Num3} - это {Num3}");
    }
}