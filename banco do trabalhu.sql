create database JcDurigam;
use JcDurigam;

create table Usuarios (
    Id int auto_increment primary key,
    NomeComp varchar(50),
    Email varchar(50),
    Telefone varchar(12)
);

select * from Usuarios;