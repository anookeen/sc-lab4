using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=user_info;UID=root;Password=seecs@123");
            string a = TextBox1.Text;
            string b = TextBox2.Text;
            if (a != "" && b != "")
            {
                string insertStatement = "Select * from admin where userName='" + a + "' and password='" + b + "'";

                con.Open();
                MySqlCommand commandDatabase = new MySqlCommand(insertStatement, con);
                MySqlDataReader reader;
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    Server.Transfer("Webform3.aspx", true);
                }
                else
                {
                    Response.Write("Wrong credentials");
                }
                reader.Close();
                con.Close();
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Enter Credentials')</script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Webform1.aspx", true);
        }
    }
}