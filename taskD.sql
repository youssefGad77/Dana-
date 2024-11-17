Create Database DesktopTask
Create Table Department
(
DepartmentID int primary key identity(1,1) ,
DepartmentName nvarchar(50) not null
)
Create Table Student 
(
StudentID int primary key identity(1,1) ,
StudentName nvarchar(50) not null unique ,
StudentPassword nvarchar(50) not null ,
Email nvarchar(50) not null unique ,
StudentAddress nvarchar(75) ,
StudentAge int ,
DepID int ,
foreign key (DepID) references Department(DepartmentID)
)