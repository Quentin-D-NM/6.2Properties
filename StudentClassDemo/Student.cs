using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassDemo
{
    class Student
    {
        private int _score1;
        private int _score2;
       
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public double AverageScore { get; set; }
        public int Score1 { get { return _score1; } set { _score1 = value;  UpdateAverageScore(); } }
        public int Score2 { get { return _score2; } set { _score2 = value; UpdateAverageScore(); } }
        public double HighScore { 
            get
            {
                if (Score1 > Score2)
                {
                    return Score1;
                }
                else
                {
                    return Score2;
                }
            } 
        }


        public Student() : this("Unknown", -1)
        {

        }

        public Student(int newIdNumber) : this("Unknown", newIdNumber)
        {
        }

        public Student(string newName) : this(newName, -1)
        {
        }

        public Student(string newName, int newIdNumber) 
        {
            this.Name = newName;
            this.IdNumber = newIdNumber.ToString(); 
        }

        public static void DoStuff()
        {
            Student molly = new Student();
            molly.Name = "Molly";
            molly.IdNumber = 42.ToString();
            Console.WriteLine(molly.Name);
            Console.WriteLine(molly.IdNumber);

            Student someStudent = new Student();
            Console.WriteLine("someStudent: {0}", someStudent.Name);
            Console.WriteLine("someStudent: {0}", someStudent.IdNumber);



        }

        private void UpdateAverageScore()
        {
            AverageScore = (Score1 + Score2) / 2; 
        }


    }
}
