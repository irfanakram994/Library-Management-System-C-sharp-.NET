using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

namespace Library_Management_System
{
    public partial class IssueBookReports : Window
    {
        public IssueBookReports()
        {
            InitializeComponent();
            LoadBookIssueData();
        }

        // Example model to represent a book issue record
        public class BookIssue
        {
            public string MemberName { get; set; }
            public string BookTitle { get; set; }
            public string IssueDate { get; set; }
            public string ReturnDate { get; set; }
        }

        
        private string connectionString = "Server=DESKTOP-LAS63P4; Database=library; Integrated Security=True;";

        // Load book issue data from the SQL database
        private void LoadBookIssueData()
        {
            List<BookIssue> bookIssues = new List<BookIssue>();

            // SQL query to fetch book issue data
            string query = "SELECT StudentName, BookName, IssueDate, ReturnDate FROM IssuedBooks";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the SQL connection
                    connection.Open();

                    // Create a command to execute the SQL query
                    SqlCommand command = new SqlCommand(query, connection);

                    // Execute the query and read the data
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Read data from each row
                        var bookIssue = new BookIssue
                        {
                            MemberName = reader["StudentName"].ToString(),
                            BookTitle = reader["BookName"].ToString(),
                            IssueDate = Convert.ToDateTime(reader["IssueDate"]).ToString("MM/dd/yyyy"),
                            ReturnDate = Convert.ToDateTime(reader["ReturnDate"]).ToString("MM/dd/yyyy")
                        };

                        // Add the record to the list
                        bookIssues.Add(bookIssue);
                    }

                    // Bind the data to the DataGrid
                    BookIssueDataGrid.ItemsSource = bookIssues;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
