-- Criando banco de dados

create database bdExemplo;

-- usando bando de dados

use bdExemplo;

-- criando as tabelas

create table Usuarios(
Id int primary key auto_increment,
Nome varchar(50) not null,
Email varchar(50) not null,
Senha varchar(50) not null
);

-- consultando os dados do banco

select * from Usuarios;

insert into Usuarios(Nome, Email, Senha) values("carlos", "carlos@gmail.com", "123456");