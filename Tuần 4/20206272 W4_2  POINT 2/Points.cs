using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206272_W4_2__POINT_2
{
    internal class Point
    {
        public double _x;
        public double _y;

        public static Point O
        {
            get { return new Point(0,0); }
        }
        public double Distance
        {
            get
            {
                return Math.Sqrt(_x * _x + _y * _y);
            }
        }
        public Point() { }
        public Point(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        public override string ToString()
        {
            return $"({this._x },{this._y})";
        }
        public Point GetSymmetricYaxis()
        {
            return new Point(-this._x, this._y);
        }
        public Point GetSymmetricXaxis()
        {
            return new Point(this._x, -this._y);
        }
        public Point GetSymmetricP(Point B)
        {
            Point C = new Point();
            C._x = this._x - 2 * (this._x - B._x);
            C._y = this._y - 2 * (this._y - B._y);
            return C;
        }

        public static Point operator + (Point A, Point B)
        {
            return new Point(A._x + B._x, A._y + B._y);

        }
        public static Point operator -(Point A, Point B)
        {
            return new Point(A._x - B._x, A._y - B._y);

        }
        public static double operator *(Point A, Point B)
        {
            return A._x * B._x + A._y * B._y;

        }
    }
}
