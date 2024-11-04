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
    (@john, 'History Essay Draft', 'Write draft on Civil War impact', GETDATE(), DATEADD(DAY, 5, GETDATE()), NULL, 0),
    (@john, 'Calculus Homework', 'Complete exercises on limits', GETDATE(), DATEADD(DAY, 2, GETDATE()), NULL, 0),
    (@john, 'Computer Science Project', 'Plan out project structure', GETDATE(), DATEADD(DAY, 4, GETDATE()), NULL, 0),
    (@john, 'English Literature Review', 'Analyze themes in assigned novel', GETDATE(), DATEADD(DAY, 7, GETDATE()), NULL, 0),
    (@john, 'Biology Notes', 'Organize class notes for test', GETDATE(), DATEADD(DAY, 3, GETDATE()), NULL, 0),
    (@john, 'Chemistry Lab Prep', 'Prepare materials for lab on gases', GETDATE(), DATEADD(DAY, 6, GETDATE()), NULL, 0),
    (@john, 'Sociology Essay', 'Write essay on social dynamics', GETDATE(), DATEADD(DAY, 5, GETDATE()), NULL, 0),
    (@john, 'Economics Reading', 'Read assigned chapters on microeconomics', GETDATE(), DATEADD(DAY, 4, GETDATE()), NULL, 0);

-- Jane's Tasks
INSERT INTO Task (UserID, TaskName, TaskDescription, DateCreated, DueDate, DateCompleted, IsCompleted)
VALUES 
    (@jane, 'Art Project Research', 'Find three artists for paper', GETDATE(), DATEADD(DAY, 7, GETDATE()), NULL, 0),
    (@jane, 'Computer Science Quiz', 'Review chapters 4 and 5', GETDATE(), DATEADD(DAY, 2, GETDATE()), NULL, 0),
    (@jane, 'Biology Lab Prep', 'Organize materials for lab on genetics', GETDATE(), DATEADD(DAY, 4, GETDATE()), NULL, 0),
    (@jane, 'Physics Study Guide', 'Prepare for midterm', GETDATE(), DATEADD(DAY, 5, GETDATE()), NULL, 0),
    (@jane, 'Algebra Homework', 'Complete problem set on quadratics', GETDATE(), DATEADD(DAY, 3, GETDATE()), NULL, 0),
    (@jane, 'Chemistry Revision', 'Review periodic table elements', GETDATE(), DATEADD(DAY, 6, GETDATE()), NULL, 0),
    (@jane, 'Essay Outline', 'Outline for history term paper', GETDATE(), DATEADD(DAY, 7, GETDATE()), NULL, 0),
    (@jane, 'Geography Assignment', 'Complete climate change worksheet', GETDATE(), DATEADD(DAY, 8, GETDATE()), NULL, 0),
    (@jane, 'Programming Exercise', 'Practice loops and conditionals', GETDATE(), DATEADD(DAY, 4, GETDATE()), NULL, 0),
    (@jane, 'Music Practice', 'Learn scales for piano test', GETDATE(), DATEADD(DAY, 3, GETDATE()), NULL, 0);

-- Alice's Tasks
INSERT INTO Task (UserID, TaskName, TaskDescription, DateCreated, DueDate, DateCompleted, IsCompleted)
VALUES 
    (@alice, 'Philosophy Essay', 'Complete essay on existentialism', GETDATE(), DATEADD(DAY, 6, GETDATE()), NULL, 0),
    (@alice, 'Economics Assignment', 'Research demand theories', GETDATE(), DATEADD(DAY, 3, GETDATE()), NULL, 0),
    (@alice, 'Chemistry Practice Problems', 'Finish worksheet on reactions', GETDATE(), DATEADD(DAY, 5, GETDATE()), NULL, 0),
    (@alice, 'History Project', 'Gather sources on WWII', GETDATE(), DATEADD(DAY, 7, GETDATE()), NULL, 0),
    (@alice, 'Math Revision', 'Revise integration techniques', GETDATE(), DATEADD(DAY, 2, GETDATE()), NULL, 0),
    (@alice, 'Physics Lab Analysis', 'Analyze lab data on waves', GETDATE(), DATEADD(DAY, 4, GETDATE()), NULL, 0),
    (@alice, 'English Paper Draft', 'Draft for paper on poetry', GETDATE(), DATEADD(DAY, 5, GETDATE()), NULL, 0),
    (@alice, 'Biology Quiz Preparation', 'Study genetics and inheritance', GETDATE(), DATEADD(DAY, 3, GETDATE()), NULL, 0),
    (@alice, 'Literature Research', 'Find themes in Gothic literature', GETDATE(), DATEADD(DAY, 6, GETDATE()), NULL, 0),
    (@alice, 'Math Quiz', 'Complete quiz on derivatives', GETDATE(), DATEADD(DAY, 1, GETDATE()), NULL, 0);

