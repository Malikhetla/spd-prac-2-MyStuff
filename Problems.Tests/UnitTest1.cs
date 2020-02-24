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

        [Test]
        public void Test1()
        {
            string thing = Program.Prefix("hello");
            Assert.AreEqual("5,1:hello", thing);
            
            
        }
        [Test]
        public void Test2()
        {
            string thing = Program.Prefix("");
            Assert.AreEqual("0,0:", thing);
            
            
        }
        [Test]
        public void Test3()
        {
            string thing = Program.Prefix("what      ... did you say??");
            Assert.AreEqual("27,5:what      ... did you say??", thing);
            
            
        }
    }
}