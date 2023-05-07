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
    public partial class Add_Teacher : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\aladil 2\source\repos\College Management System\My College.accdb");
        OleDbDataAdapter DA;
        OleDbCommand cmd;
        DataTable DT = new DataTable();
        public Add_Teacher()
        {
            InitializeComponent();
            DA = new OleDbDataAdapter("select *From teacher", con);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string gender = "";
            bool ischecked=radioButtonchMale.Checked;
            if (ischecked)
            {
                gender =radioButtonchMale.Text;
            }
            else
            {
                gender = radioButtonchFemale.Text;
            }
            cmd =new OleDbCommand("insert into teacher values('"+txtchID.Text+"','"+txtchFullName.Text+"','"+gender+"','"+dateTimePickerchDOB.Text+"','"+txtchMobile.Text+"','"+txtchEmail.Text+"','"+comboBoxchSemester.Text+"','"+comboBoxchprogramming.Text+"','"+comboBoxchDuration.Text+"','"+richTextBoxchAddress.Text+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved","Add",MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }

        private void TxtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtuReset_Click(object sender, EventArgs e)
        {
            txtchID.Text = "";
            txtchFullName.Text = "";
            radioButtonchMale.Checked = false;
            radioButtonchFemale.Checked = false;
            txtchMobile.Text = "";
            txtchEmail.Text = "";
            comboBoxchSemester.Text = "";
            comboBoxchprogramming.Text = "";
            comboBoxchDuration.Text = "";
            richTextBoxchAddress.Text = "";
            dateTimePickerchDOB.Text = "";
        }

        private void Add_Teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
