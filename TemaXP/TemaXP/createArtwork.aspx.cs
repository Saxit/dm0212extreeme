using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

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
            string height = heightOfArt.Text;
            string width = widthOfArt.Text;
            //double height = (double)Convert.ToDouble(heightOfArt.Text);
            //double width = Convert.ToDouble(widthOfArt.Text);

                try
                {
                    if (Directory.Exists(Server.MapPath("~\\ArtWorkImages")))
                    {
                        string imgName = uploadArtFile.FileName;
                        string folderPath = Server.MapPath("~\\ArtWorkImages\\");
                        uploadArtFile.SaveAs(folderPath+imgName);
                    }
                    else
                    {
                        Directory.CreateDirectory(Server.MapPath("~\\ArtWorkImages"));
                        string imgName = uploadArtFile.FileName;
                        string folderPath = Server.MapPath("~\\ArtWorkImages\\");
                        uploadArtFile.SaveAs(folderPath+imgName);
                    }
                }
                catch (Exception ex)
                {
                    ex.StackTrace.ToString();
                }
           
        }
    }
}