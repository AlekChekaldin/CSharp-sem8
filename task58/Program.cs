// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
//18 20
// 15 18

int[,] GetArray (int m, int  n,  int min, int max )
{
    int[,] result = new int [m,n] ;
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
         result [i,j]=new Random().Next(min, max+1);
    }
    return  result;
}


void PrintArray (int[,] array)
 {
 for (int i =0; i<array.GetLength(0); i++ )  
    {
         for (int j = 0; j<array.GetLength(1); j++) 
        {
            Console.Write($"{array[i,j]}\t ");
        }
        Console.WriteLine(); 
    }
 }
 
 int[,] MultiArrays(int[,] arrayA, int[,] arrayB)
 {
    int rowArrayA=arrayA.GetLength(0);
    int columnArrayA=arrayA.GetLength(1);
    int rowArrayB=arrayB.GetLength(0);
    int columnArrayB=arrayB.GetLength(1);

    int[,] multyArr= new int [rowArrayA, columnArrayB];
    
    for (int i =0; i<rowArrayA; i++ )  
    {
         for (int j = 0; j<columnArrayB; j++) 
        {
            int multySum =0;
            for (int k = 0; k<rowArrayB; k++)
            {
                multySum = multySum+arrayA[i,k]*arrayB[k,j];
            }
            multyArr[i,j]=multySum;
        }
        
    }
    return multyArr;

 }

 void Main()
 {
    Console.Clear();
    Console.Write("Введите количество строк матрицы А: ");
    int rowA = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов матрицы А: ");
    int colA = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество строк матрицы В: ");
    int rowB = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов матрицы В: ");
    int colB = int.Parse(Console.ReadLine()!);

    if (colA != rowB)
    {
        System.Console.WriteLine("Произведение матрицы невозможно");
        return;
    }
    System.Console.WriteLine ("nМатрица А:\n");
    int[,] arrayA = GetArray (rowA, colA, 1,5);
    PrintArray (arrayA);
    System.Console.WriteLine ("nМатрица B:\n");
    int[,] arrayB = GetArray (rowB, colB, 5,9);
    PrintArray (arrayB);
    System.Console.WriteLine ("nМатрица AB:\n");
    PrintArray (MultiArrays(arrayA, arrayB));

 }
Main();