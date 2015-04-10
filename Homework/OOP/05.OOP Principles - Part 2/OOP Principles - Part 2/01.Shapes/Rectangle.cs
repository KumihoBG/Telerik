namespace _01.Shapes
    {
    public class Rectangle : Shape
        {
        public Rectangle(double height, double width)
            : base(height, width)
            {
            this.Height = height;
            this.Width = width;
            }

        public override double CalculateSurface()
            {
            return this.Height * this.Width;
            }
        }
    }
