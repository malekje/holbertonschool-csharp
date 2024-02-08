using System;
using System.Collections;
    
/// <summary>
/// This Class have a method to calculate the inverse of a 2D matrix.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// This Method calculates the inverse of a 2D matrix and returns the resulting matrix.
    /// </summary>
    /// <returns>
    /// The resulting matrix. If the matrix is not a 2D matrix or non-invertible,
    /// return [-1].
    /// </returns>
    /// <param name="matrix">: Matrix to be inverted. </param>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2 &&
            (matrix[0, 0]*matrix[1, 1] - matrix[0, 1]*matrix[1, 0]) != 0)
        {
            double[,] inverseMatrix = new double[,] {
                {matrix[1, 1], (-1)*matrix[0, 1]},
                {(-1)*matrix[1, 0], matrix[0, 0]}
            };
            
            // Determinant of Inverse Matrix => det(A^(-1)) = 1/det(A) 
            double detInverMatrix = 1/(matrix[0, 0]*matrix[1, 1] - matrix[0, 1]*matrix[1, 0]);

            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    inverseMatrix[row, col] = Math.Round(detInverMatrix*inverseMatrix[row, col], 2);
                }
            }
            return inverseMatrix;
        }
        return new double[,] {{-1}};
    }
}
