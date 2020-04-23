using NUnit.Framework;
using System;

namespace CodingExercise.UnitTest
{
    public class AreStringsAnagramTest
    {
        private ICodingExercise _codingExercise;
        [SetUp]
        public void Setup()
        {
            _codingExercise = new CodingExercise();
        }

        [Test]
        public void CheckForEmptyStrings()
        {
            Assert.Throws<ArgumentNullException>(()=> _codingExercise.AreStringsAnagram("",""));
            Assert.Throws<ArgumentNullException>(()=> _codingExercise.AreStringsAnagram(null,""));
        }



        [Test]
        public void StringWithDifferentLengths()
        {
            Assert.IsFalse(_codingExercise.AreStringsAnagram("12345", "4321"));
        }


        [Test]
        public void CheckForValidCases()
        {
            Assert.IsTrue(_codingExercise.AreStringsAnagram("12345", "43215"));
            Assert.IsTrue(_codingExercise.AreStringsAnagram("Amiit", "itima"));
            Assert.IsTrue(_codingExercise.AreStringsAnagram("STONE", "notes"));
            Assert.IsTrue(_codingExercise.AreStringsAnagram("tones", "notes"));
        }

        [Test]
        public void CheckForInValidCases()
        {
            Assert.IsFalse(_codingExercise.AreStringsAnagram("12345", "48215"));
            Assert.IsFalse(_codingExercise.AreStringsAnagram("Amiit", "stima"));
            Assert.IsFalse(_codingExercise.AreStringsAnagram("STANE", "notes"));
            Assert.IsFalse(_codingExercise.AreStringsAnagram("pones", "notes"));
        }


    }
}