use PaintDB
Alter table  UsersSession
add constraint FK_UserSessions_Users Foreign Key(UserID) references PaintUsers(ID)