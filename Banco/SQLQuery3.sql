declare @senha varchar (6)
declare @usuario varchar (250)
set @senha = '123ABC'
set @usuario = 'ADIMI'
SELECT id, usuario, senha
FROM usuario
WHERE senha = @senha
AND usuario = @usuario

ALTER TABLE USUARIO DROP COLUMN ADMINISTRADOR;

declare @id int 
declare @pergunta Varchar(250)
declare @id_categoria INT
set @id = 1
set @pergunta = 'Tem facilidade em aprender novas tecnologias?'
set @id_categoria=1

update Perguntas set pergunta = @pergunta, id_categoria = @id_categoria where id=@id
select * from Perguntas