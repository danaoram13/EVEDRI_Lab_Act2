using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVEDRI_Lab_Act2
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }
       

        //method for showing data on datagrid view
        public void insertData(string name, string gender, string hobby, string favColor, string saying)
        {
            int i = dataGridView1.Rows.Add();

            this.dataGridView1.Rows[i].Cells[0].Value = name;
            this.dataGridView1.Rows[i].Cells[1].Value = gender;
            this.dataGridView1.Rows[i].Cells[2].Value = hobby;
            this.dataGridView1.Rows[i].Cells[3].Value = favColor;
            this.dataGridView1.Rows[i].Cells[4].Value = saying;
        }
        public void updateData(int id, string name, string gender, string hobby, string favColor, string saying)
        {
            this.dataGridView1.Rows[id].Cells[0].Value = name;
            this.dataGridView1.Rows[id].Cells[1].Value = gender;
            this.dataGridView1.Rows[id].Cells[2].Value = hobby;
            this.dataGridView1.Rows[id].Cells[3].Value = favColor;
            this.dataGridView1.Rows[id].Cells[4].Value = saying;
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
            form.btnAdd.Visible = false;
            form.btnUpdate.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRowIndex);
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

    }
}
