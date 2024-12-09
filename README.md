# Trackit - Task Management Application

Trackit is the final project for the Rapid Application Development (RAD) course at Louisiana State University in Shreveport. Trackit is a simple task management application built with C# and Windows Forms (WinForms). It allows users to register, log in, and manage tasks. Users can add new tasks, mark tasks as completed, and view all their tasks in a clean and organized UI.

![image](https://github.com/user-attachments/assets/c83b10a9-a8af-4d4e-ad61-82480d067628)

## Features

* User Signup and Login: Register new users or log in with existing credentials.
* Add Tasks: Create new tasks with a name, description, due date, and other details.
* Task Completion: Easily mark tasks as completed, which updates their status and completion date.
* View Tasks: Display all tasks or only pending tasks in a list view with sorting and highlighting features.
* Data Storage: All tasks and user data are stored in a SQL Server database.

## Project Structure
```
Trackit
├── Forms
│   ├── MainForm.cs: The main interface displaying the list of tasks.
│   ├── AddTaskForm.cs: Form for adding new tasks.
│   ├── LoginForm.cs: User authentication interface.
│   ├── RegisterForm.cs: User registration interface.
│   └── CompleteTaskForm.cs: Form for marking tasks as completed.
├── Models
│   ├── User.cs: Represents a user in the system.
│   ├── UserTask.cs: Represents a task associated with a user.
│   └── UserTaskManager.cs: Handles task-related operations and in-memory task list.
├── Data_Access
│   └── DatabaseManager.cs: Handles all database interactions.
└── Properties
    └── App.config: Configuration file containing connection strings.
```

## Getting Started
### Prerequisites

* Visual Studio: 2019 or later with .NET Desktop Development workload.
* SQL Server: SQL Server 2012 or later (Express edition is sufficient).
* .NET Framework: 4.7.2 or later.

### Installation

Clone the repository:
```bash
git clone https://github.com/connorzittrauer/Trackit.git
```
Open the Solution
   * Navigate to the cloned directory.
   * Open the Trackit.sln file with Visual Studio.

## Database Setup
Execute the following SQL query to get the database up and running:
```sql
CREATE DATABASE Trackit DB;

CREATE TABLE AppUser (
	UserID INT PRIMARY KEY IDENTITY(1,1),    -- Auto increment primary key by 1, starting at 1
	Username NVARCHAR(50) NOT NULL UNIQUE, 
	Password NVARCHAR(255) NOT NULL
);

CREATE TABLE Task (
    TaskID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    TaskName NVARCHAR(100) NOT NULL,
    TaskDescription NVARCHAR(255),
    DueDate DATETIME,
    DateCreated DATETIME DEFAULT GETDATE(),
    DateCompleted DATETIME,
    IsCompleted BIT DEFAULT 0,

    CONSTRAINT FK_Task_User FOREIGN KEY (UserID) REFERENCES AppUser(UserID)
    ON DELETE CASCADE
);
```
*(Optional) load dummy data to explore the application by executing ``dummy_data.sql``. 

### Update Connection String

1. In Visual Studio, locate App.config.

2. Update the connectionString with your SQL Server instance details:
```xml
<connectionStrings>
  <add name="TrackitDB" connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=TrackitDB;Integrated Security=True;" providerName="System.Data.SqlClient"/>
</connectionStrings>
```
Replace `YOUR_SERVER_NAME` with the name of your SQL Server instance.

