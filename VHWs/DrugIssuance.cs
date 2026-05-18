using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VHWs
{
    public partial class DrugIssuance : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-QFSTNQ7\\SQLEXPRESS;Initial Catalog=VHW2128139;Integrated Security=True";

        public DrugIssuance()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void IssueDrug()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Drug_Issuance (drug_id, patient_id, vhw_id, drug_name, date_issued) VALUES (@drug_id, @patient_id, @vhw_id, @drug_name, @date_issued)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    if (int.TryParse(textBoxDrug_Id.Text, out int drugId) &&
                        int.TryParse(textBoxPatient_Id.Text, out int patientId) &&
                        int.TryParse(textBoxVHW_Id.Text, out int vhwId))
                    {
                        cmd.Parameters.AddWithValue("@drug_id", drugId);
                        cmd.Parameters.AddWithValue("@patient_id", patientId);
                        cmd.Parameters.AddWithValue("@vhw_id", vhwId);
                        cmd.Parameters.AddWithValue("@drug_name", textBoxDrugName.Text);
                        // Convert the string to a DateTime object
                        cmd.Parameters.AddWithValue("@date_issued", DateTime.Parse(dateTimePickerIssueDate.Text));

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
                    else
                    {
                        MessageBox.Show("Invalid integer input in one or more text boxes.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void DrugIssuance_Load(object sender, EventArgs e)
        {

        }

        private void buttonIssue_Drug_Click(object sender, EventArgs e)
        {
            IssueDrug();
        }
    }
}
