using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using _158212_Assignment_4;

namespace Assignment4Tests {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestListOfLongestWords() {
            List<string> expected = new List<string> { "Quick", "Brown", "Jumps" };
            TextAnalyst frm = new TextAnalyst();
            List<string> actual = frm.GetLongestWords(new List<string> { "The", "Quick", "Brown", "Quick", "Fox", "Jumps", "Over", "The", "Lazy", "Dog" });
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod] 
        public void TestListOfLongestWordsWithWordsTheSameLength(){
            List<string>expected = new List<string>{"The", "Fox", "Dog"};
            TextAnalyst frm = new TextAnalyst();
            List<string>actual = frm.GetLongestWords(new List<string>{"The", "Fox", "Dog"});
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestListOfShortestWords() {
            List<string> expected = new List<string> { "The", "Fox", "Dog" };
            TextAnalyst frm = new TextAnalyst();
            List<string> actual = frm.GetShortestWords(new List<string> { "The", "Quick", "Brown", "Quick", "Fox", "Jumps", "Over", "The", "Lazy", "Dog" });
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestListOfShortestWordsWithWordsTheSameLength() {
            List<string> expected = new List<string> { "The", "Cat", "And", "Dog" };
            TextAnalyst frm = new TextAnalyst();
            List<string> actual = frm.GetShortestWords(new List<string> { "The", "Cat", "And", "Dog"});
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestAverageValueOfLengthOfWordsInAList() {
            double expected, actual;
            TextAnalyst frm = new TextAnalyst();

            expected = 4.0;
            actual = frm.GetAverageWordLength(new List<string> { "The", "Quick", "Brown", "Quick", "Fox", "Jumps", "Over", "The", "Lazy", "Dog" });
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetListOfUniqueWordsFromList() {
            List<string> expected = new List<string> { "The", "Quick", "Brown", "Fox", "Jumps", "Over", "Lazy", "Dog" };
            TextAnalyst frm = new TextAnalyst();

            List<string> actual = frm.GetUniqueWords(new List<string> { "The", "Quick", "Brown", "Quick", "Fox", "Jumps", "Over", "The", "Lazy", "Dog" });
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCountOfWordsOfCertainLength() {
            List<string> expected = new List<string>{ "Quick", "Brown", "Jumps"};
            TextAnalyst frm = new TextAnalyst();

            List<string> actual = frm.GetWordsOfLength(5, new List<string> { "The", "Quick", "Brown", "Quick", "Fox", "Jumps", "Over", "The", "Lazy", "Dog" });
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNumberOfWordsOfACertainLengthInDocumentSameCase() {
            int expected, actual;
            expected = 2;
            TextAnalyst frm = new TextAnalyst();
            actual = frm.GetNumberOfOccurancesOfWordInWordList("The", new List<string> { "The", "Quick", "Brown", "Quick", "Fox", "Jumps", "Over", "The", "Lazy", "Dog" });
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNumberOfWordsOfACertainLengthInDocumentDifferentCase() {
            int expected, actual;
            expected = 2;
            TextAnalyst frm = new TextAnalyst();
            actual = frm.GetNumberOfOccurancesOfWordInWordList("The", new List<string> { "the", "Quick", "Brown", "Quick", "Fox", "Jumps", "Over", "The", "Lazy", "Dog" });
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestMostCommonWordsInAList() {
            List<string> expected = new List<string> { "The", "Quick" };
            TextAnalyst frm = new TextAnalyst();
            List<string> actual = frm.GetMostCommonWords(new List<string> { "The", "Quick", "Brown", "Quick", "Fox", "Jumps", "Over", "The", "Lazy", "Dog" });
            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
