using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabT3
{
    public class Student
    {
        public String name, id, department;
        public float cgpa;

        public Student(string name, string id, string department, float cgpa)
        {
           this.name= name;
           this.id= id;
           this.department= department;
           this.cgpa= cgpa;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("ID:" + id);
            Console.WriteLine("Department:" + department);
            Console.WriteLine("cgpa:" + cgpa);
        }

    }
}

