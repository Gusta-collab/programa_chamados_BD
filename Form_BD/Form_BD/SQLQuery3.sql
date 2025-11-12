CREATE TABLE chamados (
id INT IDENTITY(1,1) PRIMARY KEY,
colaborador VARCHAR (35),
setor VARCHAR (24),
descricao VARCHAR(2000)
);

CREATE TABLE finalizados (
id INT IDENTITY(1,1) PRIMARY KEY,
colaborador VARCHAR (35),
setor VARCHAR (24),
descricao VARCHAR(2000)
);


SELECT * FROM finalizados;
SELECT * FROM chamados;
SELECT * FROM users;

SELECT * FROM sys.tables;

INSERT INTO chamados (colaborador ,setor , descricao)
VALUES ('alyson','TI','sem tinta na impressora');

INSERT INTO users (logins,passwords)
VALUES ('gustavo','gustavo');

ALTER TABLE finalizados ADD status NVARCHAR(50);

ALTER TABLE finalizados ADD data_abertura DATETIME DEFAULT GETDATE();

UPDATE chamados
SET colaborador = 'lindo',
	setor = 'vendas',
	descricao = 'vendi um vibrodit'
WHERE id = 1;

--mudar nome da coluna
EXEC sp_rename
'chamados.descricao',
'causa',
'COLUMN';

DELETE FROM chamados WHERE id = 6;

SELECT logins, passswords FROM users;