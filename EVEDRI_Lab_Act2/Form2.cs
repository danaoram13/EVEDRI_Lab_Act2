using EVEDRI_Lab_Act2;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EVEDRI_Lab_Act2
{
    public partial class Form2 : Form
    {
        Dashboard dashboard;
        private string getUsername;
        public Form2(Dashboard dash, string username)
        {
            InitializeComponent();
            LoadExcelFile();
            dashboard = dash;
            getUsername = username;

        }
        public void LoadExcelFile()
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");


            Worksheet sheet = book.Worksheets[0];
            DataTable dt = sheet.ExportDataTable();
            dataGridView1.DataSource = dt;

        }


        /* C:\Users\ACT-STUDENT\Downloads*/

        //method for showing data on datagrid view
        /*  public void insertData(string name, string gender, string hobby, string favColor, string saying, 
              string address, string email, string age, string username, string password)
          {
              int i = dataGridView1.Rows.Add();

              this.dataGridView1.Rows[i].Cells[0].Value = name;
              this.dataGridView1.Rows[i].Cells[1].Value = gender;
              this.dataGridView1.Rows[i].Cells[2].Value = hobby;
              this.dataGridView1.Rows[i].Cells[3].Value = favColor;
              this.dataGridView1.Rows[i].Cells[4].Value = saying;
              this.dataGridView1.Rows[i].Cells[5].Value = address;
              this.dataGridView1.Rows[i].Cells[6].Value = email;
              this.dataGridView1.Rows[i].Cells[7].Value = age;
              this.dataGridView1.Rows[i].Cells[8].Value = username;
              this.dataGridView1.Rows[i].Cells[9].Value = password;

          }
          public void updateData(int id, string name, string gender, string hobby, string favColor, string saying,
              string address, string email, string age, string username, string password)
          {
              this.dataGridView1.Rows[id].Cells[0].Value = name;
              this.dataGridView1.Rows[id].Cells[1].Value = gender;
              this.dataGridView1.Rows[id].Cells[2].Value = hobby;
              this.dataGridView1.Rows[id].Cells[3].Value = favColor;
              this.dataGridView1.Rows[id].Cells[4].Value = saying;
              this.dataGridView1.Rows[id].Cells[5].Value = address;
              this.dataGridView1.Rows[id].Cells[6].Value = email;
              this.dataGridView1.Rows[id].Cells[7].Value = age;
              this.dataGridView1.Rows[id].Cells[8].Value = username;
              this.dataGridView1.Rows[id].Cells[9].Value = password;


              dataGridView1.EndEdit();
              dataGridView1.CurrentCell = null;
          }*/

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRowIndex);

            Workbook book = new Workbook();
            Worksheet sheet = book.Worksheets[0];

            //sheet.Range[i ,1].Value = "";*/







        }


        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There is nothing to clear.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Clear all rows from the DataGridView
            dataGridView1.Rows.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Confirm exit before closing the application
            DialogResult Exit;
            Exit = MessageBox.Show("Are you sure you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*int r = dataGridView1.CurrentCell.RowIndex;
            Form1 form = (Form1)Application.OpenForms["Form1"];
            form.txtName.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            string gender = dataGridView1.Rows[r].Cells[1].Value.ToString();
            if (gender == "Male")
            {
                form.rdoMale.Checked = true;
            }
            else
            {
                form.rdoFemale.Checked = true;
            }
            string hobbies = dataGridView1.Rows[r].Cells[2].Value.ToString();
            string[] h = hobbies.Split(',');
            foreach (string val in h) 
            {
                if (val.Trim() == "Basketball")
                {
                    form.chkBasketball.Checked = true;
                }
                if (val.Trim() == "Volleyball")
                {
                    form.chkVolleyball.Checked = true;
                }
                if (val.Trim() == "Soccer")
                {
                    form.chkSoccer.Checked = true;
                }
            }
            form.cmbFavColor.SelectedItem = dataGridView1.Rows[r].Cells[3].Value.ToString();
            form.txtSaying.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            form.lblId.Text = r.ToString();

            form.txtEmail.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            form.txtAge.Text = dataGridView1.Rows[r].Cells[7].Value.ToString();
            form.txtName.Text = dataGridView1.Rows[r].Cells[8].Value.ToString();
            form.txtPassword.Text = dataGridView1.Rows[r].Cells[9].Value.ToString();
            form.txtSaying.Text = dataGridView1.Rows[r].Cells[10].Value.ToString();

            form.btnAdd.Visible = false;
            form.btnUpdate.Visible = true;*/

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Open Form1 and pass the data
                Form1 form1 = new Form1(dashboard, "defaultUserName"); // if dashboard is available
                form1.txtName.Text = row.Cells[0].Value?.ToString();
                string gender = row.Cells[1].Value?.ToString();
                if (gender == "Male") form1.rdoMale.Checked = true;
                else if (gender == "Female") form1.rdoFemale.Checked = true;

                string hobbies = row.Cells[2].Value?.ToString();
                form1.chkBasketball.Checked = hobbies.Contains("Basketball");
                form1.chkVolleyball.Checked = hobbies.Contains("Volleyball");
                form1.chkSoccer.Checked = hobbies.Contains("Soccer");

                form1.cmbFavColor.Text = row.Cells[3].Value?.ToString();
                form1.txtAddress.Text = row.Cells[4].Value?.ToString();
                form1.txtEmail.Text = row.Cells[5].Value?.ToString();
                form1.dateTimePicker1.Text = row.Cells[6].Value?.ToString();
                form1.txtAge.Text = row.Cells[7].Value?.ToString();
                form1.txtUsername.Text = row.Cells[8].Value?.ToString();
                form1.txtPassword.Text = row.Cells[9].Value?.ToString();
                form1.txtSaying.Text = row.Cells[10].Value?.ToString();
                form1.cmbCourse.Text = row.Cells[11].Value?.ToString();
                form1.txtProfile.Text = row.Cells[12].Value?.ToString();

                // Store the row index for updating (subtract header)
                form1.Controls["lblId"].Text = e.RowIndex.ToString();

                form1.Show();
                this.Hide();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(txtSearch.Text))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Name not found. Please try again.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            /* Dashboard dashboard = new Dashboard();
             this.Close();
             dashboard.ShowDialog();*/

            this.Hide();           // Close Form1
            dashboard.Show();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(dashboard, "defaultUserName");

            form.Show();

        }

        private void btnSearchLogs_Click(object sender, EventArgs e)
        {
            //i removed the break 
            dataGridView1.ClearSelection();
            bool itemFound = false;

            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Skip new row placeholder
                    if (row.IsNewRow) continue;

                    if (row.Cells[0].Value != null &&
                        row.Cells[0].Value.ToString().IndexOf(txtSearch.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        row.Selected = true;
                        // Optional: Scroll to the first match only
                        if (!itemFound)
                        {
                            dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        }
                        itemFound = true;
                    }
                }

                if (!itemFound)
                {
                    MessageBox.Show("Item was not found in the list. Please try again.", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*  private void btnDeleteActive_Click(object sender, EventArgs e)
          {

              if (dataGridView1.SelectedRows.Count == 0)
              {
                  MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  return;
              }

              DialogResult confirmation = MessageBox.Show("Are you sure you want to delete the selected Index?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

              if (confirmation != DialogResult.OK) return;

              // Load the Excel file
              Workbook book = new Workbook();
              book.LoadFromFile(@"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");
              Worksheet sheet = book.Worksheets[0];


              // Collect names of users marked as inactive for logging
              List<string> deletedUsers = new List<string>();

              foreach (DataGridViewRow dgvRow in dataGridView1.SelectedRows)
              {
                  string nameToDelete = dgvRow.Cells[0].Value.ToString();

                  for (int i = 2; i <= sheet.LastRow; i++) // assuming data starts from row 2
                  {
                      string nameInSheet = sheet.Range[i, 1].Value;

                      if (nameInSheet == nameToDelete)
                      {
                          sheet.Range[i, 14].Value = "0"; // Mark as inactive
                          deletedUsers.Add(nameToDelete);
                          break;
                      }
                  }

                  dataGridView1.Rows.Remove(dgvRow);
              }

              // Save changes
              book.SaveToFile(@"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");

              // Log all deleted users after processing
              foreach (var name in deletedUsers)
              {
                  logs logInstance = new logs(); // Create an instance of the logs class
                  logInstance.insertLogs(getUsername, $"Set '{name}' as Inactive.");
              }

              dashboard.RefreshDashboardCounts();
              MessageBox.Show("Successfully set as Inactive.");
          }*/

        private void btnDeleteActive_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to set as Inactive.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to mark this record as Inactive?",
                                                   "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            // Load Excel file
            string path = @"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx";
            Workbook book = new Workbook();
            book.LoadFromFile(path);
            Worksheet sheet = book.Worksheets[0];

            // Track changes
            List<string> inactiveUsers = new List<string>();

            foreach (DataGridViewRow dgvRow in dataGridView1.SelectedRows)
            {
                if (dgvRow.IsNewRow) continue;

                string studentName = dgvRow.Cells[0].Value?.ToString();

                for (int rowIndex = 2; rowIndex <= sheet.LastRow; rowIndex++) // Start at row 2 to skip header
                {
                    string nameInExcel = sheet.Range[rowIndex, 1].Value; // Column A (1-based)

                    if (nameInExcel == studentName)
                    {
                        // Set Status column (N / column 14) to "0"
                        sheet.Range[rowIndex, 14].Value = "0";
                        inactiveUsers.Add(studentName);
                        break;
                    }
                }

                dataGridView1.Rows.Remove(dgvRow); // Remove from DataGridView
            }

            // Save changes
            book.SaveToFile(path);

            // Log actions
            foreach (string name in inactiveUsers)
            {
                logs logInstance = new logs();
                logInstance.insertLogs(getUsername, $"Marked '{name}' as Inactive.");
            }

            // Update dashboard
            dashboard.RefreshDashboardCounts();

            MessageBox.Show("Selected record(s) marked as Inactive.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteInactive_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to activate.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to mark this record as Active?",
                                                   "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            string filePath = @"C:\Users\GUSTAV\source\repos\EVEDRI_Lab_Act2\Book1.xlsx";
            Workbook book = new Workbook();
            book.LoadFromFile(filePath);
            Worksheet sheet = book.Worksheets[0];

            List<string> activatedUsers = new List<string>();

            foreach (DataGridViewRow dgvRow in dataGridView1.SelectedRows)
            {
                if (dgvRow.IsNewRow) continue;

                string studentName = dgvRow.Cells[0].Value?.ToString();

                for (int i = 2; i <= sheet.LastRow; i++) // Start from row 2 to skip header
                {
                    string nameInExcel = sheet.Range[i, 1].Value;

                    if (nameInExcel == studentName)
                    {
                        sheet.Range[i, 14].Value = "1"; // Set status to Active
                        activatedUsers.Add(studentName);
                        break;
                    }
                }

                dataGridView1.Rows.Remove(dgvRow);
            }

            book.SaveToFile(filePath);

            foreach (string name in activatedUsers)
            {
                logs logInstance = new logs();
                logInstance.insertLogs(getUsername, $"Reactivated user '{name}'.");
            }

            dashboard.RefreshDashboardCounts();

            MessageBox.Show("Selected record(s) set to Active.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optional: Reload only inactive students into DataGridView
            DataTable dt = sheet.ExportDataTable();
            DataTable filtered = dt.Clone();

            foreach (DataRow row in dt.Rows)
            {
                if (row[13].ToString() == "0") // Column 14 is index 13 (zero-based)
                {
                    filtered.ImportRow(row);
                }
            }

            dataGridView1.DataSource = filtered;
        }
       
    }
}


