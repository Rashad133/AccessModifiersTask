using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Student_Task.Models
{
    class Student
    {
        private string _name;
        private int _age;
        private int _grade;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public void CheckName(string name)
        {
            Regex rg = new Regex(@"^[A-Z][a-zA-Z]*$");
        }
    }
}
