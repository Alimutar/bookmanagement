using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace book
{
    public partial class Form_cat : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Form_cat()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txt_addCat.Text != "")
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\ali\documents\visual studio 2017\Projects\book\book\Book_Database.mdf;Integrated Security=True");
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Tb_cat (cat) VALUES (@cat) ";
                cmd.Parameters.AddWithValue("@cat", txt_addCat.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Form Form_massageAdd = new Form_massageAdd();
                Form_massageAdd.Show();

                    

                
            }
            else
            {
                MessageBox.Show("الرجاء ادخل الصنف !!");
            }
        }
    }
}
