using System.Globalization;

namespace ClassManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student;
            int choise;
            do
            {
                Console.WriteLine( "Menu:");
                Console.WriteLine("1. Show info");
                Console.WriteLine("2. Create new group");
                int.TryParse(Console.ReadLine(), out choise);
                switch (choise)
                {
                    case 0:
                        Console.WriteLine("Proqram bitdi.");
                        break;
                    case 1:
                        Console.WriteLine("Fullname:");
                        string fullname=Console.ReadLine();
                        string pointStr = "";
                        double point;
                        do
                        {
                            Console.WriteLine("Point:");
                            pointStr= Console.ReadLine();
                        }while(!double.TryParse(pointStr, out point));
                        student = new Student(fullname,point);
                        student.ShowInfo();
                        break;
                    case 2:
                        Console.WriteLine("GroupNo:");
                        string groupNo= Console.ReadLine();
                        string studentLimitStr = "";
                        int studentLimit;
                        do
                        {
                            Console.WriteLine("StudentLimit:");
                            studentLimitStr = Console.ReadLine();
                        }while(!int.TryParse(studentLimitStr, out studentLimit));
                        Group group = new Group(groupNo, studentLimit);
                        int ch;
                        do
                        {
                            Console.WriteLine("1. Show all students");
                            Console.WriteLine("2. Get student by id");
                            Console.WriteLine("3. Add student");
                            Console.WriteLine("0. Quit");
                            int.TryParse(Console.ReadLine(), out ch);
                            switch (ch)
                            {
                                case 0:
                                    Console.WriteLine("Proqram sonlandi.");
                                    break;
                                case 1:
                                    Console.WriteLine("Butun telebeler.");
                                    Student[] students = group.GetAllStudents();
                                    foreach (var i in students)
                                    {
                                        if (i != null)
                                        {
                                            i.ShowInfo();
                                        }
                                    }
                                    break;
                                case 2:
                                    string idStr = "";
                                    int id;
                                    do
                                    {
                                        Console.WriteLine("Id:");
                                        idStr = Console.ReadLine();
                                    }while(!int.TryParse(idStr, out id));
                                    Student fstudent=group.GetStudent(id);
                                    if(fstudent != null)
                                    {
                                        fstudent.ShowInfo();
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Fullname:");
                                    string studentName = Console.ReadLine();
                                    string studentPointStr = "";
                                    double studentPoint;
                                    do
                                    {
                                        Console.WriteLine("Point:");
                                        studentPointStr = Console.ReadLine();
                                    } while (!double.TryParse(studentPointStr, out studentPoint));
                                    group.AddStudent(new Student(studentName, studentPoint));
                                    break;
                                default:
                                    break;

                            }
                        } while (ch != 0);
                        break;
                    default:
                        break;
                }
            }while(choise!=0); 

        }
    }
}
