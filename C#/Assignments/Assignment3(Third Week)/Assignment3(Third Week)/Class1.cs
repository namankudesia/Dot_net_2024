using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Third_Week_
{
    public class Student
    {
        private int rollNo;
        private string name;
        private string className;
        private string semester;
        private string branch;
        private int[] marks = new int[5];

        public Student(int rollNo, string name, string className, string semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.className = className;
            this.semester = semester;
            this.branch = branch;
        }
        public void GetMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void DisplayResult()
        {
            double totalMarks = 0;
            foreach (int mark in marks)
            {
                totalMarks += mark;
            }
            double average = totalMarks / 5;
            DisplayData();
            bool failed = false;
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                {
                    failed = true;
                    break;
                }
            }
            if (!failed && average < 50)
            {
                failed = true;
            }
            if (failed)
            {
                Console.WriteLine("Result: Failed");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }
        public void DisplayData()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {className}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
            Console.WriteLine("Marks:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {marks[i]}");
            }
        }
    }
}
