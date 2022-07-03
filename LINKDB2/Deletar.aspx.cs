using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace LINKDB2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Listar.Aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultaIndividual.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inserir.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("Alterar.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

          

            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand comando = new MySqlCommand("DELETE FROM city WHERE id = @id", conexao);

            try
            {
                
                    comando.Parameters.AddWithValue("id", TextBox1.Text);

                    conexao.Open();

                    comando.ExecuteNonQuery();

                    conexao.Close();

                    Response.Write("<script>alert('Registro deletado com sucesso!')</script>");
                
            }
            catch
            {
                Response.Write("<script>alert('Item não encontrado!')</script>");

            }
            finally
            {
                conexao.Close();
            }
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            

            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand comando = new MySqlCommand("DELETE FROM city WHERE CountryCode = @code", conexao);
            MySqlCommand comando2 = new MySqlCommand("DELETE FROM country WHERE Code = @code", conexao);
            MySqlCommand comando3 = new MySqlCommand("DELETE FROM countrylanguage WHERE CountryCode = @code", conexao);

            try
            {
                    comando.Parameters.AddWithValue("code", TextBox2.Text);
                    comando2.Parameters.AddWithValue("code", TextBox2.Text);
                    comando3.Parameters.AddWithValue("code", TextBox2.Text);


                    conexao.Open();

                    comando3.ExecuteNonQuery();
                    comando.ExecuteNonQuery();
                    comando2.ExecuteNonQuery();

                    conexao.Close();

                    Response.Write("<script>alert('Registro deletado com sucesso!')</script>");
                
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('Item não encontrado!')</script>");
            }
            finally
            {
                conexao.Close();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
           

            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand comando = new MySqlCommand("DELETE FROM countrylanguage WHERE language = @language", conexao);

            try
            {
                
                    comando.Parameters.AddWithValue("language", TextBox3.Text);

                    conexao.Open();

                    comando.ExecuteNonQuery();

                    conexao.Close();

                    Response.Write("<script>alert('Registro deletado com sucesso!')</script>");
                   
                    
            }

            finally
            {
                conexao.Close();
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand comando = new MySqlCommand("select * from city where id = @id_city", conexao);



            try
            {
                conexao.Open();
                comando.Parameters.AddWithValue("id_city", TextBox1.Text);
                GridView1.DataSource = comando.ExecuteReader();
                GridView1.DataBind();
                if(GridView1.Rows.Count > 0)
                {
                    Button3.Enabled = true;
                }
                else
                {
                    Response.Write("<script>alert('Item não encontrado!')</script>");
                }
            }

            finally
            {
                conexao.Close();
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {

            
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand comando = new MySqlCommand("select * from country where code = @code", conexao);



            try
            {
                conexao.Open();
                comando.Parameters.AddWithValue("code", TextBox2.Text);
                GridView1.DataSource = comando.ExecuteReader();
                GridView1.DataBind();
                if (GridView1.Rows.Count > 0)
                {
                    Button4.Enabled = true;
                }
                else
                {
                    Response.Write("<script>alert('Item não encontrado!')</script>");
                }
            }

            finally
            {
                conexao.Close();
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand comando = new MySqlCommand("select * from countrylanguage where language = @language_country", conexao);



            try
            {
                conexao.Open();
                comando.Parameters.AddWithValue("language_country", TextBox3.Text);
                GridView1.DataSource = comando.ExecuteReader();
                GridView1.DataBind();
                if (GridView1.Rows.Count > 0)
                {
                    Button3.Enabled = true;
                }
                else
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