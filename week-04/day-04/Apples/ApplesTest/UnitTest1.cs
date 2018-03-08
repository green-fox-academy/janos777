using Apples;
using NUnit.Framework;

namespace ApplesTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestApple()
        {
        var app = new Apple();

        Assert.AreEqual("apple", app.GetApple());
        }
    }
}