using _20206272_W2_3_Equation_and_Number;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206272_W4_4_1_Complex_Vecctor_Matrix
{

    public class Matrix
    {
        public int row;
        public int col;
        public bool IsSquare
        {
            get
            {
                if (row == col) return true;
                else return false;
            }
        }
        private Complex[,] MElements
        {
            get
            {
                Complex[,] result = new Complex[row, col];
                return new Complex[row, col];
            }
        }
        public Complex this[int rows, int cols]
        {
            get
            {
                return MElements[rows, cols];
            }
            set
            {
                MElements[rows, cols] = (Complex)value;
            }
        }
        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        public static Matrix operator +(Matrix A, Matrix B)
        {
            Matrix C = new Matrix(A.row, A.col);
            if (A.row == B.row && A.col == B.col)
            {
                for (int i = 0; i < A.row; i++)
                {
                    for (int j = 0; j < A.col; j++)
                    {
                        C[i, j] = A[i, j] + B[i, j];
                    }
                }
            }
            else throw new Exception("Matrixs don't have equal size.");
            return C;
        }

        public static Matrix operator -(Matrix A, Matrix B)
        {
            Matrix C = new Matrix(A.row, A.col);
            if (A.row == B.row && A.col == B.col)
            {
                for (int i = 0; i < A.row; i++)
                {
                    for (int j = 0; j < A.col; j++)
                    {
                        C[i, j] = A[i, j] - B[i, j];
                    }
                }

            }
            else throw new Exception("Matrixs don't have equal size.");
            return C;
        }
        public static Matrix operator -(Matrix A)
        {
            return A * (-1);
        }

        public static Matrix operator *(Matrix A, Matrix B)
        {
            Matrix C = new Matrix(A.row, A.col);
            if (A.row == B.col)
            {
                for (int i = 0; i < A.row; i++)    //hang cua ma tran thu nhat 
                {
                    for (int j = 0; j < B.col; j++)    //cot cua ma tran thu hai 
                    {
                        Complex sum = new Complex(0, 0);
                        for (int k = 0; k < A.col; k++)
                            sum = sum + A[i, k] * B[k, j];
                        C[i, j] = sum;
                    }
                }

            }
            else throw new Exception("Matrixs don't have equal col and row.");
            return C;
        }
        public static Matrix operator *(Matrix A, double B)
        {
            Matrix C = new Matrix(A.row, A.col);

            for (int i = 0; i < A.row; i++)
            {
                for (int j = 0; j < A.col; j++)
                {
                    C[i, j] = A[i, j] * B;
                }
            }
            return C;
        }

        public Matrix Tranposition()
        {
            Matrix C = new Matrix(this.col, this.row);
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.col; j++)
                {
                    C[j, i] = this[i, j];
                }
            }
            return C;
        }
    }
}
