use PaintDB
create table PaintUsers(
Id int Primary Key identity,
FirstName nvarchar(20) not Null,
LastName nvarchar(20) not Null,
Email nvarchar(30) not Null,
[Password] nvarchar(30) not Null
)