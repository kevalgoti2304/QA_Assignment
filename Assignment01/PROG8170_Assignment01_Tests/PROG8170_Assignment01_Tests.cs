using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment01;
using NUnit.Framework;

namespace PROG8170_Assignment01_Tests
{
    [TestFixture]
    public class PROG8170_Assignment01_Tests
    {
        //Test Case for  GetLength Method
        [Test]
        public void GetLength_input3_expectedLengthEquals3()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.GetLength();

            //Assert
            Assert.AreEqual(length, l);
        }

        //Test Case for  Setlength Method
        [Test]
        public void SetLength_input6_expectedLengthEquals6()
        {
            //Arrange
            int l = 6;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.GetLength();

            //Assert
            Assert.AreEqual(length, l);
        }
        
        //Test Case for  GetWidth Method
        [Test]
        public void GetWidth_input4_expectedWidthEquals4()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.GetWidth();

            //Assert
            Assert.AreEqual(width, w);
        }

        //Test Case for  SetWidth Method
        [Test]
        public void SetWidth_input8_expectedWidthEquals8()
        {
            //Arrange
            int l = 3;
            int w = 8;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.GetWidth();

            //Assert
            Assert.AreEqual(width, w);
        }

        //Test Case for GetPerimeter Method
        [Test]
        public void GetPerimeter_input3and4_expectedPerimeterEquals14()
        {
            //Arrange
            int l = 3;
            int w = 4;
            int expectedPerimeter = 14;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int perimeter = testRectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(perimeter, expectedPerimeter);
        }

        //Test Case for GetArea Method
        [Test]
        public void GetArea_input3and4_expectedAreaEquals12()
        {
            //Arrange
            int l = 3;
            int w = 4;
            int expectedArea = 12;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int area = testRectangle.GetArea();

            //Assert
            Assert.AreEqual(area, expectedArea);
        }        
    }
}
