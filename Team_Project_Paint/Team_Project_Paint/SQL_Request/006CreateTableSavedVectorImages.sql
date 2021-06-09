use PaintDB
create table SavedVectorImages
(
ImageId int Primary Key identity,
UserId int not null Foreign Key references PaintUsers(Id),
ImageName nvarchar(20) not null,
CreateDate datetime not null,
FileSize int not null,
JsonString nvarchar(max) not null 
)