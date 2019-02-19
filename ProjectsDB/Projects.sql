use master

IF DB_ID('ProjectsDB') IS NOT NULL
	DROP DATABASE ProjectsDB
GO

CREATE DATABASE ProjectsDB
GO

USE ProjectsDB
GO

CREATE TABLE Projects
(
	ProjectID	int	PRIMARY KEY IDENTITY
	,Name		varchar(50)	NOT NULL
	,Description	varchar(300)	NOT NULL
)
GO

INSERT INTO Projects(Name, Description)
	VALUES('SuperSecret', 'Ultimate secretive project for automated packing')