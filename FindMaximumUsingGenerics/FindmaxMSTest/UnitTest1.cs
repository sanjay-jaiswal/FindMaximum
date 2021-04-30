using FindMaximumUsingGenerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindmaxMSTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// It Will return max integer.
        /// </summary>
        [TestMethod]
        public void GivenThreeIntegerValues_MaxATFirstPosition_ShouldReturnMax()
        {
            int maxVal = GenericToFindMax<int>.FindMax(50, 30, 20);
            Assert.AreEqual(50, maxVal);
        }

        /// <summary>
        /// It Will return max integer.
        /// </summary>
        [TestMethod]
        public void GivenThreeIntegerValues_MaxATSecondPosition_ShouldReturnMax()
        {
            int maxVal= GenericToFindMax<int>.FindMax(30, 50, 20);
            Assert.AreEqual(50, maxVal);
        }

        /// <summary>
        /// It Will return max integer.
        /// </summary>
        [TestMethod]
        public void GivenThreeIntegerValues_MaxATThirdPosition_ShouldReturnMax()
        {
            int maxVal = GenericToFindMax<int>.FindMax(20, 30, 50);
            Assert.AreEqual(50, maxVal);
        }

        /// <summary>
        ///It will return max float value.
        /// </summary>
        [TestMethod]
        public void GivenThreeFloatValues_MaxATFirstPosition_ShouldReturnMax()
        {
            float maxVal = GenericToFindMax<float>.FindMax(50.5f, 30.5f, 20.5f);
            Assert.AreEqual(50.5f, maxVal);
        }

        /// <summary>
        /// It will return max float value
        /// </summary>
        [TestMethod]
        public void GivenThreeFloatValues_MaxATSecondPosition_ShouldReturnMax()
        {
            float maxVal = GenericToFindMax<float>.FindMax(30.5f, 50.5f, 20.5f);
            Assert.AreEqual(50.5f, maxVal);
        }

        /// <summary>
        /// Will return max float value.
        /// </summary>
        [TestMethod]
        public void GivenThreeFloatValues_MaxATThirdPosition_ShouldReturnMax()
        {
            float maxVal = GenericToFindMax<float>.FindMax(20.5f, 30.5f, 50.5f);
            Assert.AreEqual(50.5f, maxVal);
        }

        /// <summary>
        /// Given max string at 2nd position should return max string.
        /// </summary>
        [TestMethod]
        public void GivenThreeStringValues_MaxATSecondPosition_ShouldReturnMax()
        {
            string maxVal = GenericToFindMax<string>.FindMax("Sanju","Xerox","Bridgelabz");
            Assert.AreEqual("Xerox", maxVal);
        }
    }
}
