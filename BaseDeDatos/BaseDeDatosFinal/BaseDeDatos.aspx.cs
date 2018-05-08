using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaseDeDatosFinal
{
    public partial class BaseDeDatos : System.Web.UI.Page
    {
        Int16 Cla, Can;
        String Np, Fv;
        Decimal Prec;

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            // Insertar datos en la tabla
            SqlConnection Conn;
            String OrdenSql;
            Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\gcetzal\\Documents\\ASP-TEC\\bd.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                Conn.Open();
                OrdenSql = String.Format("INSERT INTO Productos(clave, nombreProd, precio, fechaVenta, cantidad) VALUES({0}, '{1}', {2}, '{3}', {4})", Cla, Np, Prec, Fv, Can);
                SqlCommand cmd = new SqlCommand(OrdenSql, Conn);
                cmd.ExecuteNonQuery();
                Label1.Text = "Se completo correctamente";
                Conn.Close();
            } catch(Exception ex)
            {
                Label1.Text = "Error " + ex;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Cla = Convert.ToInt16(TextBox1.Text);
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            Can = Convert.ToInt16(TextBox2.Text);
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            Np = Convert.ToString(TextBox3.Text);
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            Fv = Convert.ToString(TextBox4.Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Procedimiento almacenado
            SqlConnection Conn;
            String OrdenSql;
            //Nuevo
            SqlParameter sp;
            Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\gcetzal\\Documents\\ASP-TEC\\bd.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                Conn.Open();
                OrdenSql = "CambiarPrecio";
                SqlCommand cmd = new SqlCommand(OrdenSql, Conn);
                // Definir el procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Cambiar Precio";
                // Agregar los parametros de entrada
                cmd.Parameters.Add(new SqlParameter("@ClaveP", int.Parse(TextBox1.Text)));
                cmd.Parameters.Add(new SqlParameter("@PrecioP", decimal.Parse(TextBox3.Text)));


                // AGREGAR los prametros de salida
                sp = new SqlParameter();
                sp.ParameterName = "@Resul";
                sp.SqlDbType = SqlDbType.Int;
                sp.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(sp);
                cmd.ExecuteNonQuery();

                // Verificar si el procedimiento dio el resultado
                if ( int.Parse(sp.Value.ToString())>0)
                {
                    Label1.Text = "Precio Actualizado por proc almacenado";
                }
                else
                {
                    Label1.Text = "No existe ese codigo...";
                }

            } catch(Exception err)
            {
                Label1.Text = "No se pudo hacer " + err;
            }
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {
            Prec = Convert.ToDecimal(TextBox5.Text);
        }

       

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}