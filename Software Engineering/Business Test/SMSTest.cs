using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
namespace Business_Test
{
    [TestClass]
    public class SMSTest
    {
        [TestMethod]
        public void SMS_header()
        {
            string header = "S12345678";
            SMS target = new SMS();
            target.messageHeader = header;
            Assert.AreEqual(header, target.messageHeader);
        }

        [TestMethod]
        public void sender()
        {
            string phonenum = "01234567890";
            SMS target = new SMS();
            target.Sender = phonenum;
            Assert.AreEqual(phonenum, target.Sender);
        }

        [TestMethod]
        public void SMS_message()
        {
            string message = "hi come ASAP";
            SMS target = new SMS();
            target.messageText= message;
            Assert.AreEqual(message, target.messageText);
        }

    }
}
