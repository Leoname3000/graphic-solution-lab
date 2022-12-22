
namespace GraphicSolutionLab
{
    class LinearFunction : IFunction
    {
        public LinearFunction(double a, double b)
        {
            this.a = a;
            this.b = b;
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

        public double Calc(double realX)
        {
            return a * realX + b;
        }
    }
}
