using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Department
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private Student[] students;

        public void AddStudent(Student s)
        {
            students[studentCount] = s;
            StudentCount++;
        }

        public void PrintStudent()
        {
             foreach(Student s in students){
                 s.showInfo();
             }
          
        }

        public Student GetStudent(string id)
        {
            return null;
        }

        private int studentCount;
        public int StudentCount
        {
            get { return studentCount; }
            set { studentCount = value;}
            
         public Department () { 
             students = new Students [50];
         }

        public Department(string name, string id)
        {
            this.name = name;
            this.id = id;
            students = new Students [50];
        }
        public void showInfo()
        {
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("ID is: " + id);
        }
    }
}
