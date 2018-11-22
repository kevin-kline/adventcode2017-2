using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        const string TEST_FILEPATH = "C:/Users/Brave/source/repos/adventcode2017-2/adventcode2017-2/resources/checkSumTestInput.txt";
        const int TEST_STRING_LIST_COUNT = 3;
        const int TEST_CHECKSUM = 18;

        [TestMethod]
        public void TestStringListCount()
        {
            Assert.AreEqual(TEST_STRING_LIST_COUNT, adventcode2017_2.Program.getStringListFromFile(TEST_FILEPATH).Count);
        }
        [TestMethod]
        public void TestCheckSumResult()
        {
            List<string> stringList = adventcode2017_2.Program.getStringListFromFile(TEST_FILEPATH);
            Assert.AreEqual(TEST_CHECKSUM, adventcode2017_2.Program.getCheckSumFromStringList(stringList));
        }
    }
}
