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
// Console.WriteLine("Введите первое число: ");
// int Num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int Num2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите третье число: ");
// int Num3 = int.Parse(Console.ReadLine()!);

// if (Num1 > Num2) {
//     if (Num1 > Num3){
//         Console.WriteLine($"Максимальное число из {Num1}, {Num2} и {Num3} - это {Num1}");
//     }
//     else {
//         Console.WriteLine($"Максимальное число из {Num1}, {Num2} и {Num3} - это {Num3}");
//     }
// }
// else {
//     if (Num2 > Num3){
//         Console.WriteLine($"Максимальное число из {Num1}, {Num2} и {Num3} - это {Num2}");
//     }
//     else {
//         Console.WriteLine($"Максимальное число из {Num1}, {Num2} и {Num3} - это {Num3}");
//     }
// }

//Задание №3
// Console.WriteLine("Введите число для проверки: ");
// int N = int.Parse(Console.ReadLine()!);

// if (N%2==0){
//     Console.WriteLine($"Число {N} является четным");
// }
// else {
//     Console.WriteLine($"Число {N} является нечетным");
// }

//Задание №4
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int i = 2;

if (N%2==0){
    while (i < N) {
        Console.Write($"{i}, ");
        i = i + 2;
    }
    Console.Write(i);
}
else {
N = N - 1;
if (N%2==0){
    while (i < N) {
        Console.Write($"{i}, ");
        i = i + 2;
    }
    Console.Write(i);
}
}
