use PaintDB
create table UsersSession(
SessionId int Primary Key identity,
UserId int not Null,
LoginDateTime datetime not Null
)

