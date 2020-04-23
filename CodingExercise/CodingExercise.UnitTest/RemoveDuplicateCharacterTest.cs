using NUnit.Framework;
using System;

namespace CodingExercise.UnitTest
{
    public class RemoveDuplicateCharacterTest
    {
        private ICodingExercise _codingExercise;
        [SetUp]
        public void Setup()
        {
            _codingExercise = new CodingExercise();
        }

        [Test]
        public void TestEmptyString()
        {
            var result = _codingExercise.RemoveDuplicateCharacterV1(string.Empty);
            Assert.IsEmpty(result);
        }

        [Test]
        public void TestNullString()
        {
            Assert.Throws<ArgumentNullException>(()=>_codingExercise.RemoveDuplicateCharacterV1(null));
        }

        [Test]
        public void TestRemoveDuplicate()
        {
            var result = _codingExercise.RemoveDuplicateCharacterV1("aabbcccddddeeeeeefgghijjjjj 1 2 123");
            Assert.IsTrue(string.Compare(result, "abcdefghij 123")==0);
        }

        [Test]
        public void TestRemoveDuplicateCaseInSensitive()
        {
            var result = _codingExercise.RemoveDuplicateCharacterV1("My Name is Amit Kumar - my name iS aMiT KUMaR");
            Assert.IsTrue(string.Compare(result, "My NaeistKur-") == 0);
        }

    }
}