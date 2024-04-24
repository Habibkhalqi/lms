using Library_Management_System.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querry = "INSERT INTO Book VALUES('" + txt_bookid.Text+"','" + txt_bookname.Text + "','" + txt_bookauthourname.Text + "','" + txt_bookpublicaton.Text + "','" + txt_datetime.Text + "','" + txt_bookprice.Text + "','" + txt_bookquantity.Text + "')";
            helper hp = new helper();
            hp.OpenCon();
            hp.NonexecuteQuerry(querry);
            MessageBox.Show("Add Book Successfully ");
            hp.CloseCon();

            foreach (var item in this.Controls)
            {
                if(item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    t.Clear();
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_bookname.Clear();
            txt_bookauthourname.Clear();
            txt_bookpublicaton.Clear();
            txt_bookprice.Clear();
            txt_bookquantity.Clear();
            txt_bookname.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_datetime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_bookquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_bookprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_bookpublicaton_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_bookauthourname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_bookname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
