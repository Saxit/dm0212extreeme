using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CtrXP;
using ModelFirstXP;

namespace TemaXP
{
    public partial class createAuction : System.Web.UI.Page
    {
        private Artwork aw;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveInfo_Click(object sender, EventArgs e)
        {

        }

        protected void idCheck_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(artId.Text);
            var db = new ModelTemaXPContainer();
            aw = db.Artworks.Find(id);
        }
    }
}