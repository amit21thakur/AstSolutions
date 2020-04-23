using NUnit.Framework;

namespace CodingExercise.UnitTest
{
    public class IsAustralianMobileNumberValidTest
    {
        private ICodingExercise _codingExercise;
        [SetUp]
        public void Setup()
        {
            _codingExercise = new CodingExercise();
        }

        [Test]
        public void TestNumbersStartingWithZero()
        {
            Assert.IsTrue(_codingExercise.IsAustralianMobileNumberValid("0403312383"));
        }

        [Test]
        public void NumbersStartingWithInternationalCode()
        {
            Assert.IsTrue(_codingExercise.IsAustralianMobileNumberValid("+61403312383"));
        }

        [Test]
        public void ValidNumbersWithSpacing()
        {
            Assert.IsTrue(_codingExercise.IsAustralianMobileNumberValid("+61403 312 383"));
            Assert.IsTrue(_codingExercise.IsAustralianMobileNumberValid("04 03 312 383"));
            Assert.IsTrue(_codingExercise.IsAustralianMobileNumberValid("0403 312383"));
            Assert.IsTrue(_codingExercise.IsAustralianMobileNumberValid("040331 2383"));
        }

        [Test]
        public void TestInvalidNumbers()
        {
            Assert.IsFalse(_codingExercise.IsAustralianMobileNumberValid("+65403 312 383"));
            Assert.IsFalse(_codingExercise.IsAustralianMobileNumberValid("+6 14 03 312 383"));
            Assert.IsFalse(_codingExercise.IsAustralianMobileNumberValid("02 03 312 383"));
            Assert.IsFalse(_codingExercise.IsAustralianMobileNumberValid("0403 32383"));
            Assert.IsFalse(_codingExercise.IsAustralianMobileNumberValid("040331 23834"));
            Assert.IsFalse(_codingExercise.IsAustralianMobileNumberValid("04033123834"));
            Assert.IsFalse(_codingExercise.IsAustralianMobileNumberValid("+65403312383"));
        }

    }
}