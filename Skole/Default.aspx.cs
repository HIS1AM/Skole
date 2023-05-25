using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Skole
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=172.22.62.47;Initial Catalog=Test;User ID=hisham;Password=H1j2z3b4.04");
        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=172.22.62.47;Initial Catalog=Test;User ID=hisham;Password=H1j2z3b4.04"))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Elev WHERE Fornavn = @Fornavn AND Etternavn = @Etternavn";
                cmd.Parameters.AddWithValue("@Fornavn", Fornavn.Text);
                cmd.Parameters.AddWithValue("@Etternavn", Etternavn.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                GridView1.DataSource = dataTable;
                GridView1.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=172.22.62.47;Initial Catalog=Test;User ID=hisham;Password=H1j2z3b4.04"))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Elev WHERE KlasseID = @KlasseID;";
                cmd.Parameters.AddWithValue("@KlasseID", KlasseID.Text);        

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                GridView1.DataSource = dataTable;
                GridView1.DataBind();
            }

        }
    }
}