using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using System.Threading;

namespace lab_1
{
    public class Triangle
    {
        private Point2D p1, p2, p3;

        public static Triangle DrawTriangle()
        {
            Triangle T = new Triangle();
            T.p1 = Generation.DrawPoint2D();
            Thread.Sleep(20);
            T.p2 = Generation.DrawPoint2D();
            Thread.Sleep(20);
            T.p3 = Generation.DrawPoint2D();

            return T;
        }

        public Point2D getP1()
        {
            return p1;
        }

        public Point2D getP2()
        {
            return p2;
        }

        public Point2D getP3()
        {
            return p3;
        }


        public void shiftX(double value)
        {
            p1.shiftX(value);
            p2.shiftX(value);
            p3.shiftX(value);

            if ((p1.getX() < 0 || p1.getX() > 546) || (p2.getX() < 0 || p2.getX() > 546) || (p3.getX() < 0 || p3.getX() > 546))
            {
                p1.shiftX(-value);
                p2.shiftX(-value);
                p3.shiftX(-value);
            }
        }

        public void shiftY(double value)
        {
            p1.shiftY(value);
            p2.shiftY(value);
            p3.shiftY(value);

            if ((p1.getX() < 0 || p1.getX() > 261) || (p2.getX() < 0 || p2.getX() > 261) || (p3.getX() < 0 || p3.getX() > 261))
            {
                p1.shiftX(-value);
                p2.shiftX(-value);
                p3.shiftX(-value);
            }
        }

        public double getPerimeter()
        {
            double a = p1.getDistance(p2);
            double b = p2.getDistance(p3);
            double c = p3.getDistance(p1);

            return (a + b + c);
        }

        public double getArea()
        {
            double[,] array = new double[2, 2];
            array[0, 0] = p1.getX() - p3.getX();
            array[0, 1] = p1.getY() - p3.getY();
            array[1, 0] = p2.getX() - p3.getX();
            array[1, 1] = p2.getY() - p3.getY();

            return Abs((array[0, 0] * array[1, 1]) - (array[0, 1] * array[1, 0])) / 2;
        }
    }
}
