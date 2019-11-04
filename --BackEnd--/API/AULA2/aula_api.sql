/* Criando o banco */
CREATE DATABASE aula_api;

/*Usando o banco */
USE aula_api;

/* Criando tabela */
CREATE TABLE tbl_usuario(
	 usuario_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	 usuario_nome varchar (50) not null,
	 usuario_email varchar(100) not null,
	 usuario_senha varchar (255) not null
); 

/* Populando a tabela */
INSERT INTO tbl_usuario (usuario_nome, usuario_email,usuario_senha)
VALUES ('Carlos Tsukamoto', 'tsukamoto@gmail.com', 'abacaxi'),
	   ('Carol Silva', 'carolo@gmail.com', 'uva');

/* Consultando tabela */
SELECT * FROM tbl_usuario;