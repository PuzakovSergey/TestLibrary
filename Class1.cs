using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NUnit.Framework;

namespace TestLibrary
{
    /// <summary>
    /// Интерфейс для вычисления площади фигур
    /// </summary>
    public interface IArea
    {
        double CalculateArea();
    }

    /// <summary>
    /// Каласс окружность
    /// </summary>
    public class Circle : IArea
    {
        public double Radius { get; }

        /// <summary>
        /// конструктор примающий значение радиуса
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Метод вычислени площади окружности
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    /// <summary>
    /// Класс треугольник
    /// </summary>
    public class Triangle : IArea
    {
        /// <summary>
        /// конструктор принимающий значения длинны сторон треугольника
        /// </summary>
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Метод вычисления площади треугольника
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        /// <summary>
        /// Метод определяющий что треугольник прямоугольный (сам решить не смог, подсмотрел)
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
        }
    }

    /// <summary>
    /// Класс расчета площади любой фигуры
    /// </summary>
    public class AreaCalculator
    {
        /// <summary>
        /// Метод вычисляет площадь фигуры принимает объект который реализует интерфейс IArea
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public double FigureArea(IArea area)
        {
            return area.CalculateArea();
        }
    }

    /// <summary>
    /// Класс вычисления площади новой фигуры
    /// </summary>
    public class NewFigure : IArea
    {
        double NewParametr { get; }

        /// <summary>
        /// Метод вычисления новой фигуры, нужна формула вычисления и необходимые параметры
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            return NewParametr;
        }
    }


   

//[TestFixture]
//    public class ShapeTests
//    {
//        [Test]
//        public void CircleAreaTest()
//        {
//            var circle = new Circle(10);
            
//            Assert.AreEqual(Math.PI * 100, circle.CalculateArea(), 1e-10);
//        }

//        [Test]
//        public void TriangleAreaTest()
//        {
//            var triangle = new Triangle(3, 4, 5);
//            Assert.AreEqual(6, triangle.CalculateArea(), 1e-10);
//        }

//        [Test]
//        public void RightTriangleTest()
//        {
//            var triangle = new Triangle(3, 4, 5);
//            Assert.IsTrue(triangle.IsRightTriangle());
//        }

//        [Test]
//        public void NonRightTriangleTest()
//        {
//            var triangle = new Triangle(3, 4, 6);
//            Assert.IsFalse(triangle.IsRightTriangle());
//        }
//    }

}
