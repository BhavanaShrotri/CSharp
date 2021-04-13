using System;
using Xunit;

namespace GradeBook.Test
{
     public delegate string WriteLogDelegate(string logMesage);

    public class TypeTest
    {
          int count =0;

          [Fact]
          public void WriteLogDelegateCanPointToMethod()
          {
               WriteLogDelegate log=ReturnMessage;
                log += ReturnMessage;
                log += IncrementCount;

              var result = log("Hello!");
              Assert.Equal(3,count);
          }

          string IncrementCount(string message)
          {
              count++;
              return message.ToLower();
          }

          string ReturnMessage(string message)
          {
              count++;
              return message;
          }



          [Fact]
          public void Test1()
          {
              var x=GetInt();
              SetInt(ref x);
              Assert.Equal(42,x);
          }

        private void SetInt(ref int z)
        {
            z=42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void StringBehaveLikeValueTypes()
        {
            String name="Bhavana";
            var upper=MakeUpperCase(name);

            Assert.Equal("BHAVANA",upper);
        }

        private string MakeUpperCase(string name)
        {
            return name.ToUpper();
        }

        [Fact]
        public void CSharpCanPassByRef()
        {

            var book =GetBook("Book 1");
            GetBookSetName(ref book,"New Name");

            Assert.Equal("New Name",book.Name);
        }

        private void GetBookSetName(ref InMemoryBook book, string name)
        {
            book=new InMemoryBook(name);
            book.Name=name;
        }

        [Fact]
        public void CSharpISPassByValue()
        {

            var book1 =GetBook("Book 1");
            GetBookSetName(book1,"New Name");

            Assert.Equal("Book 1",book1.Name);
        }

        private void GetBookSetName(InMemoryBook book1, string name)
        {
            book1=new InMemoryBook(name);
            book1.Name=name;
        }





        [Fact]
        public void CanSetNameFromReferance()
        {

            var book1 =GetBook("Book 1");
            SetName(book1,"New Name");

            Assert.Equal("New Name",book1.Name);
        }

        private void SetName(InMemoryBook book, string name)
        {
            book.Name =name;
        }

        [Fact]
        public void GetBookReturnDifferentObjects()
        {

            var book1 =GetBook("Book 1");
            var book2 =GetBook("Book 2");

            Assert.Equal("Book 1",book1.Name);
            Assert.Equal("Book 2",book2.Name);

            Assert.NotSame(book1,book2);
           
        }


         [Fact]
         public void TwoVarsCanReferanceSameObject()
        {

            var book1 =GetBook("Book 1");
            var book2 =book1;

            Assert.Same(book1,book2);
            Assert.True(Object.ReferenceEquals(book1,book2));

           
        }

        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
