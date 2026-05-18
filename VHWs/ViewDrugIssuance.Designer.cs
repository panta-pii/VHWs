namespace VHWs
{
    partial class ViewDrugIssuance
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearchDrugIssue = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(193, 53);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(197, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(113, 113);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(581, 199);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSearchDrugIssue
            // 
            this.buttonSearchDrugIssue.Location = new System.Drawing.Point(466, 49);
            this.buttonSearchDrugIssue.Name = "buttonSearchDrugIssue";
            this.buttonSearchDrugIssue.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchDrugIssue.TabIndex = 3;
            this.buttonSearchDrugIssue.Text = "search";
            this.buttonSearchDrugIssue.UseVisualStyleBackColor = true;
            this.buttonSearchDrugIssue.Click += new System.EventHandler(this.buttonSearchDrugIssue_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ViewDrugIssuance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSearchDrugIssue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "ViewDrugIssuance";
            this.Text = "ViewDrugIssuance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchDrugIssue;
        private System.Windows.Forms.Button button2;
    }
}