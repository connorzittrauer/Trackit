-- Clear existing data in tables (optional, be cautious in production)
DELETE FROM Task;
DELETE FROM AppUser;

-- Insert Users
INSERT INTO AppUser (Username, Password)
VALUES 
    ('john', 'pass'),
    ('jane', 'asd'),
    ('alice', 'pass'),
    ('bob', 'pass'),
    ('mike', 'asd');

-- Get User IDs to assign tasks
DECLARE @john INT, @jane INT, @alice INT, @bob INT, @mike INT;

SELECT @john = UserID FROM AppUser WHERE Username = 'john';
SELECT @jane = UserID FROM AppUser WHERE Username = 'jane';
SELECT @alice = UserID FROM AppUser WHERE Username = 'alice';
SELECT @bob = UserID FROM AppUser WHERE Username = 'bob';
SELECT @mike = UserID FROM AppUser WHERE Username = 'mike';

-- Insert Tasks for each user
-- John's Tasks
INSERT INTO Task (UserID, TaskName, TaskDescription, DateCreated, DueDate, DateCompleted, IsCompleted)
VALUES 
    (@john, 'Complete Math Worksheet', 'Finish all problems from chapter 2', GETDATE(), DATEADD(DAY, 1, GETDATE()), NULL, 0),
    (@john, 'Physics Lab Report', 'Prepare lab report for optics experiment', GETDATE(), DATEADD(DAY, 3, GETDATE()), NULL, 0),
    (@john, 'History Essay Draft', 'Write draft on Civil War impact', GETDATE(), DATEADD(DAY, 5, GETDATE()), NULL, 0);

-- Jane's Tasks
INSERT INTO Task (UserID, TaskName, TaskDescription, DateCreated, DueDate, DateCompleted, IsCompleted)
VALUES 
    (@jane, 'Art Project Research', 'Find three artists for paper', GETDATE(), DATEADD(DAY, 7, GETDATE()), NULL, 0),
    (@jane, 'Computer Science Quiz', 'Review chapters 4 and 5', GETDATE(), DATEADD(DAY, 2, GETDATE()), NULL, 0),
    (@jane, 'Biology Lab Prep', 'Organize materials for lab on genetics', GETDATE(), DATEADD(DAY, 4, GETDATE()), NULL, 0);

-- Alice's Tasks
INSERT INTO Task (UserID, TaskName, TaskDescription, DateCreated, DueDate, DateCompleted, IsCompleted)
VALUES 
    (@alice, 'Philosophy Essay', 'Complete essay on existentialism', GETDATE(), DATEADD(DAY, 6, GETDATE()), NULL, 0),
    (@alice, 'Economics Assignment', 'Research demand theories', GETDATE(), DATEADD(DAY, 3, GETDATE()), NULL, 0),
    (@alice, 'Chemistry Practice Problems', 'Finish worksheet on reactions', GETDATE(), DATEADD(DAY, 5, GETDATE()), NULL, 0);

-- Bob's Tasks
INSERT INTO Task (UserID, TaskName, TaskDescription, DateCreated, DueDate, DateCompleted, IsCompleted)
VALUES 
    (@bob, 'Geometry Homework', 'Solve problems from chapter 8', GETDATE(), DATEADD(DAY, 2, GETDATE()), NULL, 0),
    (@bob, 'Literature Analysis', 'Read and analyze chapters 1-3', GETDATE(), DATEADD(DAY, 4, GETDATE()), NULL, 0),
    (@bob, 'Spanish Vocabulary Study', 'Memorize new vocab list', GETDATE(), DATEADD(DAY, 3, GETDATE()), NULL, 0);

-- Mike's Tasks
INSERT INTO Task (UserID, TaskName, TaskDescription, DateCreated, DueDate, DateCompleted, IsCompleted)
VALUES 
    (@mike, 'Chemistry Lab Preparation', 'Prepare for upcoming lab on acids', GETDATE(), DATEADD(DAY, 3, GETDATE()), NULL, 0),
    (@mike, 'Math Quiz Review', 'Study for quiz on derivatives', GETDATE(), DATEADD(DAY, 2, GETDATE()), NULL, 0),
    (@mike, 'Essay Draft', 'Draft for English literature essay', GETDATE(), DATEADD(DAY, 5, GETDATE()), NULL, 0);
