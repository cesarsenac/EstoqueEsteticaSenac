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

INSERT INTO usuarios (nome, email, login, senha, administrador) VALUES ('Administrador do Sistema','admin@admin.com','admin','','');

