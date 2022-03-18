using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
  public class EnterFirstName
    {
        public static string Enter_Name = "[a-z]{3}";

        public bool ValidName(string name)
        {
            return Regex.IsMatch(name, Enter_Name);
        }
    }
}
