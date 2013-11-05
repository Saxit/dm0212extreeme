using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CtrXP;
using System.Collections.Generic;
using ModelFirstXP;

namespace UnitTest
{
    [TestClass]
    public class ArtWorkTest
    {
        [TestMethod]
        public void TestCreateArtworkDB()
        {
            string nameOfArt = "Abc";
            string nameOfArtist = "Bcd";
            string yearOfArt = "1992";
            double heightOfArt = 145;
            double widthOfArt = 90;
            string location = "Downtown";
            string urlOfImage = "www.derp.com";

            ArtworkCtr awCtr = new ArtworkCtr();

            awCtr.CreateArtwork(nameOfArt, nameOfArtist, yearOfArt, heightOfArt, widthOfArt, location, urlOfImage);
        }

        [TestMethod]
        public void GetArtWorks()
        {
            List<Artwork> listToCheck = new List<Artwork>();
            ArtworkCtr awCtr = new ArtworkCtr();
            listToCheck = awCtr.GetArtworks();

            foreach (Artwork aw in listToCheck)
            {
                Console.WriteLine(aw.name);
                Console.Read();
            }
        }
    }
}
