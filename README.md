
# 📚 Library Management System

A desktop application built with **C#** and **WPF (.NET)** for managing library resources like books and students. It uses a **SQL Server database** to store and manage data, and includes features for issuing and returning books, along with reporting tools.

---

## 🛠 Features

* 🔐 **Login System** (Implemented in `MainWindow.xaml`)
* 🖥️ **Dashboard Interface** after login with:

  * 📘 Add/View Books
  * 👨‍🎓 Add/View Students
  * 📤 Issue Books
  * 📥 Return Books
  * 📊 Issue/Return Reports

---

## 🗂️ Project Structure

| File/Folder                        | Purpose                                              |
| ---------------------------------- | ---------------------------------------------------- |
| `MainWindow.xaml`                  | Contains the login page logic                        |
| `Dashboard.xaml`                   | Post-login dashboard UI (buttons to various actions) |
| `addbooks.xaml`                    | Interface to add books                               |
| `AddStudents.xaml`                 | Interface to add students                            |
| `ViewBooks.xaml`                   | View all books                                       |
| `ViewStudents.xaml`                | View student records                                 |
| `IssueBook.xaml`                   | Issue book to students                               |
| `ReturnBook.xaml`                  | Return books from students                           |
| `IssueBookReports.xaml`            | Issued books report                                  |
| `ReturnBookReport.xaml`            | Returned books report                                |
| `App.xaml`                         | Application startup configuration                    |
| `Library Management System.csproj` | Project configuration file                           |
| `bin/`, `obj/`                     | Build artifacts and temporary files                  |

---

## 🗄️ Database

* Uses **SQL Server** for backend storage.
* Stores information on:

  * Student records
  * Book inventory
  * Issued/returned transactions
* Connected via **ADO.NET** (or EF if used — clarify if needed).

---

## 🚀 Getting Started

### Prerequisites

* Visual Studio 2019/2022
* SQL Server (Express or full version)
* .NET Desktop Runtime

### Run the Project

1. Clone the repo:

   ```bash
   git clone https://github.com/yourusername/library-management-system.git
   ```

2. Open the solution file `Library Management System.sln` in Visual Studio.

3. Restore the database:

   * Create a SQL Server DB using the provided script (if any).
   * Update the connection string in the code if needed.

4. Build and run:

   * Press `F5` in Visual Studio to launch the app.

---

## 📸 Screenshots
### Login Page
![image](https://github.com/user-attachments/assets/935db2bb-74a8-4574-bb87-62a019ab83a3)
### Dashboard 
![image](https://github.com/user-attachments/assets/4674d0ef-6a4f-4b2d-93e0-38aed1ed5b37)

