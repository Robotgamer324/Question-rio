-- Criar o banco de dados
drop database Questionario
CREATE DATABASE Questionario;
USE Questionario;

-- Tabela para armazenar as perguntas
CREATE TABLE Perguntas (
    id INT PRIMARY KEY IDENTITY(1,1),
    pergunta varchar(250),
	Id_categoria int

);

INSERT INTO Perguntas (pergunta, Id_categoria) VALUES ('Tem facilidade em aprender novas tecnologias?', 1);
INSERT INTO Perguntas (pergunta, Id_categoria) VALUES ('Você se considera paciente e detalhista?', 1);
INSERT INTO Perguntas (pergunta, Id_categoria) VALUES ('Você se considera proativo e capaz de resolver problemas de forma independente?', 1);

INSERT INTO Perguntas (pergunta, Id_categoria) VALUES ('Você tem familiaridade com ferramentas manuais básicas (chaves, alicates, etc.)?', 2);
INSERT INTO Perguntas (pergunta, Id_categoria) VALUES ('Você já operou máquinas-ferramentas como tornos ou fresadoras?', 2);
INSERT INTO Perguntas (pergunta, Id_categoria) VALUES ('Você se sente seguro em trabalhar com ferramentas e equipamentos potencialmente perigosos?', 2);

INSERT INTO Perguntas (pergunta, Id_categoria) VALUES ('Você gosta de ler e se aprofundar em diferentes temas?', 3);
INSERT INTO Perguntas (pergunta, Id_categoria) VALUES ('Você se considera uma pessoa comunicativa e empática?', 3);
INSERT INTO Perguntas (pergunta, Id_categoria) VALUES ('Você tem facilidade para analisar textos e interpretar dados?', 3);

INSERT INTO Perguntas (pergunta, Id_categoria) VALUES ('Você se fascina com o mundo natural e seus mistérios?', 4);
INSERT INTO Perguntas (pergunta, Id_categoria) VALUES ('Você tem boa capacidade de argumentação e debate?', 4);
INSERT INTO Perguntas (pergunta, Id_categoria) VALUES ('Você se considera uma pessoa organizada e metódica em seu trabalho?', 4);

update Perguntas set pergunta =('Você tem curiosidade de saber como o mundo funciona?') where id=10

insert into Categoria values ('Mecanica'),('Humanas'),('Ciencias Natureza')

select *from Perguntas
select * from Categoria

update Categoria set categoria =('TI') where id=1

SELECT pergunta, id_categoria FROM Perguntas 

declare @id int 
declare @pergunta Varchar(250)
declare @id_categoria INT


UPDATE Perguntas  SET id=(1)WHERE Id = 2

CREATE TABLE Categoria (
    id INT PRIMARY KEY IDENTITY(1,1),
    Categoria varchar(250)
);

ALTER TABLE Perguntas
ADD CONSTRAINT fk_pergunta_categoria
FOREIGN KEY (Id_categoria)
REFERENCES Categoria (id);

drop table Perguntas

create table Usuario(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Usuario varchar(250),
	Senha varchar (6),
	Administrador bit
);

select id, Categoria from Categoria where id =