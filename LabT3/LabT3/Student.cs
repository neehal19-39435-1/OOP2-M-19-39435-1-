using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabT3
{
    public class Student
    {
        private string name, id, department;
        private float cgpa;

        public string Name
        {
            get { return name; }
            set { name = value;}
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Dept
        {
            get { return department; }
            set { department = value; }
        }

        public float CGPA
        {
            get { return cgpa; }
            set { cgpa = value; }
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

