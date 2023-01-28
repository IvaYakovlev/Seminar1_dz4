// Задача 4: Напишите программу, которая принимает на вход три 
//числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();

Console.Write("Введите первое число: "); 
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: "); 
int num2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: "); 
int num3 = int.Parse(Console.ReadLine());

int max = 0;

if (num1>num2){
  max=num1;
}
else {
  max=num2;}
int megamax=0;
if (max>num3){
  megamax=max;
}
else {
  megamax=num3;}

Console.WriteLine($"Между числами {num1}, {num2} и {num3} - максимальное: {megamax}");