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
    public partial class Fees : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\aladil 2\source\repos\College Management System\College Management System\My College.accdb");
        OleDbCommand cmd;
        OleDbDataAdapter DA;
        public Fees()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            cmd = new OleDbCommand("insert into Fees (ID,fees) values('"+Convert.ToInt32(txtRegestration.Text)+"','"+txtFees.Text+"')", con);
            DA = new OleDbDataAdapter(cmd);
            DA.Fill(ds);
            if (MessageBox.Show("Fees Submition Successfull.","Success",MessageBoxButtons.OK,MessageBoxIcon.Asterisk)==DialogResult.OK)
            {
                txtRegestration.Text = "";
                txtFees.Text = "";
                labfull.Text = "_____";
                labmother.Text = "_____";
                labduration.Text = "_____";

            }

        }

        private void Fees_Load(object sender, EventArgs e)
        {

        }

        private void TxtFees_TextChanged(object sender, EventArgs e)
        { 

        }

        private void TxtRegestration_TextChanged(object sender, EventArgs e)
        {
            if (txtRegestration.Text != "")
            {
                DataSet ds = new DataSet();
                cmd = new OleDbCommand("select full_name,Mother_name,Duration From student where ID=" + txtRegestration.Text + "", con);
                DA = new OleDbDataAdapter(cmd);
                DA.Fill(ds);

                if(ds.Tables[0].Rows.Count != 0)
                {
                    labfull.Text = ds.Tables[0].Rows[0][0].ToString();
                    labmother.Text = ds.Tables[0].Rows[0][1].ToString();
                    labduration.Text = ds.Tables[0].Rows[0][2].ToString();

                }
                else
                {
                    labfull.Text = "_____";
                    labmother.Text = "_____";
                    labduration.Text = "_____";
                }
            }
        }

        private void Labfull_Click(object sender, EventArgs e)
        {

        }
    }
}
