using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206272_W3_1_Circle_Class
{
    public abstract class GeometricObject
    {
        protected string color;
        protected double weight;
        // Default construct 
        protected GeometricObject()
        {

            color = "white";
            weight = 1.0;
        }
        // Construct a geometric object
        protected GeometricObject(string color, double weight)
        {
            this.color = color;
            this.weight = weight;
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;

            }
            set
            {
                weight = value;
            }
        }
        // Abstract method
        public abstract double findArea();
        // Abstract method
        public abstract double findPerimeter();
    }
    public class Circle : GeometricObject
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, double weight)
        {
            this.radius = radius;
            this.color = color;
            this.weight = weight;
        }
        public override string ToString()
        {
            return $"Circle radius: {this.radius}, color = {this.color}, weight = { this.weight} ";
        }
        public override double findArea()
        {
            return Math.PI * this.radius * this.radius;
        }
        public override double findPerimeter()
        {
            return 2 * Math.PI * this.radius;
        }
    }

}
