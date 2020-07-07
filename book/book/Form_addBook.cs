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
using System.IO;


namespace book
{
    public partial class Form_addBook : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        List<String> list = new List<string>();
        public int state;
        public Form_addBook()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form_cat = new Form_cat();
            bunifuTransition1.ShowSync(form_cat);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_addBook_Load_1(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\ali\documents\visual studio 2017\Projects\book\book\Book_Database.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT cat FROM Tb_cat ";
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(Convert.ToString(rd[0]));
                }
                int i = 0;
                while (i < list.LongCount())
                {
                    txt_cat.Items.Add(list[i]);
                    i = i + 1;
                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form_addBook frm_add = new Form_addBook();
            frm_add.butt_addBook.ButtonText = "أضافة";
            frm_add.state = 0;
            bunifuTransition1.ShowSync(frm_add);
            if(txt_name.Text=="" || txt_auther.Text == "")
            {
                MessageBox.Show("الرجاء ادخل معلومات الكتاب");
            }
            else
            {
                if (state == 0)
                {
                    MemoryStream ma = new MemoryStream();
                    txt_pictuer.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _cover = ma.ToArray();

                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\ali\documents\visual studio 2017\Projects\book\book\Book_Database.mdf;Integrated Security=True");
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO books (title,auther,price,cat,date,rate,cover) VALUES (@title,@auther,@price,@cat,@date,@rate,@cover) ";
                    cmd.Parameters.AddWithValue("@title", txt_name.Text);
                    cmd.Parameters.AddWithValue("@auther", txt_auther.Text);
                    cmd.Parameters.AddWithValue("@price", txt_price.Text);
                    cmd.Parameters.AddWithValue("@cat", txt_cat.Text);
                    cmd.Parameters.AddWithValue("@date", txt_date.Value);
                    cmd.Parameters.AddWithValue("@rate", txt_rate.Value);
                    cmd.Parameters.AddWithValue("@cover", _cover);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form Form_massageAdd = new Form_massageAdd();
                    Form_massageAdd.Show();
                    this.Close();
                }
                else
                {
                    MemoryStream ma = new MemoryStream();
                    txt_pictuer.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _cover = ma.ToArray();

                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\ali\documents\visual studio 2017\Projects\book\book\Book_Database.mdf;Integrated Security=True");
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE  books SET title=@title,auther=@auther,price=@price,cat=@cat,date=@date,rate=@rate,cover=@cover WHERE id=@id";
                    cmd.Parameters.AddWithValue("@title", txt_name.Text);
                    cmd.Parameters.AddWithValue("@auther", txt_auther.Text);
                    cmd.Parameters.AddWithValue("@price", txt_price.Text);
                    cmd.Parameters.AddWithValue("@cat", txt_cat.Text);
                    cmd.Parameters.AddWithValue("@date", txt_date.Value);
                    cmd.Parameters.AddWithValue("@rate", txt_rate.Value);
                    cmd.Parameters.AddWithValue("@cover", _cover);
                    cmd.Parameters.AddWithValue("@id", state);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form Form_edit = new Form_edit();
                    Form_edit.Show();
                    this.Close();

                }
            }
            cmd.Parameters.Clear();
               
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dia = new OpenFileDialog();
            var result = dia.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_pictuer.Image = Image.FromFile(dia.FileName);
            }
        }

        private void txt_pictuer_Click(object sender, EventArgs e)
        {

        }
    }
}
