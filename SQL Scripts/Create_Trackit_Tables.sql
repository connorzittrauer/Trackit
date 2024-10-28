CREATE TABLE AppUser (
	UserID INT PRIMARY KEY IDENTITY(1,1),    -- Auto increment primary key by 1, starting at 1
	Username NVARCHAR(50) NOT NULL, 
	Password NVARCHAR(255) NOT NULL
);

CREATE TABLE Task (
    TaskID INT PRIMARY KEY IDENTITY(1,1),    -- Auto increment primary key by 1, starting at 1
	Username NVARCHAR(50) NOT NULL, 
    UserID INT NOT NULL,                     -- Foreign key to AppUser table
    TaskName NVARCHAR(100) NOT NULL,         
    TaskDescription NVARCHAR(255),           
    DueDate DATETIME,                        
    DateCreated DATETIME DEFAULT GETDATE(),  
	DateCompleted DATETIME, 
    IsCompleted BIT DEFAULT 0,               

    -- Define the foreign key constraint to link Task to User
    CONSTRAINT FK_Task_User FOREIGN KEY (UserID) REFERENCES AppUser(UserID)
    ON DELETE CASCADE                        -- Optional: delete tasks if user is deleted
);
