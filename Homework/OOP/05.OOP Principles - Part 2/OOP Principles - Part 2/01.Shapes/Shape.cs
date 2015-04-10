namespace _01.Shapes
    {
    public abstract class Shape
        {
        protected Shape(double height, double width)
            {
            this.Height = height;
            this.Width = width;
            }

        public double Height { get; set; }

        public double Width { get; set; }

        public abstract double CalculateSurface();
        }
    }
