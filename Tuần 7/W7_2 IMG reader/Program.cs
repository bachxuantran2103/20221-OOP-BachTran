using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace W7_2_IMG_reader
{
    internal class Program
    {
        static string ImagePath = Environment.CurrentDirectory + @"\IMG_01.JPG";
        static string ResultPath = Environment.CurrentDirectory + @"\result.txt";
        const int PIXEL_INTERVAL = 8;
        const double BRIGHTNESS_MULTIPLIER = 10;
        public class AppMessage
        {
            public static string _QuitProgram = "Enter exit to quit program.";
            public static string _EnterImage = "Enter the image path: ";
            public static string _EnterResult = "Enter the result's path: ";
            public static string _Exit = "exit";
        }
        static void Main(string[] args)
        {
            // Trần Xuân Bách - 20206272
            //D:\Lập trình hướng đối tượng OOP\Tuần 7\W7_2 IMG reader>dotnet add package System.Drawing.Common --version 7.0.0
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            try
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                do
                {
                    Console.WriteLine(AppMessage._QuitProgram);
                    Console.WriteLine(AppMessage._EnterImage);
                    ImagePath = Console.ReadLine();
                    Console.WriteLine(AppMessage._EnterResult);
                    ResultPath = Console.ReadLine();
                    if (ImagePath.ToLower() == AppMessage._Exit || ResultPath.ToLower() == AppMessage._Exit) break;
                    try
                    {
                        Console.WriteLine(convertToText(ImagePath));
                    }
                    catch (Exception E)
                    {
                        Console.WriteLine(E);
                    }
                }
                while (true);
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
        static string convertToText(string IImagePath)
        {

            Bitmap _bmp = new Bitmap(IImagePath);
            string _images = "";
            string _writtenLine = "";
            for (int y = 0; y < _bmp.Size.Height - (_bmp.Size.Height % PIXEL_INTERVAL); y  += PIXEL_INTERVAL)
            {
                for (int x = 0; x < _bmp.Size.Width; x++)
                {
                    if (x % PIXEL_INTERVAL == 0 || x % PIXEL_INTERVAL == 1)
                    {
                        _writtenLine += getSymbolFromBrightness(_bmp.GetPixel(x, y).GetBrightness() * BRIGHTNESS_MULTIPLIER);
                    }
                }
                _images += "\n"+_writtenLine;

                //Console.WriteLine(WrittenLine);
                //using (StreamWriter writer = new StreamWriter(result_path, true))
                //{
                //    writer.WriteLine(WrittenLine);
                //}
                _writtenLine = "";
                
            }
            using (StreamWriter _writer = new StreamWriter(ResultPath, true))
            {
                _writer.WriteLine(_images);
            }
            return _images;
        }
        static string getSymbolFromBrightness(double IBrightness)
        {
            switch ((int)IBrightness)
            {
                case 0:
                    return "!";
                case 1:
                    return "@";
                case 2:
                    return "#";
                case 3:
                    return "$";
                case 4:
                    return "%";
                case 5:
                    return "^";
                case 6:
                    return "&";
                case 7:
                    return "*";
                case 8:
                    return "(";
                case 9:
                    return ")";
                case 10:
                    return "-";
                case 11:
                    return "_";
                case 12:
                    return "+";
                case 13:
                    return "=";
                case 14:
                    return "{";
                case 15:
                    return "}";
                case 16:
                    return "[";
                case 17:
                    return "]";
                case 18:
                    return "|";
                case 19:
                    return @"\";
                case 20:
                    return ":";
                case 21:
                    return ";";
                case 22:
                    return "''";
                case 23:
                    return "<";
                case 24:
                    return ">";
                case 25:
                    return "?";
                case 26:
                    return "/";
                default:
                    return " ";
            }
        }

    }
}
