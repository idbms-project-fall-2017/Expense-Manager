/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [OweLendId]
      ,[Amount]
      ,[OweLend]
      ,[Description]
      ,[Status]
      ,[SenderAccountType]
      ,[ReceiverAccountType]
      ,[Username]
      ,[FriendUsername]
  FROM [ExpenseManager].[dbo].[OweLend]

  DELETE FROM dbo.OweLend WHERE Amount = 20 AND Description = 'd' AND STATUS = 'Complete';