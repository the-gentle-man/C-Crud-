using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace LINKDB2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Listar.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Deletar.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Alterar.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inserir.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand comando = new MySqlCommand("select * from city where id = @id_city", conexao);



            try
            {
                conexao.Open();
                comando.Parameters.AddWithValue("id_city", TextBox1.Text);
                GridView1.DataSource = comando.ExecuteReader();
                GridView1.DataBind();

                if (GridView1.Rows.Count == 0)
                {
                    Response.Write("<script>alert('Item não encontrado!')</script>");
                }
               

            }
            finally
            {
                conexao.Close();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand comando = new MySqlCommand("select * from country where name like @name_country", conexao);



            try
            {
                conexao.Open();
                comando.Parameters.AddWithValue("name_country", "%" + TextBox2.Text + "%");
                GridView1.DataSource = comando.ExecuteReader();
                GridView1.DataBind();

                if (GridView1.Rows.Count == 0)
                {
                    Response.Write("<script>alert('Item não encontrado!')</script>");
                }
            }

            finally
            {
                conexao.Close();
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand comando = new MySqlCommand("select * from countrylanguage where language like @language_country", conexao);



            try
            {
                conexao.Open();
                comando.Parameters.AddWithValue("language_country", "%" + TextBox3.Text + "%");
                GridView1.DataSource = comando.ExecuteReader();
                GridView1.DataBind();

                if (GridView1.Rows.Count == 0)
                {
                    Response.Write("<script>alert('Item não encontrado!')</script>");
                }

            }

            finally
            {
                conexao.Close();
            }
        }

        
    }
}