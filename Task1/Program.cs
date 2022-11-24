// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

Console.WriteLine ("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int first=num/10000;
int second=num/1000%10;
int thirt=num/100%10;
int four=num/10%10;
int fiftth=num%10;
if (first==fiftth && second==four)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}