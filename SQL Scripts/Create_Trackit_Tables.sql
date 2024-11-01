DROP TABLE Task, AppUser;

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