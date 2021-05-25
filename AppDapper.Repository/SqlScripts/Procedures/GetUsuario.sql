Use AppDapper
Go

If Object_Id('GetUsuario') Is Not Null
Begin
	Drop Procedure GetUsuario
End
Go

SET ANSI_NULLS ON
Go

SET QUOTED_IDENTIFIER ON
Go

Create Procedure GetUsuario
As
Begin
	Select
		 Id
		,Nome
		,Ativo
	From Usuario (Nolock)
	Where Ativo = 1
End
