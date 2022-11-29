using _20206272_W2_3_Equation_and_Number;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206272_W4_4_1_Complex_Vecctor_Matrix
{
    class Vector
    {
        public int dim;
        private Complex[] Elems
        {
            get
            {
                return new Complex[dim];
            }
        }
        public Complex this[int i]
        {
            get { return Elems[i]; }
            set { Elems[i] = value; }
        }
        public Vector(int dim)
        {
            this.dim = dim;
        }

        public static Vector operator +(Vector A, Vector B)
        {
            Vector C =new Vector(A.dim);
            if(A.dim == B.dim)
            {
                for(int i =0; i < A.dim; i++)
                {
                    C[i] = A[i] + B[i];
                }
            }
            return C;
        }
        public static Vector operator -(Vector A, Vector B)
        {
            Vector C = new Vector(A.dim);
            if (A.dim == B.dim)
            {
                for (int i = 0; i < A.dim; i++)
                {
                    C[i] = A[i] - B[i];
                }
            }
            return C;
        }
        public static Vector operator -(Vector A)
        {
            return A*(-1);
        }
        public static Complex operator *(Vector A, Vector B)
        {
            Complex sum = new Complex(0, 0);
            if (A.dim == B.dim)
            {
                for (int i = 0; i < A.dim; i++)
                {
                    sum += A[i] * B[i];
                }
            }
            return sum;
        }
        public static Vector operator *(Vector A, double B)
        {
            Vector C = new Vector(A.dim);
            if (A.dim == B)
            {
                for (int i = 0; i < A.dim; i++)
                {
                    C[i] = A[i] * B;
                }
            }
            return C;
        }
    }
}
