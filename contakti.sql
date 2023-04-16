create table Contacts (
ID int identity(1,1) primary key not null,
Name varchar(50) not null,
Phone varchar(12) not null
);

insert into Contacts values ('+79151212461', 'Саня Белый');
