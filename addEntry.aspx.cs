using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lib
{
    public partial class addEntry : System.Web.UI.Page
    {
        private MySqlConnection connect()
        {
            // string myconnection = "Server=" + TxBx_Server.Text + ";Port=" + TxBx_Port.Text + ";Database=" + TxBx_Database + ";User=" + TxBx_User + ";Password=" + TxBx_Password + ";";
            string myconnection = "Server=localhost;Database=biblioteka;User=root;Password=;";
            MySqlConnection connection = new MySqlConnection(myconnection);
            try
            {
                connection.Open();
                Console.WriteLine("Connected");
                return connection;
            }
            catch
            {
                Console.WriteLine("Error");
            }
            return null;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("./dashboard.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = connect();
            if (connection != null)
            {
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO books (Authors, Title, Relese_date, ISBN, Format, Pages, Description) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "')";
                command.ExecuteNonQuery();
                Response.Redirect("./dashboard.aspx");
            }else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", "alert(\"Brak połaczenia z bazą danych, odświerz stronę!\")", true);
            }
        }
    }
}