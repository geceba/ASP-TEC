using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormaUno
{
    public partial class FormaUno : System.Web.UI.Page
    {
        Int16 a, b, c, d;

        Int16 z;
       

        protected void Page_Load(object sender, EventArgs e)
        {
            //Declaracion de una variable de estado
            //this.ViewState["VE"] = a; //Inicializa

            this.Response.Write("<h4>Formato</h4>");
           // this.ViewState["VEa"] = a;

            HttpCookie ck;
            ck = this.Request.Cookies["ValorDeA"];

            if(ck!=null)
            {
                Data1.Text = ck.Value;
            }
        }

        protected void Data1_TextChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt16(Data1.Text);
            //this.ViewState["VE"] = a;
            //Creamos la cookie
            HttpCookie ck = new HttpCookie("ValorDeA", Data1.Text);
            //Tiempo de vida
            ck.Expires = DateTime.Now.AddMinutes(1);
            this.Response.Cookies.Add(ck);
            this.Session["VSEA"] = a;

        }

        protected void Data2_TextChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt16(Data2.Text);
            this.Session["VSEB"] = b;
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            String Tabla;
        
            Tabla = "Se debio hacer la tabla";

            c = Convert.ToInt16(this.Request.Form["Dato3"]);
            this.Session["VSEC"] = c;
            //Mnadar la tabla a una segunda ventana 
            // y Mnadar el valor de txtbox1
            // a = Convert.ToInt16(Data1.Text);
            //z = (Int16)this.ViewState["VE"];
            this.Response.Redirect("FormaDos.aspx");


            //this.Response.Write("<h3>HOLA MUNDO</h3>");
            
           // d = a + b + c;
            //resultado.Text = Convert.ToString(d);
        }
    }
}