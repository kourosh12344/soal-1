using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[3, 3];

     
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                Console.Write("Enter element [{0}, {1}]: ", x, y);
                matrix[x, y] = int.Parse(Console.ReadLine());
            }
        }
        int determinant = (
            (matrix[0, 0] * matrix[1, 1] * matrix[2, 2]) +(matrix[0, 1] * matrix[1, 2] * matrix[2, 0]) +(matrix[0, 2] * matrix[1, 0] * matrix[2, 1]) -(matrix[0, 2] * matrix[1, 1] * matrix[2, 0]) -(matrix[0, 0] * matrix[1, 2] * matrix[2, 1]) -
            (matrix[0, 1] * matrix[1, 0] * matrix[2, 2])
        );
        Console.WriteLine("Determinant: {0}", determinant);
    }
}
