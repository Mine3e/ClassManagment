using System;

namespace ClassManagment
{
    internal class Student
    {
        private static int _id;
        public int Id { get; private set; }
        public string Fullname { get; set; }
        public double Point { get; set; }

        public Student(string fullname, double point)
        {
            _id++;
            Id = _id;
            Fullname = fullname;
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id}, Fullname:{Fullname}, Point:{Point}");
        }
    }
}
