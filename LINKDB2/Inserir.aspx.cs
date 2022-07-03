using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


namespace LINKDB2
{
    public partial class Inserir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultaIndividual.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Listar.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Deletar.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Alterar.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string sql = "insert into city (Name, CountryCode, District, Population)" +
                " values(@name, @countrycode, @district, @population)";
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            try
            {

                comando.Parameters.AddWithValue("name", TextBox1.Text);
                comando.Parameters.AddWithValue("countrycode", TextBox2.Text);
                comando.Parameters.AddWithValue("district", TextBox3.Text);
                comando.Parameters.AddWithValue("population", TextBox4.Text);
                

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                Response.Write("<script>alert('Registro inserido com sucesso!')</script>");

            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('Erro!')</script>");

                conexao.Close();
            }

            finally
            {
                conexao.Close();
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string sql = "insert into country (Code, Name, Continent, Region, SurfaceArea, IndepYear, Population, LifeExpectancy, GNP, GNPOld, LocalName, GovernmentForm, HeadOfState, Capital, Code2)" +
                " values(@Code, @Name, @Continent, @Region, @SurfaceArea, @IndepYear, @Population, @LifeExpectancy,@GNP, @GNPOld, @LocalName, @GovernmentForm, @HeadOfState, @Capital, @Code2)";
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            try
            {

                comando.Parameters.AddWithValue("code", TextBox10.Text);
                comando.Parameters.AddWithValue("name", TextBox11.Text);
                comando.Parameters.AddWithValue("continent", DropDownList1.Text);
                comando.Parameters.AddWithValue("region", TextBox13.Text);
                comando.Parameters.AddWithValue("surfacearea", TextBox14.Text);
                comando.Parameters.AddWithValue("indepyear", TextBox15.Text);
                comando.Parameters.AddWithValue("population", TextBox16.Text);
                comando.Parameters.AddWithValue("lifeexpectancy", TextBox17.Text.Replace(',', '.'));
                comando.Parameters.AddWithValue("gnp", TextBox18.Text);
                comando.Parameters.AddWithValue("gnpold", TextBox19.Text);
                comando.Parameters.AddWithValue("localname", TextBox20.Text);
                comando.Parameters.AddWithValue("governmentform", TextBox21.Text);
                comando.Parameters.AddWithValue("headofstate", TextBox22.Text);
                comando.Parameters.AddWithValue("capital", TextBox23.Text);
                comando.Parameters.AddWithValue("code2", TextBox24.Text);


                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                Response.Write("<script>alert('Registro inserido com sucesso!')</script>");


            }
            catch (Exception ex)
            {
                throw ex;
                
              // Response.Write("<script>alert('Erro!')</script>");

                conexao.Close();
            }

            finally
            {
                conexao.Close();
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string sql = "insert into countrylanguage (CountryCode, Language, IsOfficial, Percentage)" +
                " values(@CountryCode, @Language, @IsOfficial, @Percentage)";
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            try
            {

                comando.Parameters.AddWithValue("CountryCode", TextBox6.Text);
                comando.Parameters.AddWithValue("Language", TextBox7.Text);
                comando.Parameters.AddWithValue("IsOfficial", TextBox8.Text);
                comando.Parameters.AddWithValue("Percentage", TextBox9.Text);


                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                Response.Write("<script>alert('Registro inserido com sucesso!')</script>");


            }
            catch (Exception ex)
            {
                throw ex;
               Response.Write("<script>alert('Erro!')</script>");

                conexao.Close();
            }

            finally
            {
                conexao.Close();
            }
        }
    }
}