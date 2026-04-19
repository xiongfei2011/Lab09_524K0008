using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath;

namespace BasicMathTests
{
    [TestClass]
    public class BasicMathsTests
    {
        [TestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(-1, -1, -2)]
        [DataRow(0, 0, 0)]
        [DataRow(int.MaxValue, 1, int.MinValue)]
        [DataRow(int.MinValue, -1, int.MaxValue)]
        public void Test_AddMV(int a, int b, int expected)
        {
            BasicMaths bm = new BasicMaths();
            int actual = bm.Add(a, b);
            Console.WriteLine($"DEBUG: {a} + {b} = {actual}");
            Assert.AreEqual(expected, actual);
        }
    }
}