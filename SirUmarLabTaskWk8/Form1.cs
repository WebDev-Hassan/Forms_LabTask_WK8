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
        string PicPath = String.Empty;
        string AppliedFor = String.Empty;
        string Name = String.Empty;
        string Fname = String.Empty;
        string Address = String.Empty;
        string Gender = String.Empty;
        int Age;
        string Nationality = String.Empty;
        string Eligibility = String.Empty;

        public Form1()
        {
            InitializeComponent();
            AddBoard();
            chk_pakistani.Checked = true;
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
            ClearDetails();
        }
        private void ClearDetails()
        {
            this.Name = String.Empty;
            this.Fname = String.Empty;
            this.Address = String.Empty;
            this.Gender = String.Empty;
            this.Age = 0;
            this.Nationality = String.Empty;
            this.Eligibility = String.Empty;
        }
        private void AddBoard()
        {
            List<string> board = new List<string> { "FBISE", "BISE", "KPKBoard" };
            foreach (string b in board)
            {
                cb_board.Items.Add(b);
            }
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
            string CourseList = "";
            
            foreach(string c in lb_courses.Items)
            {
                CourseList += c + " ";
            }

            int total = int.Parse(txt_total.Text);
            int obtained = int.Parse(txt_obtained.Text);
            int percentage = (int.Parse(txt_obtained.Text) * 100) / int.Parse(txt_total.Text);

            dgv.Rows.Add(Degree, Board, CourseList, total, obtained, percentage);


        }

        private void lb_courses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int ind = lb_courses.SelectedIndex;
            lb_courses.Items.RemoveAt(ind);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
