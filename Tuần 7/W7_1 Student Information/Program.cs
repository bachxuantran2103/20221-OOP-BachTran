using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace W7_1_Student_Information
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // Trần Xuân Bách - 20206272
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            try
            {
                string Path = Environment.CurrentDirectory + @"\sv.txt";
                if (Directory.Exists(Path)) File.CreateText(Path).Close();

                bool Exit = true;
                while (Exit)
                {
                    Console.WriteLine($"\n1. {AppMessage.SaveToFile}" +
                        $"\n2. {AppMessage.ReadFile}" +
                        $"\n3. {AppMessage.ExitOption}");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Student.SaveToFile(Student.GetStudent(), Path);
                            break;
                        case "2":
                            Student.ReadFile(Path);
                            break;
                        case "3":
                            Exit = false;
                            break;
                        default:
                            Console.WriteLine(AppMessage.ReEnter);
                            break;
                    }
                }
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
        
    }
}
