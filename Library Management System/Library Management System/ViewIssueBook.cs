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
    public partial class ViewIssueBook : Form
    {
        public ViewIssueBook()
        {
            InitializeComponent();
        }

        private void ViewIssueBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementSystemDataSet6.issuebook' table. You can move, or remove it, as needed.
            this.issuebookTableAdapter.Fill(this.libraryManagementSystemDataSet6.issuebook);
            // TODO: This line of code loads data into the 'libraryManagementSystemDataSet4.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.libraryManagementSystemDataSet4.student);

        }
    }
}
