using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVEDRI_Lab_Act2
{
    public partial class Form1 : Form
    {

        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            //data += txtName.Text + ", ";
            string gender = "";

            if (rdoMale.Checked)
            {
                //string male = rdoMale.Checked;

                gender = rdoMale.Text;
            }

            if (rdoFemale.Checked)
            {
                gender = rdoFemale.Text;
            }

            string hobby = "";

            if (chkBasketball.Checked)
            {
                hobby += chkBasketball.Text + ", ";
            }

            if (chkVolleyball.Checked)
            {
                hobby += chkVolleyball.Text + ", ";
            }

            if (chkSoccer.Checked)
            {
                hobby += chkSoccer.Text + ", ";
            }

            if (IsUsernameAndPasswordExist(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Username/Password already exist. Please choose a different one.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string favColor = cmbFavColor.Text;

            string saying = txtSaying.Text;

            string address = txtAddress.Text;

            string email = txtEmail.Text;

            string age = txtAge.Text;

            string username = txtUsername.Text;

            string password = txtPassword.Text;

            string course = cmbCourse.Text;

            string pic = txtProfile.Text;

            //UNSURE OF THIS
            string bday = dateTimePicker1.Text;

            Workbook book = new Workbook();

            book.LoadFromFile(@"C:\Users\ACT-STUDENT\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");

            Worksheet sheet = book.Worksheets[0];

            int row = sheet.Rows.Length + 1;

            sheet.Range[row, 1].Value = name;
            sheet.Range[row, 2].Value = gender;
            sheet.Range[row, 3].Value = hobby;
            sheet.Range[row, 4].Value = favColor;
            sheet.Range[row, 5].Value = address;
            sheet.Range[row, 6].Value = email;
            sheet.Range[row, 7].Value = bday;
            sheet.Range[row, 8].Value = age;
            sheet.Range[row, 9].Value = username;
            sheet.Range[row, 10].Value = password;
            sheet.Range[row, 11].Value = saying;
            sheet.Range[row, 12].Value = course;

            sheet.Range[row, 13].Value = pic;

            //UNSURE OF THIS
            sheet.Range[row, 14].Value = "1";

            book.SaveToFile(@"C:\Users\ACT-STUDENT\source\repos\EVEDRI_Lab_Act2\Book1.xlsx", ExcelVersion.Version2016);

            DataTable dt = sheet.ExportDataTable();

            form2.dataGridView1.DataSource = dt;

            MessageBox.Show("Successfully added!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset fields
            txtName.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            chkBasketball.Checked = false;
            chkVolleyball.Checked = false;
            chkSoccer.Checked = false;
            cmbFavColor.SelectedIndex = -1;
            txtSaying.Clear();
            //UNSURE OF THIS
            dateTimePicker1.Text = string.Empty;
            txtAge.Clear();
            cmbCourse.SelectedIndex = -1;
            txtUsername.Clear();
            txtPassword.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtProfile.Clear();

            //focus to name field
            txtName.Focus();
            // if fields empty
            //Message box show: Error, Missing Fields You need to fill up all the empty fields

            if (txtName.Text == "" || txtAge.Text == "" || cmbCourse.Text == "" || rdoFemale.Checked == false && rdoMale.Checked == false || cmbFavColor.Text == "" ||
                chkBasketball.Checked == false && chkVolleyball.Checked == false && chkSoccer.Checked == false || cmbCourse.Text == ""
                || txtSaying.Text == "" || dateTimePicker1.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtProfile.Text == "")
            {
                MessageBox.Show("Error, Missing Fields You need to fill up all the empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtName.Text.Any(char.IsDigit)) 
            {
                MessageBox.Show("Error, you can't put numbers in your name, No Numbers allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtSaying.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Error, you can't put numbers in your saying, No Numbers allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtAge.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Error, you can't put letters in your age, No Letters allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //string val = "";

            //for (int j = 0; j < i; j++)
            //{
            //    val += "["+j+"] = "+ student[j] +"\n";
            //}

            //MessageBox.Show(val);
            
            form2.Show();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;


            string gender = "";

            if (rdoMale.Checked)
            {


                gender = rdoMale.Text;
            }

            if (rdoFemale.Checked)
            {
                gender = rdoFemale.Text;
            }

            string hobby = "";

            if (chkBasketball.Checked)
            {
                hobby += chkBasketball.Text + ", ";
            }

            if (chkVolleyball.Checked)
            {
                hobby += chkVolleyball.Text + ", ";
            }

            if (chkSoccer.Checked)
            {
                hobby += chkSoccer.Text + ", ";
            }

            if (IsUsernameAndPasswordExist(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Username/Password already exist. Please choose a different one.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string favColor = cmbFavColor.Text;

            string saying = txtSaying.Text;

            string address = txtAddress.Text;

            string email = txtEmail.Text;

            string age = txtAge.Text;

            string username = txtUsername.Text;

            string password = txtPassword.Text;

            string course = cmbCourse.Text;

            //UNSURE OF THIS
            string bday = dateTimePicker1.Text;

            string profile = txtProfile.Text;

            //data += cmbFavColor.Text + ", ";

            //data += txtSaying.Text;

            //student[i] = data;

            //i++;

            /*form2.updateData(Convert.ToInt32(lblId.Text), name, gender, hobby, favColor, saying);*/

            int row = Convert.ToInt32(lblId.Text) + 2;

            Workbook book = new Workbook();

            book.LoadFromFile(@"C:\Users\ACT-STUDENT\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");

            Worksheet sheet = book.Worksheets[0];

            // int row = sheet.Rows.Length;

            //sheet.Range[row, 1].Value = name;
            //sheet.Range[row, 2].Value = gender;
            //sheet.Range[row, 3].Value = hobby;        
            //sheet.Range[row, 8].Value = favColor;
            //sheet.Range[row, 9].Value = saying;
            //sheet.Range[row, 4].Value = txtAddress.Text;
            //sheet.Range[row, 5].Value = txtEmail.Text;
            //sheet.Range[row, 6].Value = dtpBirthday.Text;
            //sheet.Range[row, 7].Value = txtAge.Text;
            //sheet.Range[row, 10].Value = txtUsername.Text;
            //sheet.Range[row, 11].Value = txtPassword.Text;

            sheet.Range[row, 1].Value = name;
            sheet.Range[row, 2].Value = gender;
            sheet.Range[row, 3].Value = hobby;
            sheet.Range[row, 4].Value = favColor;
            sheet.Range[row, 5].Value = address;
            sheet.Range[row, 6].Value = email;
            sheet.Range[row, 7].Value = bday;
            sheet.Range[row, 8].Value = age;
            sheet.Range[row, 9].Value = username;
            sheet.Range[row, 10].Value = password;
            sheet.Range[row, 11].Value = saying;
            sheet.Range[row, 12].Value = course;
            sheet.Range[row, 13].Value = profile;
            
            sheet.Range[row, 14].Value = "1";

            book.SaveToFile(@"C:\Users\ACT-STUDENT\source\repos\EVEDRI_Lab_Act2\Book1.xlsx", ExcelVersion.Version2016);

            DataTable dt = sheet.ExportDataTable();

            form2.dataGridView1.DataSource = dt;

            MessageBox.Show("Successfully updated!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset fields
            txtName.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            chkBasketball.Checked = false;
            chkVolleyball.Checked = false;
            chkSoccer.Checked = false;
            cmbFavColor.SelectedIndex = -1;
            txtSaying.Clear();
            txtAge.Clear();
            cmbCourse.SelectedIndex = -1;

            //UNSURE OF THIS
            dateTimePicker1.Text = string.Empty;

            txtUsername.Clear();
            txtPassword.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtProfile.Clear();

            //focus to name field
            txtName.Focus();          

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string[] date = dateTimePicker1.Text.Split(',');

            int age = DateTime.Now.Year - Convert.ToInt32(date[2]);

            txtAge.Text = age.ToString();
        }

        private void btnBrowsee_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtProfile.Text = openFileDialog.FileName;
            }
        }

        private bool IsUsernameAndPasswordExist(string username, string password)
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\GUSTAV\Desktop\Projects\mec\Spam\Manriquez\Book1.xlsx");

            Worksheet sh = book.Worksheets[0];
            DataTable dt = sh.ExportDataTable();

            foreach (DataRow row in dt.Rows)
            {
                if (row["Username"].ToString() == username && row["Password"].ToString() == password)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnBacktoDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }
    }
}
