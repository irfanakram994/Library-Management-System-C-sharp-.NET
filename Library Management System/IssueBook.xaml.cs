using System;
using System.Data.SqlClient;
using System.Windows;

namespace Library_Management_System
{
    public partial class IssueBook : Window
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void SearchMemberButton_Click(object sender, RoutedEventArgs e)
        {
            string studentId = memberIdTextBox.Text; // Treat as Student ID
            if (string.IsNullOrEmpty(studentId))
            {
                MessageBox.Show("Please enter a Student ID.");
                return;
            }

            string connectionString = "Server=DESKTOP-LAS63P4; Database=library; Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Updated query to search Students table
                    string query = "SELECT StudentName FROM Students WHERE StudentID = @StudentID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentID", studentId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        memberNameTextBox.Text = $"StudentName: {reader["StudentName"]}";
                    }
                    else
                    {
                        MessageBox.Show("Student not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void SearchBookButton_Click(object sender, RoutedEventArgs e)
        {
            string bookId = bookIdTextBox.Text;
            if (string.IsNullOrEmpty(bookId))
            {
                MessageBox.Show("Please enter a Book ID.");
                return;
            }

            string connectionString = "Server=DESKTOP-LAS63P4; Database=library; Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT BookName FROM Books WHERE BookID = @BookID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BookID", bookId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        bookTitleTextBox.Text = $"BookName: {reader["BookName"]}";
                        issueBookButton.IsEnabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Book not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        private void IssueBookButton_Click(object sender, RoutedEventArgs e)
        {
            string memberId = memberIdTextBox.Text; // Student ID
            string bookId = bookIdTextBox.Text;

            // Fetch the Return Date from the DatePicker
            DateTime? returnDate = returnDatePicker.SelectedDate;

            if (string.IsNullOrEmpty(memberId) || string.IsNullOrEmpty(bookId))
            {
                MessageBox.Show("Please search for both Member and Book.");
                return;
            }

            // Validate Return Date
            if (returnDate == null)
            {
                MessageBox.Show("Please select a return date.");
                return;
            }

            string connectionString = "Server=DESKTOP-LAS63P4; Database=library; Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Updated query to include ReturnDate
                    string query = "INSERT INTO IssuedBooks (StudentID, BookID, IssueDate, ReturnDate) " +
                                   "VALUES (@StudentID, @BookID, @IssueDate, @ReturnDate)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@StudentID", memberId);
                    command.Parameters.AddWithValue("@BookID", bookId);
                    command.Parameters.AddWithValue("@IssueDate", DateTime.Now);
                    command.Parameters.AddWithValue("@ReturnDate", returnDate.Value);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Book issued successfully.");
                        issueBookButton.IsEnabled = false;
                        memberNameTextBox.Clear();
                        bookTitleTextBox.Clear();
                        memberIdTextBox.Clear();
                        bookIdTextBox.Clear();
                        returnDatePicker.SelectedDate = null; // Clear Return Date
                    }
                    else
                    {
                        MessageBox.Show("Failed to issue book.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }



    }
}
