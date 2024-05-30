 --Criar o banco de dados
CREATE DATABASE ListaPresenca
GO 
USE ListaPresenca
GO

--Criar a Tabela de Cursos
CREATE TABLE Cursos(
ID                 int identity(1,1) primary key, 
Nome               nvarchar(70) not null unique, 
Abreviacao         nvarchar(10) not null unique
)
GO

--Inserir o registo de cursos
INSERT INTO Cursos VALUES ('Nenhum','Nenhum'),
('Curso Técnico de Informática','CTI'),
('Gestão Empresarial','GE'),
('Electrónica e Telecomunicação','ET'),
('Ciência Fisica e Biológica','CFB'),
('Ciência Económica e Juridica','CEJ'),
('Curso Tecnico de Eletricidade', 'CTE'),
('Arquitetura e Construnção Civil','ACC'),
('Informática de Gestão', 'IG')
GO
SELECT * FROM Cursos
GO

--Criar a Tabela de Turmas
CREATE TABLE Turmas(
ID	               int identity(1,1) primary key,
IdC                int,
Classe             nvarchar(4) not null,
Turma              nvarchar(2) not null, 
Periodo            nvarchar(10) not null, 
Sala               tinyint, 
FOREIGN KEY(IdC) REFERENCES cursos(ID)
) 
GO

--Inserir registros de turmas
INSERT INTO Turmas VALUES
(2,'10ª','A','Manhã',13),
(6,'10ª','A','Tarde',17),
(4,'10ª','A','Manhã',4),
(5,'10ª','A','Manhã',9),
(2,'10ª','B','Tarde',13),
(6,'11ª','A','Tarde',14),
(2,'11ª','A','Mahã',11),
(2,'10ª','B','Tarde',15),
(7,'10ª','A','Tarde',11),
(7,'11ª','A','Tarde',23),
(8,'10ª','A','Manhã',15)
GO 
SELECT * FROM Turmas
GO

SELECT * FROM Turmas t
JOIN Cursos c ON c.ID = t.IdC
GO

--Criar a Tabela de Alunos
CREATE TABLE Alunos(
ID                 int identity(1,1) primary key,
IdT                int, 
Nome               nvarchar(70) not null, 
Sexo               nvarchar(10) not null,
NumeroBI           nvarchar(20) not null, 
Disposicao		   nvarchar(10) not null,
NumeroTelefone     nvarchar(15), 
Endereco           ntext,
DataNascimento     datetime,
FOREIGN KEY(IdT) REFERENCES turmas(ID)
)
GO

--Inserir registro de alunos
INSERT INTO Alunos VALUES
(2,'Mimosa Vakanda','Femenino','3557','activo','5733','Mabor','12-05-2006'),
(3,'Marleni David','Femenino','4564','activo','65564','Mabor','06-09-2007'),
(7,'Joaquim','Masculino','4564','activo','654','Mabor','08-02-2005'),
(4,'Kiasunda','Masculino','543','activo','725','Malueca','03-06-2001'),
(6,'Malanda José','Masculino','4363','activo','53','Mabor','11-12-2006'),
(1,'Afonsina','Femenino','76353','activo','75373753','Palanca','04-11-2004'),
(2,'Isabel Teka','Femenino','626','activo','3455','Sapú','08-08-2002'),
(5,'Moises Victor','Masculino','4564','activo','654','Mabor','03-01-2001'),
(8,'João Tomas Kinavuidi','Masculino','431261','activo','8563','Samba','07-12-2006'),
(7,'Monteiro Garcia Augusto','Masculino','734373','activo','624654','Camama','03-04-2008'),
(3,'Helena Kimbemba Maria','Femenino','724573','activo','4357','Hoja-ya-henda','08-06-2009'),
(8,'Fábiu Manuel David','Masculino','75342','activo','7537','Tala-Hadi','09-11-2003')
GO
SELECT * FROM Alunos
GO

SELECT  * FROM Alunos a
JOIN Turmas t ON IdT = t.ID
JOIN cursos c ON IdC = c.ID
GO

--Criar tabela de Dias
CREATE TABLE Dias(
ID					int identity(1,1) primary key,
Data				date not null,
Descricao			nvarchar(30) default('Dia Normal'),
Stado				nvarchar(15) default('Habilitado')
)
GO

--Inserir registro dos Dias
INSERT INTO Dias VALUES 
('2024-03-01','Dia Normal' ,'Habilitado'),
('2024/03/02',default ,default),
('2024/03/03',default ,default),
('2024/03/04',default ,default),
('2024/03/05',default ,default)
GO
SELECT * FROM Dias
GO

--Criar tabela de Presenças
CREATE TABLE Presencas(
ID						 int identity(1,1) primary key,
IdA						 int not null,
Referenca				 int not null,
Presenca				 nvarchar(10),
FOREIGN KEY (IdA)		 REFERENCES Alunos(ID),
FOREIGN KEY (Referenca)	 REFERENCES Dias(ID)
)
GO

--Iserir registros de Presença
INSERT INTO Presencas VALUES
(5,1, 'Presente'),	
(1,1,'Presente'),
(4,1,'Ausente'),
(7,1,'Presente'),
(8,1,'Presente'),
(11,1,'Ausente'),
(2,1,'Presente'),
(3,1,'Presente'),
(6,1,'Ausente'),
(9,1,'Presente'),
(10,1,'Ausente'),
(12,1,'Ausente'), -----
(5,2, 'Ausente'),
(1,2,'Presente'),
(4,2,'Presente'),
(7,2,'Presente'),
(8,2,'Ausente'),
(11,2,'Presente'),
(2,2,'Presente'),
(3,2,'Ausente'),
(6,2,'Presente'),
(9,2,'Presente'),
(10,2,'Ausente'),
(12,2,'Presente')
GO
SELECT * FROM Presencas
GO

SELECT * FROM Alunos a
JOIN Presencas p ON a.ID = p.IdA
JOIN Dias d ON p.Referenca = d.ID
GO


SELECT ID FROM Turmas WHERE IdC = 6 AND Classe = '10ª' AND Turma = 'A'
GO


