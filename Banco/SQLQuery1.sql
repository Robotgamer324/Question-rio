-- Criar o banco de dados
drop database Questionario
CREATE DATABASE Questionario;
USE Questionario;

-- Tabela para armazenar as perguntas
CREATE TABLE Perguntas (
    id INT PRIMARY KEY IDENTITY(1,1),
    pergunta TEXT NOT NULL
);

-- Tabela para armazenar as respostas
CREATE TABLE Respostas (
    id INT PRIMARY KEY IDENTITY(1,1),
    pergunta_id INT,
    correta BIT,
    resposta TEXT NOT NULL,
    FOREIGN KEY (pergunta_id) REFERENCES Perguntas(id)
);

-- Inserir perguntas
INSERT INTO Perguntas (pergunta) VALUES
('Qual é a capital do Brasil?'),
('Quem é o presidente atual dos Estados Unidos?');

-- Inserir respostas
INSERT INTO Respostas (pergunta_id, resposta, correta) VALUES
(1, 'Brasília', 1),
(1, 'Rio de Janeiro', 0),
(1, 'São Paulo', 0),
(2, 'Joe Biden', 1),
(2, 'Donald Trump', 0),
(2, 'Barack Obama', 0);

-- Selecionar todas as respostas
SELECT id, pergunta FROM Perguntas;
