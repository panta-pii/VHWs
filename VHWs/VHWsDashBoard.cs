using System;
using System.Windows.Forms;

namespace VHWs
{

    public partial class VHWsDashBoard : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-QFSTNQ7\\SQLEXPRESS;Initial Catalog=VHW2128139;Integrated Security=True";
        public VHWsDashBoard()
        {
            InitializeComponent();
        }

        private void VHWsDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewDrugIssued_Click(object sender, EventArgs e)
        {
            ViewDrugIssuance view = new ViewDrugIssuance();
            view.Show();
        }
    }
}
