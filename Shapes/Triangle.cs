namespace Shapes
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

        private const string errorMessage = "Triangle cannot have side equal to or less than zero";

        #endregion

        #region Methods

        /// <summary>
        /// Check if the triangle is right angled.
        /// </summary>
        /// <returns>True if is right angled, otherwise false.</returns>
        public bool IsRightAngled()
        {
            if (sideA * sideA == sideB * sideB + sideC * sideC ||
                sideB * sideB == sideA * sideA + sideC * sideC ||
                sideC * sideC == sideA * sideA + sideB * sideB)
                return true;
            return false;
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
            if (sideA > 0 && sideB > 0 && sideC > 0)
            {
                this.sideA = sideA;
                this.sideB = sideB;
                this.sideC = sideC;
            }
            else
                throw new ArgumentException(errorMessage);
        }

        #endregion
    }
}
