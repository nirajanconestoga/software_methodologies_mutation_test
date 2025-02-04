//Lab3: Mutation Test
//Name: Nirajan Kumar Bista

using NUnit.Framework;
using NUnit.Framework.Legacy;
using NMutationLab1;

namespace TriangleTest
{
    [TestFixture]
    public class TestTriangles
    {
        [Test]
        public void TestValidIsoscelesTriangle()
        {
            // Arrange
            int firstSide = 40;
            int secondSide = 60;
            int thirdSide = 60;

            string expected = "The triangle is an isosceles triangle.";

            // Act
            string actual = Triangle.IsoscelesTriangle(firstSide, secondSide, thirdSide);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

    }
}
