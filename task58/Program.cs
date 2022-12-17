
//Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

using System;
using static System.Console;

Clear();

int [,] massA = new int [3,3];
CreateArray (massA);
WriteLine($"\nПервая матрица");
WriteArray (massA);

int [,] massB = new int [3,3];
CreateArray (massB);
WriteLine($"\nВторая матрица");
WriteArray (massB);

int [,] resultMatrix = new int[3,3];

MultiMatrix(massA, massB, resultMatrix);
WriteLine($"\nПроизведение первой и второй матриц");
WriteArray(resultMatrix);

void MultiMatrix(int[,] massA, int[,] massB, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int mult = 0;
            for (int k=0; k < massA.GetLength(1); k++)
            { 
                mult += massA[i,k] * massB[k,j];
            }
            resultMatrix[i,j] = mult;
        }
        
    }
}


void WriteArray(int[,] mass)
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

void CreateArray(int[,]mass)
{
    for (int i=0; i<mass.GetLength(0); i++)
    {
        for (int j=0; j<mass.GetLength(1); j++)
        {
            mass[i,j]=new Random().Next(1,10);
        }
    }
  
}

