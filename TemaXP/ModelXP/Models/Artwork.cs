using System;
using System.Collections.Generic;

namespace ModelXP.Models
{
    public partial class Artwork
    {
        public Artwork()
        {
            var db = new dmaa0212a_6Context();
            this.Auctions = new List<Auction>();
        }

        public int id { get; set; }
        public string artName { get; set; }
        public string yearCreated { get; set; }
        public Nullable<decimal> height { get; set; }
        public Nullable<decimal> width { get; set; }
        public string location { get; set; }
        public string imagePath { get; set; }
        public virtual ICollection<Auction> Auctions { get; set; }
    }
}
