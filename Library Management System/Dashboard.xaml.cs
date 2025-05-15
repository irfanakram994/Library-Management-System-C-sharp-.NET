using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Library_Management_System
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            addbooks add = new addbooks();
            add.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewBooks viewBooks = new ViewBooks();
            viewBooks.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddStudents addS = new AddStudents();
            addS.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ViewStudents viewS = new ViewStudents();    
            viewS.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            IssueBook issueBook = new IssueBook();  
                issueBook.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ReturnBook returb = new ReturnBook();
                returb.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            IssueBookReports issue_BR = new IssueBookReports();
                issue_BR.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ReturnBookReport return_BR = new ReturnBookReport();    
            return_BR.Show();
        }
    }
}
