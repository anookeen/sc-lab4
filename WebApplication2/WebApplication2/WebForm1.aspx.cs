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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=user_info;UID=root;Password=seecs@123");
            string a = TextBox1.Text;
            string b = TextBox2.Text;
            string c = TextBox3.Text;
            string d = TextBox4.Text;
            if (a != "" && b != "" && c != "" && d != "")
            {
                string insertStatement = "insert into userdata (userName,fname,lname,address) values('" + a + "','" + b + "','" + c + "','" + d + "')";
                string exists = "Select username from userdata where username='" + TextBox1.Text + "'";
                con.Open();
                MySqlCommand commandDatabase = new MySqlCommand(insertStatement, con);
                MySqlCommand commandDatabase1 = new MySqlCommand(exists, con);
                MySqlDataReader reader;
                reader = commandDatabase1.ExecuteReader();
                int rows = 0;
                //Response.Write(rows1);
                if (!reader.Read())
                {
                    reader.Close();
                    rows = commandDatabase.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        Response.Write("<script>alert('Data Stored')</script>");
                    }

                }



                else
                {
                    Response.Write("<script>alert('Username already exists')</script>");
                }
            }
            else {
                Response.Write("<script>alert('Enter data')</script>");
            }
            //reader.Close();
            con.Close();
            TextBox1.Text="";
            TextBox2.Text="";
            TextBox3.Text="";
            TextBox4.Text="";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Webform2.aspx", true);
        }
    }
}