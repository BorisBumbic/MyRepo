using Common.services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Common.test
{
    [TestClass]
    public class StringService_CutString_Test
    {
        StringService a = new StringService();

        [TestMethod]
        public void should_add_dots_when_cut_made_test()
        {
            Assert.AreEqual("acad...", a.CutString("academy", 4));
        }

        [TestMethod]
        public void should_return_null_if_string_null()
        {
            Assert.AreEqual("", a.CutString("academy", 0));
        }

        [TestMethod]
        public void should_return_original_string()
        {
            Assert.AreEqual("academy", a.CutString("academy", 100));
        }
    }
}
