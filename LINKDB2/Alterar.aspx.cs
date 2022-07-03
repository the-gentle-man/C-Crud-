using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace LINKDB2
{
    public partial class WebForm4 : System.Web.UI.Page
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
            Response.Redirect("Inserir.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string sql = "update city set ID = @id, name = @name, CountryCode = @countrycode , District = @district, Population = @population WHERE Id = @id";
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            String teste = TextBox1.Text;

            if (teste.Trim() == "")
            { 
                Response.Write("<script>alert('Insira um id Válido!')</script>");
            }
            else
            {

            
                try
                {

                    comando.Parameters.AddWithValue("id", TextBox1.Text);
                    comando.Parameters.AddWithValue("name", TextBox2.Text);
                    comando.Parameters.AddWithValue("countrycode", TextBox3.Text);
                    comando.Parameters.AddWithValue("district", TextBox4.Text);
                    comando.Parameters.AddWithValue("population", TextBox5.Text);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                    conexao.Close();
                    Response.Write("<script>alert('Registro alterado com sucesso!')</script>");


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


        }

        

        protected void Button6_Click(object sender, EventArgs e)
        {
            string sql = "update countrylanguage set IsOfficial = @isofficial, Percentage = @percentage WHERE CountryCode = @countrycode and Language = @language";
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            string teste2 = TextBox6.Text;
            string teste3 = TextBox7.Text;

            if (teste2.Trim() == "" || teste3.Trim() == "")
            {
                Response.Write("<script>alert('Insira um Código de País ou língua Válidos!')</script>");
            }
            else
            {

                try
                {

                    comando.Parameters.AddWithValue("countrycode", TextBox6.Text);
                    comando.Parameters.AddWithValue("language", TextBox7.Text);
                    comando.Parameters.AddWithValue("isofficial", TextBox8.Text);
                    comando.Parameters.AddWithValue("percentage", TextBox9.Text);


                    conexao.Open();
                    comando.ExecuteNonQuery();
                    conexao.Close();
                    Response.Write("<script>alert('Registro alterado com sucesso!')</script>");


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
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string sql = "update country set Name = @name, Continent = @continent, Region = @region, SurfaceArea = @surfacearea," +
                "IndepYear = @indepyear, Population = @population, LifeExpectancy = @lifeexpectancy, GNP = @gnp, GNPOld = @gnpold, " +
                "LocalName = @localname, GovernmentForm = @governmentform, HeadOfState = @headofstate, Capital = @capital, Code2 = @code2 WHERE Code = @code";
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            string teste4 = TextBox10.Text;

            if (teste4.Trim() == "")
            {
                Response.Write("<script>alert('Insira um Código de país Válido!')</script>");
            }
            else
            {
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
                    Response.Write("<script>alert('Registro alterado com sucesso!')</script>");


                }
                catch (Exception ex)
                {

                    Response.Write("<script>alert('Erro!')</script>");
                    throw ex;
                    conexao.Close();
                }

                finally
                {
                    conexao.Close();
                }
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM city WHERE ID=@Id";
            MySqlConnection con = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
            cmd.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    TextBox1.Text = reader[0].ToString();
                    TextBox2.Text = reader[1].ToString();
                    TextBox3.Text = reader[2].ToString();
                    TextBox4.Text = reader[3].ToString();
                    TextBox5.Text = reader[4].ToString();
                }
                else
                {
                    Response.Write("<script>alert('ID não encontrado!')</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Erro')</script>");
            }
            finally
            {
                con.Close();
            }

            
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM countrylanguage WHERE CountryCode = @countrycode and Language = @language";
            MySqlConnection con = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("countrycode", TextBox6.Text);
            cmd.Parameters.AddWithValue("language", TextBox7.Text);
            cmd.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    TextBox6.Text = reader[0].ToString();
                    TextBox7.Text = reader[1].ToString();
                    TextBox8.Text = reader[2].ToString();
                    TextBox9.Text = reader[3].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Língua não encontrada!')</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Erro')</script>");
            }
            finally
            {
                con.Close();
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM country WHERE Code = @code";
            MySqlConnection con = new MySqlConnection("server=localhost; User Id=root;database=world; password=P@ssw0rd");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("code", TextBox10.Text);
            
            cmd.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader;
            con.Open();
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    TextBox10.Text = reader[0].ToString();
                    TextBox11.Text = reader[1].ToString();
                    DropDownList1.SelectedValue = reader[2].ToString();
                    TextBox13.Text = reader[3].ToString();
                    TextBox14.Text = reader[4].ToString();
                    TextBox15.Text = reader[5].ToString();
                    TextBox16.Text = reader[6].ToString();
                    TextBox17.Text = reader[7].ToString();
                    TextBox18.Text = reader[8].ToString();
                    TextBox19.Text = reader[9].ToString();
                    TextBox20.Text = reader[10].ToString();
                    TextBox21.Text = reader[11].ToString();
                    TextBox22.Text = reader[12].ToString();
                    TextBox23.Text = reader[13].ToString();
                    TextBox24.Text = reader[14].ToString();

                }
                else
                {
                    Response.Write("<script>alert('País não encontrado!')</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Erro')</script>");
            }
            finally
            {
                con.Close();
            }
        }
    }
}