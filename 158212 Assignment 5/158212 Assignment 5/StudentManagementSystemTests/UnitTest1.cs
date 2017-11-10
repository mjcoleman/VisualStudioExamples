using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentManagementSystem;
using System.Collections.Generic;


namespace StudentManagementSystemTests {
    [TestClass]
    public class UnitTest1 {
       
        //***Constructor Tests***\\
        [TestMethod]
        public void TestUniversityConstructorNoNameNotNull() {
            University uni = new University();
            Assert.IsNotNull(uni);
        }

        [TestMethod]
        public void TestUniversityConstructorWithNameNotNull() {
            University uni = new University("My Uni");
            Assert.IsNotNull(uni);
        }

        [TestMethod]
        public void TestStudentConstructorIsNotNull() {
            Student s = new Student("Student Man", 1234, DateTime.ParseExact("26/10/1987", "dd/MM/yyyy", null));
            Assert.IsNotNull(s);
        }

        [TestMethod]
        public void TestPaperConstructorIsNotNull() {
            Paper p = new Paper("Paper 101", 100101, "Paper Man");
            Assert.IsNotNull(p);
        }


        //**Uni Class Function Tests**\\
        [TestMethod]
        public void TestIfUniCanAddAStudentThatAlreadyExistsInStudentDictionary() {
            University uni = new University();

            Student s = new Student("A Student", 111, DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null));
            Student s2 = new Student("A Student", 111, DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null));
            uni.AddNewStudent(s);

