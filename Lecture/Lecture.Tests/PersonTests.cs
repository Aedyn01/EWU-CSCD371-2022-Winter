using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lecture.Tests;
    [TestClass]
    public class PersonTests
    {
        Person Person = new("Inigo Montoya");
        string UserName = "";
        string Password = "";

        [TestInitialize]
        public void Initialize()
        {
            Password = "YouKilledMyF@ther!";
            UserName = "Inigo.Montoya";
        }


        [TestMethod]
        public void Login_GivenInvalidPassword_Failure()
        {
            Password = "InvalidPwd";
            bool result = Person.Login(UserName, Password);
            Assert.IsFalse(result);

        }


        [TestMethod]
        public void Login_GivenValidUserNameAndPassword_Success()
        {
            bool success = Person.Login(UserName, Password);
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void Login_GivenInvalidUsername_Failure()
        {
            UserName = "MarkMichaelis";
            bool result = Person.Login(UserName, Password);
            Assert.IsFalse(result);
        }

        [TestMethod]
        // Can add ignore to tell compiler to ignore a specific test
        // usefull when test isnt being implemented yet, but you want to keep code
        // [Ignore("Ignored because not yet implemented")]
        // inside () you list a reason as to why its being ignored
        public void Name_GivenNameIsNull_ThrowException()
        {
            Person person = new Person("Inigo Montoya");

            // The ! at the end is used to override the compiler when given a warning for null assignments
            person.Name = null!;
        }
    }