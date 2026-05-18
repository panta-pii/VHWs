namespace VHWs
{
    partial class DrugIssuance
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelVHW = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerIssueDate = new System.Windows.Forms.DateTimePicker();
            this.labelDrugs = new System.Windows.Forms.Label();
            this.textBoxDrug_Id = new System.Windows.Forms.TextBox();
            this.textBoxDrugName = new System.Windows.Forms.TextBox();
            this.textBoxPatient_Id = new System.Windows.Forms.TextBox();
            this.textBoxVHW_Id = new System.Windows.Forms.TextBox();
            this.labelDrug_name = new System.Windows.Forms.Label();
            this.buttonIssue_Drug = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Patient_ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelVHW
            // 
            this.labelVHW.AutoSize = true;
            this.labelVHW.Location = new System.Drawing.Point(38, 122);
            this.labelVHW.Name = "labelVHW";
            this.labelVHW.Size = new System.Drawing.Size(38, 13);
            this.labelVHW.TabIndex = 6;
            this.labelVHW.Text = "VHWs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date  Of Issue";
            // 
            // dateTimePickerIssueDate
            // 
            this.dateTimePickerIssueDate.Location = new System.Drawing.Point(133, 199);
            this.dateTimePickerIssueDate.Name = "dateTimePickerIssueDate";
            this.dateTimePickerIssueDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerIssueDate.TabIndex = 10;
            // 
            // labelDrugs
            // 
            this.labelDrugs.AutoSize = true;
            this.labelDrugs.Location = new System.Drawing.Point(43, 37);
            this.labelDrugs.Name = "labelDrugs";
            this.labelDrugs.Size = new System.Drawing.Size(47, 13);
            this.labelDrugs.TabIndex = 12;
            this.labelDrugs.Text = "Drug_ID";
            // 
            // textBoxDrug_Id
            // 
            this.textBoxDrug_Id.Location = new System.Drawing.Point(133, 37);
            this.textBoxDrug_Id.Name = "textBoxDrug_Id";
            this.textBoxDrug_Id.Size = new System.Drawing.Size(100, 20);
            this.textBoxDrug_Id.TabIndex = 13;
            // 
            // textBoxDrugName
            // 
            this.textBoxDrugName.Location = new System.Drawing.Point(133, 160);
            this.textBoxDrugName.Name = "textBoxDrugName";
            this.textBoxDrugName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDrugName.TabIndex = 14;
            // 
            // textBoxPatient_Id
            // 
            this.textBoxPatient_Id.Location = new System.Drawing.Point(133, 80);
            this.textBoxPatient_Id.Name = "textBoxPatient_Id";
            this.textBoxPatient_Id.Size = new System.Drawing.Size(100, 20);
            this.textBoxPatient_Id.TabIndex = 15;
            // 
            // textBoxVHW_Id
            // 
            this.textBoxVHW_Id.Location = new System.Drawing.Point(133, 122);
            this.textBoxVHW_Id.Name = "textBoxVHW_Id";
            this.textBoxVHW_Id.Size = new System.Drawing.Size(100, 20);
            this.textBoxVHW_Id.TabIndex = 16;
            // 
            // labelDrug_name
            // 
            this.labelDrug_name.AutoSize = true;
            this.labelDrug_name.Location = new System.Drawing.Point(38, 160);
            this.labelDrug_name.Name = "labelDrug_name";
            this.labelDrug_name.Size = new System.Drawing.Size(62, 13);
            this.labelDrug_name.TabIndex = 17;
            this.labelDrug_name.Text = "Drug_name";
            // 
            // buttonIssue_Drug
            // 
            this.buttonIssue_Drug.Location = new System.Drawing.Point(213, 290);
            this.buttonIssue_Drug.Name = "buttonIssue_Drug";
            this.buttonIssue_Drug.Size = new System.Drawing.Size(75, 23);
            this.buttonIssue_Drug.TabIndex = 18;
            this.buttonIssue_Drug.Text = "Issue";
            this.buttonIssue_Drug.UseVisualStyleBackColor = true;
            this.buttonIssue_Drug.Click += new System.EventHandler(this.buttonIssue_Drug_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(551, 289);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // DrugIssuance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonIssue_Drug);
            this.Controls.Add(this.labelDrug_name);
            this.Controls.Add(this.textBoxVHW_Id);
            this.Controls.Add(this.textBoxPatient_Id);
            this.Controls.Add(this.textBoxDrugName);
            this.Controls.Add(this.textBoxDrug_Id);
            this.Controls.Add(this.labelDrugs);
            this.Controls.Add(this.dateTimePickerIssueDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelVHW);
            this.Controls.Add(this.label2);
            this.Name = "DrugIssuance";
            this.Text = "DrugIssuance";
            this.Load += new System.EventHandler(this.DrugIssuance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVHW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueDate;
        private System.Windows.Forms.Label labelDrugs;
        private System.Windows.Forms.TextBox textBoxDrug_Id;
        private System.Windows.Forms.TextBox textBoxDrugName;
        private System.Windows.Forms.TextBox textBoxPatient_Id;
        private System.Windows.Forms.TextBox textBoxVHW_Id;
        private System.Windows.Forms.Label labelDrug_name;
        private System.Windows.Forms.Button buttonIssue_Drug;
        private System.Windows.Forms.Button buttonBack;
    }
}