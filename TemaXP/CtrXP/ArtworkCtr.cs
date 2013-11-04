using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelXP.Models;
using System.Data.Entity;

namespace CtrXP
{
    public class ArtworkCtr
    {
        private dmaa0212a_6Context dbContext;
        public ArtworkCtr()
        {
            dbContext = new dmaa0212a_6Context();
        }

        public void CreateArtwork(string nameOfArt, string nameOfArtist, string yearOfArt, double heightOfArt, double widthOfArt, string location, string urlOfImage)
        {

            Artwork aw = new Artwork()
            {
                artName = nameOfArt,
                yearCreated = yearOfArt,
                height = (decimal)heightOfArt,
                width = (decimal)widthOfArt,
                location = location,
                imagePath = urlOfImage
                
            };
            
            dbContext.Artworks.Add(aw);
            dbContext.SaveChanges();

        }
    }
}
