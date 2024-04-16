using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication37
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\srcadmin\documents\visual studio 2012\Projects\WebApplication37\WebApplication37\App_Data\Database1.mdf;Integrated Security=True");
            con.Open();


            SqlCommand cmd = new SqlCommand("INSERT INTO Register(FName,Email,Password) VALUES (@FName,@Email,@Password)", con);
            cmd.Parameters.AddWithValue("@FName", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Email", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox3.Text);
            cmd.ExecuteNonQuery();
            Label1.Text = "Successfully Register!";
            con.Close();
            
            

        }
    }
}