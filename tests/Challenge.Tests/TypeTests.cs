using System;

using ChallengeApp;

using Xunit;

namespace Challenge.Tests
{
    public class TypeTests
    {
        [Fact]
        public void GetStudentReturnsDirreferentsObjects()
        {
            //arrange
            //var student1 = new Student("Miroslaw"); - ta metoda przypisania też się testuje prawidłowo
            //var student2 = new Student("Jaroslaw"); - ta metoda przypisania też się testuje prawidłowo
            var student1 = GetStudent("Miroslaw");
            var student2 = GetStudent("Jaroslaw");

            //act

            //assert
            Assert.Equal("Miroslaw", student1.FullName);
            Assert.Equal("Jaroslaw", student2.FullName);
            Assert.NotSame(student1, student2);
            Assert.False(Object.ReferenceEquals(student1, student2));
            Student.Equals(student1.FullName, student2.FullName);
        }

        private Student GetStudent(string fullName) => new(name: fullName);
    }
}