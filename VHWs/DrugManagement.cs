using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace VHWs
{
    public partial class DrugManagement : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-QFSTNQ7\\SQLEXPRESS;Initial Catalog=VHW2128139;Integrated Security=True";

        public DrugManagement()
        {
            InitializeComponent();
        }

        private void DrugManagement_Load(object sender, EventArgs e)
        {
        }

        private void SearchDrug(string searchTerm)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Drug WHERE name LIKE @searchTerm";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            listView1.Items.Clear();
                            listView1.View = View.Details;
                            listView1.Columns.Add("ID");
                            listView1.Columns.Add("Name");
                            listView1.Columns.Add("BatchLot Number");
                            listView1.Columns.Add("Expiry Date");

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                                item.SubItems.Add(reader["name"].ToString());
                                item.SubItems.Add(reader["batch_lot_number"].ToString());
                                item.SubItems.Add(reader["expiry_date"].ToString());
                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for drugs: " + ex.Message);
            }
        }

        public void AddDrug()
        {
            using (DrugsDataContext data = new DrugsDataContext())
            {
                try
                {
                    string query = "INSERT INTO Drug (name, batch_lot_number, expiry_date) VALUES (@name, @batch_lot_number, @expiry_date)";
                    SqlCommand cmd = new SqlCommand(query, (SqlConnection)data.Connection);
                    cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@batch_lot_number", textBoxBatchLotNo.Text);

                    // Convert the string to a DateTime object
                    cmd.Parameters.AddWithValue("@expiry_date", DateTime.Parse(dateTimePickerExpiry.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Drug Added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Adding Drug failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
        }

        public void DeleteDrug()
        {
            try
            {
                if (int.TryParse(textBoxDrugID.Text, out int drug_id))
                {
                    MessageBox.Show("Please enter valid drug id");
                    return;
                }
                using (DrugsDataContext data = new DrugsDataContext())
                {
                    var drugToArchive = data.Drugs.FirstOrDefault(d => d.ID == drug_id);
                    if (drugToArchive != null) {
                        var deletedRecord = new DeletedRecord
                        {
                            name = drugToArchive.name,
                            batch_lot_number = drugToArchive.batch_lot_number,
                            expiry_date = drugToArchive.expiry_date,
                            data.DeletedRecords.Add(deletedRecord)
                        };

                }
           
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting a drug: " + ex.Message);
            }
        }
        public void UpdateDrug()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "UPDATE Drug SET name = @name, batch_lot_number = @batch_lot_number, expiry_date = @expiry_date WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                        cmd.Parameters.AddWithValue("@batch_lot_number", textBoxBatchLotNo.Text);
                        cmd.Parameters.AddWithValue("@expiry_date", DateTime.Parse(dateTimePickerExpiry.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Drug information updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No drug with the specified ID found. Update failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating a drug: " + ex.Message);
            }
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;
            SearchDrug(searchTerm);
        }

        private void buttonInsertDrugs_Click(object sender, EventArgs e)
        {
            AddDrug();
        }

        private void buttonDeleteDrugs_Click(object sender, EventArgs e)
        {
            DeleteDrug();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxBatchLotNo.Clear();
            textBoxName.Clear();
            textBoxDrugID.Clear();
            textBoxSearch.Clear();
            listView1.Items.Clear();
        }
    }
}
