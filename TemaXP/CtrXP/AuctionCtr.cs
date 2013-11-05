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
            using (var db = new ModelTemaXPContainer())
            {
                Auction au = new Auction()
                {
                    startingBid = startBid,
                    startDate = startDate,
                    endDate = endDate,
                    itemText = itemText,
                    Artwork = db.Artworks.Find(1) //hardcoded id for testing purposes
                };

                //using (dbContext = new ModelTemaXPContainer()) ;
                db.Auctions.Add(au);
                db.SaveChanges();
            }
        }
    }
}