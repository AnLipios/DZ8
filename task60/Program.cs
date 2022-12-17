//Сформируйте трёхмерный массив из неповторяющихся 
//двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.

using System;
using static System.Console;

Clear();
int[,,] mass = new int [2,2,2];
CreateArray (mass);
FillArray(mass);
PrintArray (mass);


void PrintArray (int[,,] mass)
{
    for (int i = 0; i < mass.GetLength (0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k< mass.GetLength(2); k++)
            {
                Write($"{mass[i,j,k]}=({i},{j},{k}); ");
            }
            WriteLine();
        }
        WriteLine();
    }
}

void FillArray(int[,,]mass)
{
    for (int i=0; i<mass.GetLength(0); i++)
    {
        for (int j=0; j<mass.GetLength(1); j++)
        {
            for (int k=0; k < mass.GetLength(2); k++)
            {
                mass[i,j,k]=new Random().Next(1,100);
            }
        }
    }
}
void CreateArray(int[,,]mass)
{
    int[] temp = new int[mass.GetLength(0) * mass.GetLength(1) * mass.GetLength(2)];
    int number;
    for (int i=0; i<temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(1, 100);
        number = temp[i];
        if (i>=1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i]= new Random().Next(1, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }

    }
    int count = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k =0; k < mass.GetLength(2); k++)
            {
                mass[i,j,k] = temp[count];
                count++;
            }
        }
    }
}