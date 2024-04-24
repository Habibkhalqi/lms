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
    public partial class Add_student : Form
    {
        public Add_student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querry = "INSERT INTO student VALUES('" + txt_studentid.Text + "','" + txt_sname.Text + "','" + txt_dob.Text+ "','" + txt_address.Text + "','" + txt_contact + "')";
            helper hp = new helper();
            hp.OpenCon();
            hp.NonexecuteQuerry(querry);
            MessageBox.Show("Add Book Successfully ");
            hp.CloseCon();

            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    t.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if(item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    t.Clear();
                }

            }
        }
    }
}
