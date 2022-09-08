using System;
using Xunit;




namespace Task2.Tests
{
    public class Task2Tests
    {
        [Fact]
        public void calculate_x_2_mx123_degree2_exp11()
        {
            // arrange
            double[] matrix = {1, 2, 3 };
            double value = 0;
            double valueExpected = 11;
            double x = 2;
            int Degree = 2;

            // act
            Multimember.MultiMember C = new Multimember.MultiMember(matrix, Degree);
            value = C.calculate(matrix, value, x, Degree);

            // assert
            Assert.Equal(valueExpected, value);
        }

        [Fact]
        public void YmnojenieMultMem()
        {
            // arrange                 
            double[] matrix = { 1, 1, 1 };
            double[] matrix2 = { 1, 2, 3, 2, 1 };
            Multimember.MultiMember args = new Multimember.MultiMember(matrix2);
            int Degree = 2;
            Multimember.MultiMember A = new Multimember.MultiMember(matrix, Degree);
            Multimember.MultiMember B = new Multimember.MultiMember(matrix, Degree);         

            // act
            Multimember.MultiMember E = A * B;
            
            // assert          
                Assert.Equal(args.polynomial, E.polynomial);
            
        }
        [Fact]
        public void SummMultMem()
        {
            // arrange                 
            double[] matrix = { 1, 1, 1 };
            double[] matrix2 = { 2, 2, 2 };
            int Degree = 2;
            Multimember.MultiMember A = new Multimember.MultiMember(matrix, Degree);
            Multimember.MultiMember B = new Multimember.MultiMember(matrix, Degree);
            Multimember.MultiMember summ = new Multimember.MultiMember(matrix2, Degree);
            Multimember.MultiMember E;

            // act
            E = A + B;

            // assert          
            Assert.Equal(summ.Matrix, E.Matrix);

        }
        [Fact]
        public void SubMultMem()
        {
            // arrange                 
            double[] matrix = { 1, 1, 1 };
            double[] matrix2 = { 0, 0, 0 };
            int Degree = 2;
            Multimember.MultiMember A = new Multimember.MultiMember(matrix, Degree);
            Multimember.MultiMember B = new Multimember.MultiMember(matrix, Degree);
            Multimember.MultiMember summ = new Multimember.MultiMember(matrix2, Degree);
            Multimember.MultiMember E = new Multimember.MultiMember(matrix, Degree);

            // act
            E = A - B;

            // assert          
            Assert.Equal(summ.Matrix, E.Matrix);

        }
      

    }
}
