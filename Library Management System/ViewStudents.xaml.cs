using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Library_Management_System
{
    /// <summary>
    /// Interaction logic for ViewStudents.xaml
    /// </summary>
    public partial class ViewStudents : Window
    {
        public ViewStudents()
        {
            InitializeComponent();
            LoadStudentsData();
        }

        private void LoadStudentsData()
        {
            // Connection string to the database
            string connectionString = "Server=DESKTOP-LAS63P4; Database=library; Integrated Security=True;";

            // Query to fetch student data
            string query = "SELECT StudentID, StudentName, EnrollmentNo, Email, PhoneNumber, Department FROM students";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind data to the DataGrid
                        StudentsDataGrid.ItemsSource = dataTable.DefaultView;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
