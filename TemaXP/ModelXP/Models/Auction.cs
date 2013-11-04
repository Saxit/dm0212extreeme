using System;
using System.Collections.Generic;

namespace ModelXP.Models
{
    public partial class Auction
    {
        public int id { get; set; }
        public Nullable<int> startingBid { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public string itemText { get; set; }
        public Nullable<int> artID { get; set; }
        public virtual Artwork Artwork { get; set; }
    }
}
