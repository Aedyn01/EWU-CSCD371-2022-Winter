﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
    
{
    [TestClass]
    public class LogFactoryTests
    {
        [TestMethod]
        public void LogFactory_ClassNameAssigned_True()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();
            // Act
            logFactory.ConfigureFileLogger("this is a test");
            var baseLogger = logFactory.CreateLogger("fileLogger");
            // Assert
            Assert.AreEqual<string>(baseLogger.Name, "fileLogger");
        }

        [TestMethod]
        public void LogFactory_ConfigureFileLoggerUsesPrivateMember_True()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();

            // Act
            logFactory.ConfigureFileLogger("//this_is_a_path");
            var logger = logFactory.CreateLogger("fileLogger");
            
            // Assert
            Assert.AreEqual<string>(logger.FilePath!, "//this_is_a_path");

        }

        [TestMethod]
        public void LogFactory_IfFileLoggerNotConfiguredReturnNull_True()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();

            // Act
            var logger = logFactory.CreateLogger("fileLogger");

            // Assert
            Assert.IsNull(logger);

        }
    }
}