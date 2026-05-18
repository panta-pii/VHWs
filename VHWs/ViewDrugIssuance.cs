using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VHWs
{
    public partial class ViewDrugIssuance : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-QFSTNQ7\\SQLEXPRESS;Initial Catalog=VHW2128139;Integrated Security=True";
        public ViewDrugIssuance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void SearchDrugIssued(string searchTerm)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Drug_Issuance WHERE drug_id LIKE  @searchTerm OR drug_name  LIKE @searchTerm";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%"); // Use '%' to search for partial matches

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Clear existing items in the ListView
                        listView1.Items.Clear();

                        // Add column headers to the ListView
                        listView1.View = View.Details;
                        listView1.Columns.Add("Drug Name");
                        listView1.Columns.Add("ID");
                        listView1.Columns.Add("Drug ID");
                        listView1.Columns.Add("Patient ID");
                        listView1.Columns.Add("VHW ID");
                        listView1.Columns.Add("Date Issued");

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["drug_name"].ToString());
                            item.SubItems.Add(reader["ID"].ToString());
                            item.SubItems.Add(reader["drug_id"].ToString());
                            item.SubItems.Add(reader["patient_id"].ToString());
                            item.SubItems.Add(reader["vhw_id"].ToString());
                            item.SubItems.Add(reader["date_issued"].ToString());

                            listView1.Items.Add(item);
                        }
                    }
                }
            }
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearchDrugIssue_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;
            SearchDrugIssued(searchTerm);
        }
    }
}
