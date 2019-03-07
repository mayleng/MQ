using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MQ
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //IBM WebSphereMQ
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/IBMMQ.aspx");
        }

        //MicrosoftMQ
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/MicroMQ.aspx");
        }

        //RabbitMQ
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/RabbitMq.aspx");
        }
    }
}