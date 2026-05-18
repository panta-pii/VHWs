using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VHWs
{
    public partial class UserManagement : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-QFSTNQ7\\SQLEXPRESS;Initial Catalog=VHW2128139;Integrated Security=True";
        public UserManagement()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelRole_Click(object sender, EventArgs e)
        {

        }
        public void AddUser()
        {
            using (AddUserDataContext data = new AddUserDataContext())
            {
                string query = "INSERT INTO Users (username, password, role, address, contacts) VALUES (@username, @password,@role, @address, @contacts)";
                SqlCommand cmd = new SqlCommand(query, (SqlConnection)data.Connection);
                cmd.Parameters.AddWithValue("@username", textBoxusername.Text);
                cmd.Parameters.AddWithValue("@password", textBoxpassword.Text);
                cmd.Parameters.AddWithValue("@role", comboBoxrole.Text);
                cmd.Parameters.AddWithValue("@address", textBoxaddress.Text);
                cmd.Parameters.AddWithValue("@contacts", Convert.ToInt32(textBoxcontacts.Text));
                data.Connection.Open();
                cmd.ExecuteNonQuery();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User information Added successfully.");
                }
                else
                {
                    MessageBox.Show("Adding User failed.");
                }
                data.Connection.Close();
            }

        }
        public void UpdateUser()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Ensure that textBoxID contains a valid integer value
                    if (int.TryParse(textBoxID.Text, out int userID))
                    {
                        string query = "UPDATE Users SET username = @username, password = @password, address = @address, contacts = @contacts, role = @role WHERE ID = @ID";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@ID", userID);
                            cmd.Parameters.AddWithValue("@username", textBoxusername.Text);
                            cmd.Parameters.AddWithValue("@password", textBoxpassword.Text);
                            cmd.Parameters.AddWithValue("@address", textBoxaddress.Text);
                            cmd.Parameters.AddWithValue("@contacts", Convert.ToInt32(textBoxcontacts.Text));
                            cmd.Parameters.AddWithValue("@role", comboBoxrole.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User information updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No user with the specified ID found. Update failed.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid User ID in the textBoxID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating a user: " + ex.Message);
            }
        }





        private void textBoPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                AddUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void SearchUsers(string searchTerm)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Users WHERE username LIKE @searchTerm OR role LIKE @searchTerm";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%"); // Use '%' to search for partial matches

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Clear existing items in the ListView
                        listView1.Items.Clear();
                        // Add column headers to the ListView
                        listView1.View = View.Details;
                        listView1.Columns.Add("User Name" +
                            "");
                        listView1.Columns.Add("Password");
                        listView1.Columns.Add("Role");
                        listView1.Columns.Add("Address");
                        listView1.Columns.Add("Contacts");



                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["username"].ToString());
                            item.SubItems.Add(reader["password"].ToString());
                            item.SubItems.Add(reader["role"].ToString());
                            item.SubItems.Add(reader["address"].ToString());
                            item.SubItems.Add(reader["contacts"].ToString());

                            listView1.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;
            SearchUsers(searchTerm);
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            try {
                UpdateUser();
            }
            catch(Exception  ex) { 
            MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
           textBoxID.Clear();
            textBoxcontacts.Clear();
            textBoxpassword.Clear();
            textBoxaddress.Clear();
            textBoxusername.Clear();
            textBoxSearch.Clear();  
            listView1.Clear();
        }
    }
}
