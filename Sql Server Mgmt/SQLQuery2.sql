/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ExpenseId]
      ,[AccountType]
      ,[Amount]
      ,[Type_Expense]
      ,[CreatedAt]
      ,[Username]
  FROM [ExpenseManager].[dbo].[Expense]

  DELETE FROM dbo.Expense WHERE Type_Expense LIKE 'd %' AND Amount = 20;