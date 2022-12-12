// See https://aka.ms/new-console-template for more information
// на входе трехзначное число на выходе показывает вторую цифру

Console.WriteLine("Введите трехзначное число: ");
int numberA=int.Parse(Console.ReadLine());
numberA=numberA%100/10;
Console.WriteLine(numberA);
