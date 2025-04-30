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
        //string data = "";

        //initialize student array
        //string[] student = new string[5];

        //int i = 0;

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

            string favColor = cmbFavColor.Text;

            string saying = txtSaying.Text;

            //data += cmbFavColor.Text + ", ";

            //data += txtSaying.Text;

            //student[i] = data;

            //i++;

            form2.insertData(name, gender, hobby, favColor, saying);

            MessageBox.Show("Successfully added!");

            //reset fields
            txtName.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            chkBasketball.Checked = false;
            chkVolleyball.Checked = false;
            chkSoccer.Checked = false;
            cmbFavColor.SelectedIndex = -1;
            txtSaying.Clear();

            //focus to name field
            txtName.Focus();
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

            string favColor = cmbFavColor.Text;

            string saying = txtSaying.Text;

            //data += cmbFavColor.Text + ", ";

            //data += txtSaying.Text;

            //student[i] = data;

            //i++;

            form2.updateData(Convert.ToInt32(lblId.Text), name, gender, hobby, favColor, saying);

            MessageBox.Show("Successfully updated!");

            //reset fields
            txtName.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            chkBasketball.Checked = false;
            chkVolleyball.Checked = false;
            chkSoccer.Checked = false;
            cmbFavColor.SelectedIndex = -1;
            txtSaying.Clear();

            //focus to name field
            txtName.Focus();
        }
    }
}
