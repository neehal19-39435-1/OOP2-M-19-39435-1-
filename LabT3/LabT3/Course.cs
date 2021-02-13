using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabT3
{
    class Course
    {
        string CourseName, CourseCode;
        int CourseCredit;

        public string coursename
        {
            get { return CourseName; }
            set { CourseName = value; }
        }

        public string coursecode
        {
            get { return CourseCode; }
            set { CourseCode = value; }
        }

        public int coursecredit
        {
            get { return CourseCredit; }
            set { CourseCredit = value; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Course Name:" + CourseName);
            Console.WriteLine("Course Code:" + CourseCode);
            Console.WriteLine("Course Credit:" + CourseCredit);
            
        }

    }
}

