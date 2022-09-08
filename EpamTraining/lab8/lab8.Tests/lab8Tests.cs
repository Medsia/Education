using System;
using Xunit;
using lab8;

namespace lab8.Tests
{
    public class lab8Tests
    {
        [Fact]
        public static void FillMatrixRandomTest()
        {
            // arrange
            Random random = new Random();
            double[,] matrix1 = new double[2,2];
            double[,] matrix2 = new double[2,2];
            matrix1[0, 0] = 44;
            matrix1[0, 1] = 33;
            matrix1[1, 0] = 22;
            matrix1[1, 1] = 11;
            matrix2[0, 0] = 44;
            matrix2[0, 1] = 33;
            matrix2[1, 0] = 22;
            matrix2[1, 1] = 11;        
            // act
            Program.FillMatrixRandom(matrix1, random);
            //assert
            Assert.NotEqual(matrix2, matrix1);
        }

        [Fact]
        public static void MatrixSummTest()
        {
            // arrange
            Random random = new Random();
            double[,] matrix1 = new double[2, 2];
            double[,] matrix2 = new double[2, 2];
            double[,] matrixExp = new double[2, 2];
            matrix1[0, 0] = 44;
            matrix1[0, 1] = 33;
            matrix1[1, 0] = 22;
            matrix1[1, 1] = 11;
            matrix2[0, 0] = 44;
            matrix2[0, 1] = 33;
            matrix2[1, 0] = 22;
            matrix2[1, 1] = 11;
            matrixExp[0, 0] = 88;
            matrixExp[0, 1] = 66;
            matrixExp[1, 0] = 44;
            matrixExp[1, 1] = 22;
            // act
            double[,] matrix3 = Program.MatrixSumm (matrix1, matrix2);
            //assert
            Assert.Equal(matrixExp, matrix3);
        }

        [Fact]
        public static void MatrixDiffTest()
        {
            // arrange
            Random random = new Random();
            double[,] matrix1 = new double[2, 2];
            double[,] matrix2 = new double[2, 2];
            double[,] matrixExp = new double[2, 2];
            matrix1[0, 0] = 44;
            matrix1[0, 1] = 33;
            matrix1[1, 0] = 22;
            matrix1[1, 1] = 11;
            matrix2[0, 0] = 44;
            matrix2[0, 1] = 33;
            matrix2[1, 0] = 22;
            matrix2[1, 1] = 10;
            matrixExp[0, 0] = 0;
            matrixExp[0, 1] = 0;
            matrixExp[1, 0] = 0;
            matrixExp[1, 1] = 1;
            // act
            double[,] matrix3 = Program.MatrixDiff(matrix1, matrix2);
            //assert
            Assert.Equal(matrixExp, matrix3);
        }

        [Fact]
        static void MatrixMultTest()
            {
                // arrange

                double[,] matrix1 = new double[2, 2];
                double[,] matrixExp = new double[2, 2];
                matrix1[0, 0] = 44;
                matrix1[0, 1] = 33;
                matrix1[1, 0] = 22;
                matrix1[1, 1] = 11;
                matrixExp[0, 0] = 88;
                matrixExp[0, 1] = 66;
                matrixExp[1, 0] = 44;
                matrixExp[1, 1] = 22;
                int sc = 2;
                // act
                double[,] matrix3 = Program.MatrixMult(matrix1, sc);
                //assert
               
                Assert.Equal(matrixExp, matrix3);
             
            }

        [Fact]
        static void MxMMultTest()
        {
            // arrange

            double[,] matrix1 = new double[2, 2];
            double[,] matrix2 = new double[2, 2];
            double[,] matrixExp = new double[2, 2];
            matrix1[0, 0] = 4;
            matrix1[0, 1] = 3;
            matrix1[1, 0] = 2;
            matrix1[1, 1] = 1;
            matrix2[0, 0] = 0;
            matrix2[0, 1] = 3;
            matrix2[1, 0] = 2;
            matrix2[1, 1] = 1;
            matrixExp[0, 0] = 6;
            matrixExp[0, 1] = 15;
            matrixExp[1, 0] = 2;
            matrixExp[1, 1] = 7;
            // act
            double[,] matrix3 = Program.MxMMult(matrix1, matrix2);
            //assert           
            Assert.Equal(matrixExp, matrix3);

        }
    }
}