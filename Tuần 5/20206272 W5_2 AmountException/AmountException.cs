using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206272_W5_2_AmountException
{
    public class AmountException : ApplicationException
    {
        public string ExceptionName;
        public static string CheckIncome(Student objStudent)
        {

            if (objStudent.title.ToLower() == "senior")
            {
                if (objStudent.salary < 60000)
                {
                    return $"Senior {objStudent.personName} has salary < 60000";
                }

                if (objStudent.bonus > 10000)
                    return $"Senior {objStudent.personName} has bonus > 10000";
                return "";
            }
            else return "Checked";
        }
    }
}
