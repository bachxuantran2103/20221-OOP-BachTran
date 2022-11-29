using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _20206272_W4_1_Class_Sinh_Viên
{
    internal class SinhVien
    {
        public string _HoTen;
        public int _Tuoi;
        public string _GioiTinh;
        public double _DiemTin;
        public double _DiemTiengAnh;
        public double _DiemTrietHoc;
        public double _DiemTrungBinh;
        public double _HocBong;

        public SinhVien()
        {
            this._HocBong = 10000;
            this._Tuoi = 20;
        }
        public SinhVien(string Name, int Age)
        {
            this._HoTen = Name;
            this._Tuoi = Age;
        }

        public virtual void TinhDTB()
        {
            double DTB = 0;
            DTB = (this._DiemTin + this._DiemTiengAnh + this._DiemTrietHoc) / 3;
            this._DiemTrungBinh = DTB;
            switch (DTB)
            {
                case var expression when DTB>=9:
                    this._HocBong = 200000;
                    break;
                case var expression when (DTB >= 8 && DTB < 9):
                    this._HocBong = 160000;
                    break;
                case var expression when (DTB >= 7 && DTB < 8):
                    this._HocBong = 120000;
                    break;
                case var expression when (DTB >= 6 && DTB < 7):
                    this._HocBong = 90000;
                    break;
            }
        }
        public virtual void InThongTin()
        {
            Console.WriteLine($"{this._HoTen}, {this._Tuoi} tuổi\nGiới tính: {this._GioiTinh}\nĐiểm Tin: {this._DiemTin}\nĐiểm Tiếng Anh: {this._DiemTiengAnh}" +
                $"\nĐiểm Triết học: {this._DiemTrietHoc}\nĐiểm trung bình: {this._DiemTrungBinh}\nHọc bổng: {this._HocBong} \n");
        }
        public static bool operator >= (SinhVien A, SinhVien B)
        {
            if (A._DiemTrungBinh >= B._DiemTrungBinh) return true;
            else return false;
        }
        public static bool operator <=(SinhVien A, SinhVien B)
        {
            if (A._DiemTrungBinh <= B._DiemTrungBinh) return true;
            else return false;
        }
        public static SinhVien operator +(SinhVien A, SinhVien B)
        {
            A._HocBong += B._HocBong;
            return A;
        }
        public CSinhVien2007 ChuyenDoi()
        {
            CSinhVien2007 A = new CSinhVien2007();
            A._HoTen = this._HoTen;
            foreach(FieldInfo item in this.GetType().GetFields() )
            {
                string[] tempt = item.ToString().Split(" ");
                string fieldName = tempt[tempt.Length-1];
                object tem = this.GetType().GetField(fieldName).GetValue(this);
                if (tem == null) continue;

                A.GetType().GetField(fieldName).SetValue(A,tem);
            }
            return A;
        }

    }
    class CSinhVien2007: SinhVien
    {
        public double DiemTrachNhiem;

        public override void TinhDTB()
        {
            double DTB = 0;
            DTB = (this._DiemTin + this._DiemTiengAnh + this._DiemTrietHoc + this.DiemTrachNhiem) / 4;
            this._DiemTrungBinh = DTB;
            switch (DTB)
            {
                case var expression when DTB >= 9:
                    this._HocBong = 200000;
                    break;
                case var expression when (DTB >= 8 && DTB < 9):
                    this._HocBong = 160000;
                    break;
                case var expression when (DTB >= 7 && DTB < 8):
                    this._HocBong = 120000;
                    break;
                case var expression when (DTB >= 6 && DTB < 7):
                    this._HocBong = 90000;
                    break;
            }
        }
        public override void InThongTin()
        {
            Console.WriteLine($"{this._HoTen}, {this._Tuoi} tuổi\nGiới tính: {this._GioiTinh}\nĐiểm Tin: {this._DiemTin}\nĐiểm Tiếng Anh: {this._DiemTiengAnh}" +
                $"\nĐiểm Triết học: {this._DiemTrietHoc}\nĐiểm trách nhiệm: {this.DiemTrachNhiem}  \nĐiểm trung bình: {this._DiemTrungBinh}\nHọc bổng: {this._HocBong}\n");
        }
    }



}
