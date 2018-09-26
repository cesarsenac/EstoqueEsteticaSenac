CREATE DATABASE EstoqueEsteticaSenac;

USE EstoqueEsticaSenac;

CREATE TABLE usuarios (
id int primary key identity(1,1),
nome varchar(255), 
email varchar(255), 
login varchar(255), 
senha varchar(255), 
administrador varchar(255)
);

CREATE TABLE Produtos
(
ID INT PRIMARY KEY IDENTITY(1,1),
NomeProduto VARCHAR(255) NOT NULL,
CodigoDeBarras VARCHAR(13) NOT NULL,
Observações VARCHAR(8000) NOT NULL
);
--Precisa de foreign key para a Marca

CREATE Table Marca
(
ID_Marca Smallint Primary Key Identity,
Nome_Marca Varchar(100) not null,
Observacao_Marca Varchar (8000),
);

create table SaidaEstoque
(
CodigoProduto int primary key not null identity(1,1),
Quantidade int not null,
DataSaida int not null,
DataVencimento int not null,

);

create table EntradaEstoque
(
CodigoProduto int primary key not null identity(1,1),
Quantidade int not null,
DataEntrada int not null,
DataVencimento int not null,
);

INSERT INTO usuarios (nome, email, login, senha, administrador) VALUES ('Administrador do Sistema','admin@admin.com','admin','','');