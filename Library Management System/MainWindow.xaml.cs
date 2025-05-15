using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Net.Security;
//using Microsoft.Data.SqlClient;


namespace Library_Management_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       

        private void login_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = Passwordbox.Password;

            // Connection string to your SQL Server and database
            string connectionString = "Server=DESKTOP-LAS63P4; Database=library; Integrated Security=True;";

#pragma warning disable CS0618 // Type or member is obsolete
            using (SqlConnection connection = new(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL query to validate user credentials
                    string query = "SELECT COUNT(1) FROM login WHERE Username = @Username AND Password = @Password";

#pragma warning disable CS0618 // Type or member is obsolete
                    using (SqlCommand command = new(query, connection))
                    {
                        // Use parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                            //Dashboard d= new Dashboard();
                            try
                            {
                                Dashboard d = new Dashboard();
                                d.Show();
                                this.Hide();  // Hide the login window
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error displaying dashboard: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
#pragma warning restore CS0618 // Type or member is obsolete
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
#pragma warning restore CS0618 // Type or member is obsolete

        }
    }
}