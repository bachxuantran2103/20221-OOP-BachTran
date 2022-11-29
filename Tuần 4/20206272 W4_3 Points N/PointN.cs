using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20206272_W4_2_Points_N
{
    internal class PointN
    {
        public int dim;
        private double[] Elements;

        public double this[int index]
        {
            get
            {
                return Elements[index];
            }
            set { Elements[index] = value; }
        }
        public double Distance
        {
            get
            {
                double sum = 0;
                for(int i = 0; i < dim; i++) sum += Elements[i] * Elements[i];
                return Math.Sqrt(sum);
            }
        }
        public PointN GetZero(int dim)
        {
            PointN tmp = new PointN(dim);
            for (int i = 0; i < dim; i++) tmp[i] = 0;
            return tmp;
        }
        

        public PointN(int dim)
        {
            this.dim = dim;
            this.Elements = new double[dim];
            for(int i = 0; i < dim; i++) { this.Elements[i] = 0; }
        }
        public PointN( params double[] lists)
        {
            this.dim = lists.Length;
            this.Elements = new double[lists.Length];
            this.Elements = lists;
        }
        public override string ToString()
        {
            string infor = "(";
            for (int i = 0; i < this.dim - 1; i++) infor = string.Concat(infor, $" {this[i]},");
            infor = string.Concat(infor, $" {this[this.dim - 1]})");
            return infor;
        }
        public PointN GetSymmetric(int wdim)
        {
            try
            {
                this[wdim-1] = -this[wdim-1];
                return this;
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);
                return this;
            }
        }
        public static PointN operator +(PointN A, PointN B)
        {
            PointN C = new PointN(A.dim);

            if (A.dim == B.dim)
            {
                for (int i = 0; i < C.dim; i++) C[i] = A[i] - B[i];
                return C;
            }
            else
            {
                Console.Write("2 point don't have same numbers of dimmension. ");
                return A;
            }

        }
        public static PointN operator -(PointN A, PointN B)
        {
            PointN C = new PointN(A.dim);
            if(A.dim == B.dim)
            {
                for (int i = 0; i < C.dim; i++) C[i] = A[i] - B[i];
                return C;
            }
            else
            {
                Console.Write("2 point don't have same numbers of dimmension. ");
                return A;
            }
            
        }

    }
}
