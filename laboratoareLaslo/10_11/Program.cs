using System;
// primul laborator cu Laslo 




namespace _10_11
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // #2 ConsoleApp | Se da n si apoi n numere intregi. Sa se determine Suma celor mai mari 3 maxime
            // Date intrare: 18
            // 1 2 5 2 7 6 4 60 70 4 2 3 5 2 25 60 3 56 19
            // Date de iesire
            // 190 = 70 + 60 + 60 

            // 1 2 5 2 7 6 4 60 70 4 2 3 5 2 25 60 3 56 19 -> ??? (ar trebui sa le salvez intr-un vector)
            // 1 2 2 2 3 3 4 4 5 5 6 7 19 25 56 60 60 70 



            // video - lab01 Laslo -> min 70 (1h 10min) /1h42min

        }
    }
}


/*
// #1 ConsoleApp |  https://www.pbinfo.ro/probleme/559/5numere
// Se dau 5 numere intregi. Sa se afiseze Suma celor mai mari 3 valori (problema 559 de pe pbinfo.ro)
// declarare
// int -> integer (intregi)
// float (reale)

int a, b, c, d, e;

// citire tastatura
a = int.Parse(Console.ReadLine()); // cin>>a;
b = int.Parse(Console.ReadLine()); // cin>>b;
c = int.Parse(Console.ReadLine()); // cin>>c;
d = int.Parse(Console.ReadLine()); // cin>>d;
e = int.Parse(Console.ReadLine()); // cin>>e;


if (a > b)
{
    int aux = a;
    a = b;
    b = aux;
}

if (a > c)
{
    int aux = a;
    a = c;
    c = aux;
}

if (a > d)
{
    int aux = a;
    a = d;
    d = aux;
}

if (a > e)
{
    int aux = a;
    a = e;
    e = aux;
}

if (b > c)
{
    int aux = b;
    b = c;
    c = aux;
}

if (b > d)
{
    int aux = b;
    b = d;
    d = aux;
}

if (b > e)
{
    int aux = b;
    b = e;
    e = aux;
}

if (c > d)
{
    int aux = c;
    c = d;
    d = aux;
}

if (c > e)
{
    int aux = c;
    c = e;
    e = aux;
}

if (d > e)
{
    int aux = d;
    d = e;
    e = aux;
}

// Console.Write("({0},{1},{2},{3},{4})", a, b, c, d, e); // afisare ---> varianta "Oros"
// Console.Write("("+ a + "," + b + "," + c + "," + d + "," + e + ")"); // afisare "Laslo"
Console.Write((c + d + e).ToString());
Console.ReadKey();
*/

