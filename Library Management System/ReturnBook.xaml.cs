using System;
using System.Data.SqlClient;
using System.Windows;

namespace Library_Management_System
{
    public partial class ReturnBook : Window
    {
        public ReturnBook()
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
                    // Query to search in Students table
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
                        returnBookButton.IsEnabled = true;
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

        private void ReturnBookButton_Click(object sender, RoutedEventArgs e)
        {
            string studentId = memberIdTextBox.Text; // Student ID
            string bookId = bookIdTextBox.Text;

            if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(bookId))
            {
                MessageBox.Show("Please search for both Member and Book.");
                return;
            }

            string connectionString = "Server=DESKTOP-LAS63P4; Database=library; Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the book is issued to the student and not returned
                    string checkQuery = "SELECT * FROM IssuedBooks WHERE StudentID = @StudentID AND BookID = @BookID AND ReturnDate IS NULL";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@StudentID", studentId);
                    checkCommand.Parameters.AddWithValue("@BookID", bookId);

                    SqlDataReader reader = checkCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        // Book is issued and not returned, so now return the book
                        reader.Close();

                        // Update the ReturnDate for the book
                        string updateQuery = "UPDATE IssuedBooks SET ReturnDate = @ReturnDate WHERE StudentID = @StudentID AND BookID = @BookID AND ReturnDate IS NULL";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@ReturnDate", DateTime.Now);
                        updateCommand.Parameters.AddWithValue("@StudentID", studentId);
                        updateCommand.Parameters.AddWithValue("@BookID", bookId);

                        int result = updateCommand.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Book returned successfully.");
                            bookTitleTextBox.Clear();
                            memberNameTextBox.Clear();
                            memberIdTextBox.Clear();
                            bookIdTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to return the book.");
                        }
                    }
                    else
                    {
                        // Book is either not issued or already returned
                        MessageBox.Show("This book was not issued to the student or has already been returned.");
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
