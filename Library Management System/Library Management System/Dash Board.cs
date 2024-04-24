using System;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Dash_Board : Form
    {
        private string text;
        private int len = 0;

        public Dash_Board()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = MessageBox.Show("Do You Want To Exit?", "Asking Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (result == "Yes")
            {
                Application.Exit();
            }
        }

        private void Dash_Board_Load(object sender, EventArgs e)
        {
            text = lbl_txt.Text;
            lbl_txt.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                lbl_txt.Text = lbl_txt.Text + text[len];
                len++;
                
            }
            else
            {
                // Reset len to 0 to restart the animation
                lbl_txt.Text = null;
                len = 0;
            }
        }

        private void addNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            AddBook ab = new AddBook();
            ab.Show(this);

        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBook vb = new viewBook();
            vb.Show(this);  
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_student ad = new Add_student();
            ad.Show(this);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeiwStudent vs = new VeiwStudent();
            vs.Show(this);
        }

        private void addIssueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issue_book b = new issue_book();
            b.Show(this);
        }

        private void viewIssueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewIssueBook vs = new ViewIssueBook();
            vs.Show(this);
        }

        private void addReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return_Book rb = new Return_Book();
            rb.Show(this);
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {Veiw_Retrun r = new Veiw_Retrun();
            r.Show(this);
        }
    }
}
