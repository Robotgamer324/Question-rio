declare @senha varchar (6)
declare @usuario varchar (250)
set @senha = '123ABC'
set @usuario = 'ADIMI'
SELECT id, usuario, senha
FROM usuario
WHERE senha = @senha
AND usuario = @usuario

ALTER TABLE USUARIO DROP COLUMN ADMINISTRADOR;
