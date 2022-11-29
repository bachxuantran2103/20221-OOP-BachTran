using _20206272_W4_4_Complex_Number;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _20206272_W4_5_Polynomial
{
    class Polynomial
    {
        public int rank;
        private ComplexNumbers[] Elements;
        public ComplexNumbers this[int i]
        {
            get
            {
                return Elements[i];
            }
            set
            {
                Elements[i] = value;
            }
        }
        public static Polynomial UnitElem0
        {
            get
            {
                Polynomial Unit = new Polynomial(0);
                Unit[0] = new ComplexNumbers(0, 0);
                return Unit;

            }
        }
        public static Polynomial UnitElem1
        {
            get
            {
                Polynomial Unit = new Polynomial(0);
                Unit[0] = new ComplexNumbers(1, 0);
                return Unit;

            }
        }

        public Polynomial() { }
        public Polynomial(int rank)
        {
            this.rank = rank;
            this.Elements = new ComplexNumbers[rank + 1];
            for(int i=0; i <= rank; i++)
            {
                this.Elements[i] = new ComplexNumbers();
            }
        }
        public override string ToString()
        {
            string output ="";
            for(int i = 0; i <= this.rank; i++)
            {
                if (this[i] == ComplexNumbers.Unit0 || this[i] == null) continue;
                if (i == 0)
                {
                    output = string.Concat(output, $" ({this[i].ToString()}) ");
                    continue;
                }
                if (i == 1)
                {
                    /*if (this[i].real >= 0) output = string.Concat(output, $"({this[i].ToString()})*X ");
                    else output = string.Concat(output, $"({this[i].ToString()})*X ");*/
                    output = String.Concat(output, $"+ ({this[i].ToString()})*X ");
                    continue;
                }
                output = String.Concat(output, $"+ ({this[i].ToString()})*X^{i} ");
                /*if (this[i].real >= 0) output = string.Concat(output, $"+ ({this[i].ToString()})*X^{i}");
                if (this[i].real <0)  output = string.Concat(output, $" ({this[i].ToString()})*X^{i}");*/
            }
            return output;
        }

        public static Polynomial operator + (Polynomial A, Polynomial B)
        {
            int rank = 0;
            bool isHigher;
            if (A.rank >= B.rank)
            {
                rank = A.rank;
                isHigher = true;
            }
            else
            {
                rank = B.rank;
                isHigher = false;
            }
            Polynomial C = new Polynomial(rank);
            if (isHigher)
            {
                for(int i = 0; i < rank+1; i++)
                {
                    if (i <= B.rank) C[i] = A[i] + B[i];
                    else C[i] = A[i];
                }
            }
            else
            {
                for (int i = 0; i < rank + 1; i++)
                {
                    if (i <= A.rank) C[i] = A[i] + B[i];
                    else C[i] = B[i];
                }
            }
            return C;
        }
        public static Polynomial operator -(Polynomial A, Polynomial B)
        {
            int rank = 0;
            bool isHigher;
            if (A.rank >= B.rank)
            {
                rank = A.rank;
                isHigher = true;
            }
            else
            {
                rank = B.rank;
                isHigher = false;
            }
            Polynomial C = new Polynomial(rank);
            if (isHigher)
            {
                for (int i = 0; i < rank + 1; i++)
                {
                    if (i <= B.rank) C[i] = A[i] - B[i];
                    else C[i] = A[i];
                }
            }
            else
            {
                for (int i = 0; i < rank + 1; i++)
                {
                    if (i <= A.rank) C[i] = A[i] - B[i];
                    else C[i] = -B[i];
                }
            }
            return C;
        }

        public static Polynomial operator *(Polynomial A, Polynomial B)
        {
            Polynomial C = new Polynomial(A.rank+B.rank);
            ComplexNumbers[,] Operand = new ComplexNumbers[A.rank+1, B.rank+1];
            for(int i = 0; i <= A.rank; i++)
            {
                for(int j= 0; j <= B.rank; j++)
                {
                    Operand[i, j] = A[i] * B[j];
                }
            }
            int row = 0, col = 0;
            ComplexNumbers sum = new ComplexNumbers(0, 0);
            for(int i = 0; i <= C.rank; i++)
            {
                row = 0;
                col = i;
                sum = new ComplexNumbers(0, 0);
                for (int j = 0; j <= i; j++)
                {
                    if (row > A.rank || col > B.rank || row < 0 || col < 0)
                    {
                        row++;
                        col--;
                        continue;
                    }
                    else
                    {
                        sum += Operand[row, col];
                        row++;
                        col--;
                    }
                }
                C[i] = sum; 
            }

            return C;
        }
        public ComplexNumbers CalculateValue(ComplexNumbers X)
        {
            ComplexNumbers sum =new ComplexNumbers(0, 0);
            for(int i = 0; i <= this.rank; i++)
            {
                sum+= this[i]*(X^i);
            }
            return sum;
        }
        public Polynomial Derivative() // đạo hàm
        {
            Polynomial deri = new Polynomial(this.rank - 1);
            for(int i = 0; i <= this.rank-1; i++)
            {
                deri[i]= this[i+1]*i;
            }
            return deri;
        }
        public Polynomial Primitive() // nguyên hàm
        {
            Polynomial prim = new Polynomial(this.rank + 1);
            prim[0] = ComplexNumbers.Unit1;
            for(int i = 1; i <= prim.rank;i++)
            {
                prim[i] = this[i - 1] / i;
            }

            return prim;
        }
        public ComplexNumbers[] Solve()
        {
            ComplexNumbers[] Ans = new ComplexNumbers[this.rank];
            for(int j = 0; j < this.rank; j++)
            {
                Ans[j] = new ComplexNumbers();
            }
            if (this.rank == 1)
            {
                if (this[this.rank] != ComplexNumbers.Unit0)
                {
                    Ans[0] = -this[0] / this[1];
                    Console.WriteLine($"Phương trình có nghiệm: {Ans[0]}");
                }
                {
                    if (this[0] == ComplexNumbers.Unit0 ) Console.WriteLine("Phương trình vô số nghiệm");
                    else Console.WriteLine($"Phương trình vô nghiệm");
                }
            }
            if(this.rank == 2)
            {
                ComplexNumbers denta = new ComplexNumbers();
                denta = ((this[1] ^ 2) - this[2] * this[0] * 4);
                Ans[0] = (-this[1] - denta.SqrtC()) / (this[2]*2);
                Ans[1] = (-this[1] + denta.SqrtC()) / (this[2] * 2);
            }

            return Ans;
        }

    }
}
