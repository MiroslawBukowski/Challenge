using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public class Student
    {
        public List<decimal> grades = new List<decimal>();
        public List<string> names = new List<string>();
        public List<int> ages = new List<int>(); 

        public string Name { get; set; } // zmieniono Name na name oraz public na private

        //public Student(string FullName)
        //{
        //    this.FullNames.Add(FullName);
        //}

        public void AddGrade(string mark)
        {
            if (decimal.TryParse(mark, out decimal grade))
            {
                this.grades.Add(grade);
                
                Console.WriteLine($"Grade added to Student's grades list: {grade} ");              
            }
            else
            {
                Console.WriteLine($"Grade entered incorectly, try again!");
            }
        }
        public void AddGrade(decimal grade)
        {
            this.grades.Add(grade);
        }

        public string FullName
        {
            get
            {
                return this.Name;
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0M;
            result.High = decimal.MinValue;
            result.Low = decimal.MaxValue;

            foreach (var grade in this.grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /= grades.Count;
            return result;
        }

        //public void AddAge(int age, object student)
        //{
        //    new Student(names: FullName).AddAge(age);
        //    var ages = new List<int>();
        //    ages.Add(age);
        //    Console.WriteLine("Age {age} added to the ages list");
        //}

        private void AddAge(int age)
        {
            throw new NotImplementedException();
        }
    }
}
