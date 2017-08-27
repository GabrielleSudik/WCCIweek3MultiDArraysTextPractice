using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCCIweek3MultiDArraysTextPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //multidimensional arrays
            //proper syntaxes:

            int[,] twoDimensionalArray; //2D has one ,
            int[,,] threeDimensionalArray; //3D has two ,,
                                           //3D+ rarely used

            int[,] intMatrix = new int[3, 4]; //2D. 3 elements, length of 4.
            float[,] floatMatrix = new float[8, 2]; //8 elems, 2 length
            string[,,] stringCube = new string[5, 5, 5]; //3D. 

            int[,] matrix =
            {
                {1, 2, 3, 4 }, //values in row zero
                {5, 6, 7, 8 }, //values in row one
            };

            //"row" and "col" are what they sound like.
            //GetLength(0) is number of rows
            //GetLength(1) is number of columns

            //how to print the matrix:

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine(matrix[row, col]);
                }
                Console.WriteLine(); //this just adds a line between two groups of numbers
            }

            //reading a matrix from the console:

            Console.WriteLine("Enter number of rows:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of columns:");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix2 = new int[rows, cols];

            Console.WriteLine("Enter the cells of the matrix:");

            for (int row = 0; row < matrix2.GetLength(0); row++)
            {
                for (int col = 0; col < matrix2.GetLength(1); col++)
                {
                    Console.WriteLine("matrix[{0},{1}] = ", row, col);
                    matrix2[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < matrix2.GetLength(0); row++)
            {
                for (int col = 0; col < matrix2.GetLength(1); col++)
                {
                    Console.WriteLine(" " + matrix2[row, col]);
                }
                Console.WriteLine();
                //mine didn't print like the text, but it printed.
            }

            //arrays of arrays, aka jagged arrays
            //example: Pascal's Triangle

            //syntax:
            //(yeah, I don't get it lol)

            int[][] jaggedArray;
            jaggedArray = new int[2][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];

            //to initialize:

            int[][] myJaggedArray =
            {
                new int[] {5, 7, 9},
                new int[] {10, 20, 30},
                new int[] {2, 4} //note no last comma here
            }; //but semi-c here

            //let's practice:

            const int HEIGHT = 12;

            //allocates an array in triangle form:

            long[][] triangle = new long[HEIGHT + 1][];

            for (int row = 0; row < HEIGHT; row++)
            {
                triangle[row] = new long[row + 1];
            }

            //calculate pascal's triangle:

            triangle[0][0] = 1; //this is the value of the first element

            for (int row = 0; row < HEIGHT -1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            //print it:

            for (int row = 0; row < HEIGHT; row++)
            {
                Console.WriteLine("".PadLeft((HEIGHT - row) * 2));
                for (int col = 0; col <= row; col++)
                {
                    Console.WriteLine("{0,3} ", triangle[row][col]);
                }

                Console.WriteLine();
                //again, didn't print like the text, but printed.
                //does this version of VS work different than textbook?
            }

            Console.ReadLine();
        }
    }
}
