using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelXP
{
    public class Artwork
    {
        public string NameOfArt { get; set; }
        public string NameOfArtist { get; set; }
        public string YearOfArt { get; set; }
        public double HeightOfArt { get; set; }
        public double WidthOfArt { get; set; }
        public string Location { get; set; }
        public string UrlOfImage { get; set; }

        public Artwork(string nameOfArt, string nameOfArtist, string yearOfArt, double heightOfArt, double widthOfArt, string location, string urlOfImage)
        {
            this.NameOfArt = nameOfArt;
            this.NameOfArtist = nameOfArtist;
            this.YearOfArt = yearOfArt;
            this.HeightOfArt = heightOfArt;
            this.WidthOfArt = widthOfArt;
            this.Location = location;
            this.UrlOfImage = urlOfImage;
        }
    }
}
