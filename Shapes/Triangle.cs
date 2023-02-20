﻿namespace Shapes
{
    /// <summary>
    /// Class to represent triangle.
    /// </summary>
    public class Triangle : Shape
    {
        #region Fields and properties

        private readonly double sideA;

        private readonly double sideB;

        private readonly double sideC;

        #endregion

        #region Methods

        /// <summary>
        /// Check if the triangle is right angled.
        /// </summary>
        /// <returns>True if is right angled, otherwise false.</returns>
        public bool IsRightAngled()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Shape

        public override double GetSquare()
        {
            var halfperimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(halfperimeter * (halfperimeter - sideA) * (halfperimeter - sideB) * (halfperimeter - sideC));
        }

        #endregion

        #region Constructors

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        #endregion
    }
}
