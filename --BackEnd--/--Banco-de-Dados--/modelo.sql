
/* ESSA QUERY CRIA O BANCO DE DADOS */
CREATE DATABASE exercicio;

/* Query - linha de codigo para falar qual banco de dados vou usar*/

USE exercicio;

CREATE TABLE equipe (
	idEquipe INT IDENTITY /*CONTADOR*/ PRIMARY KEY NOT NULL, /*da nome e tipo para a coluna dentro da tabela*/
	nome varchar(50),
	especialidade varchar(50),
	localizacaoCidade varchar(50)
);

/* Adicionar uma coluna */
ALTER TABLE equipe ADD tecnico varchar(50); /*add uma nova coluna*/

/* Apagar uma coluna */
ALTER TABLE equipe DROP COLUMN tecnico;


/* Criar chave estrangeira e realizar referencia citando nome_da_tabela(campo)*/

/* Nunca esquecer de rodar o USE nome_do_banco */
Use exercicio;

CREATE TABLE jogador (
	idJogador INT IDENTITY PRIMARY KEY NOT NULL,
	nome VARCHAR(50) UNIQUE, /*Escifica q o campo deve ser unico*/
	idade INT,
	idEquipe INT FOREIGN KEY REFERENCES equipe(idEquipe) /* o campo idequipe  da tabela jogador faz referencia ao campo idequipe da tabela equipe*/ 
);

CREATE TABLE endereco (
	idEndereco INT IDENTITY PRIMARY KEY NOT NULL,
	rua VARCHAR(100),
	numero INT,
	bairro VARCHAR(100),
	estado VARCHAR(50),
	pais VARCHAR(50),
	cep INT,
	idJogador INT FOREIGN KEY REFERENCES jogador(idJogador)
);



ALTER TABLE endereco DROP COLUMN cep;




/* Inserir dados(valores) dentro da tabela*/

INSERT INTO equipe(nome,especialidade,localizacaoCidade)
VALUES ('Corinthians','Futebol','São Paulo'),
	   ('Palmeiras','Vôlei','Santos'),
	   ('Santos','Futebol','São Paulo'),
       ('Sesi','Futebol','São Paulo');


/* Alterar valor de tabela */

UPDATE equipe
SET nome = 'Palmeiras'
WHERE idEquipe = 3;

UPDATE equipe
SET localizacaoCidade = 'Suzano'
WHERE idEquipe = 3;




SELECT * FROM equipe; /*Selecione tudo da tabela x*/

delete from equipe where idEquipe = 11;

delete from equipe where idEquipe >= 10 and idEquipe <= 14;

SELECT * FROM jogador;

insert into jogador (nome, idade, idEquipe) 
values('Marcelinho Carioca',40,3);

insert into endereco(rua, numero, bairro, estado, pais, idJogador) 
values('Alameda barão de Limeira', 539, 'Campos Eliseos', 'SP', 'Brasil',1);

insert into jogador (nome, idade, idEquipe) values ('Zezinho pé de chinelo',40,4);

/*Chave estrangeira da tabela jogador = Chave primaria idEquipe da tabela equipe*/
select jog.nome, testeEquipe.nome from jogador as jog
inner join /*Fala com qual tabela vou juntar*/
equipe as testeEquipe
on jog.idEquipe = testeEquipe.idEquipe;

TRUNCATE TABLE equipe; /*Limpa a tabela*/

DROP DATABASE exercicio;





