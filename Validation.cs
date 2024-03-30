using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MidProjectUI
{
    public class Validation
    {
        public static string FirstNameRegex = "^[A-Za-z]{1,9}$";
        public static string SecondNameRegex = "^[A-Za-z]{1,9}$";
        public static string EmailRegex = "^\\S+@\\S+\\.\\S+$";
        public static string GenderRegex = "^M(ale)?$|^F(emale)?$";
        public static string ContactRegex = "^[0-9]{1,11}$";
        public static string RegNoRegex = "^[0-9]{1,4}-[A-Za-z]{2}-[0-9]{0,4}$";
        public static string SalaryRegex = @"^\d+$";
        public static string IdRegex = "^[0-9]+$";
        public static string stringRegex = ".*";
        public static string empty = @"^\s*$";

        public static bool CheckRegNo(string RegNo)
        {
            return Regex.IsMatch(RegNo, RegNoRegex);
        }

        public static bool CheckEmpty(string EMPTY)
        {
            return Regex.IsMatch(EMPTY, empty);
        }
        public static bool CheckFirstName(string name)
        {
            return Regex.IsMatch(name, FirstNameRegex);
        }
        public static bool CheckSecondName(string name)
        {
            return Regex.IsMatch(name, SecondNameRegex);
        }
        public static bool CheckEmail(string Email)
        {
            return Regex.IsMatch(Email, EmailRegex);
        }
        public static bool CheckContact(string rate)
        {
            return Regex.IsMatch(rate, ContactRegex);
        }

        public static bool CheckGender(string Gender)
        {
            return Regex.IsMatch(Gender, GenderRegex);
        }

        public static bool CheckSalary(string Salary)
        {
            return Regex.IsMatch(Salary, SalaryRegex);
        }

        public static bool CheckId(string Id)
        {
            return Regex.IsMatch(Id, IdRegex);
        }

        public static bool CheckString(string str)
        {
            return Regex.IsMatch(str, stringRegex);
        }

    }
}
