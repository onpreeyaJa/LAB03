using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB03
{
    internal class Student
    {
        private string _name;
        private string _id;
        private int _birthYear;
        private double _height;
        private double _grade;
        private string _major;

        public string Name
        {
            get { return this._name; }
        }
        public string ID
        {
            get { return this._id; }
        }
        public int Birthyear
        {
            get { return this._birthYear; }
        }
        public double Height
        {
            get { return this._height; }
        }
        public double Grade
        {
            get { return this._grade; }
        }
        public string Major
        {
            get { return this._major; }
        }


        //constructor
        public Student(string name, string ID, int birthYear, double Height, double Grade, string Major)
        {
            this._name = name;
            this._birthYear = birthYear;
            this._id = ID;
            this._height = Height;
            this._grade = Grade;
            this._major = Major;
        }

    }
}
