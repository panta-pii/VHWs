namespace VHWs
{
    partial class Drug_Dispensation
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
            this.textBoxdrug_ID = new System.Windows.Forms.TextBox();
            this.textBoxbatch_lot = new System.Windows.Forms.TextBox();
            this.textBoxIssued_By = new System.Windows.Forms.TextBox();
            this.textBoxquantity = new System.Windows.Forms.TextBox();
            this.labelDrug_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonDispensation = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dateTimePickerDate_issued = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxdrug_ID
            // 
            this.textBoxdrug_ID.Location = new System.Drawing.Point(160, 100);
            this.textBoxdrug_ID.Name = "textBoxdrug_ID";
            this.textBoxdrug_ID.Size = new System.Drawing.Size(100, 20);
            this.textBoxdrug_ID.TabIndex = 0;
            // 
            // textBoxbatch_lot
            // 
            this.textBoxbatch_lot.Location = new System.Drawing.Point(160, 142);
            this.textBoxbatch_lot.Name = "textBoxbatch_lot";
            this.textBoxbatch_lot.Size = new System.Drawing.Size(100, 20);
            this.textBoxbatch_lot.TabIndex = 1;
            // 
            // textBoxIssued_By
            // 
            this.textBoxIssued_By.Location = new System.Drawing.Point(160, 224);
            this.textBoxIssued_By.Name = "textBoxIssued_By";
            this.textBoxIssued_By.Size = new System.Drawing.Size(100, 20);
            this.textBoxIssued_By.TabIndex = 3;
            // 
            // textBoxquantity
            // 
            this.textBoxquantity.Location = new System.Drawing.Point(160, 264);
            this.textBoxquantity.Name = "textBoxquantity";
            this.textBoxquantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxquantity.TabIndex = 4;
            // 
            // labelDrug_id
            // 
            this.labelDrug_id.AutoSize = true;
            this.labelDrug_id.Location = new System.Drawing.Point(34, 107);
            this.labelDrug_id.Name = "labelDrug_id";
            this.labelDrug_id.Size = new System.Drawing.Size(45, 13);
            this.labelDrug_id.TabIndex = 5;
            this.labelDrug_id.Text = "Drug_Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date_Issued";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Issued_By";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(34, 264);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 8;
            this.labelQuantity.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Search Drug Here";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Batch_lot_number";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(204, 15);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(203, 20);
            this.textBoxSearch.TabIndex = 11;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(431, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(385, 100);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(403, 213);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // buttonDispensation
            // 
            this.buttonDispensation.Location = new System.Drawing.Point(98, 317);
            this.buttonDispensation.Name = "buttonDispensation";
            this.buttonDispensation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDispensation.Size = new System.Drawing.Size(102, 23);
            this.buttonDispensation.TabIndex = 14;
            this.buttonDispensation.Text = "Dispense";
            this.buttonDispensation.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(340, 317);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDate_issued
            // 
            this.dateTimePickerDate_issued.Location = new System.Drawing.Point(160, 187);
            this.dateTimePickerDate_issued.Name = "dateTimePickerDate_issued";
            this.dateTimePickerDate_issued.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate_issued.TabIndex = 16;
            // 
            // Drug_Dispensation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerDate_issued);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDispensation);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDrug_id);
            this.Controls.Add(this.textBoxquantity);
            this.Controls.Add(this.textBoxIssued_By);
            this.Controls.Add(this.textBoxbatch_lot);
            this.Controls.Add(this.textBoxdrug_ID);
            this.Name = "Drug_Dispensation";
            this.Text = "Drug_Dispensation";
            this.Load += new System.EventHandler(this.Drug_Dispensation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxdrug_ID;
        private System.Windows.Forms.TextBox textBoxbatch_lot;
        private System.Windows.Forms.TextBox textBoxIssued_By;
        private System.Windows.Forms.TextBox textBoxquantity;
        private System.Windows.Forms.Label labelDrug_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonDispensation;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate_issued;
    }
}