using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment02;
using NUnit.Framework;

namespace PROG8170_Assignment02_Tests
{
    [TestFixture]
    public class PROG8170_Assignment02_Tests
    {
        //Test Case for  GetLength Method
        [Test]
        public void Analyze_input2and2and2_expectedResultEqualsEquilateral()
        {
            //Arrange
            int dimensionOne = 2;
            int dimensionTwo = 2;
            int dimensionThree = 2;
            string expectedResult = "Equilateral";

             TriangleSolver testRectangle = new TriangleSolver();

            //Act
            string result = testRectangle.Analyze(dimensionOne, dimensionTwo, dimensionThree);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Analyze_input3and4and5_expectedResultEqualsScalene()
        {
            //Arrange
            int dimensionOne = 3;
            int dimensionTwo = 4;
            int dimensionThree = 5;
            string expectedResult = "Scalene";

            TriangleSolver testRectangle = new TriangleSolver();

            //Act
            string result = testRectangle.Analyze(dimensionOne, dimensionTwo, dimensionThree);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Analyze_input4and5and4_expectedResultEqualsIsosceles()
        {
            //Arrange
            int dimensionOne = 4;
            int dimensionTwo = 5;
            int dimensionThree = 4;
            string expectedResult = "Isosceles";

            TriangleSolver testRectangle = new TriangleSolver();

            //Act
            string result = testRectangle.Analyze(dimensionOne, dimensionTwo, dimensionThree);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Analyze_input6and6and6_expectedResultEqualsEquilateral()
        {
            //Arrange
            int dimensionOne = 6;
            int dimensionTwo = 6;
            int dimensionThree = 6;
            string expectedResult = "Equilateral";

            TriangleSolver testRectangle = new TriangleSolver();

            //Act
            string result = testRectangle.Analyze(dimensionOne, dimensionTwo, dimensionThree);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Analyze_input1000and1001and1002_expectedResultEqualsScalene()
        {
            //Arrange
            int dimensionOne = 1000;
            int dimensionTwo = 1001;
            int dimensionThree = 1002;
            string expectedResult = "Scalene";

            TriangleSolver testRectangle = new TriangleSolver();

            //Act
            string result = testRectangle.Analyze(dimensionOne, dimensionTwo, dimensionThree);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Analyze_input22and22and23_expectedResultEqualsIsosceles()
        {
            //Arrange
            int dimensionOne = 22;
            int dimensionTwo = 22;
            int dimensionThree = 23;
            string expectedResult = "Isosceles";

            TriangleSolver testRectangle = new TriangleSolver();

            //Act
            string result = testRectangle.Analyze(dimensionOne, dimensionTwo, dimensionThree);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Analyze_input2and2and2_expectedResultEqualsScalene()
        {
            //Arrange
            int dimensionOne = 20;
            int dimensionTwo = 12;
            int dimensionThree = 23;
            string expectedResult = "Scalene";

            TriangleSolver testRectangle = new TriangleSolver();

            //Act
            string result = testRectangle.Analyze(dimensionOne, dimensionTwo, dimensionThree);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Analyze_input7and7and7_expectedResultEqualsEquilateral()
        {
            //Arrange
            int dimensionOne = 7;
            int dimensionTwo = 7;
            int dimensionThree = 7;
            string expectedResult = "Equilateral";

            TriangleSolver testRectangle = new TriangleSolver();

            //Act
            string result = testRectangle.Analyze(dimensionOne, dimensionTwo, dimensionThree);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

    }
}
