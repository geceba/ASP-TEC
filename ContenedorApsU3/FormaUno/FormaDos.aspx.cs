using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormaUno
{
    public partial class FormaDos : System.Web.UI.Page
    {
        Int16 r1, r2, r3;
        Int16 aux;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDesplegar_Click(object sender, EventArgs e)
        {
            r1 = (Int16)this.Session["VSEA"];
            r2 = (Int16)this.Session["VSEB"];
            r3 = (Int16)this.Session["VSEC"];
            //aux = r1;
            
            this.Response.Write("<h1>Respuestas</h1>");
            // lblMensaje.Text= Convert.ToString(aux);
            Label1.Text = "" + r1;
            Label2.Text = "" + r2;
            Label3.Text = "" + r3;

        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("FormaUno.aspx");
        }
    }
}