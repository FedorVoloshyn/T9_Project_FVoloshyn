using NUnit.Framework;
using System.Collections.Generic;

namespace T9_Project_FVoloshyn.Tests
{
    [TestFixture]
    class Test_T9Encoder
    {
        [Test]
        public void SimpleTextTest1()
        {
            T9Engine t9engine = new T9Engine();

            string input = "hi";
            string output = "44 444";

            string result = t9engine.TextToNumber(input);

            Assert.AreEqual(result, output);
        }

        [Test]
        public void SimpleTextTest2()
        {
            T9Engine t9engine = new T9Engine();

            string input = "yes";
            string output = "999337777";

            string result = t9engine.TextToNumber(input);

            Assert.AreEqual(result, output);
        }

        [Test]
        public void SimpleTextTest3()
        {
            T9Engine t9engine = new T9Engine();

            string input = "foo  bar";
            string output = "333666 6660 022 2777";

            string result = t9engine.TextToNumber(input);

            Assert.AreEqual(result, output);
        }

        [Test]
        public void SimpleTextTest4()
        {
            T9Engine t9engine = new T9Engine();

            string input = "hello world";
            string output = "4433555 555666096667775553";

            string result = t9engine.TextToNumber(input);

            Assert.AreEqual(result, output);
        }

        [Test]
        public void EmptyStringTest1()
        {
            T9Engine t9engine = new T9Engine();

            string input = "";
            string output = "";

            string result = t9engine.TextToNumber(input);

            Assert.AreEqual(result, output);
        }
    }
}
