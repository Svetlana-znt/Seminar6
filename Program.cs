//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)


//Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.
/*
bool Triangle(int num1, int num2, int num3)
{
     if(num1 + num2 > num3 && num2 + num3 > num1 && num1 + num3> num2) return true;
     return false;
}
Console.WriteLine("Input num1 = ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num2 = ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num3 = ");
int num3 = Convert.ToInt32(Console.ReadLine());
bool triangle = Triangle(num1, num2, num3);
Console.WriteLine(triangle);*/


//----------------------------------------------------------------------------
//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
void ShowArray(int[] newarray)
{
    for(int i = 0; i<newarray.Length; i++)
        Console.Write(newarray[i] + "   ");
        Console.WriteLine();
}
int[] NewArray(int size, int a, int b)
{
    int[] array = new int[size];
    array[0] = a;
    array[1] = b;

    for(int  i = 2; i<size; i++)
        array[i] =  array[i-2] + array[i-1];
    return array;
}
ShowArray(NewArray(10, 0, 1));*/

//----------------------------------------------------------------------------------------------
//Напишите программу, которая будет создавать копию заданного массива с помощью 
//поэлементного копирования.
int[] RandomCollection(int size, int minvalue, int maxvalue)
{
    int[] randomarray = new int[size];
    for(int index = 0; index<size; index++)
        randomarray[index] = new Random().Next(minvalue, maxvalue);
    return randomarray;
}

int[] CopyArray(int[] array)
{
    int[] copiedarray = new int[array.Length];
    for(int i = 0; i<array.Length; i++)
       copiedarray[i] = -array[i];
    return copiedarray;
}

void PrintCollection(int[] randomcoll)
{
    for (int i = 0; i<randomcoll.Length; i++)
    Console.Write(randomcoll[i] + "  ");
    Console.WriteLine(); 
}

Console.WriteLine("Input size of array = ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value of array's element = ");
int minvalue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max valueof array's element = ");
int maxvalue = Convert.ToInt32(Console.ReadLine());
int[] randomarray = RandomCollection(size, minvalue, maxvalue);
PrintCollection(randomarray);
int[] copiedarray = CopyArray(randomarray);
PrintCollection(copiedarray);