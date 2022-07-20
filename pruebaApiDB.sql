create database pruebaApi

create table persona(
id int identity(1,1) primary key,
nombre varchar(50) not null,
edad int not null
)

select * from persona