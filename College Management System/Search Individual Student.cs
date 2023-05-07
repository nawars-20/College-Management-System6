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
    public partial class Search_Individual_Student : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\aladil 2\source\repos\College Management System\College Management System\My College.accdb");
        OleDbCommand cmd1;
        /*OleDbDataAdapter DA;
        DataTable DT = new DataTable();*/
        public Search_Individual_Student()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd1 = new OleDbCommand("select ID,fullname,Mothername,Gender,DateBrith,MobileNo,Email,Semester,Programming,School,Duration,Address From student where ID="+txtregestrationsem.Text+"", con);
          /*  OleDbDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                labID.Text = reader1["ID"].ToString();
                labfullname.Text = reader1["fullname"].ToString();
                labmother.Text = reader1["Mothername"].ToString();
                labgender.Text = reader1["Gender"].ToString();
                labdate.Text = reader1["DateBrith"].ToString();
                labmobile.Text = reader1["MobileNo"].ToString();
                labemail.Text = reader1["Email"].ToString();
                labsemester.Text = reader1["Semester"].ToString();
                labprogram.Text = reader1["Programming"].ToString();
                labschool.Text = reader1["School"].ToString();
                labduration.Text = reader1["Duration"].ToString();
                labaddress.Text = reader1["Address"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }*/
            con.Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtregestrationsem.Text = "";
            labID.Text = "___";
            labfullname.Text = "___";
            labmother.Text = "___";
            labgender.Text = "___";
            labmobile.Text = "___";
            labdate.Text = "___";
            labemail.Text = "___";
            labsemester.Text = "___";
            labprogram.Text = "___";
            labschool.Text = "___";
            labduration.Text = "___";
            labaddress.Text = "___";

        }

        private void Search_Individual_Student_Load(object sender, EventArgs e)
        {

        }

        private void Labschool_Click(object sender, EventArgs e)
        {

        }

        private void Labsemester_Click(object sender, EventArgs e)
        {

        }

        private void Labemail_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }
    }
}
