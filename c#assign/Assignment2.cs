using System;

namespace Assignment1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rollnum;
            int marks1, marks2, marks3, marks4, marks5;

            Console.WriteLine("Enter 1 st Student Roll Number :");
            rollnum = Convert.ToInt32(Console.ReadLine());
           
            //for accepting marks
            Console.WriteLine("Enter 1 st student Marks : ");
            marks1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2 nd student Marks : ");
            marks2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3 rd student Marks : ");
            marks3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 4 th student Marks : ");
            marks4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 5 th student Marks : ");
            marks5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maximum marks are:"+Math.Max(marks1,marks2,marks3,marks4,marks5));
            Console.ReadKey();
        }
    }
}
