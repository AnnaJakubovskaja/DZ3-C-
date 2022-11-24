// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53


int x1=ReadInt("Введите координаты X первой точки: ");
int y1=ReadInt("Введите координаты Y первой точки: ");
int z1=ReadInt("Введите координаты Z первой точки: ");

int x2=ReadInt("Введите координаты X второй точки: ");
int y2=ReadInt("Введите координаты Y второй точки: ");
int z2=ReadInt("Введите координаты Z второй точки: ");

int a=x2-x1;
int b=y2-y1;
int c=z2-z1;

double result=Math.Sqrt(a*a+b*b+c*c);
Console.WriteLine($"Расстояние между первой и вотой точками равно {result}");

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}