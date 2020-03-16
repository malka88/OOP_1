using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace lab_1
{
    public class Rectangle
    {
        private Point2D p1, p2, p3, p4;

        public static Rectangle DrawRectangle()
        {
            Rectangle R = new Rectangle();
            R.p1 = Generation.DrawPoint2D();
            Thread.Sleep(20);
            R.p2 = Generation.DrawPoint2D();
            Thread.Sleep(20);
            R.p3 = Generation.DrawPoint2D();
            Thread.Sleep(20);
            R.p4 = Generation.DrawPoint2D();

            R.p2.setX(R.p4.getX());
            R.p2.setY(R.p1.getY());
            R.p3.setY(R.p4.getY());
            R.p3.setX(R.p1.getX());

            return R;
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

        public Point2D getP4()
        {
            return p4;
        }

        public void shiftX(double value)
        {
            p1.shiftX(value);
            p2.shiftX(value);
            p3.shiftX(value);
            p4.shiftX(value);

            if((p1.getX() < 0 || p1.getX() > 546) || (p2.getX() < 0 || p2.getX() > 546) || (p3.getX() < 0 || p3.getX() > 546) || (p4.getX() < 0 || p4.getX() > 546))
            {
                p1.shiftX(-value);
                p2.shiftX(-value);
                p3.shiftX(-value);
                p4.shiftX(-value);
            }
        }

        public void shiftY(double value)
        {
            p1.shiftY(value);
            p2.shiftY(value);
            p3.shiftY(value);
            p4.shiftY(value);

            if ((p1.getX() < 0 || p1.getX() > 261) || (p2.getX() < 0 || p2.getX() > 261) || (p3.getX() < 0 || p3.getX() > 261) || (p4.getX() < 0 || p4.getX() > 261))
            {
                p1.shiftX(-value);
                p2.shiftX(-value);
                p3.shiftX(-value);
                p4.shiftX(-value);
            }
        }

        public double getPerimeter()
        {
            double a = p1.getDistance(p2);
            double b = p1.getDistance(p3);

            return ((a + b) * 2);
        }

        public double getArea()
        {
            double a = p1.getDistance(p2);
            double b = p1.getDistance(p3);

            return (a * b);
        }
    }
}
