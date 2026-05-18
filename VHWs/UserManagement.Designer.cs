namespace VHWs
{
    partial class UserManagement
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
            System.Windows.Forms.Label labelAddress;
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.labelContacts = new System.Windows.Forms.Label();
            this.textBoxcontacts = new System.Windows.Forms.TextBox();
            this.textBoxaddress = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboBoxrole = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            labelAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new System.Drawing.Point(35, 242);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new System.Drawing.Size(45, 13);
            labelAddress.TabIndex = 19;
            labelAddress.Text = "Address";
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(131, 113);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(100, 20);
            this.textBoxusername.TabIndex = 0;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(131, 139);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxpassword.TabIndex = 3;
            this.textBoxpassword.TextChanged += new System.EventHandler(this.textBoPassword_TextChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(35, 116);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 8;
            this.labelUsername.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(35, 173);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(29, 13);
            this.labelRole.TabIndex = 12;
            this.labelRole.Text = "Role";
            this.labelRole.Click += new System.EventHandler(this.labelRole_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(35, 146);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Password";
            this.labelPassword.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(119, 324);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(109, 23);
            this.buttonCreateAccount.TabIndex = 14;
            this.buttonCreateAccount.Text = "CreateUserAccount";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.Location = new System.Drawing.Point(279, 324);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(120, 23);
            this.buttonUpdateUser.TabIndex = 15;
            this.buttonUpdateUser.Text = "UpdateUserAccount";
            this.buttonUpdateUser.UseVisualStyleBackColor = true;
            this.buttonUpdateUser.Click += new System.EventHandler(this.buttonUpdateUser_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(480, 324);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(121, 23);
            this.buttonDeleteUser.TabIndex = 16;
            this.buttonDeleteUser.Text = "DeleteUserAccount";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            // 
            // labelContacts
            // 
            this.labelContacts.AutoSize = true;
            this.labelContacts.Location = new System.Drawing.Point(35, 199);
            this.labelContacts.Name = "labelContacts";
            this.labelContacts.Size = new System.Drawing.Size(49, 13);
            this.labelContacts.TabIndex = 17;
            this.labelContacts.Text = "Contacts";
            // 
            // textBoxcontacts
            // 
            this.textBoxcontacts.Location = new System.Drawing.Point(131, 199);
            this.textBoxcontacts.Name = "textBoxcontacts";
            this.textBoxcontacts.Size = new System.Drawing.Size(100, 20);
            this.textBoxcontacts.TabIndex = 18;
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.Location = new System.Drawing.Point(131, 235);
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxaddress.TabIndex = 20;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(159, 58);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(355, 20);
            this.textBoxSearch.TabIndex = 21;
            this.textBoxSearch.Text = "le";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(44, 61);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(97, 13);
            this.labelSearch.TabIndex = 22;
            this.labelSearch.Text = "Search Users Here";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(535, 55);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 23;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(665, 324);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 24;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBoxrole
            // 
            this.comboBoxrole.FormattingEnabled = true;
            this.comboBoxrole.Items.AddRange(new object[] {
            "HealthCareProffessionals",
            "Admin",
            "VHWs",
            "Patient"});
            this.comboBoxrole.Location = new System.Drawing.Point(131, 173);
            this.comboBoxrole.Name = "comboBoxrole";
            this.comboBoxrole.Size = new System.Drawing.Size(121, 21);
            this.comboBoxrole.TabIndex = 25;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(385, 97);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(392, 193);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "User Manager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "User_ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(131, 85);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 29;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBoxrole);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxaddress);
            this.Controls.Add(labelAddress);
            this.Controls.Add(this.textBoxcontacts);
            this.Controls.Add(this.labelContacts);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.buttonUpdateUser);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxusername);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Label labelContacts;
        private System.Windows.Forms.TextBox textBoxcontacts;
        private System.Windows.Forms.TextBox textBoxaddress;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ComboBox comboBoxrole;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
    }
}