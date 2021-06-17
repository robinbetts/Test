using NUnit.Framework;
using WebApplication1.Pages;

namespace TestProject1
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
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Assert.Pass();
        }

        [Test]
        public void index_model_should()
        {
            var sut = new IndexModel(null);
            Assert.That(sut.Test(1), Is.EqualTo(2));
        }

        [Test]
        public void index_model_test_2_should()
        {
            var sut = new IndexModel(null);
            Assert.That(sut.Test2(1), Is.EqualTo(3));
        }
    }
}