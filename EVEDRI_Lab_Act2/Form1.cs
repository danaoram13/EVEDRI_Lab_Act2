using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVEDRI_Lab_Act2
{
    public partial class Form1 : Form
    {

        /*Form2 form2 = new Form2();*/
        Form2 form2;

        Dashboard dashboard;
        public Form1(Dashboard dash)
        {
            InitializeComponent();
            dashboard = dash;
            form2 = new Form2(dashboard);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

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
            if (txtSaying.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Error, you can't put numbers in your saying, No Numbers allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtAge.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Error, you can't put letters in your age, No Letters allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            book.LoadFromFile(@"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");

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

            book.SaveToFile(@"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx", ExcelVersion.Version2016);

            DataTable dt = sheet.ExportDataTable();

            form2.dataGridView1.DataSource = dt;

            RefreshDashboardData();

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
            
            
        }
        private void RefreshDashboardData()
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");

            Worksheet sheet = book.Worksheets[0];
            int rowCount = sheet.Rows.Length;

            int activeCount = 0;
            int inactiveCount = 0;
            int maleCount = 0;
            int femaleCount = 0;
            int basketballCount = 0;
            int volleyballCount = 0;
            int soccerCount = 0;

            for (int i = 2; i <= rowCount; i++)
            {
                if (sheet.Range[i, 14].Value == "1")
                {
                    activeCount++;
                }
                else
                {
                    inactiveCount++;
                }

                if (sheet.Range[i, 2].Value == "Male")
                {
                    maleCount++;
                }
                else if (sheet.Range[i, 2].Value == "Female")
                {
                    femaleCount++;
                }

                string hobbies = sheet.Range[i, 3].Value;
                if (hobbies.Contains("Basketball"))
                {
                    basketballCount++;
                }
                if (hobbies.Contains("Volleyball"))
                {
                    volleyballCount++;
                }
                if (hobbies.Contains("Soccer"))
                {
                    soccerCount++;
                }
            }

          
           /* Dashboard dashboard = new Dashboard();
            dashboard.lblActiveCount.Text = activeCount.ToString();
            dashboard.lblInactiveCount.Text = inactiveCount.ToString();
            dashboard.lblMaleCount.Text = maleCount.ToString();
            dashboard.lblFemaleCount.Text = femaleCount.ToString();
            dashboard.lblBasketCount.Text = basketballCount.ToString();
            dashboard.lblVolleyCount.Text = volleyballCount.ToString();
            dashboard.lblSoccerCount.Text = soccerCount.ToString();*/
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {            
           form2.Show();                     
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check for required fields
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(cmbCourse.Text) ||
                (!rdoFemale.Checked && !rdoMale.Checked) ||
                string.IsNullOrWhiteSpace(cmbFavColor.Text) ||
                (!chkBasketball.Checked && !chkVolleyball.Checked && !chkSoccer.Checked) ||
                string.IsNullOrWhiteSpace(txtSaying.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtProfile.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Name should not contain digits
            if (txtName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot contain numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Saying should not contain digits
            if (txtSaying.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Saying cannot contain numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Age should be numeric
            if (!int.TryParse(txtAge.Text, out _))
            {
                MessageBox.Show("Age must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check username/password duplication
            if (IsUsernameAndPasswordExist(txtUsername.Text.Trim(), txtPassword.Text.Trim()))
            {
                MessageBox.Show("Username/Password already exist. Choose a different one.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Collect values
            string name = txtName.Text.Trim();
            string gender = rdoMale.Checked ? rdoMale.Text : rdoFemale.Text;
            string favColor = cmbFavColor.Text.Trim();
            string saying = txtSaying.Text.Trim();
            string address = txtAddress.Text.Trim();
            string email = txtEmail.Text.Trim();
            string age = txtAge.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string course = cmbCourse.Text.Trim();
            string profile = txtProfile.Text.Trim();
            string bday = dateTimePicker1.Value.ToShortDateString();

            // Build hobbies
            List<string> hobbies = new List<string>();
            if (chkBasketball.Checked) hobbies.Add(chkBasketball.Text);
            if (chkVolleyball.Checked) hobbies.Add(chkVolleyball.Text);
            if (chkSoccer.Checked) hobbies.Add(chkSoccer.Text);
            string hobby = string.Join(", ", hobbies);

            // Get the row to update
            if (!int.TryParse(lblId.Text, out int rowIndex))
            {
                MessageBox.Show("Invalid ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int row = rowIndex + 2;

            // Load workbook
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");
            Worksheet sheet = book.Worksheets[0];

            // Update Excel sheet
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
            sheet.Range[row, 14].Value = "1"; // Assuming this marks the row as active

            // Save changes
            book.SaveToFile(@"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx", ExcelVersion.Version2016);

            // Update DataGridView
            DataTable dt = sheet.ExportDataTable();
            form2.dataGridView1.DataSource = dt;

            // Success message
            MessageBox.Show("Successfully updated!", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset all fields
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
            dateTimePicker1.Value = DateTime.Now;
            txtUsername.Clear();
            txtPassword.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtProfile.Clear();

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
            /*Dashboard dashboard = new Dashboard();
            this.Close();
            dashboard.ShowDialog();
*/
            this.Close();           // Close Form1
            dashboard.Show();
        }
    }
}
