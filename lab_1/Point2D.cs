using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace lab_1
{
    public class Point2D
    {
        private double x, y;

        public static Point2D DrawPoint2D()
        {
            Point2D P = new Point2D();
            Random rnd = new Random();
            P.x = rnd.Next() * 546;
            P.y = rnd.Next() * 261;

            return P;
        }

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        public void shiftX(double value)
        {
            x += value;
        }

        public void shiftY(double value)
        {
            y += value;
        }

        public double getDistance(Point2D otherPoint)
        {
            double distance = Sqrt(Pow((x - otherPoint.getX()), 2) + Pow((y - otherPoint.getY()), 2));

            return distance;
        }
    }
}
