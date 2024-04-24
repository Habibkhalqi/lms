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
    public partial class VeiwStudent : Form
    {
        public VeiwStudent()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addBookBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VeiwStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementSystemDataSet3.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.libraryManagementSystemDataSet3.student);

        }
    }
}
