using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneLibrary;

namespace Test
{
    [TestClass]
    public class TestFilters
    {
        [TestMethod]
        public void TestMethodFull()
        {
            // prepare data
            StorageMessages testStorage = new StorageMessages
            {
                MyCapacity = 100,
                ListMessages = new List<MyMessage>
                {
                    new MyMessage
                    {
                    User = "UserTest1",
                    PhoneNo = "+380950000000",
                    ReceivingTime = DateTime.Now,
                    Text = $"Test text"
                    },
                    new MyMessage
                    {
                    User = "UserTest2",
                    PhoneNo = "+380950000000",
                    ReceivingTime = DateTime.Now,
                    Text = $"Test text"
                    }

                }
            };

            string expectedUserFound = "UserTest1";

            //test
            string filterUser = "UserTest1";
            string filterText = "text";
            DateTime toDate = DateTime.Now.Date;
            DateTime fromDate = DateTime.Now.Date;
            IEnumerable<MyMessage> filterTestQuery = MobilePhoneProjLab2WinForm.FormMessageFiltering.FilterMessages(testStorage.ListMessages, filterUser, filterText, toDate, fromDate);

            //display (filtered) messages
            string actualUserFound = "";
            foreach (MyMessage msg in filterTestQuery)
            {
              actualUserFound = actualUserFound+msg.User;
            }

            Assert.AreEqual(actualUserFound, expectedUserFound);
        }

        [TestMethod]
        public void TestMethodFilterByText()
        {
            // prepare data
            StorageMessages testStorage = new StorageMessages
            {
                MyCapacity = 100,
                ListMessages = new List<MyMessage>
                {
                    new MyMessage
                    {
                    User = "UserTest1",
                    PhoneNo = "+380950000000",
                    ReceivingTime = DateTime.Now,
                    Text = $"Test text 1"
                    },
                    new MyMessage
                    {
                    User = "UserTest2",
                    PhoneNo = "+380950000000",
                    ReceivingTime = DateTime.Now,
                    Text = $"Test text 2"
                    }

                }
            };

            int expectedUserFound = 2;

            //test
            string filterUser = null;
            string filterText = "text";
            DateTime toDate = DateTime.Now.Date;
            DateTime fromDate = DateTime.Now.Date;
            IEnumerable<MyMessage> filterTestQuery = MobilePhoneProjLab2WinForm.FormMessageFiltering.FilterMessages(testStorage.ListMessages, filterUser, filterText, toDate, fromDate);

            //display (filtered) messages
            int actualUserFound = 0;
            foreach (MyMessage msg in filterTestQuery)
            {
                actualUserFound += 1;
            }

            Assert.AreEqual(actualUserFound, expectedUserFound);
        }
    }
}
