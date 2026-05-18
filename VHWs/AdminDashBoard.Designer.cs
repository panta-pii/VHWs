namespace VHWs
{
    partial class AdminDashBoard
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
            this.buttonOpenUserManager = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelAdminDashBoard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpenUserManager
            // 
            this.buttonOpenUserManager.Location = new System.Drawing.Point(52, 159);
            this.buttonOpenUserManager.Name = "buttonOpenUserManager";
            this.buttonOpenUserManager.Size = new System.Drawing.Size(161, 23);
            this.buttonOpenUserManager.TabIndex = 0;
            this.buttonOpenUserManager.Text = "Open user Management";
            this.buttonOpenUserManager.UseVisualStyleBackColor = true;
            this.buttonOpenUserManager.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelAdminDashBoard
            // 
            this.labelAdminDashBoard.AutoSize = true;
            this.labelAdminDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminDashBoard.Location = new System.Drawing.Point(178, 42);
            this.labelAdminDashBoard.Name = "labelAdminDashBoard";
            this.labelAdminDashBoard.Size = new System.Drawing.Size(184, 24);
            this.labelAdminDashBoard.TabIndex = 2;
            this.labelAdminDashBoard.Text = "Admin Dash Board";
            this.labelAdminDashBoard.Click += new System.EventHandler(this.labelAdminDashBoard_Click);
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 329);
            this.Controls.Add(this.labelAdminDashBoard);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonOpenUserManager);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminDashBoard";
            this.Text = "AdminDashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenUserManager;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelAdminDashBoard;
    }
}