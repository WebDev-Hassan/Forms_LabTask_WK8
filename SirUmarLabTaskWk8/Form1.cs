using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirUmarLabTaskWk8
{
    public partial class Form1 : Form
    {
        string PicPath = "";
        string AppliedFor = "";
        string Name = "";
        string Fname = "";
        string Address = "";
        string Gender = "";
        int Age;
        string Nationality = "Pakistani";
        string Eligibility = "";

        public Form1()
        {
            InitializeComponent();
            AddBoard();
        }

        private string getGender()
        {
            if (rb_m.Checked)
                return rb_m.Text;
            else
                return rb_f.Text;
        }
        private int getAge()
        {
            DateTime dob = dtp_dob.Value;
            int age = 0;
            age = DateTime.Now.Subtract(dob).Days;
            age = age / 365;
            return age;

        }
        private void SaveDetails()
        {
            this.Name = txt_name.Text;
            this.Fname = txt_fname.Text;
            this.Address = txt_address.Text;
            this.Gender = getGender();
            this.Age = getAge();
            this.Nationality = chk_pakistani.Checked ? "Pakistani" : "Not Pakistani";
            this.Eligibility = this.Age >= 14 && this.Age < 24 ? "Yes" : "No";
        }
        private void ShowDetails()
        {
            dgv_details.Rows.Add(this.Name, this.Fname, this.PicPath, this.Age, this.Nationality, this.Eligibility);
        }
        private void AddBoard()
        {
            List<string> board = new List<string> { "FBISE", "BISE", "KPKBoard" };
            foreach (string b in board)
            {
                cb_board.Items.Add(b);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                this.PicPath = dialog.FileName;
                //picBox.Image = Image.FromFile(path);
                picbox.Image = Image.FromFile(PicPath);
            }
        }

        private void btn_savedetails_Click(object sender, EventArgs e)
        {
            SaveDetails();
            ShowDetails();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string course = txt_courses.Text;
            lb_courses.Items.Add(course);
        }

        private void btn_addtogrid_Click(object sender, EventArgs e)
        {
            string Degree = cb_degree.Text;
            string Board = cb_board.Text;
            List<string> courseList =  new List<string>();
            
            foreach(string c in lb_courses.Items)
            {
                courseList.Add(c);
            }

            int total = int.Parse(txt_total.Text);
            int obtained = int.Parse(txt_obtained.Text);
            int percentage = (int.Parse(txt_obtained.Text) * 100) / int.Parse(txt_total.Text);

            dgv.Rows.Add(Degree, Board, courseList, total, obtained, percentage);


        }
    }
}
