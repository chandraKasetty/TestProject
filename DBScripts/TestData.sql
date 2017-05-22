  
Insert Into AttachmentTypes ( Value) values ('Text', 'Image') 

Insert Into Status( StatusType) values ('Statarted'), ('Pending'), ('Done')

Insert Into Assignees( Name) values ('Chandra'), ('Kasetty'), ('Shekar')

Insert Into Task( Name, Description, StatusId, AssigneeId, DueDate) 
values 
('Task1', 'Task1Description', 1,1, GETDATE()), 
('Task2', 'Task2Description', 2,2, GETDATE()), 
('Task3', 'Task3Description', 2, 3, GETDATE())

--use some test image path
Insert Into Attachments ( TaskId, Value, TypeId) 
Select 1,BulkColumn , 1
from Openrowset (Bulk 'C:\Users\ckase\Pictures\windows-phone-logo-topic.png', Single_Blob) as Image