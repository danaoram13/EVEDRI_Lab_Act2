using EVEDRI_Lab_Act2;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVEDRI_Lab_Act2
{
    public partial class login : Form
    {
       
        logs Logs = new logs();

        public login()
        {
            InitializeComponent();
        }
        int isActive = 1;
        int inActive = 0;

        private void btnLogin_Click(object sender, EventArgs e)
        {

            checkEmpty();


            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                return;
            }


            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");

            Worksheet sheet = book.Worksheets[0];
            int row = sheet.Rows.Length;

            bool log = false;


            for (int i = 2; i <= row; i++)
            {
                if (sheet.Range[i, 9].Value == txtUsername.Text &&
                    sheet.Range[i, 10].Value == txtPassword.Text)
                {
                    Logs.insertLogs(txtUsername.Text, "Successfully Logged In!");

                    string username = sheet.Range[i, 9].Value;
                    string profileImagePath = sheet.Range[i, 13].Value;

                    Dashboard dashboard = new Dashboard(username, profileImagePath);
                    MessageBox.Show("Log In Success", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    dashboard.ShowDialog();
                    

                    log = true;
                    break;
                }
            }

            if (!log)
            {
                
                MessageBox.Show("\t\tInvalid login \nPlease Enter the correct Username and Password", "Log in Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
            }

            for (int i = 2; i < row; i++)
            {
                if (sheet.Range[i, 12].Value == "1")
                {
                    isActive++;
                }
                else
                {
                    inActive++;
                }
            }


            /*if (log)
            {
                MessageBox.Show("Log In Success", "Welcome" ,MessageBoxButtons.OK,MessageBoxIcon.Information);

                Dashboard dashboard = new Dashboard(username, profileImagePath);
                this.Hide();
                dashboard.ShowDialog();

                *//*Form1 form = new Form1();
                *this.Hide();
                form.ShowDialog();*/

            /*Form2 form = new Form2();
            this.Hide();
            form.ShowDialog();*//*
        }
        else
        {
            MessageBox.Show("\t\tInvalid login \nPlease Enter the correct Username and Password", "Log in Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }*/


            for (int i = 2; i < row; i++)
            {
                if (sheet.Range[i, 12].Value == "1")
                {
                    isActive++;
                }
                else
                {
                    inActive++;
                }
            }
        }
        public void checkEmpty()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                    {
                        MessageBox.Show(c.Name + " is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
            }
            return;
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

      
    }
}




