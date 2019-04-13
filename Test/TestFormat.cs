using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneProjLab2WinForm;

namespace Test
{
    [TestClass]
    public class TestFormat
    {
        [TestMethod]
        public void TestMethod_FormatterNone()
        {/*
            string testMessage = "Message #1 is received.";
            string expectedStr = "Message #1 is received.\r\n";
            
            string actualStr = MobilePhoneProjLab2WinForm.Form1.SMSProvider_FormatterNone(testMessage);
            Assert.AreEqual(expectedStr, actualStr);
            */
        }

        [TestMethod]
        public void TestMethod_FormatterWithTime()
        {/*
            string testMessage = "Message #1 is received.";
            string expectedStr = $"[{DateTime.Now}]: Message #1 is received.\r\n";

            string actualStr = MobilePhoneProjLab2WinForm.Form1.SMSProvider_FormatterWithTime(testMessage);
            Assert.AreEqual(expectedStr, actualStr);
*/
        }


        [TestMethod]
        public void TestMethod_FormatterWithTimeEnd()
        {/*
            string testMessage = "Message #1 is received.";
            string expectedStr = $"Message #1 is received. [{DateTime.Now}]\r\n";

            string actualStr = MobilePhoneProjLab2WinForm.Form1.SMSProvider_FormatterWithTimeEnd(testMessage);
            Assert.AreEqual(expectedStr, actualStr);
*/
        }

        [TestMethod]
        public void TestMethod_FormatterUpper()
        {/*
            string testMessage = "Message #1 is received.";
            string expectedStr = "MESSAGE #1 IS RECEIVED.\r\n";

            string actualStr = MobilePhoneProjLab2WinForm.Form1.SMSProvider_FormatterUpper(testMessage);
            Assert.AreEqual(expectedStr, actualStr);
*/
        }

        [TestMethod]
        public void TestMethod_FormatterLower()
        {/*
            string testMessage = "Message #1 is received.";
            string expectedStr = $"message #1 is received.\r\n";

            string actualStr = MobilePhoneProjLab2WinForm.Form1.SMSProvider_FormatterLower(testMessage);
            Assert.AreEqual(expectedStr, actualStr);
*/
        }

    }
}
