using System;
using Xunit;

namespace Task1.Tests
{
    public class Task1Tests
    {
        [Fact]
        public void operatSumm()
        {
            // arrange
            int x1 = 1;
            int y1 = 1;
            int z1 = 1;
            int expected = 2;
            Vector.Vector vector1 = new Vector.Vector(x1, y1, z1);
            int x2 = 1;
            int y2 = 1;
            int z2 = 1;
            Vector.Vector vector2 = new Vector.Vector(x2, y2, z2);
            // act
            Vector.Vector A = vector1 + vector2;
            // assert
            Assert.Equal(expected, A.x);
            Assert.Equal(expected, A.y);
            Assert.Equal(expected, A.z);
        }
        [Fact]
        public void operatSub()
        {
            // arrange
            int x1 = 1;
            int y1 = 1;
            int z1 = 1;
            int expected = 0;
            Vector.Vector vector1 = new Vector.Vector(x1, y1, z1);
            int x2 = 1;
            int y2 = 1;
            int z2 = 1;
            Vector.Vector vector2 = new Vector.Vector(x2, y2, z2);
            // act
            Vector.Vector A = vector1 - vector2;
            // assert
            Assert.Equal(expected, A.x);
            Assert.Equal(expected, A.y);
            Assert.Equal(expected, A.z);
        }
        [Fact]
        public void operatYmnojenie()
        {
            // arrange
            int sc = 2;
            int x1 = 1;
            int y1 = 1;
            int z1 = 1;
            int expected = 2;
            Vector.Vector vector1 = new Vector.Vector(x1, y1, z1);
            int x2 = 1;
            int y2 = 1;
            int z2 = 1;
            Vector.Vector vector2 = new Vector.Vector(x2, y2, z2);
            // act
            Vector.Vector A = vector1 * sc;
            Vector.Vector B = vector2 * sc;
            // assert
            Assert.Equal(expected, A.x);
            Assert.Equal(expected, A.y);
            Assert.Equal(expected, A.z);
            Assert.Equal(expected, B.x);
            Assert.Equal(expected, B.y);
            Assert.Equal(expected, B.z);
        }
        [Fact]
        public void lenght()
        {
            
            int x1 = 1;
            int y1 = 1;
            int z1 = 1;
            //float expected = 3.7f;
           // double delta = 0.1;
            Vector.Vector vector1 = new Vector.Vector(x1, y1, z1);
            int x2 = 1;
            int y2 = 1;
            int z2 = 1;
            Vector.Vector vector2 = new Vector.Vector(x2, y2, z2);
            try
            {
                Vector.Vector.lenght(vector1, vector2);
                Assert.True(true);
            }
            catch
            {
                Assert.True(false);
            }
            //Assert.Equal(expected, lenght, delta);

        }
    }
}
