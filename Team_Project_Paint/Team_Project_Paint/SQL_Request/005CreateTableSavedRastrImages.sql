use PaintDB
create table SavedRastrImages
(
ImageId int Primary Key identity,
UserId int not null Foreign Key references PaintUsers(Id),
ImageName nvarchar(20) not null,
CreateDate datetime not null,
FileSize int not null 
)