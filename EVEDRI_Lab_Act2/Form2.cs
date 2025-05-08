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
        

        public Form2()
        {
            InitializeComponent();
            LoadExcelFile();
        }
        public void LoadExcelFile() 
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");

            Worksheet sheet = book.Worksheets[0];
            DataTable dt = sheet.ExportDataTable();
            dataGridView1.DataSource = dt;
        }


       /* C:\Users\ACT-STUDENT\Downloads*/

        //method for showing data on datagrid view
        public void insertData(string name, string gender, string hobby, string favColor, string saying, 
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRowIndex);

            Workbook book = new Workbook();
            Worksheet sheet = book.Worksheets[0];

            //sheet.Range[i ,1].Value = "";
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
            int r = dataGridView1.CurrentCell.RowIndex;
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
            form.btnUpdate.Visible = true;
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
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

      
    }
}