            bool expected, actual;
            expected = true;
            actual = uni.CheckIfStudentAlreadyExists(s2.ID);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIfUniCanAddANewStudent() {
            University uni = new University();

            Student s = new Student("A Student", 111, DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null));
            Student s2 = new Student("A Student", 112, DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null));
            uni.AddNewStudent(s);

            bool expected, actual;
            expected = false;
            actual = uni.CheckIfStudentAlreadyExists(s2.ID);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCannotEnrollAStudentDueToPaperConflict() {
            University uni = new University();
            Student s = new Student("A Student", 111, DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null));
            uni.AddNewStudent(s);
            Paper p = new Paper("Paper 101", 100101, "Paper Man");
            uni.AddNewPaper(p);
            uni.EnrollAStudentInAPaper(s, p);
            bool expected, actual;
            expected = false;
            actual = uni.EnrollAStudentInAPaper(s,p);
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIfUniCanAddAPaperThatAlreadyExistsInPaperDictionary() {
            University uni = new University();

            Paper p = new Paper("Paper 101", 100101, "Paper Man");
            Paper p2 = new Paper("Paper 101", 100101, "Paper Man");
            uni.AddNewPaper(p);

            bool expected, actual;
            expected = true;
            actual = uni.CheckIfPaperAlreadyExists(p2.PaperID, p2.PaperName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIfUniCanAddANewPaper() {
            University uni = new University();

            Paper p = new Paper("Paper 101", 100101, "Paper Man");
            Paper p2 = new Paper("Paper 102", 100102, "Paper Man");
            uni.AddNewPaper(p);

            bool expected, actual;
            expected = false;
            actual = uni.CheckIfPaperAlreadyExists(p2.PaperID, p2.PaperName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetUniName() {
            University uni = new University("A University");
            string expected, actual;
            expected = "A University";
            actual = uni.UniName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSetUniName() {
            University uni = new University("A University");
            uni.UniName = "B University";
            string expected, actual;
            expected = "B University";
            actual = uni.UniName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetPaperDictionary() {
            University uni = new University("A University");
            Paper p = new Paper("Paper 101", 100101, "Paper Man");
            uni.AddNewPaper(p);
            Dictionary<int, Paper> expected = new Dictionary<int, Paper> { };
            expected.Add(100101, p);

            Dictionary<int, Paper> actual = uni.Papers;

            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestGetStudentDictionary() {
            University uni = new University("A University");
            Student s = new Student("A Student", 111, DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null));
            uni.AddNewStudent(s);
            Dictionary<int, Student> expected = new Dictionary<int, Student> { };
            expected.Add(111, s);

            Dictionary<int, Student> actual = uni.Students;

            CollectionAssert.AreEqual(expected, actual);
       }


        //**Student Class Function Tests**\\
        [TestMethod]
        public void TestIfStudentIsAreadyEnrolledInPaper() {
            University uni = new University();
            Student s = new Student("A Student", 111, DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null));
            Paper p = new Paper("Paper 101", 100101, "Paper Man");
            uni.EnrollAStudentInAPaper(s, p);

            bool expected, actual;
            expected = false;
            actual = s.CanAddPaperToStudent(p);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGettingStudentName() {
            Student s = new Student("A Student", 111, DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null));

            string expected, actual;
            expected = "A Student";
            actual = s.Name;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSettingStudentName() {
            Student s = new Student("A Student", 111, DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null));
            s.Name = "B Student";
            string expected, actual;
            expected = "B Student";
            actual = s.Name;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGettingStudentID() {
            Student s = new Student("A Student", 111, DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null));
            int expected, actual;
            expected = 111;
            actual = s.ID;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSettingStudentID() {
            Student s = new Student("A Student", 111, DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null));
            s.ID = 222;
            int expected, actual;
            expected = 222;
            actual = s.ID;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGettingStudentDateOfBirth() {
            Student s = new Student("A Student", 111, DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null));
            DateTime expected, actual;
            expected = DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null);
            actual = s.Birthdate;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSettingStudentDateOfBirth() {
            Student s = new Student("A Student", 111, DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null));
            s.Birthdate = DateTime.ParseExact("21/11/1975", "dd/MM/yyyy", null);
            DateTime expected, actual;
            expected = DateTime.ParseExact("21/11/1975", "dd/MM/yyyy", null);
            actual = s.Birthdate;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGettingStudentEnrolledPapers() {
            Student s = new Student("A Student", 111, DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null));
            Paper p = new Paper("Paper 101", 100101, "Paper Man");
            s.AddPaperToStudent(p);

            Dictionary<int, Paper> expected = new Dictionary<int, Paper> { };
            expected.Add(100101, p);
            Dictionary<int, Paper> actual = s.EnrolledPapers;

            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestStudentToStringOverride() {
            Student s = new Student("A Student", 111, DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null));
            string expected, actual;
            expected = "111 - A Student";
            actual = s.ToString();

            Assert.AreEqual(expected, actual);
        }

        //**Paper Class Function Tests**\\
        [TestMethod]
        public void TestGettingPaperName() {
            Paper p = new Paper("Paper 101", 100101, "Paper Man");
            string expected, actual;
            expected = "Paper 101";
            actual = p.PaperName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSettingPaperName() {
            Paper p = new Paper("Paper 101", 100101, "Paper Man");
            p.PaperName = "Paper 102";
            string expected, actual;
            expected = "Paper 102";
            actual = p.PaperName;

            Assert.AreEqual(expected, actual);
        }

        

        [TestMethod]
        public void TestGettingPaperId() {
            Paper p = new Paper("Paper 101", 100101, "Paper Man");
            int expected, actual;
            expected = 100101;
            actual = p.PaperID;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSettingPaperId() {
            Paper p = new Paper("Paper 101", 100101, "Paper Man");
            p.PaperID = 200202;
            int expected, actual;
            expected = 200202;
            actual = p.PaperID;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGettingPaperCoordinator() {
            Paper p = new Paper("Paper 101", 100101, "Paper Man");
            string expected, actual;
            expected = "Paper Man";
            actual = p.PaperCoordinator;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSettingPaperCoordinator() {
            Paper p = new Paper("Paper 101", 100101, "Paper Man");
            p.PaperCoordinator = "Paper Woman";
            string expected, actual;
            expected = "Paper Woman";
            actual = p.PaperCoordinator;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestPaperToStringOverride() {
            Paper p = new Paper("Paper 101", 100101, "Paper Man");
            string expected, actual;
            expected = "100101 - Paper 101";
            actual = p.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGettingStudentsEnrolledInPaper() {
            Student s = new Student("A Student", 111, DateTime.ParseExact("20/10/1974", "dd/MM/yyyy", null));
            Paper p = new Paper("Paper 101", 100101, "Paper Man");
            p.AddStudentToPaper(s);

            Dictionary<int, Student> expected = new Dictionary<int,Student> { };
            expected.Add(111, s);
            Dictionary<int, Student> actual = p.StudentsInPaper;

            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
