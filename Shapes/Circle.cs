namespace Shapes
{
    /// <summary>
    /// Class to represent circle.
    /// </summary>
    public class Circle : Shape
    {
        #region Fields and properties

        private readonly double radius;
        
        private const string errorMessage = "Circle cannot have radius equal or less than zero";

        #endregion

        #region Shape

        public override double GetSquare() => radius * radius * Math.PI;

        #endregion

        #region Constructors

        public Circle(double radius)
        {
            if (radius > 0)
                this.radius = radius;
            else
                throw new ArgumentException(errorMessage);
        }

        #endregion
    }
}
