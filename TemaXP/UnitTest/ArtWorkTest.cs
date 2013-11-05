using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelXP;
using CtrXP;

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
    }
}
