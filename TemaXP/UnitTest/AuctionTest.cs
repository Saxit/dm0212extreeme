using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelXP;
using CtrXP;

namespace UnitTest
{
    [TestClass]
    public class AuctionTest
    {
        [TestMethod]
        public void TestCreateAuctionDB()
        {
            float startingBid = 100;
            DateTime startingDate = DateTime.Now;
            DateTime endingDate = DateTime.Now.AddDays(1);
            string itemDescription = "A Piece of art";
            int artId = 1;

            AuctionCtr auCtr = new AuctionCtr();

            auCtr.CreateAuction(startingBid, startingDate, endingDate, itemDescription, artId);
        }
    }
}