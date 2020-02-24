using NUnit.Framework;
using Problems;
namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase("hello", "5,1:hello" )]
        [TestCase("", "0,0:" )]
        [TestCase("what      ... did you say??", "27,5:what      ... did you say??" )]
        [TestCase("what is happening?", "18,3:what is happening?" )]
        [TestCase("I need sleep, I need sleep!", "27,6:I need sleep, I need sleep!" )]
        [TestCase("This is not so fun", "18,5:This is not so fun" )]

      public void  TestMethod(string input, string output){
          Program Program = new Program();
          Assert.AreEqual(Program.Prefix(input), output);
      }



        //[Test]
        //public void Test1()
        //{
          //  string thing = Program.Prefix("hello");
            //Assert.AreEqual("5,1:hello", thing);
            
            
        //}
        //[Test]
        //public void Test2()
        //{
          //  string thing = Program.Prefix("");
            //Assert.AreEqual("0,0:", thing);
            
            
        //}
        //[Test]
        //public void Test3()
        //{
          //  string thing = Program.Prefix("what      ... did you say??");
            //Assert.AreEqual("27,5:what      ... did you say??", thing);
            
            
        //}
    }
}