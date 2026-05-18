namespace VHWs
{
    partial class VHWsDashBoard
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonViewDrugIssued = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "VHW DashBoard";
            // 
            // buttonViewDrugIssued
            // 
            this.buttonViewDrugIssued.Location = new System.Drawing.Point(257, 105);
            this.buttonViewDrugIssued.Name = "buttonViewDrugIssued";
            this.buttonViewDrugIssued.Size = new System.Drawing.Size(155, 23);
            this.buttonViewDrugIssued.TabIndex = 1;
            this.buttonViewDrugIssued.Text = "View Drug Issuance";
            this.buttonViewDrugIssued.UseVisualStyleBackColor = true;
            this.buttonViewDrugIssued.Click += new System.EventHandler(this.buttonViewDrugIssued_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(476, 118);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Issue A Drug Here";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // VHWsDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonViewDrugIssued);
            this.Controls.Add(this.label1);
            this.Name = "VHWsDashBoard";
            this.Text = "VHWsDashBoard";
            this.Load += new System.EventHandler(this.VHWsDashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonViewDrugIssued;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button1;
    }
}