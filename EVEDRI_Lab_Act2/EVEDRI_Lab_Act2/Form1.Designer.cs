namespace EVEDRI_Lab_Act2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.chkBasketball = new System.Windows.Forms.CheckBox();
            this.chkVolleyball = new System.Windows.Forms.CheckBox();
            this.chkSoccer = new System.Windows.Forms.CheckBox();
            this.lblFavColor = new System.Windows.Forms.Label();
            this.cmbFavColor = new System.Windows.Forms.ComboBox();
            this.lblSaying = new System.Windows.Forms.Label();
            this.txtSaying = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(198, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(266, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(109, 24);
            this.txtName.TabIndex = 1;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(198, 101);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 18);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender:";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(266, 103);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 3;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(327, 103);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 4;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHobbies.Location = new System.Drawing.Point(198, 152);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(67, 18);
            this.lblHobbies.TabIndex = 5;
            this.lblHobbies.Text = "Hobbies:";
            // 
            // chkBasketball
            // 
            this.chkBasketball.AutoSize = true;
            this.chkBasketball.Location = new System.Drawing.Point(234, 191);
            this.chkBasketball.Name = "chkBasketball";
            this.chkBasketball.Size = new System.Drawing.Size(75, 17);
            this.chkBasketball.TabIndex = 6;
            this.chkBasketball.Text = "Basketball";
            this.chkBasketball.UseVisualStyleBackColor = true;
            // 
            // chkVolleyball
            // 
            this.chkVolleyball.AutoSize = true;
            this.chkVolleyball.Location = new System.Drawing.Point(234, 225);
            this.chkVolleyball.Name = "chkVolleyball";
            this.chkVolleyball.Size = new System.Drawing.Size(70, 17);
            this.chkVolleyball.TabIndex = 7;
            this.chkVolleyball.Text = "Volleyball";
            this.chkVolleyball.UseVisualStyleBackColor = true;
            // 
            // chkSoccer
            // 
            this.chkSoccer.AutoSize = true;
            this.chkSoccer.Location = new System.Drawing.Point(234, 260);
            this.chkSoccer.Name = "chkSoccer";
            this.chkSoccer.Size = new System.Drawing.Size(60, 17);
            this.chkSoccer.TabIndex = 8;
            this.chkSoccer.Text = "Soccer";
            this.chkSoccer.UseVisualStyleBackColor = true;
            // 
            // lblFavColor
            // 
            this.lblFavColor.AutoSize = true;
            this.lblFavColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavColor.Location = new System.Drawing.Point(198, 304);
            this.lblFavColor.Name = "lblFavColor";
            this.lblFavColor.Size = new System.Drawing.Size(106, 18);
            this.lblFavColor.TabIndex = 9;
            this.lblFavColor.Text = "Favorite Color:";
            // 
            // cmbFavColor
            // 
            this.cmbFavColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFavColor.FormattingEnabled = true;
            this.cmbFavColor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Black"});
            this.cmbFavColor.Location = new System.Drawing.Point(201, 340);
            this.cmbFavColor.Name = "cmbFavColor";
            this.cmbFavColor.Size = new System.Drawing.Size(121, 21);
            this.cmbFavColor.TabIndex = 10;
            // 
            // lblSaying
            // 
            this.lblSaying.AutoSize = true;
            this.lblSaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaying.Location = new System.Drawing.Point(198, 391);
            this.lblSaying.Name = "lblSaying";
            this.lblSaying.Size = new System.Drawing.Size(56, 18);
            this.lblSaying.TabIndex = 11;
            this.lblSaying.Text = "Saying:";
            // 
            // txtSaying
            // 
            this.txtSaying.Location = new System.Drawing.Point(201, 430);
            this.txtSaying.Multiline = true;
            this.txtSaying.Name = "txtSaying";
            this.txtSaying.Size = new System.Drawing.Size(150, 79);
            this.txtSaying.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(185, 546);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 43);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.Green;
            this.btnDisplay.Location = new System.Drawing.Point(301, 546);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(98, 43);
            this.btnDisplay.TabIndex = 14;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(128, 49);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(52, 18);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "Name:";
            this.lblId.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Green;
            this.btnUpdate.Location = new System.Drawing.Point(185, 546);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 43);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 634);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSaying);
            this.Controls.Add(this.lblSaying);
            this.Controls.Add(this.cmbFavColor);
            this.Controls.Add(this.lblFavColor);
            this.Controls.Add(this.chkSoccer);
            this.Controls.Add(this.chkVolleyball);
            this.Controls.Add(this.chkBasketball);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.Label lblFavColor;
        private System.Windows.Forms.Label lblSaying;
        private System.Windows.Forms.Button btnDisplay;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.RadioButton rdoMale;
        public System.Windows.Forms.RadioButton rdoFemale;
        public System.Windows.Forms.CheckBox chkBasketball;
        public System.Windows.Forms.CheckBox chkVolleyball;
        public System.Windows.Forms.CheckBox chkSoccer;
        public System.Windows.Forms.ComboBox cmbFavColor;
        public System.Windows.Forms.TextBox txtSaying;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Label lblId;
    }
}

