using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ModelFirstXP;

namespace CtrXP
{
    public class AuctionCtr
    {
        // Constructor
        public AuctionCtr()
        {
            
        }

        public void CreateAuction(float startBid, DateTime startDate, DateTime endDate, string itemText, int artId)
        {
            Auction au = new Auction()
            {
                startingBid = startBid,
                startDate = startDate,
                endDate = endDate,
                itemText = itemText,
                
            };

            ModelTemaXPContainer dbContext = new ModelTemaXPContainer();
            dbContext.Auctions.Add(au);
            dbContext.SaveChanges();
        }
    }
}