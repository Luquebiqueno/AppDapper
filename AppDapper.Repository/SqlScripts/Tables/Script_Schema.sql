Use AppDapper
Go

If Object_Id('Usuario') Is Null 
Begin
	Create Table Usuario 
	(
		 Id		Int Identity(1,1) Constraint PK_Usuario_Id Primary Key
		,Nome	Varchar(100)	Not Null
		,Ativo	Bit				Not Null
	)
End
Go
