using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TemaXP
{
    public partial class createArtwork : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveInfo_Click(object sender, EventArgs e)
        {
            string nameArt = nameOfArt.Text;
            string nameArtist = nameOfArtist.Text;
            string year = yearOfArt.Text;
            double height = Convert.ToDouble(heightOfArt.Text);
            double width = Convert.ToDouble(widthOfArt.Text);
            string 
        }
    }
}