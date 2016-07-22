using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment05
{
    class Grades
    {
        string lName;
        string fName;
        string grade;

        public string LName
        {
            get { return lName; }

            set { lName = value; }
        }
        public string FName
        {
            get { return fName; }

            set { fName = value; }
        }
        public string Grade
        {
            get { return grade; }

            set { grade = value; }
        }

        public Grades()
        { }

        public Grades(string lName, string fName, string grade)
        {
            this.lName = lName;
            this.fName = fName;
            this.grade = grade;
        }
    }
}
