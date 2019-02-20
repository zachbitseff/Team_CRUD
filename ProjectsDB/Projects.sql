CREATE TABLE Projects
(
	ProjectID	int	PRIMARY KEY IDENTITY
	,Name		varchar(50)	NOT NULL
	,Description	varchar(300)	NOT NULL
)
GO

INSERT INTO Projects(Name, Description)
	VALUES('SuperSecret', 'Ultimate secretive project for automated packing')