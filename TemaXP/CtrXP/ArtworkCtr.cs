using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelFirstXP;
using System.Data.Entity;

namespace CtrXP
{
    public class ArtworkCtr
    {
        //Contructor
        public ArtworkCtr()
        {
            
        }

        //Methods
        public void CreateArtwork(string nameOfArt, string nameOfArtist, string yearOfArt, double heightOfArt, double widthOfArt, string location, string urlOfImage)
        {

            Artwork aw = new Artwork()
            {
                name = nameOfArt,
                artistName = nameOfArtist,
                year = yearOfArt,
                height = (heightOfArt),
                width = (widthOfArt),
                location = location,
                imageName = urlOfImage
                
            };

            ModelTemaXPContainer db = new ModelTemaXPContainer();
            db.Artworks.Add(aw);
            db.SaveChanges();

        }

        public List<Artwork> GetArtworks()
        {
            List<Artwork> artworks = new List<Artwork>();

            using(var db = new ModelTemaXPContainer())
            {
                artworks = db.Artworks.ToList<Artwork>();
            }
            return artworks;
        }
    }
}
