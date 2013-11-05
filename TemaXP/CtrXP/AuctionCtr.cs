using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelXP.Models;
using System.Data.Entity;

namespace CtrXP
{
    public class AuctionCtr
    {
        private dmaa0212a_6Context dbContext;

        // Constructor
        public AuctionCtr()
        {
            dbContext = new dmaa0212a_6Context();
        }

        public void CreateAuction(int startBid, DateTime startDate, DateTime endDate, string itemText, int artId)
        {
            Auction au = new Auction()
            {
                startingBid = startBid,
                startDate = startDate,
                endDate = endDate,
                itemText = itemText,
                artID = artId,
            };

            dbContext.Auctions.Add(au);
            dbContext.SaveChanges();
        }
    }
}