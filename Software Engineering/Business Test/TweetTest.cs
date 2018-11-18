using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
namespace Business_Test
{
    [TestClass]
    public class TweetTest
    {
        [TestMethod]
        public void tweet_header()
        {
            string header = "T12345678";
            Tweet target = new Tweet();
            target.messageHeader = header;
            Assert.AreEqual(header, target.messageHeader);
        }

        [TestMethod]
        public void tweetid()
        {
            string id = "@tester";
            Tweet target = new Tweet();
            target.twitterId = id;
            Assert.AreEqual(id, target.twitterId);
        }

        [TestMethod]
        public void tweet_message()
        {
            string message = "hi @tester #test";
            Tweet target = new Tweet();
            target.messageText= message;
            Assert.AreEqual(message, target.messageText);
        }

    }
}
