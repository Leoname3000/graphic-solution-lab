
namespace GraphicSolutionLab
{
    class QuadraticFunction : IFunction
    {
        public QuadraticFunction(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        double a;
        public double A 
        {
            get { return a; }
            set { a = value; } 
        }

        double b;
        public double B
        {
            get { return b; }
            set { b = value; }
        }

        double c;
        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public double Discriminant()
        {
            return b * b - 4 * a * c;
        }

        public double Calc(double realX)
        {
            return a * realX * realX + b * realX + c;
        }
    }
}
