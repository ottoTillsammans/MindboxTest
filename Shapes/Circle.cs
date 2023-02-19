namespace Shapes
{
    /// <summary>
    /// Class to represent circle.
    /// </summary>
    public class Circle : Shape
    {
        #region Fields and properties

        private readonly double radius;

        #endregion

        #region Shape

        public override double GetSquare() => radius * radius * Math.PI;

        #endregion

        #region Constructors

        public Circle(double radius)
        {
            this.radius = radius;
        }

        #endregion
    }
}
