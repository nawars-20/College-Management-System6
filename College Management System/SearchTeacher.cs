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
    public partial class SearchTeacher : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\aladil 2\source\repos\College Management System\My College.accdb");
        OleDbCommand cmd;
        OleDbDataAdapter Da;
        DataTable DT = new DataTable();

        public SearchTeacher()
        {
            InitializeComponent();
        }
        void DGview()
        {
            DT.Clear();
            Da = new OleDbDataAdapter("select * From teacher", con);
            Da.Fill(DT);
            dataGridView1.DataSource = DT;
        }

        private void SearchTeacher_Load(object sender, EventArgs e)
        {
            DGview();

        }

        private void BtnSearchteacher_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            Da = new OleDbDataAdapter("select * From teacher where ID=" + txtteacherRegestration.Text + "", con);
            Da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            txtteacherRegestration.Clear();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
