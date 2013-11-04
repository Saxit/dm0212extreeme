using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelXP.Models;
using System.Data.Entity;

namespace UnitTest
{
    [TestClass]
    public class UnitTestAuction
    {
        private Artwork art;    
        private Auction auction;

        [TestMethod]
        public void CreateAuction()
        {
            Console.WriteLine("Gets Here");
            art = new Artwork();
            art.id = 1;
            art.artName = "picasso";
            art.yearCreated = 1988;
            art.height = 5;
            art.width = 5;
            art.location = "Aalborg";
            art.imagePath = "C:\\";

            
            auction = new Auction();
            auction.startingBid = 100;
            auction.startDate = DateTime.Now;
            auction.endDate = DateTime.Now.AddDays(1);
            auction.itemText = "This is a fine painting";
            auction.artID = art.id;
            auction.Artwork = art;
        }

        [TestMethod]
        public void InsertArtDB()
        {
            CreateAuction();
            using (var db = new dmaa0212a_6Context()) 
            {
                try
                {
                    db.Artworks.Add(art);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occured" + ex);
                }
            }
        }
    }
}