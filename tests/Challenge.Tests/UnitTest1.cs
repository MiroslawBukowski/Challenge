using ChallengeApp;

using Xunit;

namespace Challenge.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var student = new Student("Miroslaw");
            student.AddGrade(2.75M);
            student.AddGrade(3.51M);
            student.AddGrade(4.25M);

            //act
            var result = student.GetStatistics();

            //assert
            Assert.Equal(2.75M, result.Low);
            Assert.Equal(4.25M, result.High);
            Assert.Equal(3.50M, result.Average, 2);
        }
    }
}
