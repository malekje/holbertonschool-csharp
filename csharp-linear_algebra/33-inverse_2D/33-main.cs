using System;
using System.Numerics;
using System.Windows;

class Program
{
    public static void Main()
    {
        Console.WriteLine("\n==================== TEST 1 ======================\n");
        double[,] matrix1 = {
            {1, 2},
            {3, 4}
        };
        Console.WriteLine($"Matrix1:\nRows = {matrix1.GetLength(0)}\nColumns = {matrix1.GetLength(1)}");
        printMatrix(MatrixMath.Inverse2D(matrix1));
        
        Console.WriteLine("\n==================== TEST 2 ======================\n");
        double[,] matrix3 = new double[,] {
            {1, 2},
            {3, 4},
            {5, 6}
        };
        Console.WriteLine($"Matrix3:\nRows = {matrix3.GetLength(0)}\nColumns = {matrix3.GetLength(1)}");
        printMatrix(MatrixMath.Inverse2D(matrix3));
    }
    // Method to print Matrix
    public static void printMatrix(double [,] matrix)
    {
        if (matrix.Length <= 1)
        {
            Console.WriteLine("The matrix is not a 2D matrix or non-invertible");
            Console.WriteLine($"{matrix[0,0]}");
        } else
        {
                    
            Console.WriteLine(
                $"Dimension (Rank) = {matrix.Rank}\nDimension Row = {matrix.GetLength(0)}\nDimension Column = {matrix.GetLength(1)}\nAll Elements = {matrix.Length}"
                );
            
            Console.WriteLine($"Multiply resulting matrix is: \n");
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                Console.Write("| ");
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine("|");
            }
        }
    }
}
