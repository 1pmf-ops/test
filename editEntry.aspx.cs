using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lib
{
    public partial class editEntry : System.Web.UI.Page
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
        protected void Edit(object sender, EventArgs e)
        {
            MySqlConnection conn = connect();
            if(conn != null)
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "UPDATE books SET Authors='" + TxBx_Authors.Text + "', Title='" + TxBx_Title.Text + "', Relese_date='" + TxBx_ReDate.Text + "', ISBN='" + TxBx_ISBN.Text + "', Format='" + TxBx_Format.Text + "', Pages='" + TxBx_Pages.Text + "', Description='" + TxBx_Desc.Text + "' WHERE Id=" + int.Parse(Session["Id"].ToString()) + ";";
                command.ExecuteNonQuery();
                Response.Redirect("./dashboard.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", "alert(\"Brak połaczenia z bazą danych, odświerz stronę!\")", true);
            }
        }
        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("./dashboard.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["send"].ToString() == "1")
            {
                TxBx_Authors.Text = Session["Authors"].ToString();
                TxBx_Title.Text = Session["Title"].ToString();
                TxBx_ReDate.Text = Session["Release_date"].ToString();
                TxBx_ISBN.Text = Session["ISBN"].ToString();
                TxBx_Format.Text = Session["Format"].ToString();
                TxBx_Pages.Text = Session["Pages"].ToString();
                TxBx_Desc.Text = Session["Desc"].ToString();
                Session["send"] = 0;
            }
        }
    }
}