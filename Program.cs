using System;
using System.Collections.Generic;
using System.Threading;
using UniversityGradingSystem.Entity;

namespace UniversityGradingSystem
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool isLoggedIn = true;
            string selectedProcess;
            string userName ;
            string password;

            Console.WriteLine("Welcome to the student exam information system");
            while (isLoggedIn)
            {
                Console.WriteLine("Please select the action you want : Teacher Log in(1) / Student Log in(2)");
                selectedProcess = Console.ReadLine().ToLower();
                Console.Clear();

                switch (selectedProcess)
                {
                    case "1":
                        Console.WriteLine($"Welcome");
                        Console.WriteLine("------------------------------------");
                        TeacherLogIn();
                        break;
                    case "2":
                        Console.WriteLine($"Welcome back, please enter your information!");
                        Console.WriteLine("--------------------------------------------");
                        StudentLogIn();
                        break;
                    default:
                        Console.WriteLine("Wrong choice, please choose the right one!");
                        continue;
                }

                Console.WriteLine("Press 'q' to quit");
                string continueChoice = Console.ReadLine().ToLower();

                if (continueChoice == "q")
                    break;
            }
        }
        static void StudentLogIn()
        {
            int blockCount = 0;
            bool accessstudent = true;
            string studentUsername;
            string studentPassword;
            List<Students> students = new List<Students>();
            students.Add(new Students("student1", "password1"));
            students.Add(new Students("student2", "password2"));
            students.Add(new Students("student3", "password3"));   //istediğimiz kadar öğrenci ekleyebiliriz
            students.Add(new Students("student4", "password4"));
            students.Add(new Students("student5", "password5"));
            while (accessstudent)
            {
                Console.WriteLine("Please write own student username and password!");
                studentUsername = Console.ReadLine();
                Console.WriteLine("Student username :" + studentUsername);
                studentPassword = Console.ReadLine();
                Console.WriteLine("Student password :" + studentPassword);
                foreach (var student in students)
                {
                    if (student.Username == studentUsername && student.Password == studentPassword)
                    {
                        Console.Clear();
                        Console.WriteLine("Access Approved");
                        student.PrintStudentNotes();
                        accessstudent = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Access Denied! Try Again.");
                        blockCount++;
                        if (blockCount >= 3)
                        {
                            Console.WriteLine("Wrong limit exceeded");
                            Thread.Sleep(3000);
                            Environment.Exit(1);
                        }
                        blockCount = 0;
                    }
                }
            }
        }
        static void TeacherLogIn()
        {
            int blockCount = 0;
            bool accessTeacher = true;
            string teacherUsername;
            string teacherPassword;
            List<Teachers> teachers = new List<Teachers>();
            teachers.Add(new Teachers("teacher1", "password11"));
            teachers.Add(new Teachers("teacher2", "password12"));
            while (accessTeacher)
            {
                Console.WriteLine("Please write own teacher username and password!");
                teacherUsername = Console.ReadLine();
                Console.WriteLine("Teacher username:" + teacherUsername);
                teacherPassword = Console.ReadLine();
                Console.WriteLine("Teacher password" + teacherPassword);
                foreach (var teacher in teachers)
                {
                    if (teacher.Username == teacherUsername && teacher.Password == teacherPassword)
                    {
                        Console.Clear();
                        Console.WriteLine("Access Approved");
                        accessTeacher = false;
                        teacher.TeacherSendMailFromTheirFamily();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Access Denied! Try Again.");
                        blockCount++;
                        if (blockCount >= 3)
                        {
                            Console.WriteLine("Wrong limit exceeded");
                            Thread.Sleep(3000);
                            Environment.Exit(1);
                        }
                        blockCount = 0;
                    }
                }
            }

        }
    }
}
