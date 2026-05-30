\# Student Management System



A desktop application built with C# Windows Forms and MySQL for managing student academic records.



\*\*Developer:\*\* Maria Mahreen (2024-AG-6579)  

\*\*Course:\*\* Visual Programming (CS-412)  

\*\*University:\*\* University of Agriculture Faisalabad  



\---



\## Features



\- Secure login with Admin role

\- Dashboard with real-time statistics

\- Complete CRUD operations for Students, Courses, and Enrollments

\- Search and filter functionality

\- Soft delete (data preservation)

\- DataGridView with auto-populate on row selection



\---



\## Technologies Used



| Component | Technology |

|-----------|------------|

| Language | C# (.NET Framework 4.7.2) |

| UI Framework | Windows Forms |

| Database | MySQL Server 8.0 |

| Data Access | ADO.NET |

| Version Control | Git / GitHub |

| IDE | Visual Studio 2022 |



\---



\## Database Setup



1\. Install MySQL Server 8.0

2\. Open MySQL Workbench

3\. Run the `database.sql` file



Default login credentials:

\- \*\*Username:\*\* admin

\- \*\*Password:\*\* admin123



\---



\## How to Run



1\. Clone the repository

2\. Open `StudentManagementSystem2.sln` in Visual Studio 2022

3\. Update MySQL password in `Database/DatabaseHelper.cs`

4\. Install NuGet package: MySql.Data

5\. Press \*\*F5\*\* to run



\---



\## Project Structure



```

StudentManagementSystem2/

├── Database/

│   └── DatabaseHelper.cs

├── Forms/

│   ├── LoginForm.cs

│   ├── DashboardForm.cs

│   ├── StudentForm.cs

│   ├── CourseForm.cs

│   └── EnrollmentForm.cs

├── Models/

│   ├── Student.cs

│   ├── Course.cs

│   └── User.cs

└── Program.cs

```

