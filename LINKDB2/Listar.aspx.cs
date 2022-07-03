using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace LINKDB2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultaIndividual.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inserir.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Deletar.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Alterar.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;User Id=root;database=world; password=P@ssw0rd");
            String sql = "SELECT * FROM city";
            MySqlCommand comando = new MySqlCommand(sql, conexao);


            try
            {
                conexao.Open();
                GridView1.DataSource = comando.ExecuteReader();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;User Id=root;database=world; password=P@ssw0rd");
            String sql = "SELECT * FROM country";
            MySqlCommand comando = new MySqlCommand(sql, conexao);


            try
            {
                conexao.Open();
                GridView1.DataSource = comando.ExecuteReader();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;User Id=root;database=world; password=P@ssw0rd");
            String sql = "SELECT * FROM countrylanguage";
            MySqlCommand comando = new MySqlCommand(sql, conexao);


            try
            {
                conexao.Open();
                GridView1.DataSource = comando.ExecuteReader();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}