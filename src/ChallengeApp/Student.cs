using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public class Student
    {
        public List<decimal> grades = new List<decimal>();
        public List<string> FullNames = new List<string>();
        public List<int> ages = new List<int>();

        public string Name { get; set; } // zmieniono Name na name oraz public na private

        public Student(string FullName)
        {
            this.FullNames.Add(FullName);
        }

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
        public void ChangeGrade(string inputMark)
        {

            var markwithsign = inputMark switch
            {
                "1+" => 1.5M,
                "2+" => 2.5M,
                "3+" => 3.5M,
                "4+" => 4.5M,
                "5+" => 5.5M,
                "6-" => 5.75M,
                "5-" => 4.75M,
                "4-" => 3.75M,
                "3-" => 2.75M,
                "2-" => 1.75M,
                "1" or "2" or "3" or"4" or "5" or "6" => decimal.Parse(inputMark),
                _=>throw new ArgumentException("Grade out of range") 
            };
            this.grades.Add(markwithsign);
            
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

        public object age { get; internal set; }

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

        public int AddAge(int age, object student)
        {
            new Student(FullName: FullName).AddAge(age, student);
            var ages = new List<int>();
            ages.Add(age);
            return age;
            Console.WriteLine("Age {age} added to the ages list");
        }

        private void AddAge(int age)
        {
            Console.WriteLine("Entered age is null or in incorect format!");
            //throw new NotImplementedException();
            throw new ArgumentException("Argument age is out of range");
            
        }
    }
}

