Create Table Cars
(
Id int not null primary key ,
BrandId int ,
ColorId int,
ModelYear nvarchar(4),
DailyPrice int ,
Description nvarchar(200)
)
Create Table Brands
(
BrandId int not null primary key  ,
BrandName nvarchar(30)
)
Create Table Colors
(
ColorId int not null primary key  ,
ColorName nvarchar(30)
)


