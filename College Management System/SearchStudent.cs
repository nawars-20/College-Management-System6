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
    public partial class SearchStudent : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\aladil 2\source\repos\College Management System\My College.accdb");
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataTable DT = new DataTable();
        public SearchStudent()
        {
            InitializeComponent();
            //DGview();

        }
        void DGview()
        {
            DT.Clear();
            da = new OleDbDataAdapter("select * From student", con);
            da.Fill(DT);
            dataGridView1.DataSource = DT;

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            DGview();
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // OleDbDataAdapter dax = new OleDbDataAdapter();
            //DataTable dtx = new DataTable();
            DataSet ds = new DataSet();
            da= new OleDbDataAdapter("Select * From student where ID=" + txtstudRegestration.Text + "", con);
           da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            txtstudRegestration.Clear();
        }

        private void TxtRegestration_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
