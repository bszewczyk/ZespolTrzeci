using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingProject.Tests
{
    [TestClass]
    public class MessageTest
    {

        private static const FBUser SOME_FBUSER_A = new FBUser("UserA");
        private static const FBUser SOME_FBUSER_B = new FBUser("UserB");
        private static const String SOME_10_CHAR_LONG_STRING = "1234567890";
        private static const int MINIMUM_CONTENT_LENGTH = 5;

        [TestMethod]
        public void MessageMustHaveRecipient()
        {
            // when
            UserMessage testObj = new UserMessage(SOME_FBUSER_A, SOME_FBUSER_B, SOME_10_CHAR_LONG_STRING);
            // then
            Assert.IsNotNull(testObj.Recipient, "UserMessage must be assigned the Recipient passed in constructor.");
        }

        [TestMethod]
        public void MessageMustHaveSender()
        {
            // when
            UserMessage testObj = new UserMessage(SOME_FBUSER_A, SOME_FBUSER_B, SOME_10_CHAR_LONG_STRING);
            // then
            Assert.IsNotNull(testObj.Sender, "UserMessage must be assigned the Sender passed in constructor.");
        }

        [TestMethod]
        public void MessageMustHaveContentOfProperLength()
        {
            // when
            UserMessage testObj = new UserMessage(SOME_FBUSER_A, SOME_FBUSER_B, SOME_10_CHAR_LONG_STRING);
            // then
            Assert.IsTrue(testObj.Content.Length >= MINIMUM_CONTENT_LENGTH, "UserMessage's content must meet its minimal length.");
        }
    }
}
