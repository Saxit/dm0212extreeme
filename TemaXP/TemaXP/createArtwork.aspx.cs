using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using CtrXP;

namespace TemaXP
{

    public partial class createArtwork : System.Web.UI.Page
    {
        
        //Methods
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveInfo_Click(object sender, EventArgs e)
        {
            string nameArt = nameOfArt.Text;
            string nameArtist = nameOfArtist.Text;
            int year = Convert.ToInt32(yearOfArt.Text);
            double height = Convert.ToDouble(heightOfArt.Text);
            double width = Convert.ToDouble(widthOfArt.Text);
            string location = locationOfArt.Text;

            ArtworkCtr cont = new ArtworkCtr();
            cont.CreateArtwork(nameArt, nameArtist, year, height, width, location, uploadArtFile.FileName);
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