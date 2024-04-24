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
    public partial class Veiw_Retrun : Form
    {
        public Veiw_Retrun()
        {
            InitializeComponent();
        }

        private void Veiw_Retrun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementSystemDataSet5.ReturnBook' table. You can move, or remove it, as needed.
            this.returnBookTableAdapter.Fill(this.libraryManagementSystemDataSet5.ReturnBook);

        }
    }
}
