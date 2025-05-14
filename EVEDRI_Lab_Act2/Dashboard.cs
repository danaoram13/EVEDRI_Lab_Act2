using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Xls;

namespace EVEDRI_Lab_Act2
{
    public partial class Dashboard : Form
    {
        logs Logs = new logs();
        private string getUsername;
        public Dashboard(string username, string profileImagePath)
        {
            InitializeComponent();
            getUsername = username; // Store the username in a field
            /*       lblActiveCount.Text = showcount(13, "1").ToString();
                   lblInactiveCount.Text = showcount(13, "0").ToString();
                   lblMaleCount.Text = showcount(2, "Male").ToString();
                   lblFemaleCount.Text = showcount(2, "Female").ToString();
                   lblBasketCount.Text = showcount(3, "Basketball").ToString();
                   lblVolleyCount.Text = showcount(3, "Volleyball").ToString();
                   lblSoccerCount.Text = showcount(3, "Soccer").ToString();
                   lblRedCount.Text = showcount(4, "Red").ToString();
                   lblBlueCount.Text = showcount(4, "Blue").ToString();
                   lblBlackCount.Text = showcount(4, "Black").ToString();
                   lblBsitCount.Text = showcount(12, "BSIT").ToString();
                   lblBscsCount.Text = showcount(12, "BSCS").ToString();
                   lblBscpeCount.Text = showcount(12, "BSCpE").ToString();*/
            
            RefreshDashboardCounts(); // call here once


            lblUserName.Text = username; // Add a label to show the username
            // Initialize the dashboard with the provided username and profile image path
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(profileImagePath);

            lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }


        public void RefreshDashboardCounts()
        {
            lblActiveCount.Text = showcount(14, "1").ToString();
            lblInactiveCount.Text = showcount(14, "0").ToString();
            lblMaleCount.Text = showcount(2, "Male").ToString();
            lblFemaleCount.Text = showcount(2, "Female").ToString();
            lblBasketCount.Text = showcount(3, "Basketball").ToString();
            lblVolleyCount.Text = showcount(3, "Volleyball").ToString();
            lblSoccerCount.Text = showcount(3, "Soccer").ToString();
            lblRedCount.Text = showcount(4, "Red").ToString();
            lblBlueCount.Text = showcount(4, "Blue").ToString();
            lblBlackCount.Text = showcount(4, "Black").ToString();
            lblBsitCount.Text = showcount(12, "BSIT").ToString();
            lblBscsCount.Text = showcount(12, "BSCS").ToString();
            lblBscpeCount.Text = showcount(12, "BSCpE").ToString();
        }

        /*public int showcount(int m, string val)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(@"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");
            Worksheet sheet = workbook.Worksheets[0];
            int r = sheet.Rows.Length;
            int count = 0;

            for (int i = 2; i < r; i++)
            {
                if (sheet.Range[i, m].Value == val)
                {
                    count++;
                }
            }

            return count;
        }*/
        public int showcount(int m, string val)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(@"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");
            Worksheet sheet = workbook.Worksheets[0];
            int r = sheet.Rows.Length;
            int count = 0;

            for (int i = 2; i < r; i++)
            {
                string cellValue = sheet.Range[i, m].Value;

                // For hobby column (column 3), use Contains check
                if (m == 3)
                {
                    if (cellValue.Contains(val))
                        count++;
                }
                else
                {
                    if (cellValue == val)
                        count++;
                }
            }

            return count;
        }



        public void ShowLogs(DataGridView D)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(@"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");
            Worksheet sheet = workbook.Worksheets[1];
            DataTable dt = sheet.ExportDataTable();
            D.DataSource = dt;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Are you sure you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Exit == DialogResult.Yes)
            {
                
                this.Close();
                /*  login login = new login();
                  login.Show();*/
                /*Application.Exit();*/
            }
            login login = new login();
            login.Show();

            logs Logs = new logs();
            // Use the 'getUsername' field from the Dashboard class instead of 'Logs.getUsername'
            Logs.insertLogs(getUsername, "Successfully Logged Out!");
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            // Load Excel file
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");
            Worksheet sheet = book.Worksheets[0];

            // Export data table with headers
            DataTable dt = sheet.ExportDataTable(sheet.AllocatedRange, true, true);
            DataTable activeStudents = dt.Clone(); // same structure

            // Filter for active students (assuming 14th column is status)
            foreach (DataRow row in dt.Rows)
            {
                if (dt.Columns.Count > 13 && row[13].ToString().Trim() == "1")
                {
                    activeStudents.ImportRow(row);
                }
            }

            // Open Form2 and show filtered data
            Form2 f2 = new Form2(this, getUsername);
            f2.dataGridView1.DataSource = activeStudents;
            f2.Show();
            f2.btnAddNew.Visible = true;
            this.Hide();

        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
           
            // Load Excel file
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");
            Worksheet sheet = book.Worksheets[0];

            // Export data table with headers
            DataTable dt = sheet.ExportDataTable(sheet.AllocatedRange, true, true);
            DataTable activeStudents = dt.Clone(); // same structure

            // Filter for active students (assuming 14th column is status)
            foreach (DataRow row in dt.Rows)
            {
                if (dt.Columns.Count > 13 && row[13].ToString().Trim() == "0")
                {
                    activeStudents.ImportRow(row);
                }
            }

            // Open Form2 and show filtered data
            Form2 f2 = new Form2(this, getUsername);
            f2.dataGridView1.DataSource = activeStudents;
            f2.Show();
            this.Hide();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
           /* var f2 = new Form2();
            ShowLogs(f2.dataGridView1);
            f2.Show();
*/
            var f2 = new Form2(this, getUsername);
            ShowLogs(f2.dataGridView1);
            f2.btnSearchLogs.Visible = true;
            this.Hide();
            f2.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            /* Form1 form = new Form1();
             this.Close();
             form.ShowDialog();*/

            Form1 form = new Form1(this, getUsername);  // pass the current dashboard instance
            this.Hide();                   // instead of Close()
            form.ShowDialog();
            this.Show();
        }
    }
}
