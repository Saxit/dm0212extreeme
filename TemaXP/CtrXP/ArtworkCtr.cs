using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelXP;

namespace CtrXP
{
    public class ArtworkCtr
    {
        public ArtworkCtr()
        {
        }

        public void CreateArtwork(string nameOfArt, string nameOfArtist, string yearOfArt, double heightOfArt, double widthOfArt, string location, string urlOfImage)
        {
            Artwork aw = new Artwork(nameOfArt, nameOfArtist, yearOfArt, heightOfArt, widthOfArt, location, urlOfImage);

        }
    }
}
