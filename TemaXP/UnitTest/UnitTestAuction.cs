using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelXP;
using CtrXP;

namespace UnitTest
{
    [TestClass]
    public class UnitTestAuction
    {
        [TestMethod]
        public void TestCreateAuction()
        {
            int startingBid = 100;
            DateTime startingDate = DateTime.Now;
            DateTime endingDate = DateTime.Now.AddDays(1);
            string itemDescription = "A Piece of art";
            int artId = 1;

            Auction au = new Auction(startingBid,startingDate,endingDate,itemDescription,artId);

            Assert.AreEqual(100, startingBid, "Wrong, values not matching");
            //Assert.AreEqual(DateTime.Now, startingDate, "Wrong, values not matching");
            //Assert.AreEqual(DateTime.Now.AddDays(1), endingDate, "Wrong, values not matching");
            Assert.AreEqual("A Piece of art", itemDescription, "Wrong, values not matching");
            Assert.AreEqual(1, artId, "Wrong, values not matching");
        }


        [TestMethod]
        public void TestCreateAuctionDB()
        {
            int startingBid = 100;
            DateTime startingDate = DateTime.Now;
            DateTime endingDate = DateTime.Now.AddDays(1);
            string itemDescription = "A Piece of art";
            int artId = 1;

            AuctionCtr auCtr = new AuctionCtr();
 
            auCtr.CreateAuction(startingBid, startingDate, endingDate, itemDescription, artId);
        }
    }
}