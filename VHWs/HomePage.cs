using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VHWs
{
    public partial class HomePage : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-QFSTNQ7\\SQLEXPRESS;Initial Catalog=VHW2128139;Integrated Security=True";
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxusername.Text;
                string password = textBoxpassword.Text;

                // Validate user credentials against the database
                if (AuthenticateUser(username, password))
                {

                    // Determine the user's role from the database
                    string userRole = GetUserRole(username);

                    // Open the respective portal based on the user's role
                    if (userRole == "Admin")
                    {
                        AdminDashBoard adminPortal = new AdminDashBoard();
                        adminPortal.Show();
                    }
                    else if (userRole == "VHW")
                    {
                        VHWsDashBoard vhwPortal = new VHWsDashBoard();
                        vhwPortal.Show();
                    }
                    else if (userRole == "HealthCareProffessionals")
                    {
                        HealthCarePro HCPPortal = new HealthCarePro();
                        HCPPortal.Show();
                    }
                    // Close the login form
                    this.Hide(); // Use Hide() instead of Close() to keep the application running
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {

                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE username=@username AND password=@password", connection))
                    {
                        command.Parameters.AddWithValue("@username", textBoxusername.Text);
                        command.Parameters.AddWithValue("@password", textBoxpassword.Text); // Password should be hashed in a real application

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            return reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while authenticating the user: " + ex.Message);
                return false;
            }

        }
        private string GetUserRole(string username)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT role FROM Users WHERE username=@username", connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        return command.ExecuteScalar()?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while getting the user's role: " + ex.Message);
                return null;
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
