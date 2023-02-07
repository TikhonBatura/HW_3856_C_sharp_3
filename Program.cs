// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Задача 19");
Console.WriteLine();
Console.WriteLine("Entre number:  ");
int num = int.Parse(Console.ReadLine());
int numCHK = 0;
int Temp = num;

Console.WriteLine();

while(Temp > 0)
        {
            numCHK = numCHK*10 + Temp % 10;
            Temp = Temp / 10;
        }

if(num < 9999 || num > 99999)
    {
        Console.WriteLine("input incorrect number.");

    }
    
else if(num == numCHK)
    {
        Console.WriteLine("Yes, input number palindrome.");
    }
else
    {
        Console.WriteLine("No, input number just a number...");
    }
Console.WriteLine();
Console.WriteLine("************");






// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Задача 21");
Console.WriteLine();
Console.WriteLine("Entre number X1 ");
double numX1 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Y1 ");
double numY1 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Z1 ");
double numZ1 = double.Parse(Console.ReadLine());


Console.WriteLine("Entre number X2 ");
double numX2 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Y2 ");
double numY2 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Z2 ");
double numZ2 = double.Parse(Console.ReadLine());

Console.WriteLine();

double numSQRT = Math.Sqrt(Math.Pow((numX1-numX2),2)+Math.Pow((numY1-numY2),2)+Math.Pow((numZ1-numZ2),2));

Console.WriteLine(numSQRT);
Console.WriteLine();
Console.WriteLine("************");

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Задача 23");
Console.WriteLine();
System.Console.WriteLine("Enter number: ");
int Number = int.Parse(Console.ReadLine());
int I = 1;

while(I  <= Number)
{
    Console.Write(Math.Pow(I, 3)+ " "); // Math.Pow(I, 3) - функция, где "I" число возводимое в степень, а число "3" - степень этого числа.
                                                       
    I+=1;

}