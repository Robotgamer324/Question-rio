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
('Você já teve alguma experiência anterior com programação ou desenvolvimento de software?', 2),
('Você tem interesse em criar e desenvolver sites, aplicativos web e outras soluções online?', 3),
('Você já teve alguma experiência anterior com HTML, CSS, JavaScript ou outras linguagens de programação relacionadas à web?', 3),
--('Quanto mais conectados estamos, mais importante se torna entender como funcionam as redes de computadores, não é verdade?', 4),
--('Em um mundo cada vez mais dependente da tecnologia, não seria valioso ter habilidades para configurar e manter redes de computadores?', 4)
insert into Perguntas values--('Quanto mais conectados estamos, mais importante se torna entender como funcionam as redes de computadores, não é verdade?',5),
--('Em um mundo cada vez mais dependente da tecnologia, não seria valioso ter habilidades para configurar e manter redes de computadores?',5),
('Em um mundo onde a eletricidade e a eletrônica estão em toda parte, não é crucial entender como esses sistemas funcionam?',6),
('Diante da crescente demanda por tecnologias mais eficientes e sustentáveis, não é importante ter habilidades em eletroeletrônica para contribuir com soluções inovadoras?',6),
('Em um mundo onde a integração entre sistemas elétricos e mecânicos é essencial, não é crucial entender como esses componentes interagem?',7),
('Diante da crescente demanda por tecnologias mais eficientes e automatizadas, não é importante ter habilidades em eletromecânica para projetar e manter esses sistemas?',7),
('Em um mundo onde a eficiência na cadeia de suprimentos é crucial para o sucesso de empresas de todos os setores, não é essencial entender os princípios da logística?',8),
('Diante da crescente demanda por métodos eficazes de gestão de estoque, transporte e distribuição, não é importante ter habilidades em logística para otimizar esses processos?',8),
('voce tem interesse em aprender o basico da computaçao?',9),
('Você já imaginou como aprofundar seu entendimento sobre computadores poderia facilitar suas interações com a tecnologia no dia a dia?',9),
('Você já se perguntou como os computadores funcionam por dentro e como realizar a manutenção básica para mantê-los funcionando corretamente?',10),
('Você já considerou a possibilidade de aprender a diagnosticar e resolver problemas comuns de hardware e software em computadores?',10)


SELECT pergunta, id_categoria FROM Perguntas 

declare @id int
declare @pergunta Varchar(250)
declare @id_categoria INT


UPDATE Perguntas  SET pergunta=('Você já teve alguma experiência anterior com HTML, CSS, JavaScript ou outras linguagens de programação relacionadas à web?') WHERE Id = 6