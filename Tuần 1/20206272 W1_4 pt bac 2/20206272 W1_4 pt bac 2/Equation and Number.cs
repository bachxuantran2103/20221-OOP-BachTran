using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _20206272_W2_3_Equation_and_Number
{
    internal class Equation
    {
        public static void FirstEqR(double a, double b)
        {
            if (a != 0) Console.WriteLine($"Phương trình có nghiệm: {-b / a}");
            else
            {
                if (b == 0) Console.WriteLine("Phương trình vô số nghiệm");
                else
                {
                    Console.WriteLine($"Phương trình vô nghiệm");
                }

            }
        }
        public static void FirstEqC(Complex A, Complex B)
        {
            if (A != new Complex(0.ToString())) Console.WriteLine($"Phương trình có nghiệm: {(B * (-1)) / A}");
            else
            {
                if (B == new Complex(0.ToString())) Console.WriteLine("Phương trình vô số nghiệm");
                else
                {
                    Console.WriteLine($"Phương trình vô nghiệm");
                }

            }
        }
        public static void QuadraticC(Complex A, Complex B, Complex C)
        {
            Complex X1 = new Complex();
            Complex X2 = new Complex();
            Complex denta = new Complex();
            denta = B * B - A * C * 4;

            X1 = (B * (-1) - Complex.SqrtC(B * B - A * C * 4)) / (A * 2);
            X2 = (B * (-1) + Complex.SqrtC(B * B - A * C * 4)) / (A * 2);
            Console.WriteLine($"Phương trình có 2 nghiệm: \n{X1.ToString()}\n{X2.ToString()}");
        }
        public static void QuadraticR(double a, double b, double c)
        {
            double x1, x2, denta;
            denta = b * b - 4 * a * c;
            if (denta < 0)
            {
                Console.WriteLine("Phương trình không có nghiệm thực");
                QuadraticC(new Complex(a.ToString()), new Complex(b.ToString()), new Complex(c.ToString()));
            }
            else if (denta == 0)
            {
                Console.WriteLine($"Phương trình có nghiệm kép: {-b / (2 * a)}");

            }
            else
            {
                x1 = (-b - Math.Sqrt(denta)) / (2 * a);
                x2 = (-b + Math.Sqrt(denta)) / (2 * a);
                Console.WriteLine($"Phương trình có 2 nghiệm phân biệt: {x1} {x2}");
            }
        }
    }

    internal class Number
    {
        protected enum NumType
        {
            integer,
            Ratio,
            Real,
            Complex
        }
        protected Complex ToComplex()
        {
            return new Complex(this.ToString());
        }

    }
    class Complex : Number
    {
        public double real = 0;
        public double img = 0;
        public double modun
        {
            get
            {
                return Math.Sqrt(real * real + img * img);
            }
        }
        public Complex Conjugate
        {
            get
            {
                return new Complex(real, -img);
            }
        }
        public override string ToString()
        {
                if (real != 0 && img != 0)
                {
                    if (img > 0) return $"{real}+{img}i";
                    else return $"{real}{img}i";
                }
                else
                {
                    if (real == 0 && img == 0) return $"{real}";
                    else
                    {
                        if (real == 0) return $"{img}i";
                        else return $"{real}";
                    }
                }
           
        }
        public Complex() { }
        public Complex(double real, double img)
        {
            this.real = real;
            this.img = img;
        }
        public Complex(string A)
        {
            int countOP = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == '+' || A[i] == '-' || A[i] == '*' || A[i] == '/')
                {
                    countOP++;
                }
            }
            if (countOP == 1 && A[A.Length - 1] == 'i')
            {
                char nComop = '+';
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == '+' || A[i] == '-')
                    {
                        nComop = A[i];
                        double.TryParse(A.Substring(0, i), out this.real);
                        double.TryParse(A.Substring(i + 1, A.Length - i - 2), out this.img);
                        if (nComop == '-') this.img = -this.img;
                        break;
                    }
                }
            }
            else if (countOP == 0 && A[A.Length - 1] == 'i')
            {
                this.real = 0;
                double.TryParse(A.Substring(0, A.Length - 1), out this.img);
            }
            else if (double.TryParse(A, out this.real)) this.img = 0;
            else Console.WriteLine("Can't create complex");
        }
        public static Complex operator +(Complex A, Complex B)
        {
            return new Complex(A.real + B.real, A.img + B.img);
        }
        public static Complex operator +(Complex A, double B)
        {
            return new Complex(A.real + B, A.img);
        }
        public static Complex operator -(Complex A, Complex B)
        {
            return new Complex(A.real - B.real, A.img - B.img);
        }
        public static Complex operator -(Complex A, double B)
        {
            return new Complex(A.real - B, A.img);
        }
        public static Complex operator *(Complex A, Complex B)
        {
            Complex C = new Complex();
            C.real = A.real * B.real - A.img * B.img;
            C.img = B.real * A.img + A.real * B.img;
            return C;
        }
        public static Complex operator *(Complex A, double B)
        {
            return new Complex(A.real * B, A.img * B);
        }
        public static Complex operator /(Complex A, Complex B)
        {
            Complex C = new Complex();
            C.real = (A.real * B.real + A.img * B.img) / (B.real * B.real + B.img * B.img);
            C.img = (A.img * B.real - A.real * B.img) / (B.real * B.real + B.img * B.img);
            return C;
        }
        public static Complex operator /(Complex A, double B)
        {
            return new Complex(A.real / B, A.img / B);
        }
        public static Complex operator ^(Complex A, int n)
        {
            Complex C = new Complex();
            C = A;
            for (int i = 1; i <= n - 1; i++)
            {
                C = C * A;
            }
            return C;
        }
        private Complex SqrtC()
        {
            Complex A = new Complex();
            A = this;
            double modun = A.modun;
            double a, b;
            if (A.img != 0)
            {
                a = Math.Sqrt((modun + A.real) / 2);
                b = A.img / Math.Abs(A.img) * Math.Sqrt((modun - A.real) / 2);
                return new Complex(a, b);
            }
            else
            {
                if (A.real >= 0) return new Complex(Math.Sqrt(A.real), 0);
                else return new Complex(0, Math.Sqrt(-A.real));
            }
        }
        public static Complex SqrtC(Complex A)
        {
            return A.SqrtC();
        }
        public Complex Inverse()
        {
            Complex x = new Complex(1, 0);
            return x / this;
        }
        /*public static void Quaradic(Complex A, Complex B, Complex C)
        {
            Complex X1 = new Complex();
            Complex X2 = new Complex();
            Complex denta = new Complex();
            denta = B * B - A * C * 4;

            X1 = (B * (-1) - SqrtC(B * B - A * C * 4)) / (A * 2);
            X2 = (B * (-1) + SqrtC(B * B - A * C * 4)) / (A * 2);
            Console.WriteLine($"Phương trình có 2 nghiệm: \n{X1.infor}\n{X2.infor}");
        }*/
    }
}
