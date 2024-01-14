using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SchoolManagement;
using System;

namespace SchoolTest
{
    [TestClass]
    public class SchoolTest
    {
        Student stud = new Student();

        Subject sub = new Subject();

        Teacher teach = new Teacher();

        [TestCase("Maya", ExpectedResult = true)]
        [TestCase("Jovika", ExpectedResult = false)]
        [TestCase("Poornima", ExpectedResult = false)]
        [TestCase("Suresh", ExpectedResult = true)]
        public bool IsStudent(string search)
        {

            return stud.FindByName(search);

        }

        [TestCase("Hindi", ExpectedResult = false)]
        [TestCase("Mathematics", ExpectedResult = false)]
        [TestCase("Biology", ExpectedResult = true)]
        [TestCase("English", ExpectedResult = true)]
        public bool IsSubject(string subj)
        {

            return sub.FindByName(subj);

        }

        [TestCase("Vikram", ExpectedResult = true)]
        [TestCase("Vishnu", ExpectedResult = true)]
        [TestCase("Ananya", ExpectedResult = false)]
        [TestCase("Varma", ExpectedResult = false)]
        public bool IsTeacher(string t)
        {

            return teach.FindByName(t);

        }
    }
}
