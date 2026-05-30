-- Student Management System Database
-- Developer: Maria Mahreen (2024-AG-6579)

CREATE DATABASE IF NOT EXISTS StudentManagementDB;
USE StudentManagementDB;

CREATE TABLE Students (
    StudentID INT AUTO_INCREMENT PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    RollNumber VARCHAR(20) UNIQUE NOT NULL,
    Email VARCHAR(100),
    Phone VARCHAR(20),
    Address TEXT,
    DateOfBirth DATE,
    Gender ENUM('Male', 'Female', 'Other'),
    IsActive TINYINT DEFAULT 1,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Courses (
    CourseID INT AUTO_INCREMENT PRIMARY KEY,
    CourseName VARCHAR(100) NOT NULL,
    CourseCode VARCHAR(20) UNIQUE NOT NULL,
    CreditHours INT,
    Description TEXT,
    IsActive TINYINT DEFAULT 1
);

CREATE TABLE Enrollments (
    EnrollmentID INT AUTO_INCREMENT PRIMARY KEY,
    StudentID INT NOT NULL,
    CourseID INT NOT NULL,
    EnrollmentDate DATE,
    Grade VARCHAR(5),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) UNIQUE NOT NULL,
    Password VARCHAR(100) NOT NULL,
    Role ENUM('Admin', 'User') DEFAULT 'User',
    IsActive TINYINT DEFAULT 1
);

INSERT INTO Users (Username, Password, Role)
VALUES ('admin', 'admin123', 'Admin');