using System;

namespace StudentClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student molly = new Student("Molly Cat", 1234);

            Console.WriteLine("molly's Name: {0}", molly.Name);
            Console.WriteLine("molly's Id Number: {0}", molly.IdNumber);
            molly.Score1 = 100;
            molly.Score2 = 80;
            Console.WriteLine("molly's Average Score: {0}", molly.AverageScore);
            Console.WriteLine("molly's High Score: {0}", molly.HighScore);

            Student bella = new Student("Bella");

            Console.WriteLine("bella's Id Number: {0}", bella.IdNumber);
            Console.WriteLine("bella's Name: {0}", bella.Name);

            Student kitkat = new Student("Kitkat");

            Console.WriteLine("kitkat's Id Number: {0}", kitkat.IdNumber);
            Console.WriteLine("kitkat's Name: {0}", kitkat.Name);


        }
    }
}
