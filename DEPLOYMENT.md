\# Deployment Guide - Student Management System



Developer: Maria Mahreen (2024-AG-6579)  

Course: Visual Programming (CS-412)  



\---



\## System Requirements



\- Operating System: Windows 10 or Windows 11 (64-bit)

\- .NET Framework: 4.7.2 or higher

\- Database: MySQL Server 8.0 or higher

\- IDE: Visual Studio 2022 (Community Edition)

\- RAM: 4 GB minimum

\- Storage: 500 MB free disk space



\---



\## Step 1: Install Prerequisites



1\. Install Visual Studio 2022 Community

&#x20;  - Download: https://visualstudio.microsoft.com/

&#x20;  - Select ".NET Desktop Development" workload



2\. Install MySQL Server 8.0

&#x20;  - Download: https://dev.mysql.com/downloads/mysql/

&#x20;  - Install MySQL Server + MySQL Workbench



3\. Install Git

&#x20;  - Download: https://git-scm.com/



\---



\## Step 2: Clone Repository



```bash

git clone https://github.com/MariaMahreen/StudentManagementSystem2.git

```



\---



\## Step 3: Database Setup



1\. Open MySQL Workbench

2\. Connect to localhost

3\. Run the database.sql script:



```sql

CREATE DATABASE IF NOT EXISTS StudentManagementDB;

USE StudentManagementDB;

```



Or run the full database.sql file provided in the project.



\---



\## Step 4: Configure Connection



Open `StudentManagementSystem2/Database/DatabaseHelper.cs`



Update this line with your MySQL password:



```csharp

private static string connectionString =

&#x20;   "Server=localhost;Database=StudentManagementDB;Uid=root;Pwd=YOUR\_PASSWORD;";

```



\---



\## Step 5: Install NuGet Package



1\. Open project in Visual Studio 2022

2\. Tools → NuGet Package Manager → Manage NuGet Packages

3\. Search: MySql.Data

4\. Install: MySql.Data by Oracle



\---



\## Step 6: Run Application



1\. Press F5 in Visual Studio

2\. Login with default credentials:

&#x20;  - Username: admin

&#x20;  - Password: admin123



\---



\## Default Login Credentials



| Role | Username | Password |

|------|----------|----------|

| Admin | admin | admin123 |

