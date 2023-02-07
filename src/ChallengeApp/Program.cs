using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ChallengeApp
{
    class Program
    {
        public string? mark;
        public decimal grade;
        public int age;
        public static decimal result;
        private static object grades;

        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            int i;
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("Give FullName of student in the following formatand then press enter key  (first letters should be capital, name and surname separated by space char) :");
                string FullName = Console.ReadLine();

                {
                    Regex checkFullName = new(@"^[A-Z]{1}[a-z\u00c0-\u017e]{2,}\s[A-Z]{1}[a-z\u00c0-\u017e]{2,}$"); //u00c0-\u017e
                                                                                                                    // Regex checkage = new(@"^[0-9]{2}");
                    if (!checkFullName.IsMatch(FullName) | FullName == null)
                    {
                        Console.WriteLine($"Student's FullName can not be empty, contain digits or is in incorect format, try agian!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Student's FullName is: {FullName}\n");
                    }
                }

                var student = new Student(FullName: FullName);
                Console.WriteLine("Input age of student in the following format: dd");
                string? a = Console.ReadLine();
                Regex checkage = new(@"^[1-9]{2,}$");
                if (!checkage.IsMatch(input: a)) // | a == null)
                {
                    Console.WriteLine("Entered age is missing, in incorrect format or out of range - conversion failed!");
                    break;
                }
                else
                {
                    if (int.TryParse(a, out int age))
                    {
                     
                        var ages = new List<int>();
                        ages.Add(age);
                    }
                    else
                    {
                        throw ArgumentException("Invalid argument!");
                    }
                }

                Console.WriteLine("Input grade achived by student in the following format: d,dd");
                var inputMark = Console.ReadLine(); //zmieniony typ string? na var
                //var markwithsign = Console.ReadLine();
                Regex check_grade = new(@"^[1-6]{1}\,[0-9]{2,} $"); // | " ^[1 - 5] { 1 } + $" | "^[2-6]{1} '-' $");
                Regex check_markwithsign = new(@"[1-5]{1}\.- $ | [2-6]{1}\.+$");
                
                
                
                if (inputMark == "q")
                {
                    break;
                }
                    if (!check_grade.IsMatch(input: inputMark))
                    {
                    Console.WriteLine("Entered grade is missing, in incorrect format or out of range - conversion failed!");
                    }
                    else
                     
                     if (decimal.TryParse(inputMark, out decimal grade))
                    { 
                         student.AddGrade(grade); 
                    }
                    if(!check_markwithsign.IsMatch(input: inputMark))
                     {
                        Console.WriteLine("Entered grade is incorect format!");
                     }           
                    else
                    {
                        student.AddGrade(inputMark);
                    }

                student.AddGrade(inputMark);
                Console.WriteLine(value: $"Student {student.FullNames[i]} is at age :");
                var stat = student.GetStatistics();
                Console.WriteLine(value: $"Grades achived by student {student.FullNames[i]}  are: \n ");
                Console.WriteLine($"The Min value of these grades  is : {stat.Low:N2}");
                Console.WriteLine($"The Max value of these grades  is : {stat.High:N2}");
                Console.WriteLine($"The Average of these grades  is : {stat.Average:N3}");
                Console.WriteLine("Total grade is:  ");
            }
        }
        private static Exception ArgumentException(string v)
        {
            throw new NotImplementedException();
        }
    }
}








        
        
    



