namespace _01.Shapes
    {
    public class Square : Shape
        {
        public Square(double width)
            : base(width, width)
            {
            this.Width = width;
            this.Height = width;
            }

        public override double CalculateSurface()
            {
            return this.Width * this.Height;
            }
        }
    }
