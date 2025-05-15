using System;
using System.Data.SqlClient;
using System.Windows;

namespace Library_Management_System
{
    /// <summary>
    /// Interaction logic for AddStudents.xaml
    /// </summary>
    public partial class AddStudents : Window
    {
        public AddStudents()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Server=DESKTOP-LAS63P4; Database=library; Integrated Security=True;";

            string query = @"INSERT INTO students (StudentName, EnrollmentNo, Email, PhoneNumber, Department, Address) 
                     VALUES (@StudentName, @EnrollmentNo, @Email, @PhoneNumber, @Department, @Address)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentName", txtStudentName.Text.Trim());
                        command.Parameters.AddWithValue("@EnrollmentNo", txtEnrollmentNo.Text.Trim());
                        command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim());
                        command.Parameters.AddWithValue("@Department", txtDepartment.Text.Trim());
                        command.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add student. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
