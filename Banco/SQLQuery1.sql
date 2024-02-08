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

insert into Perguntas values('você aprendeu a dirigir cedo?', 1),
('você tem interesse em manutençao automotiva?', 1),
('Você se sente confortável trabalhando com computadores e tecnologia em geral?', 2),
('Você já teve alguma experiência anterior com programação ou desenvolvimento de software? Se sim, como você se sentiu em relação a essa experiência?', 2),
('Você tem interesse em criar e desenvolver sites, aplicativos web e outras soluções online?', 3),
('Você já teve alguma experiência anterior com HTML, CSS, JavaScript ou outras linguagens de programação relacionadas à web?', 3),
('Quanto mais conectados estamos, mais importante se torna entender como funcionam as redes de computadores, não é verdade?', 4),
('Em um mundo cada vez mais dependente da tecnologia, não seria valioso ter habilidades para configurar e manter redes de computadores?', 4)


SELECT pergunta, id_categoria FROM Perguntas;

declare @id int
declare @pergunta Varchar(250)
declare @id_categoria INT


