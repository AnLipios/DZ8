//Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.

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

void GetSort(int[,]mass)
{    
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(1)-1; k++)
            {
                if (mass[i,k] < mass[i,k+1])
                {
                    int temp = mass[i,k+1];
                    mass[i,k+1] = mass[i,k];
                    mass[i,k] = temp;
                }
            }
        }
    }
}

int[,] mass=new int[5,5];
FillArray(mass);
PrintArray (mass);
WriteLine("----------");
GetSort (mass);
PrintArray (mass);