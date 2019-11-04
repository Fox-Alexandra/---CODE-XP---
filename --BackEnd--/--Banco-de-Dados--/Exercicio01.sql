
/* ESSA QUERY CRIA O BANCO DE DADOS */
CREATE DATABASE exercicio01;

USE exercicio01;

CREATE TABLE Escola (
	idEscola INT IDENTITY PRIMARY KEY NOT NULL,
	nome VARCHAR(50)
);

CREATE TABLE Aluno (
	idAluno INT IDENTITY PRIMARY KEY NOT NULL,
	nome VARCHAR(50),
	RA INT UNIQUE,
	dataNascimento DATE
);

CREATE TABLE Trabalho (
	idTrabalho INT IDENTITY PRIMARY KEY NOT NULL,
	nome VARCHAR(50),
	materia VARCHAR(50),
	dataEntrega DATE,
	idEscola INT FOREIGN KEY REFERENCES Escola(idEscola),
	idAluno INT FOREIGN KEY REFERENCES Aluno(idAluno)
);

INSERT INTO Escola (nome)
VALUES ('E.E. GLAUBER ROCHA'),
	('E.E. MARIA ANGÉLICA SOAVE'),
	('PEDRINHO E NARIZINHO');

INSERT INTO Aluno (nome,RA,dataNascimento)
VALUES ('Alexandra da Silveira',123455,'14/03/1997'),
	('Alexia da Silveira',121245,'21/07/1998'),
	('Alexania da Silveira',236474,'18/04/2002');

INSERT INTO Trabalho (nome,materia,dataEntrega,idEscola, idAluno)
VALUES ('Revolução Francesa','História','22/10/2019',1,2),
	('A guerra de Sesseção','História','21/11/2019',2,1),
	 ('Biologia Marinha','Biologia','23/09/2019',3,3);




SELECT * FROM Escola;
SELECT * FROM Trabalho;
SELECT * FROM Aluno;


SELECT Aluno.nome AS 'Nome Aluno', Trabalho.nome AS 'Nome Trabalho', Trabalho.materia AS 'Matéria', Escola.nome AS 'Nome Escola' from Trabalho
inner join /*Fala com qual tabela vou juntar*/
Aluno AS Aluno
ON Trabalho.idAluno = Aluno.idAluno
inner join
Escola AS Escola
ON Trabalho.idEscola = Escola.idEscola



