using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _20206272_W2_3_Equation_and_Number
{
    public abstract class Numbers
    {
        protected int numElements;
        public double[] Element
        {
            get { return new double[numElements]; }
        }
        public double this[int indexers]
        {
            get
            {
                return Element[indexers];
            }
            set
            {
                Element[indexers] = value;
            }
        }

        private enum NumTypes
        {
            real,
            complex
        }
        

    }
    public class Complex : Numbers
    {
        
        public double modun
        {
            get
            {
                return Math.Sqrt(this[0] * this[0] + this[1] * this[1]);
            }
        }
        public Complex Conjugate
        {
            get
            {
                return new Complex(this[0], -this[1]);
            }
        }
        public Complex()
        {
            this.numElements = 2;
        }
        public Complex(double a, double b)
        {
            this.numElements = 2;
            this[0] = a;
            this[1] = b;
        }
        public Complex(string A)
        {
            this.numElements = 2;
            int countOP = 0;
            double tempt = 0;

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
                            this[0] = testR;
                            this[1] = testI;
                        }
                        else Console.WriteLine("Can't create complex");
                        if (nComop == '-') this[1] = -this[1];
                        break;
                    }
                }
            }
            else if (countOP == 0 && A[A.Length - 1] == 'i')
            {
                this[0] = 0;
                this[1] = double.Parse(A.Substring(0, A.Length - 1));
            }
            else if (double.TryParse(A, out tempt)) { this[0] = tempt; this[1] = 0; }
            else Console.WriteLine("Can't create complex");
        }

        public override string ToString()
        {
            if (this[0] != 0 && this[1] != 0)
            {
                if (this[1] > 0) return $"{this[0]}+{this[1]}i";
                else return $"{this[0]}{this[1]}i";
            }
            else
            {
                if (this[0] == 0 && this[1] == 0) return $"{this[0]}";
                else
                {
                    if (this[0] == 0) return $"{this[1]}i";
                    else return $"{this[0]}";
                }
            }
        }
        public bool TryToDouble(Complex A, ref double b)
        {
            if (this[1] != 0)
            {
                return false;
            }
            else
            {
                b=this[0];
                return true;
            }
        }

        public static Complex operator +(Complex A, Complex B)
        {
            return new Complex(A[0] + B[0], A[1] + B[1]);
        }
        public static Complex operator +(Complex A, double B)
        {
            return new Complex(A[0] + B, A[1]);
        }
        public static Complex operator -(Complex A, Complex B)
        {
            return new Complex(A[0] - B[0], A[1] - B[1]);
        }
        public static Complex operator -(Complex A, double B)
        {
            return new Complex(A[0] - B, A[1]);
        }
        public static Complex operator -(Complex A)
        {
            return new Complex(-A[0], -A[1]);
        }
        public static Complex operator *(Complex A, Complex B)
        {
            Complex C = new Complex();
            C[0] = A[0] * B[0] - A[1] * B[1];
            C[1] = B[0] * A[1] + A[0] * B[1];
            return C;
        }
        public static Complex operator *(Complex A, double B)
        {
            return new Complex(A[0] * B, A[1] * B);
        }
        public static Complex operator /(Complex A, Complex B)
        {
            Complex C = new Complex();
            C[0] = (A[0] * B[0] + A[1] * B[1]) / (B[0] * B[0] + B[1] * B[1]);
            C[1] = (A[1] * B[0] - A[0] * B[1]) / (B[0] * B[0] + B[1] * B[1]);
            return C;
        }
        public static Complex operator /(Complex A, double B)
        {
            return new Complex(A[0] / B, A[1] / B);
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
            if (A[1] != 0)
            {
                a = Math.Sqrt((modun + A[0]) / 2);
                b = A[1] / Math.Abs(A[1]) * Math.Sqrt((modun - A[0]) / 2);
                return new Complex(a, b);
            }
            else
            {
                if (A[0] >= 0) return new Complex(Math.Sqrt(A[0]), 0);
                else return new Complex(0, Math.Sqrt(-A[0]));
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

    }

    

}
