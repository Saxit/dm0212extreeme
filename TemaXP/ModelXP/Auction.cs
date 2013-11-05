using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelXP
{
    public class Auction
    {
        public int StartingBid { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string itemText { get; set; }
        public int artId { get; set; }

        public Auction(int startBid, DateTime startDate, DateTime endDate, string itemText, int artId)
        {
            this.StartingBid = startBid;
            this.startDate = startDate;
            this.endDate = endDate;
            this.itemText = itemText;
            this.artId = artId;
        }
    }
}