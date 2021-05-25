Use master
Go

If Not Exists (Select * From sys.databases Where Name = 'AppDapper')
Begin
	Create Database AppDapper
End
Go

If Exists (Select * From sys.databases Where Name = 'AppDapper')
Begin
	Use AppDapper
End
Go