using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicSolutionLab
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            step = 1.0;
            zoom = DEFAULT_ZOOM;
            marginX = panel.Width / 2;
            marginY = panel.Height * 2 / 3;

            quadratic = new QuadraticFunction(1, 2, 3);
            linear = new LinearFunction(2, 4);
            restoreFieldValues();
            solveButton.PerformClick();

            axisPenColor = Color.Black;
            linePenColor = Color.LightGray;
            plotPenColor = Color.Black;

            isMouseHold = false;

            panel.Paint += new PaintEventHandler(panel_Marking);
            panel.Paint += new PaintEventHandler(panel_Paint);

            panel.MouseDown += panel_MouseDown; 
            panel.MouseUp += panel_MouseUp; 
            panel.MouseMove += panel_MouseMove;
            panel.MouseWheel += panel_MouseWheel;
        }

        const int ZOOM_STEP = 5;
        const int MAX_ZOOM = ZOOM_STEP * 24;
        const int DEFAULT_ZOOM = ZOOM_STEP * 8;
        const int MIN_ZOOM = ZOOM_STEP * 2;

        double step;
        int zoom;
        int marginX;
        int marginY;

        Color axisPenColor;
        Color linePenColor;
        Color plotPenColor;


        // ----- Решение системы и обработка соответствующей кнопки ----- //

        // Для хранения решений используется класс myPoint с действительными координатами,
        // так как во встроенном классе Point координаты целочисленные.

        List<myPoint> solve(QuadraticFunction quadratic, LinearFunction linear)
        {
            List<myPoint> points = new List<myPoint>();
            QuadraticFunction equation = new QuadraticFunction(quadratic.A, quadratic.B - linear.A, quadratic.C - linear.B);

            double discriminant = equation.Discriminant();
            if (discriminant == 0)
            {
                double x = (-equation.B + Math.Sqrt(discriminant)) / (2 * equation.A);
                myPoint p = new myPoint(Math.Round(x, 2), Math.Round(linear.Calc(x), 2)) ;
                points.Add(p);
            }
            else if (discriminant > 0)
            {
                double x1 = (-equation.B - Math.Sqrt(discriminant)) / (2 * equation.A);
                myPoint p1 = new myPoint(Math.Round(x1, 2), Math.Round(linear.Calc(x1), 2));
                points.Add(p1);

                double x2 = (-equation.B + Math.Sqrt(discriminant)) / (2 * equation.A);
                myPoint p2 = new myPoint(Math.Round(x2, 2), Math.Round(linear.Calc(x2), 2));
                points.Add(p2);
            }

            return points;
        }

        void restoreFieldValues()
        {
            firstSquareField.Text = Convert.ToString(quadratic.A);
            firstLinearField.Text = Convert.ToString(quadratic.B);
            firstConstField.Text = Convert.ToString(quadratic.C);
            secondLinearField.Text = Convert.ToString(linear.A);
            secondConstField.Text = Convert.ToString(linear.B);
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(firstSquareField.Text, out double firstSquare) ||
                !double.TryParse(firstLinearField.Text, out double firstLinear) ||
                !double.TryParse(firstConstField.Text, out double firstConst) ||
                !double.TryParse(secondLinearField.Text, out double secondLinear) ||
                !double.TryParse(secondConstField.Text, out double secondConst))
            {
                MessageBox.Show("Коэффициенты должны быть действительными числами с дробной частью, отделённой запятой, или целыми числами.");
                restoreFieldValues();
            }
            else if (firstSquare == 0)
            {
                MessageBox.Show("Коэффициент перед старшей степенью квадратного уравнения не должен быть равен нулю.");
                restoreFieldValues();
            }
            else if (secondLinear == 0 && secondConst == 0)
            {
                MessageBox.Show("Коэффициенты линейного уравнения не должны быть равны нулю одновременно.");
                restoreFieldValues();
            }
            else
            {
                quadratic.A = firstSquare;
                quadratic.B = firstLinear;
                quadratic.C = firstConst;

                linear.A = secondLinear;
                linear.B = secondConst;

                List<myPoint> solutions = solve(quadratic, linear);

                if (solutions.Count == 1)
                {
                    noSolutionLabel.Visible = false;
                    firstSolutionGroupBox.Visible = true;
                    secondSolutionGroupBox.Visible = false;

                    firstSolutionLabelX.Text = Convert.ToString(solutions[0].X);
                    firstSolutionLabelY.Text = Convert.ToString(solutions[0].Y);
                }
                else if (solutions.Count == 2)
                {
                    noSolutionLabel.Visible = false;
                    firstSolutionGroupBox.Visible = true;
                    secondSolutionGroupBox.Visible = true;

                    firstSolutionLabelX.Text = Convert.ToString(solutions[0].X);
                    firstSolutionLabelY.Text = Convert.ToString(solutions[0].Y);

                    secondSolutionLabelX.Text = Convert.ToString(solutions[1].X);
                    secondSolutionLabelY.Text = Convert.ToString(solutions[1].Y);
                }
                else
                {
                    noSolutionLabel.Visible = true;
                    firstSolutionGroupBox.Visible = false;
                    secondSolutionGroupBox.Visible = false;
                }
                panel.Refresh();
            }
        }


        // ----- Отрисовка координатной сетки ----- //
        private void panel_Marking(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen axisPen = new Pen(axisPenColor);
            Pen linePen = new Pen(linePenColor);

            // Upper horizontal lines
            for (double i = step; (int)Math.Round(marginY - i * zoom) >= 0; i += step)
            {
                Point pHorLeft = new Point(0, (int)Math.Round(marginY - i * zoom));
                Point pHorRight = new Point(panel.Width, (int)Math.Round(marginY - i * zoom));

                g.DrawLine(linePen, pHorLeft, pHorRight);
            }

            // Lower horizontal lines
            for (double i = step; (int)Math.Round(marginY + i * zoom) <= panel.Height; i += step)
            {
                Point pHorLeft = new Point(0, (int)Math.Round(marginY + i * zoom));
                Point pHorRight = new Point(panel.Width, (int)Math.Round(marginY + i * zoom));

                g.DrawLine(linePen, pHorLeft, pHorRight);
            }

            // Left vertical lines
            for (double i = step; (int)Math.Round(marginX - i * zoom) >= 0; i += step)
            {
                Point pVerTop = new Point((int)Math.Round(marginX - i * zoom), 0);
                Point pVerBottom = new Point((int)Math.Round(marginX - i * zoom), panel.Height);

                g.DrawLine(linePen, pVerTop, pVerBottom);
            }

            // Right vertical lines
            for (double i = step; (int)Math.Round(marginX + i * zoom) <= panel.Width; i += step)
            {
                Point pVerTop = new Point((int)Math.Round(marginX + i * zoom), 0);
                Point pVerBottom = new Point((int)Math.Round(marginX + i * zoom), panel.Height);

                g.DrawLine(linePen, pVerTop, pVerBottom);
            }

            // Main axis
            Point axisHorLeft = new Point(0, marginY);
            Point axisHorRight = new Point(panel.Width, marginY);
            g.DrawLine(axisPen, axisHorLeft, axisHorRight);

            Point axisVerTop = new Point(marginX, 0);
            Point axisVerBottom = new Point(marginX, panel.Height);
            g.DrawLine(axisPen, axisVerTop, axisVerBottom);
        }


        // ----- Обсчёт значений функции, попадающих на график и отрисовка графика ----- //

        // Происходит следующим образом: Пробегаются все целочисленные значения по горизонтали, попадающие на panel (plotX),
        // для каждого из них происходит преобразование: plotX -> realX -> realY -> plotY, и в множество точек добавляется точка (plotX, plotY),
        // с учётом сдвигов относительно начала отсчёта marginX и marginY.
        // По множеству точек строится кривая (процесс происходит дважды: для QuadraticFunction и для LinearFunction).
        // Этот процесс используется потому, что на panel координаты задаются целочисленными значениями (plotX, plotY),
        // а для расчётов используются действительные (realX, realY).
        
        QuadraticFunction quadratic;
        LinearFunction linear;

        double realX(int pX)
        {
            return (double)pX / zoom;
        }

        double realY(IFunction function, int pX)
        {
            double rX = realX(pX);
            return function.Calc(rX);
        }

        int plotY(IFunction function, int pX)
        {
            int y = (int)Math.Round(-realY(function, pX) * zoom);
            return y;
        }

        bool onScreen(IFunction function, int pX)
        {
            return plotY(function, pX) >= -marginY && 
                   plotY(function, pX) <= panel.Height - marginY && 
                   pX + marginX > 0 && 
                   pX + marginX < panel.Width;
        }

        void drawFunctionPointByPoint(Pen pen, Graphics g, IFunction function)
        {
            List<Point> pointList = new List<Point>();

            for (int plotX = -marginX; plotX <= panel.Width - marginX; plotX++)
            {
                Point pointToAdd = new Point(plotX + marginX, plotY(function, plotX) + marginY);

                if (!onScreen(function, plotX) && onScreen(function, plotX + 1))
                    pointList.Add(pointToAdd);
                else if (onScreen(function, plotX))
                    pointList.Add(pointToAdd);
                else if (!onScreen(function, plotX) && onScreen(function, plotX - 1))
                {
                    pointList.Add(pointToAdd);

                    if (pointList.Count >= 2)
                    {
                        Point[] pointArray = pointList.ToArray();
                        g.DrawCurve(pen, pointArray);

                        pointList.Clear();
                    }
                }
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(plotPenColor, 1.0f);
            Graphics g = e.Graphics;

            drawFunctionPointByPoint(pen, g, quadratic);
            drawFunctionPointByPoint(pen, g, linear);
        }


        // ----- Масштабирование и передвижение графика ----- //
        int deltaX;
        int deltaY;

        bool isMouseHold;

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            deltaX = Cursor.Position.X - marginX;
            deltaY = Cursor.Position.Y - marginY;

            isMouseHold = true;
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseHold = false;
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseHold)
            {
                marginX = Cursor.Position.X - deltaX;
                marginY = Cursor.Position.Y - deltaY;

                panel.Refresh();
            }
        }

        private void panel_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && zoom < MAX_ZOOM)
            {
                zoom += ZOOM_STEP;
                panel.Refresh();
            }
            else if (e.Delta < 0 && zoom > MIN_ZOOM)
            {
                zoom -= ZOOM_STEP;
                panel.Refresh();
            }
        }
    }
}
