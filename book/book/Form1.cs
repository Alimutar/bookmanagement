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
    public partial class Form1 : Form
    {
        int move;
        int movx;
        int movy;
        SqlConnection con =new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        List<string> list = new List<string>();

        

        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move ==1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\ali\documents\visual studio 2017\Projects\book\book\Book_Database.mdf;Integrated Security=True");
            var sql = "SELECT Id ,title ,auther  ,price FROM books ";
            da = new SqlDataAdapter(sql,con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "التسلسل";
            dataGridView1.Columns[1].HeaderText = "أسم الكتاب";
            dataGridView1.Columns[2].HeaderText = "الكاتب";
            dataGridView1.Columns[3].HeaderText = "السعر";

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form frm_add = new Form_addBook();
            bunifuTransition1.ShowSync(frm_add);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Form_Details frdetails = new Form_Details();

            
            bunifuTransition1.ShowSync(frdetails);
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\ali\documents\visual studio 2017\Projects\book\book\Book_Database.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT title,auther,price,cat,date,rate FROM books WHERE id=@id ";
                cmd.Parameters.AddWithValue("@id", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(Convert.ToString(rd[0]));
                    list.Add(Convert.ToString(rd[1]));
                    list.Add(Convert.ToString(rd[2]));
                    list.Add(Convert.ToString(rd[3]));
                    list.Add(Convert.ToString(rd[4]));
                    list.Add(Convert.ToString(rd[5]));
                }

                frdetails.txt_name.Text = list[0];
                frdetails.txt_auther.Text = list[1];
                frdetails.txt_price.Text = list[2];
                frdetails.txt_cat.Text = list[3];
                frdetails.txt_date.Text = list[4];
                frdetails.txt_rate.Text = list[5];
                con.Close();

                con.Open();
                cmd.CommandText = "SELECT cover FROM books WHERE id=@idimage";
                cmd.Parameters.AddWithValue("@idimage", dataGridView1.CurrentRow.Cells[0].Value);
                byte[] img = (byte[])cmd.ExecuteScalar();
                MemoryStream ma = new MemoryStream();
                ma.Write(img, 0, img.Length);
                frdetails.txt_pictuer.Image = Image.FromStream(ma);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
            cmd.Parameters.Clear();
        }



        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form_addBook frm_add = new Form_addBook();
            frm_add.butt_addBook.ButtonText = "تعديل";
            frm_add.state = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            bunifuTransition1.ShowSync(frm_add);
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\ali\documents\visual studio 2017\Projects\book\book\Book_Database.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT title,auther,price,cat,date,rate FROM books WHERE id=@id ";
                cmd.Parameters.AddWithValue("@id",Convert.ToInt16( dataGridView1.CurrentRow.Cells[0].Value));
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(Convert.ToString(rd[0]));
                    list.Add(Convert.ToString(rd[1]));
                    list.Add(Convert.ToString(rd[2]));
                    list.Add(Convert.ToString(rd[3]));
                    list.Add(Convert.ToString(rd[4]));
                    list.Add(Convert.ToString(rd[5]));
                }
                
                frm_add.txt_name.Text = list[0];
                frm_add.txt_auther.Text = list[1];
                frm_add.txt_price.Text = list[2];
                frm_add.txt_cat.Text = list[3];
                frm_add.txt_date.Text= list[4];
                frm_add.txt_rate.Text = list[5];
                con.Close();

                con.Open();
                cmd.CommandText = "SELECT cover FROM books WHERE id=@idimage";
                cmd.Parameters.AddWithValue("@idimage", dataGridView1.CurrentRow.Cells[0].Value);
                byte[] img = (byte[])cmd.ExecuteScalar();
                MemoryStream ma = new MemoryStream();
                ma.Write(img, 0, img.Length);
                frm_add.txt_pictuer.Image = Image.FromStream(ma);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
            cmd.Parameters.Clear();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\ali\documents\visual studio 2017\Projects\book\book\Book_Database.mdf;Integrated Security=True");
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "DELETE FROM books WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();
            con.Close();
            Form_deletMassge Form_deletMassge = new Form_deletMassge();
            Form_deletMassge.Show();
            cmd.Parameters.Clear();
        }
    }
}
