using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCRUD
{
    public partial class _Default : Page
    {
        //menampilkan halaman
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                LoadRecord();
            }
        }
        SqlConnection conn = new SqlConnection(@"Data Source=martin-pc\martin880;Initial Catalog=StudentDB;Integrated Security=True");
        // Cara Insert data
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=martin-pc\martin880;Initial Catalog=StudentDB;Integrated Security=True");
            conn.Open();
            SqlCommand comm = new SqlCommand("insert into StudentInfoTab values ('"+int.Parse(TextBox1.Text)+"','"+TextBox2.Text+"','"+DropDownList1.SelectedValue+"','"+double.Parse(TextBox3.Text)+"','"+TextBox4.Text+"')", conn);
            comm.ExecuteNonQuery();
            conn.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Berhasil memasukkan data');", true);
            LoadRecord();
            ClearData();
        }

        // Membuat method untuk menampilkan record di GridView
        void LoadRecord()
        {
            SqlCommand comm = new SqlCommand("Select * From StudentInfoTab", conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        // method untuk fungsi clear data
        void ClearData() 
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            LoadRecord();
        }

        // fungsi update data
        protected void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("update StudentInfoTab set studentName = '"+TextBox2.Text+"', address = '"+DropDownList1.SelectedValue+"', age = '"+double.Parse(TextBox3.Text)+"', contact = '"+TextBox4.Text+"' where studentId = '"+int.Parse(TextBox1.Text)+"'" , conn);
            comm.ExecuteNonQuery();
            conn.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Berhasil mengupdate data');", true);
            LoadRecord();
            ClearData();
        }

        // fungsi delete data
        protected void Button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("delete StudentInfoTab where studentId = '" + int.Parse(TextBox1.Text) + "'", conn);
            comm.ExecuteNonQuery();
            conn.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Berhasil menghapus data');", true);
            LoadRecord();
        }

        // fungsi Get data
        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("Select * From StudentInfoTab where studentId = '" + int.Parse(TextBox1.Text) + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        // fungsi Search Data
        protected void Button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("Select * From StudentInfoTab where studentId = '" + int.Parse(TextBox1.Text) + "'", conn);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read()) 
            {
                TextBox2.Text = dr.GetValue(1).ToString();
                DropDownList1.SelectedValue = dr.GetValue(2).ToString();
                TextBox3.Text = dr.GetValue(3).ToString();
                TextBox4.Text = dr.GetValue(4).ToString();
            }
        }

        // fungsi clear data
        protected void Button6_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}