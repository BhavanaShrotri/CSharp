using System;
using Xunit;

namespace GradeBook.Test
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAvgGrades()
        {

           var book=new InMemoryBook("");
           book.AddGrade(23.80);
           book.AddGrade(30.55);
           book.AddGrade(40.60);

           var result=book.GetStatistics();

           Assert.Equal(31.6,result.Avg,1);
           Assert.Equal(40.6,result.High,1);
           Assert.Equal(23.8,result.Low,1);
           Assert.Equal('F',result.Letter);

        }
    }
}
