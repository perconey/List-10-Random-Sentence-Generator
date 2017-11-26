using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sentence_Generator.Logic;

namespace SentenceGeneratorUnitTests
{
    [TestClass]
    public class SentenceGeneratorTests
    {
        /// <summary>
        /// Returns positive test result if in table VERBS , ID -> 2 is a "look" string
        /// </summary>
        [TestMethod]
        public void DatabaseWordsImporterStringImportTest()
        {
            //Arrange
            DataBaseWordsImporter imp = new DataBaseWordsImporter();

            //Act
            var expected = "look";
            var actual = imp.ImportedString;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
