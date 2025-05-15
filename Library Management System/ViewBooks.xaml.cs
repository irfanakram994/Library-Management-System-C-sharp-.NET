using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Library_Management_System
{
    /// <summary>
    /// Interaction logic for ViewBooks.xaml
    /// </summary>
    public partial class ViewBooks : Window
    {
        public ViewBooks()
        {
            InitializeComponent();
            LoadBooksData();
        }

        private void LoadBooksData()
        {
            string connectionString = "Server=DESKTOP-LAS63P4; Database=library; Integrated Security=True;";
            string query = "SELECT BookID, BookName, AuthorName, Publication, FORMAT(PurchaseDate, 'yyyy-MM-dd') AS PurchaseDate, BookPrice, BookQuantity FROM books";

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

                        // Bind data to DataGrid
                        BooksDataGrid.ItemsSource = dataTable.DefaultView;
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
