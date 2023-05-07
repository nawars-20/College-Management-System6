using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
           // if(username=="s"&& password == "s") //"student"
            //{
                menuStrip1.Visible = true;
                panel1.Visible = false;
            //}
            //else
            //{
              //  MessageBox.Show("Invalid userid or password", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }


        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }
        private void NewAdmissionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new_Admission na = new new_Admission();
            na.Show();

        }

        private void UpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpgradeSemester up = new UpgradeSemester();
            up.Show();
        }

        private void FeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees fs = new Fees();
            fs.Show();
        }

        private void SearchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent sr = new SearchStudent();
            sr.Show();
        }
        private void ExitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Us au = new About_Us();
            au.Show();
        }

        private void RemoveStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStudent rs = new RemoveStudent();
            rs.Show();
        }

        private void AddTeacherInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Teacher AT = new Add_Teacher();
            AT.Show();
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTeacher st = new SearchTeacher();
            st.Show();
        }

        private void IndividualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Individual_Student si = new Search_Individual_Student();
            si.Show();
        }
    }
}
