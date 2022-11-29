using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _20206272_W4_4_Complex_Number
{
    class ComplexNumbers
    {
        public double real = 0;
        public double img = 0;
        public static ComplexNumbers Unit0
        {
            get { return new ComplexNumbers(0, 0); }
        }
        public static ComplexNumbers Unit1
        {
            get { return new ComplexNumbers(1, 0); }
        }
        public double modun
        {
            get
            {
                return Math.Sqrt(real * real + img * img);
            }
        }
        
        public ComplexNumbers() { }
        public ComplexNumbers(double real, double img)
        {
            this.real = real;
            this.img = img;
        }
        
        public ComplexNumbers(string A)
        {
            int countOP = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == '+' || A[i] == '-' )
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
                        double testR = 0, testI = 0;
                        if (double.TryParse(A.Substring(0, i), out testR) && double.TryParse(A.Substring(i + 1, A.Length - i - 2), out testI))
                        {
                            this.real = testR;
                            this.img = testI;
                            if (nComop == '-') this.img = -this.img;
                        }
                        else Console.WriteLine("Can't create complex");
                        
                        break;
                    }
                }
            }
            else if (countOP == 0 && A[A.Length - 1] == 'i' && double.TryParse(A.Substring(0, A.Length - 1), out this.img))
            {
                this.real = 0;
            }
            else if (double.TryParse(A, out this.real)) this.img = 0;
            else Console.WriteLine("Can't create complex");
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
        public static ComplexNumbers operator +(ComplexNumbers A, ComplexNumbers B)
        {
            return new ComplexNumbers(A.real + B.real, A.img + B.img);
        }
        public static ComplexNumbers operator +(ComplexNumbers A, double B)
        {
            return new ComplexNumbers(A.real + B, A.img);
        }
        public static ComplexNumbers operator -(ComplexNumbers A, ComplexNumbers B)
        {
            return new ComplexNumbers(A.real - B.real, A.img - B.img);
        }
        public static ComplexNumbers operator -(ComplexNumbers A, double B)
        {
            return new ComplexNumbers(A.real - B, A.img);
        }
        public static ComplexNumbers operator -(ComplexNumbers A)
        {
            return new ComplexNumbers(-A.real, -A.img);
        }
        public static ComplexNumbers operator *(ComplexNumbers A, ComplexNumbers B)
        {
            ComplexNumbers C = new ComplexNumbers();
            C.real = A.real * B.real - A.img * B.img;
            C.img = B.real * A.img + A.real * B.img;
            return C;
        }
        public static ComplexNumbers operator *(ComplexNumbers A, double B)
        {
            return new ComplexNumbers(A.real * B, A.img * B);
        }
        public static ComplexNumbers operator /(ComplexNumbers A, ComplexNumbers B)
        {
            ComplexNumbers C = new ComplexNumbers();
            C.real = (A.real * B.real + A.img * B.img) / (B.real * B.real + B.img * B.img);
            C.img = (A.img * B.real - A.real * B.img) / (B.real * B.real + B.img * B.img);
            return C;
        }
        public static ComplexNumbers operator /(ComplexNumbers A, double B)
        {
            return new ComplexNumbers(A.real / B, A.img / B);
        }
        public static ComplexNumbers operator ^(ComplexNumbers A, int n)
        {
            ComplexNumbers C = new ComplexNumbers();
            C = A;
            if (n == 0) return new ComplexNumbers(1, 0);
            for (int i = 1; i <= n - 1; i++)
            {
                C = C * A;
            }
            return C;
        }
        public ComplexNumbers SqrtC()
        {
            ComplexNumbers A = new ComplexNumbers();
            A = this;
            double modun = A.modun;
            double a, b;
            if (A.img != 0)
            {
                a = Math.Sqrt((modun + A.real) / 2);
                b = A.img / Math.Abs(A.img) * Math.Sqrt((modun - A.real) / 2);
                return new ComplexNumbers(a, b);
            }
            else
            {
                if (A.real >= 0) return new ComplexNumbers(Math.Sqrt(A.real), 0);
                else return new ComplexNumbers(0, Math.Sqrt(-A.real));
            }
        }
        public static ComplexNumbers SqrtC(ComplexNumbers A)
        {
            return A.SqrtC();
        }
    }
}
