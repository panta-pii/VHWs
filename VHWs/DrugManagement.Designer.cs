namespace VHWs
{
    partial class DrugManagement
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
            this.labelDrugName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelExpiry = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBatchLotNo = new System.Windows.Forms.TextBox();
            this.buttonUpdateDrugs = new System.Windows.Forms.Button();
            this.buttonDeleteDrugs = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonInsertDrugs = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDrugID = new System.Windows.Forms.TextBox();
            this.dateTimePickerExpiry = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDrugName
            // 
            this.labelDrugName.AutoSize = true;
            this.labelDrugName.Location = new System.Drawing.Point(35, 150);
            this.labelDrugName.Name = "labelDrugName";
            this.labelDrugName.Size = new System.Drawing.Size(61, 13);
            this.labelDrugName.TabIndex = 0;
            this.labelDrugName.Text = "Drug Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BatchLotNumber";
            // 
            // labelExpiry
            // 
            this.labelExpiry.AutoSize = true;
            this.labelExpiry.Location = new System.Drawing.Point(35, 238);
            this.labelExpiry.Name = "labelExpiry";
            this.labelExpiry.Size = new System.Drawing.Size(61, 13);
            this.labelExpiry.TabIndex = 2;
            this.labelExpiry.Text = "Expiry Date";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(170, 150);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxBatchLotNo
            // 
            this.textBoxBatchLotNo.Location = new System.Drawing.Point(170, 185);
            this.textBoxBatchLotNo.Name = "textBoxBatchLotNo";
            this.textBoxBatchLotNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxBatchLotNo.TabIndex = 7;
            // 
            // buttonUpdateDrugs
            // 
            this.buttonUpdateDrugs.Location = new System.Drawing.Point(191, 319);
            this.buttonUpdateDrugs.Name = "buttonUpdateDrugs";
            this.buttonUpdateDrugs.Size = new System.Drawing.Size(106, 23);
            this.buttonUpdateDrugs.TabIndex = 8;
            this.buttonUpdateDrugs.Text = "Update Records";
            this.buttonUpdateDrugs.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteDrugs
            // 
            this.buttonDeleteDrugs.Location = new System.Drawing.Point(353, 319);
            this.buttonDeleteDrugs.Name = "buttonDeleteDrugs";
            this.buttonDeleteDrugs.Size = new System.Drawing.Size(108, 23);
            this.buttonDeleteDrugs.TabIndex = 9;
            this.buttonDeleteDrugs.Text = "Delete Records";
            this.buttonDeleteDrugs.UseVisualStyleBackColor = true;
            this.buttonDeleteDrugs.Click += new System.EventHandler(this.buttonDeleteDrugs_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(560, 319);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonInsertDrugs
            // 
            this.buttonInsertDrugs.Location = new System.Drawing.Point(38, 319);
            this.buttonInsertDrugs.Name = "buttonInsertDrugs";
            this.buttonInsertDrugs.Size = new System.Drawing.Size(110, 23);
            this.buttonInsertDrugs.TabIndex = 11;
            this.buttonInsertDrugs.Text = "Insert Records";
            this.buttonInsertDrugs.UseVisualStyleBackColor = true;
            this.buttonInsertDrugs.Click += new System.EventHandler(this.buttonInsertDrugs_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(217, 57);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(178, 20);
            this.textBoxSearch.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search Drugs Here";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(410, 107);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(310, 206);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Drug Management";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Drug ID";
            // 
            // textBoxDrugID
            // 
            this.textBoxDrugID.Location = new System.Drawing.Point(170, 113);
            this.textBoxDrugID.Name = "textBoxDrugID";
            this.textBoxDrugID.Size = new System.Drawing.Size(100, 20);
            this.textBoxDrugID.TabIndex = 18;
            // 
            // dateTimePickerExpiry
            // 
            this.dateTimePickerExpiry.Location = new System.Drawing.Point(170, 238);
            this.dateTimePickerExpiry.Name = "dateTimePickerExpiry";
            this.dateTimePickerExpiry.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerExpiry.TabIndex = 19;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(407, 57);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 21;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // DrugManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dateTimePickerExpiry);
            this.Controls.Add(this.textBoxDrugID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonInsertDrugs);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDeleteDrugs);
            this.Controls.Add(this.buttonUpdateDrugs);
            this.Controls.Add(this.textBoxBatchLotNo);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelExpiry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDrugName);
            this.Name = "DrugManagement";
            this.Text = "DrugManagement";
            this.Load += new System.EventHandler(this.DrugManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDrugName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelExpiry;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBatchLotNo;
        private System.Windows.Forms.Button buttonUpdateDrugs;
        private System.Windows.Forms.Button buttonDeleteDrugs;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonInsertDrugs;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDrugID;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpiry;
        private System.Windows.Forms.Button buttonSearch;
    }
}