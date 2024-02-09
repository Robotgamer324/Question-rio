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
('Voc� j� teve alguma experi�ncia anterior com programa��o ou desenvolvimento de software?', 2),
('Voc� tem interesse em criar e desenvolver sites, aplicativos web e outras solu��es online?', 3),
('Voc� j� teve alguma experi�ncia anterior com HTML, CSS, JavaScript ou outras linguagens de programa��o relacionadas � web?', 3),
--('Quanto mais conectados estamos, mais importante se torna entender como funcionam as redes de computadores, n�o � verdade?', 4),
--('Em um mundo cada vez mais dependente da tecnologia, n�o seria valioso ter habilidades para configurar e manter redes de computadores?', 4)
insert into Perguntas values--('Quanto mais conectados estamos, mais importante se torna entender como funcionam as redes de computadores, n�o � verdade?',5),
--('Em um mundo cada vez mais dependente da tecnologia, n�o seria valioso ter habilidades para configurar e manter redes de computadores?',5),
('Em um mundo onde a eletricidade e a eletr�nica est�o em toda parte, n�o � crucial entender como esses sistemas funcionam?',6),
('Diante da crescente demanda por tecnologias mais eficientes e sustent�veis, n�o � importante ter habilidades em eletroeletr�nica para contribuir com solu��es inovadoras?',6),
('Em um mundo onde a integra��o entre sistemas el�tricos e mec�nicos � essencial, n�o � crucial entender como esses componentes interagem?',7),
('Diante da crescente demanda por tecnologias mais eficientes e automatizadas, n�o � importante ter habilidades em eletromec�nica para projetar e manter esses sistemas?',7),
('Em um mundo onde a efici�ncia na cadeia de suprimentos � crucial para o sucesso de empresas de todos os setores, n�o � essencial entender os princ�pios da log�stica?',8),
('Diante da crescente demanda por m�todos eficazes de gest�o de estoque, transporte e distribui��o, n�o � importante ter habilidades em log�stica para otimizar esses processos?',8),
('voce tem interesse em aprender o basico da computa�ao?',9),
('Voc� j� imaginou como aprofundar seu entendimento sobre computadores poderia facilitar suas intera��es com a tecnologia no dia a dia?',9),
('Voc� j� se perguntou como os computadores funcionam por dentro e como realizar a manuten��o b�sica para mant�-los funcionando corretamente?',10),
('Voc� j� considerou a possibilidade de aprender a diagnosticar e resolver problemas comuns de hardware e software em computadores?',10)


SELECT pergunta, id_categoria FROM Perguntas 

declare @id int
declare @pergunta Varchar(250)
declare @id_categoria INT


UPDATE Perguntas  SET pergunta=('Voc� j� teve alguma experi�ncia anterior com HTML, CSS, JavaScript ou outras linguagens de programa��o relacionadas � web?') WHERE Id = 6