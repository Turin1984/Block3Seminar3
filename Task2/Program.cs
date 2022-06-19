// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear ();

int Prompt(string message)
{
Console.Write(message);
string number = Console.ReadLine();
int numInt = int.Parse(number);
return numInt;
}
int x1 = Prompt("Введите координаты x1 = ");
int y1 = Prompt("Введите координаты y1 = ");
int z1 = Prompt("Введите координаты z1 = ");
int x2 = Prompt("Введите координаты x2 = ");
int y2 = Prompt("Введите координаты y2 = ");
int z2 = Prompt("Введите координаты z2 = ");

int a = x1-x2;
int b = y1-y2;
int c = z1-z2;

double distance = Math.Sqrt(a*a+b*b+c*c);

Console.WriteLine ("Расстояние между 2-я точками в 3D пространстве равно =>" + distance);



