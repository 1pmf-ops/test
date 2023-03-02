using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lib
{
    public partial class Database : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

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

        protected void Bu_Send_Click(object sender, EventArgs e)
        {
            Session["db"] = connect();
            if (Session["db"] != null) {
                Response.Redirect("./dashboard.aspx", true);
            }
        }
    }
}