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
    public partial class issue_book : Form
    {
        public issue_book()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string querry = "insert into issuebook values('"+txt_StdID.Text+"','"+txt_bookid.Text+"','"+txt_issuedate.Text+"','"+txt_duedate.Text+"') ";
            helper hp = new helper();
            hp.OpenCon();
            hp.NonexecuteQuerry(querry);
            MessageBox.Show("Record Save Successfully");
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
    }
}
