﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Student
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
        private float cgpa;

        public float CGPA
        {
            get { return cgpa;}
            set {cgpa = value;}
        }

        private Department dept;

        public Department Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        public Student() { 
        }
        public Student(string name, string id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }
        public void showInfo()
        {
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("ID is: " + id);
            Console.WriteLine("CGPA is: " + cgpa);
        }

        public void ShowDepartmentDetails()
        {
            showInfo();
            dept.showInfo();
        }
        
    }
}
