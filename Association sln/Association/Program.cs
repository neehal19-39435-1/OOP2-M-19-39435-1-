using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("NEEHAL" , "19-XXXXX-1" , 3.5f);
            Student s2 = new Student("SARAH", "19-XXXXX-2", 3.2f);
            Student s3 = new Student("MONICA", "19-XXXXX-3", 3.4f);

            Department d1 = new Department("Computer science" , "CS");
            Department d2 = new Department("Law", "LAW");
            s1.Dept = d1;
            s2.Dept = d2;
            s3.Dept = d1;

            s1.ShowDepartmentDetails();
            s2.ShowDepartmentDetails();

            d1.Name = "Computer and information systems";
            d1.Id = "CIS";
            s1.ShowDepartmentDetails();
            d1.PrintStudent();
            s3.Name = "AHMED";
            d2.PrintStudent();
        }
    }
}
