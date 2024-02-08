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

insert into Perguntas values('voc� aprendeu a dirigir cedo?', 1),
('voc� tem interesse em manuten�ao automotiva?', 1),
('Voc� se sente confort�vel trabalhando com computadores e tecnologia em geral?', 2),
('Voc� j� teve alguma experi�ncia anterior com programa��o ou desenvolvimento de software? Se sim, como voc� se sentiu em rela��o a essa experi�ncia?', 2),
('Voc� tem interesse em criar e desenvolver sites, aplicativos web e outras solu��es online?', 3),
('Voc� j� teve alguma experi�ncia anterior com HTML, CSS, JavaScript ou outras linguagens de programa��o relacionadas � web?', 3),
('Quanto mais conectados estamos, mais importante se torna entender como funcionam as redes de computadores, n�o � verdade?', 4),
('Em um mundo cada vez mais dependente da tecnologia, n�o seria valioso ter habilidades para configurar e manter redes de computadores?', 4)


SELECT pergunta, id_categoria FROM Perguntas;

declare @id int
declare @pergunta Varchar(250)
declare @id_categoria INT


