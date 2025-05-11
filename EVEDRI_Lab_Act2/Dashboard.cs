using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Xls;

namespace EVEDRI_Lab_Act2
{
    public partial class Dashboard : Form
    {

        public Dashboard(string username, string profileImagePath)
        {
            InitializeComponent();
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

        public int showcount(int m, string val)
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
                login login = new login();
                this.Close();
                login.Show();
                /*Application.Exit();*/
            }
            /*login login = new login();
            login.Show();*/
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");
            Worksheet sh = book.Worksheets[0];

            DataTable dt = sh.ExportDataTable();
            DataTable filtered = dt.Clone();

            foreach (DataRow row in dt.Rows)
            {
                if (row[14].ToString() == "1") 
                {
                    filtered.ImportRow(row);
                }
            }



            f2.dataGridView1.DataSource = filtered;
            f2.Show();
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");
            Worksheet sh = book.Worksheets[0];

            DataTable dt = sh.ExportDataTable();
            DataTable filtered = dt.Clone();

            foreach (DataRow row in dt.Rows)
            {
                if (row[14].ToString() == "0") 
                {
                    filtered.ImportRow(row);
                }
            }



            f2.dataGridView1.DataSource = filtered;
            f2.Show();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            ShowLogs(f2.dataGridView1);
            f2.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(this);
            this.Close();
            form.ShowDialog();
        }
    }
}
