using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneLibrary;

namespace Test
{
    [TestClass]
    public class TestEvenRaised
    {
        [TestMethod]
        public void TesRaiseEventMessageAdded()
        {
            // prepare data
            StorageMessages testStorage = new StorageMessages
            {
                MyCapacity = 100,
                ListMessages = new List<MyMessage>()
            };

            MyMessage AddTestMessage = new MyMessage()
            {
                User = "UserTest",
                PhoneNo = "+380950000000",
                ReceivingTime = DateTime.Now,
                Text = $"Test text"
            };
            bool expectedFlag = true;
            bool actualFlag = false ;

            testStorage.MessageAdded += (MyMessage m) => actualFlag = true;

            //test
            testStorage.Add(AddTestMessage);
            
            //compare
            Assert.AreEqual(expectedFlag, actualFlag);
        
        }
    }
}
