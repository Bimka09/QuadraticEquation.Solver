using QuadraticEquationTesting;
using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void NoRoots()
        {
            // Arrange
            double a = 1;
            double b = 0;
            double c = 1;
            double[] expected = new double[0];

            //Act
            double[] actual = QuadraticEquation.Solve(a, b, c);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TwoRootsExists()
        {
            // Arrange
            double a = 1;
            double b = 0;
            double c = -1;
            double[] expected = new double[] { 1, -1};

            //Act
            double[] actual = QuadraticEquation.Solve(a, b, c);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OneRootExists()
        {
            // Arrange
            double a = 1;
            double b = 2;
            double c = 1;
            double[] expected = new double[] { -1 };

            //Act
            double[] actual = QuadraticEquation.Solve(a, b, c);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void A_CantBe_0_OrException()
        {
            // Arrange
            double a = 0;
            double b = 2;
            double c = 1;

            //Act Assert
            Assert.Throws<Exception>(() => QuadraticEquation.Solve(a, b, c));
        }

        [Fact]
        public void A_Epsilon()
        {
            // Arrange
            double a = double.Epsilon;
            double b = 2;
            double c = 1;

            //Act Assert
            Assert.Throws<Exception>(() => QuadraticEquation.Solve(a, b, c));
        }

        [Fact]
        public void IndexesNaN()
        {
            // Arrange
            double a = double.NaN;
            double b = double.NaN;
            double c = double.NaN;

            //Act Assert
            Assert.Throws<Exception>(() => QuadraticEquation.Solve(a, b, c));
        }
        [Fact]
        public void A_Is_NaN()
        {
            // Arrange
            double a = double.NaN;
            double b = 1;
            double c = 2;

            //Act Assert
            Assert.Throws<Exception>(() => QuadraticEquation.Solve(a, b, c));
        }
        [Fact]
        public void B_Is_NaN()
        {
            // Arrange
            double a = 1;
            double b = double.NaN;
            double c = 2;

            //Act Assert
            Assert.Throws<Exception>(() => QuadraticEquation.Solve(a, b, c));
        }
        [Fact]
        public void C_Is_NaN()
        {
            // Arrange
            double a = 2;
            double b = 3;
            double c = double.NaN;

            //Act Assert
            Assert.Throws<Exception>(() => QuadraticEquation.Solve(a, b, c));
        }

        [Fact]
        public void TestDoubleRoot()
        {
            double epsilon = 1e-15;
            double a = 1;
            double b = 2 * Math.Sqrt(epsilon);
            double c = epsilon;
            double[] expected = new double[] { -Math.Sqrt(epsilon) };
            double[] actual = QuadraticEquation.Solve(a, b, c);
            Assert.Equal(expected, actual);
        }
    }
}