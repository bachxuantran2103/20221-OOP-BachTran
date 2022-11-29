using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static W7_1_Student_Information.Program;

namespace W7_1_Student_Information
{
    public class Student
    {
        private string _Name;
        private int _Age;
        private double _Mark;
        public Student() { }
        public Student(string IName, int IAge, double IMark)
        {
            _Name = IName;
            _Age = IAge;
            _Mark = IMark;
        }
        public override string ToString()
        {
            return $"{_Name}: {_Age} years old, {_Mark} points.";
        }
        public static List<Student> ReadFile(string IPath)
        {
            StreamReader _file = new StreamReader(IPath);
            List<Student> _students = new List<Student>();

            int _i = 0;
            bool _exit = true;
            while (_exit)
            {

                Student _objTemp = new Student();
                string[] _arrData = new string[3];
                _arrData[0] = _file.ReadLine();
                _arrData[1] = _file.ReadLine();
                _arrData[2] = _file.ReadLine();
                try
                {
                    _objTemp = new Student(_arrData[0], int.Parse(_arrData[1]), double.Parse(_arrData[2]));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + $"at rows {_i}, {_i + 1}, {_i + 2}. ");

                }
                _students.Add(_objTemp);
                _i++;

                Console.WriteLine(_objTemp.ToString());

                if (_file.EndOfStream)
                {
                    Console.WriteLine(AppMessage.EndOfFile);
                    _exit = false;
                    break;
                }
            }

            //foreach (Student _student in _students)
            //{
            //    Console.WriteLine(_student.ToString());
            //}
            _file.Close();
            return _students;
        }
        public static void SaveToFile(List<Student> IStudents, string IPath)
        {
            if (IStudents is null)
            {
                throw new ArgumentNullException(nameof(IStudents));
            }

            StreamWriter _file = new StreamWriter(IPath, true);
            if (!File.Exists(IPath))
            {
                // Create a file to write to.
                _file = File.CreateText(IPath);
            }
            _file.AutoFlush = true;
            foreach (Student _student in IStudents)
            {
                _file.WriteLine(_student._Name);
                _file.WriteLine(_student._Age);
                _file.WriteLine(_student._Mark);
                _file.Flush();
            }

            _file.Close();

        }
        public static List<Student> GetStudent()
        {
            List<Student> _students = new List<Student>();
            int i = 0;
            string[] _data = new string[3];

            Console.WriteLine(AppMessage.DoneMessage);
            while (Console.ReadLine().ToLower() != AppMessage.Done.ToLower())
            {
                Console.WriteLine(AppMessage.EnterStudent.Replace(AppMessage.NumOrder, i.ToString()));
                Console.WriteLine(AppMessage.EnterName);
                _data[0] = Console.ReadLine();
                Console.WriteLine(AppMessage.EnterAge);
                _data[1] = Console.ReadLine();
                Console.WriteLine(AppMessage.EnterMark);
                _data[2] = Console.ReadLine();
                try
                {
                    _students.Add(new Student(_data[0], int.Parse(_data[1]), double.Parse(_data[2])));
                }
                catch (Exception _e)
                {
                    Console.WriteLine(_e.Message);
                }
                i++;
            }
            return _students;

        }
    }
}
