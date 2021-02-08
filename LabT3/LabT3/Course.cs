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

        public Course(string CourseName, string CourseCode, int CourseCredit)
        {
            this.CourseName = CourseName;
            this.CourseCode = CourseCode;
            this.CourseCredit = CourseCredit;
           
        }
        public void ShowInfo1()
        {
            Console.WriteLine("Course Name:" + CourseName);
            Console.WriteLine("Course Code:" + CourseCode);
            Console.WriteLine("Course Credit:" + CourseCredit);
            
        }

    }
}

