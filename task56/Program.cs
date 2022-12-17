
//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.

using System;
using static System.Console;

Clear();


void PrintArray(int[,] mass)
{
    for (int i=0; i<mass.GetLength(0); i++)
    {
        for (int j=0; j< mass.GetLength(1); j++)
        {
            Write($"{mass[i,j]} ");
            }
            WriteLine();
    }
    
}

void FillArray(int[,]mass)
{
    for (int i=0; i<mass.GetLength(0); i++)
    {
        for (int j=0; j<mass.GetLength(1); j++)
        {
            mass[i,j]=new Random().Next(1,10);
        }
    }
  
}

int GetSum(int[,]mass, int i)
{
    int sum = mass[i,0];
    for (int j = 1; j < mass.GetLength(1); j++)
    {
        sum += mass[i,j];
    }
    return sum;
}

int[,] mass=new int[6,5];
FillArray(mass);
PrintArray (mass);
WriteLine("----------");

int minSum = 0;
int sum = GetSum(mass, 0);
for (int i = 1; i < mass.GetLength(0); i++)
{
    int tempSum = GetSum(mass, i);
    if (sum > tempSum)
    {
        sum = tempSum;
        minSum = i;
    }
}
WriteLine($"Строка с наименьшей суммой элементов: {minSum+1}");
