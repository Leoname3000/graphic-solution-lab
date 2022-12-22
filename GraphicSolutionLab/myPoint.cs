
namespace GraphicSolutionLab
{
    class myPoint
    {
        public myPoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        double x;
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        double y;
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
