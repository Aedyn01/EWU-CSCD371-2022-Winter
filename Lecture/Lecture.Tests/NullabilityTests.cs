using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lecture.Tests;
    public class NullabilityTests
    {
        [TestMethod]
        public void NullDeclarationConcepts()
        {
            string? text = "Inigo Montoya";
            text = text.Length > 0 ? text : SomeMethod();
            int? number1 = null;
            Nullable<int> number2 = null;

            // if(text == null)
            // Use These for checking null:
            if (text is not null)
            {
                Assert.AreEqual(42, text.Length);
            }
            if (text is null) { }
            // if(text.equals(null))
            // if(string.ReferenceEquals(text, null))

            Assert.IsNotNull(text);
            Assert.IsNotNull(number1);
        }

        // Methods dont need a body, can just be declared
        private string SomeMethod() => "Princess Buttercup";
    }