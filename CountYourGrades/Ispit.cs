using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountYourGrades
{
    class Ispit
    {
        private String _name;
        private int _grade;

        public String Name { get => _name; set => _name = value;}
        public int Grade { get => _grade; set => _grade = value; }

        public Ispit() { }
        public Ispit(String name, int grade)
        {
            this._name = name;
            this._grade = grade;
        }
    }
}
