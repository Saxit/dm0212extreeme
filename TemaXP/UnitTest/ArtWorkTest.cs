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
        public void TestCreateArtwork()
        {
            string nameOfArt = "Abc";
            string nameOfArtist = "Bcd";
            int yearOfArt = 1992;
            double heightOfArt = 145;
            double widthOfArt = 90;
            string location = "Downtown";
            string urlOfImage = "www.derp.com";

            Artwork aw = new Artwork(nameOfArt, nameOfArtist, yearOfArt, heightOfArt, widthOfArt, location, urlOfImage);

            Assert.AreEqual("Abc", nameOfArt, "Something's wrong");
            Assert.AreEqual("Bcd", nameOfArtist, "Something's wrong");
            Assert.AreEqual(1992, yearOfArt, "Something's wrong");
            Assert.AreEqual(145, heightOfArt, "Something's wrong");
            Assert.AreEqual(90, widthOfArt, "Something's wrong");
            Assert.AreEqual("Downtown", location, "Something's wrong");
            Assert.AreEqual("www.derp.com", urlOfImage, "Something's wrong");
        }

        [TestMethod]
        public void TestCreateArtworkDB()
        {
            string nameOfArt = "Abc";
            string nameOfArtist = "Bcd";
            int yearOfArt = 1992;
            double heightOfArt = 145;
            double widthOfArt = 90;
            string location = "Downtown";
            string urlOfImage = "www.derp.com";

            ArtworkCtr awCtr = new ArtworkCtr();

            awCtr.CreateArtwork(nameOfArt, nameOfArtist, yearOfArt, heightOfArt, widthOfArt, location, urlOfImage);
        }
    }
}
