using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LanzaDado
{
    public partial class LanzaDado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo la primera vez se hara
            if(!this.IsPostBack)
            {
                this.ViewState["Total"] = 0;
                this.ViewState["Sumador"] = 0;
            }
        }

        protected void btnLanzar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int n = r.Next(1, 7);
            this.ViewState["Total"] = (int)this.ViewState["Total"]+1;
            this.ViewState["Sumador"] = (int)this.ViewState["Sumador"] + n;
            lblInfo.Text = Convert.ToString(n);
        }

        protected void btnDesplegar_Click(object sender, EventArgs e)
        {
            lblProm.Text = "Total " + ViewState["Total"];
            lblProm.Text = "Prom " + +((int)this.ViewState["Sumador"] / (int)this.ViewState["Total"]);
        }
    }
}