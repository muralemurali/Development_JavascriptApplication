using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JavascriptLearning.WebPages
{
    public partial class PostForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblStatus.Text = "Forking Documentation";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Completed : Forking Documentation";
        }
    }
}