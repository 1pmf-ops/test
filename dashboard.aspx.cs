using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lib
{
    public partial class dashboard : System.Web.UI.Page
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
        protected void Modify(Object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Ed")
            {
                Response.Redirect("./editEntry.aspx");
            }
            else
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridV_Select.Rows[index];
                MySqlConnection connection = connect();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "DELETE FROM books WHERE id=" + row.Cells[2].Text;
                command.ExecuteNonQuery();
                connection.Close();
                Response.Redirect("./dashboard.aspx");
            }
        }
        protected void Add(object sender, EventArgs e)
        {
            Response.Redirect("./addEntry.aspx");
        }
        protected void Search(object sender, EventArgs e)
        {
            Response.Redirect("./searchEntries.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = connect();
            if (connection != null)
            {
                DataTable dTab = new DataTable();
                dTab.Columns.Add("Id", typeof(string));
                dTab.Columns.Add("Authors", typeof(string));
                dTab.Columns.Add("Title", typeof(string));
                dTab.Columns.Add("Release_date", typeof(string));
                dTab.Columns.Add("ISBN", typeof(string));
                dTab.Columns.Add("Format", typeof(string));
                dTab.Columns.Add("Pages", typeof(string));
                dTab.Columns.Add("Description", typeof(string));

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM books";

                MySqlDataReader reader = command.ExecuteReader();
                string id, authors, title, releaseDate, isbn, format, pages, desc;
                while(reader.Read())
                {
                    id = reader.GetString("Id");
                    authors = reader.GetString("Authors");
                    title = reader.GetString("Title");
                    releaseDate = reader.GetString("Relese_date");
                    isbn = reader.GetString("ISBN");
                    format = reader.GetString("Format");
                    pages = reader.GetString("Pages");
                    desc = reader.GetString("Description");
           
                    DataRow row = dTab.NewRow();
                    row["Id"] = id;
                    row["Authors"] = authors;
                    row["Title"] = title;
                    row["Release_date"] = releaseDate;
                    row["ISBN"] = isbn;
                    row["Format"] = format;
                    row["Pages"] = pages;
                    row["Description"] = desc;// dodać (opcjonalnie) by przyciski były po lewej stronie

                    dTab.Rows.Add(row);
                }
                GridV_Select.DataSource = dTab;
                GridV_Select.DataBind();
            }
            connection.Close();
        }
    }
}