using System;
using System.Reflection;
using System.Text;

namespace _20206272_W4_1_Class_Sinh_Viên
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trần Xuân Bách - 20206272
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            try
            {
                SinhVien Bach = new SinhVien("Trần Xuân Bách", 20);
                SinhVien Mai = new SinhVien("Hoàng Xuân Mai", 20);
                Bach._DiemTin = 10; Bach._DiemTiengAnh = 8; Bach._DiemTrietHoc = 5; Bach._GioiTinh = "Nam";
                Mai._DiemTin = 7; Mai._DiemTiengAnh = 8; Mai._DiemTrietHoc = 9; Mai._GioiTinh = "Nữ";
                Bach.TinhDTB();
                Mai.TinhDTB();
                Bach.InThongTin();
                Mai.InThongTin();
                if (Bach >= Mai) Console.WriteLine("\nBach không kém hơn Mai");
                else Console.WriteLine("Bách không giỏi hơn Mai");
                Console.WriteLine($"\nTổng học bổng của cả 2 là: {(Bach + Mai)._HocBong}");

                CSinhVien2007 Bach2 = new CSinhVien2007();
                Bach2 = Bach.ChuyenDoi();
                Bach2.DiemTrachNhiem = 8;
                Bach2.TinhDTB();
                Console.WriteLine();
                Bach2.InThongTin();
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }


    }
}
