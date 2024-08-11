CREATE DATABASE ToDoListDB;

USE ToDoListDB;

CREATE TABLE Tasks (
    Id INT PRIMARY KEY IDENTITY(1,1),
    StartTime DATETIME ,
    Description NVARCHAR(MAX),
	Title NVARCHAR(255),
    EndTime DATETIME,
    Priority varchar(5),
	isChecked bit

);

 Create table FinishTask(
	id int primary key,
    StartTime DATETIME,
	EndTime DATETIME,
	Title NVARCHAR(255),
    Description NVARCHAR(MAX),
	Priority varchar(5)
	foreign key(id) references Tasks(id)
 );

INSERT INTO Tasks (StartTime, EndTime, Title, Description, Priority, IsChecked)
VALUES 
('2024-08-11 08:00:00', '2024-08-11 09:00:00', 'Work', 'Meet with Client A to discuss the new project.', 'I', 0),

('2024-08-11 10:00:00', '2024-08-11 11:30:00', 'Personal', 'Complete the Q2 report and send it to the manager.', 'II', 0),

('2024-08-11 13:00:00', '2024-08-11 14:00:00', 'Study', 'Attend the weekly meeting with the project team.', 'I', 0),

('2024-08-11 15:00:00', '2024-08-11 16:00:00', 'Health', 'Check and respond to important emails.', 'III', 0),

('2024-08-11 17:00:00', '2024-08-11 18:00:00', 'Finance', 'Plan for the new project starting next week.', 'II', 0),

('2024-08-12 08:30:00', '2024-08-12 09:30:00', 'Home', 'Meet with Client B to discuss additional requirements.', 'I', 0),

('2024-08-12 10:00:00', '2024-08-12 11:00:00', 'Travel', 'Train new employees on company procedures.', 'II', 0),

('2024-08-12 14:00:00', '2024-08-12 15:00:00', 'Personal Development', 'Review project documents from the QA team.', 'III', 0),

('2024-08-12 16:00:00', '2024-08-12 17:00:00', 'Entertainment', 'Prepare materials and content for the presentation.', 'I', 0),

('2024-08-12 18:00:00', '2024-08-12 19:00:00', 'Personal Projects', 'Summarize and report on the day''s work.', 'IV', 0);

select * from Tasks