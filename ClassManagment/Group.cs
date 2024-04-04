using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagment
{
    internal class Group
    {
        public  string GroupNo {  get; set; }
        private  int _studentLimit;
        public  int StudentLimit
        {
            get { return _studentLimit; }
            private set
            {
                if(value>=5 && value<=18)
                {
                    _studentLimit = value;
                }
                else
                {
                    Console.WriteLine("Duzgun deyer daxil edin:");
                }
            }
        }
        private Student[] Students;
        private int _studentCount;
        public Group(string groupNo, int studentLimit)
        {
            if(!CheckGroupNo(groupNo))
            {
                Console.WriteLine("Duzgun daxil edin:");
            }
            GroupNo = groupNo;
            StudentLimit = studentLimit;
            Students = new Student[studentLimit];
        }
        public static bool CheckGroupNo(string groupNo)
        {

            if (groupNo.Length != 5)
            {
                return false;
            }

            bool isUpper = Char.IsUpper(groupNo[0]) && Char.IsUpper(groupNo[1]);
            bool isDigit = Char.IsDigit(groupNo[2]) && Char.IsDigit(groupNo[3]) && Char.IsDigit(groupNo[4]);

            return isUpper && isDigit;
        }
        public void AddStudent(Student student)
        {
            if(_studentCount< StudentLimit)
            {
                Students[_studentCount] = student;
                _studentCount++;
            }
            else
            {
                Console.WriteLine("Group doludur.");
            }
        }
        public Student[] GetAllStudents()
        {
            return Students;
        }
        public Student GetStudent(int id)
        {
            foreach (var student in Students)
            {
                if (student != null && student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
