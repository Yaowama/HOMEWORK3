using System;
class Program{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter an operator (+ or -) or any other character to exit: ");
            string operation = Console.ReadLine();

            if (operation != "+" && operation != "-")             {
                Console.WriteLine("Invalid input. Exiting program.");
                break;
            }
                Console.WriteLine("Enter the size of the matrix: ");
                int s = int.Parse(Console.ReadLine());

                Console.Write("Enter a real number: ");
                int n = int.Parse(Console.ReadLine());

                float[,] matrix1 = new float[s, n];
                float[,] matrix2 = new float[s, n];
                float[,] resultMatrix = new float[s, n];

                Console.WriteLine("Enter the values matrix 1: ");
                ReadMatrixValues(matrix1);

                Console.WriteLine("Enter the values for matrix 2:");
                ReadMatrixValues(matrix2); 

                if (operation == "+")
                {
                    resultMatrix = AddMatrices(matrix1, matrix2);
                } 
                else if (operation == "-")
                {
                    resultMatrix = SubtractMatrices(matrix1, matrix2);
                }

                Console.WriteLine("Result matrix:");
                PrintMatrix(resultMatrix);
        }
    }
                 static void ReadMatrixValues(float[,] matrix)
                {
                    int rows = matrix.GetLength(0);
                    int size = matrix.GetLength(1);

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            Console.WriteLine("Enter value for position [" + i + "," + j + "]:");
                            matrix[i, j] = Convert.ToSingle(Console.ReadLine());
                        }
                    }
                }
                static float[,] AddMatrices(float[,] matrix1, float[,] matrix2)
                {
                int rows = matrix1.GetLength(0);
                int size = matrix1.GetLength(1);
                float[,] resultMatrix = new float[rows, size];

                for (int i = 0; i < rows; i++){
                     for (int j = 0; j < size; j++){
                         resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                     }
                }
                return resultMatrix;
            }
            static float[,] SubtractMatrices(float[,] matrix1, float[,] matrix2)
            {
                int rows = matrix1.GetLength(0);
                int cols = matrix1.GetLength(1);
                float[,] resultMatrix = new float[rows, cols];

                for (int i = 0; i < rows; i++){
                    for (int j = 0; j < cols; j++){
                resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return resultMatrix;
    }
            static void PrintMatrix(float[,] matrix)
    {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++){
                for (int j = 0; j < cols; j++){
                
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}