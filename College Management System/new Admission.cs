using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace College_Management_System
{
    public partial class new_Admission : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\aladil 2\source\repos\College Management System\My College.accdb");
        OleDbDataAdapter DA;
        OleDbCommand cmd;
        DataTable DT = new DataTable();
        public new_Admission()
        {
            InitializeComponent();
           
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtFullName.Clear();
            txtMotherName.Clear();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();
            comboBoxSemester.ResetText();
            comboBoxprogramming.ResetText();
            comboBoxDuration.ResetText();
            txtSchoolName.Clear();
            richTextBoxAddress.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            string gender = "";
             bool ischecked = radioButtonMale.Checked;
             if (ischecked)
             {
                 gender = radioButtonMale.Text;
             }
             else
             {
                 gender = radioButtonFemale.Text;
             }
            cmd = new OleDbCommand("insert into student (ID,fullname,Mothername,Gender,DateBrith,MobileNo,Email,Semester,Programming,School,Duration,Address) values('" + Convert.ToInt32(txtID.Text)+"','"+txtFullName.Text+"','"+txtMotherName.Text+"','"+gender+"','"+dateTimePickerDOB.Text+"','"+Convert.ToInt64(txtMobile.Text)+"','"+txtEmail.Text+"','"+comboBoxSemester.Text+"','"+comboBoxprogramming.Text+"','"+txtSchoolName.Text+ "','"+comboBoxDuration.Text+"','"+richTextBoxAddress.Text+"')", con);
            OleDbDataAdapter Ad = new OleDbDataAdapter(cmd);
            DataSet Ds = new DataSet();
            Ad.Fill(Ds);

            MessageBox.Show("Data Saved.", "Data", MessageBoxButtons.OK,MessageBoxIcon.Hand);
            con.Close();
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void New_Admission_Load(object sender, EventArgs e)
        {
            DA = new OleDbDataAdapter("insert into From student", con);
          
           
        }
    }
}
