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
    public partial class RemoveStudent : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\aladil 2\source\repos\College Management System\My College.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter Ad;
        DataTable DT = new DataTable();
        public RemoveStudent()
        {
            InitializeComponent();
            DGView();
        }
        
        void DGView()
        {
            DT.Clear();
            Ad = new OleDbDataAdapter("select * From student", con);
            Ad.Fill(DT);
            dataGridViewDelete.DataSource = DT;

        }
        
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("delete * from student where ID=" + txtDelRegestration.Text + "", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DGView();
            MessageBox.Show("Deleted Successful", "Delete", MessageBoxButtons.OK);
            txtDelRegestration.Clear();
        }

        private void DataGridViewDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void RemoveStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
