using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
namespace Business_Test
{
    [TestClass]
    public class EmailTest
    {
        [TestMethod]
        public void email_header()
        {
            string header = "E12345678";
            Email target = new Email();
            target.messageHeader = header;
            Assert.AreEqual(header, target.messageHeader);
        }

        [TestMethod]
        public void email_subject()
        {
            string subject = "SIR 08/02/99";
            Email target = new Email();
            target.Subject = subject;
            Assert.AreEqual(subject, target.Subject);
        }

        [TestMethod]
        public void email_message()
        {
            string message = "Sort Code: 99-99-99 Nature of incident Theft ";
            Email target = new Email();
            target.messageText= message;
            Assert.AreEqual(message, target.messageText);
        }

        [TestMethod]
        public void sender()
        {
            string sender = "test@test.com";
            Email target = new Email();
            target.Sender = sender;
            Assert.AreEqual(sender, target.Sender);
        }

    }
}
