using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206272_W2_4_perimeter_and_area
{
    // Trần Xuân Bách - 20206272
    internal class Shape
    {
        double _Area;
        double _Perimeter;
        enum Typeshape
        {
            Circle,
            Rectangle,
            Trapezoid,
            Triagle
        }

        public virtual double GetPerimeter()
        {
            return this._Perimeter;
        }
        public virtual double GetArea()
        {
            return this._Area;
        }
    }
    class Circle : Shape
    {
        double _radius;

        public Circle(double radius)
        {
            this._radius = radius;
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * this._radius ;
        }
        public override double GetArea()
        {
            return Math.PI * this._radius * this._radius;
        }
    }
    class Triagle : Shape
    {
        double _Egde1;
        double _Egde2;
        double _Egde3;

        public Triagle(double egde1, double egde2, double egde3)
        {
            this._Egde1 = egde1;
            this._Egde2 = egde2;
            this._Egde3 = egde3;
        }
        public override double GetPerimeter()
        {
            return this._Egde1 + this._Egde2 + this._Egde3;
        }
        public override double GetArea()
        {
            double p = this.GetPerimeter() / 2;
            return Math.Sqrt(p * (p - this._Egde1) * (p - this._Egde2) * (p - this._Egde3));

        }
    }
    class Rectangle: Shape
    {
        double _Longs;
        double _Width;

        public Rectangle(double longs, double width)
        {
            this._Longs = longs;
            this._Width = width;
        }
        public override double GetPerimeter()
        {
            return 2*(this._Longs+this._Width);
        }
        public override double GetArea()
        {
            return this._Longs * this._Width;
        }
    }
    class Trapezoid: Shape
    {
        double _ShortBase;
        double _LongBase;
        double _LeftLeg;
        double _RightLeg;

        public Trapezoid(double shortbase, double longbase, double leftleg, double rightleg)
        {
            this._ShortBase = shortbase;
            this._LongBase = longbase;
            this._LeftLeg = leftleg;
            this._RightLeg = rightleg;
        }
        public override double GetArea()
        {
            double base1 = this._ShortBase + this._LongBase; //P+Q
            double base2 = this._LongBase - this._ShortBase; //P-Q
            double l2 = this._LeftLeg * this._LeftLeg; //R^2
            double r2 = this._RightLeg * this._RightLeg; //S^2

            return (base1*Math.Sqrt(2*(l2*r2+l2*base2*base2 + r2*base2*base2 )-(l2*l2+r2*r2+Math.Pow(base2,4)  ) ) ) / (4 * base2);
        }
        public override double GetPerimeter()
        {
            return (this._ShortBase + this._LongBase + this._LeftLeg + this._RightLeg);
        }
    }
}
