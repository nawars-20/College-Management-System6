using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class UpgradeSemester : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\aladil 2\source\repos\College Management System\My College.accdb");
        OleDbDataAdapter DA;
        OleDbCommand cmd;
        DataTable DT = new DataTable();
        public UpgradeSemester()
        {
            InitializeComponent();
            DA = new OleDbDataAdapter("select *From student", con);
        }

        private void UpgradeSemester_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnUpgrade_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("update student set Semester='" + comboBoxTo.Text + "'where Semester='" +comboBoxFrom.Text+ "' ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved. Remember the Registration ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}
