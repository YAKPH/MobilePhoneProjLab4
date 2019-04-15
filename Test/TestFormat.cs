using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneProjLab2WinForm;
using PhoneLibrary;

namespace Test
{
    [TestClass]
    public class TestFormat
    {
        [TestMethod]
        public void TestMethod_FormatterNone()
        {
            string testText = "Message #1 is received.";

            MyMessage TestMessage = new MyMessage()
            {
                User = "UserTest",
                PhoneNo = "+380950000000",
                ReceivingTime = DateTime.Now,
                Text = testText
            };

            string expectedStr = "Message #1 is received.";
            
            string actualStr = MobilePhoneProjLab2WinForm.FormMessageFiltering.SMSProvider_FormatterNone(TestMessage);
            Assert.AreEqual(expectedStr, actualStr);
            
        }

        [TestMethod]
        public void TestMethod_FormatterWithTime()
        {
            string testText = "Message #1 is received.";

            MyMessage TestMessage = new MyMessage()
            {
                User = "UserTest",
                PhoneNo = "+380950000000",
                ReceivingTime = DateTime.Now,
                Text = testText
            };

            string expectedStr = $"[{DateTime.Now}]: Message #1 is received.";

            string actualStr = MobilePhoneProjLab2WinForm.FormMessageFiltering.SMSProvider_FormatterWithTime(TestMessage);
            Assert.AreEqual(expectedStr, actualStr);

        }


        [TestMethod]
        public void TestMethod_FormatterWithTimeEnd()
        {
            string testText = "Message #1 is received";

            MyMessage TestMessage = new MyMessage()
            {
                User = "UserTest",
                PhoneNo = "+380950000000",
                ReceivingTime = DateTime.Now,
                Text = testText
            };

            string expectedStr = $"Message #1 is received [{TestMessage.ReceivingTime}]";

            string actualStr = MobilePhoneProjLab2WinForm.FormMessageFiltering.SMSProvider_FormatterWithTimeEnd(TestMessage);
            Assert.AreEqual(expectedStr, actualStr);

        }

        [TestMethod]
        public void TestMethod_FormatterUpper()
        {
            string testText = "Message #1 is received";

            MyMessage TestMessage = new MyMessage()
            {
                User = "UserTest",
                PhoneNo = "+380950000000",
                ReceivingTime = DateTime.Now,
                Text = testText
            };

            string expectedStr = "MESSAGE #1 IS RECEIVED";

            string actualStr = MobilePhoneProjLab2WinForm.FormMessageFiltering.SMSProvider_FormatterUpper(TestMessage);
            Assert.AreEqual(expectedStr, actualStr);

        }

        [TestMethod]
        public void TestMethod_FormatterLower()
        {
            string testText = "Message #1 is received";

            MyMessage TestMessage = new MyMessage()
            {
                User = "UserTest",
                PhoneNo = "+380950000000",
                ReceivingTime = DateTime.Now,
                Text = testText
            };

            string expectedStr = $"message #1 is received";

            string actualStr = MobilePhoneProjLab2WinForm.FormMessageFiltering.SMSProvider_FormatterLower(TestMessage);
            Assert.AreEqual(expectedStr, actualStr);

        }

    }
}
