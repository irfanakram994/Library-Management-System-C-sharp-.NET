using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows;

namespace Library_Management_System
{
    /// <summary>
    /// Interaction logic for addbooks.xaml
    /// </summary>
    public partial class addbooks : Window
    {
        public addbooks()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Capture input data
            string bookName = ((TextBox)FindName("BookNameTextBox")).Text;
            string authorName = ((TextBox)FindName("AuthorNameTextBox")).Text;
            string publication = ((TextBox)FindName("PublicationTextBox")).Text;
            string purchaseDate = ((DatePicker)FindName("PurchaseDatePicker")).SelectedDate?.ToString("yyyy-MM-dd");
            string bookPrice = ((TextBox)FindName("BookPriceTextBox")).Text;
            string bookQuantity = ((TextBox)FindName("BookQuantityTextBox")).Text;

            // Validate input
            if (string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(authorName) || string.IsNullOrEmpty(publication) ||
                string.IsNullOrEmpty(purchaseDate) || string.IsNullOrEmpty(bookPrice) || string.IsNullOrEmpty(bookQuantity))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Connection string
            string connectionString = "Server=DESKTOP-LAS63P4; Database=library; Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL Insert Query
                    string query = "INSERT INTO books (BookName, AuthorName, Publication, PurchaseDate, BookPrice, BookQuantity) " +
                                   "VALUES (@BookName, @AuthorName, @Publication, @PurchaseDate, @BookPrice, @BookQuantity)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@BookName", bookName);
                        command.Parameters.AddWithValue("@AuthorName", authorName);
                        command.Parameters.AddWithValue("@Publication", publication);
                        command.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
                        command.Parameters.AddWithValue("@BookPrice", bookPrice);
                        command.Parameters.AddWithValue("@BookQuantity", bookQuantity);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the book.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