-- Bob's Tasks
INSERT INTO Task (UserID, TaskName, TaskDescription, DateCreated, DueDate, DateCompleted, IsCompleted)
VALUES 
    (@bob, 'Geometry Homework', 'Solve problems from chapter 8', GETDATE(), DATEADD(DAY, 2, GETDATE()), NULL, 0),
    (@bob, 'Literature Analysis', 'Read and analyze chapters 1-3', GETDATE(), DATEADD(DAY, 4, GETDATE()), NULL, 0),
    (@bob, 'Spanish Vocabulary Study', 'Memorize new vocab list', GETDATE(), DATEADD(DAY, 3, GETDATE()), NULL, 0),
    (@bob, 'Algebra Exam Prep', 'Review all topics', GETDATE(), DATEADD(DAY, 7, GETDATE()), NULL, 0),
    (@bob, 'History Chapter Summary', 'Summarize key events', GETDATE(), DATEADD(DAY, 6, GETDATE()), NULL, 0),
    (@bob, 'Science Lab Prep', 'Prepare materials for lab', GETDATE(), DATEADD(DAY, 5, GETDATE()), NULL, 0),
    (@bob, 'Art History Project', 'Research Renaissance painters', GETDATE(), DATEADD(DAY, 8, GETDATE()), NULL, 0),
    (@bob, 'Math Problems Set', 'Practice with word problems', GETDATE(), DATEADD(DAY, 3, GETDATE()), NULL, 0),
    (@bob, 'Chemistry Review', 'Go over reaction types', GETDATE(), DATEADD(DAY, 2, GETDATE()), NULL, 0),
    (@bob, 'Economics Case Study', 'Prepare case study for presentation', GETDATE(), DATEADD(DAY, 4, GETDATE()), NULL, 0);

-- Mike's Tasks
INSERT INTO Task (UserID, TaskName, TaskDescription, DateCreated, DueDate, DateCompleted, IsCompleted)
VALUES 
    (@mike, 'Chemistry Lab Preparation', 'Prepare for upcoming lab on acids', GETDATE(), DATEADD(DAY, 3, GETDATE()), NULL, 0),
    (@mike, 'Math Quiz Review', 'Study for quiz on derivatives', GETDATE(), DATEADD(DAY, 2, GETDATE()), NULL, 0),
    (@mike, 'Essay Draft', 'Draft for English literature essay', GETDATE(), DATEADD(DAY, 5, GETDATE()), NULL, 0),
    (@mike, 'French Vocabulary', 'Memorize new words for quiz', GETDATE(), DATEADD(DAY, 4, GETDATE()), NULL, 0),
    (@mike, 'Physics Homework', 'Finish problem set on energy', GETDATE(), DATEADD(DAY, 6, GETDATE()), NULL, 0),
    (@mike, 'Art Project', 'Work on final painting', GETDATE(), DATEADD(DAY, 7, GETDATE()), NULL, 0),
    (@mike, 'Chemistry Worksheet', 'Complete acid-base reactions sheet', GETDATE(), DATEADD(DAY, 3, GETDATE()), NULL, 0),
    (@mike, 'Biology Quiz Study', 'Review cell structures', GETDATE(), DATEADD(DAY, 2, GETDATE()), NULL, 0),
    (@mike, 'English Summary', 'Summarize recent readings', GETDATE(), DATEADD(DAY, 8, GETDATE()), NULL, 0),
    (@mike, 'Computer Science Exercise', 'Work on array problems', GETDATE(), DATEADD(DAY, 5, GETDATE()), NULL, 0);
