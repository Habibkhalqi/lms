using Library_Management_System.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Return_Book : Form
    {
        public Return_Book()
        {
            InitializeComponent();
        }
        string connection = System.Configuration.ConfigurationManager.ConnectionStrings["myconnecton"].ToString();
        private void button1_Click(object sender, EventArgs e)
        {
            string querrry = "select * from issuebook where Studentid ='"+txt_StdID.Text+ "' AND bookid = '"+txt_bookid.Text+"' ";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd  = new SqlCommand(querrry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                string querry = "insert into ReturnBook values('" + txt_StdID.Text + "','" + txt_bookid.Text + "','" + txt_returndate.Text + "','" + txt_latefee.Text + "') ";
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

                string querryy = "Delete  from issuebook where Studentid ='" + txt_StdID.Text + "' AND bookid = '" + txt_bookid.Text + "' ";
                SqlConnection scon = new SqlConnection(connection);
                scon.Open();
                SqlCommand cmdd = new SqlCommand(querryy, scon);
                cmdd.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("student id or book id is not matching or this student id is not register or issued book for this id");
            }
           
          
        }
    }
}
