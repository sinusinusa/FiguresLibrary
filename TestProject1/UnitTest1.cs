using Squares.Infrastructure;
using Squares.Models;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestFailture()
        {
            List<Double> parameters = new List<Double>() { 5 };
            string name = "Triangle";
            Assert.That(FigureCalculator.GetSquare(name, parameters)
                , Is.EqualTo(-1).Within(0.0001));
        }

        [Test]
        public void TestCalculateCircleArea()
        {
            List<Double> parameters = new List<Double>() { 5 };
            string name = "Circle";
            Assert.That(FigureCalculator.GetSquare(name, parameters)
                , Is.EqualTo(78.53981633974483).Within(0.0001));
        }
        [Test]
        public void TestCalculateTriangleArea()
        {
            List<Double> parameters = new List<Double>() { 3, 4, 5 };
            string name = "Triangle";
            Assert.That(FigureCalculator.GetSquare(name, parameters), Is.EqualTo(6).Within(0.0001));
        }
        [Test]
        public void TestCheckRightTriangleArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.IsRightTriangle(), Is.True);
        }
    }
}