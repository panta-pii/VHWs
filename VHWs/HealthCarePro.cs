using System;
using System.Windows.Forms;

namespace VHWs
{
    public partial class HealthCarePro : Form
    {
        public HealthCarePro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserManagement open = new UserManagement();
            open.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DrugManagement open = new DrugManagement();
            open.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DrugIssuance drugIssuance = new DrugIssuance();
            drugIssuance.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Drug_Dispensation drug = new Drug_Dispensation();
            drug.Show();
        }

    }
}
