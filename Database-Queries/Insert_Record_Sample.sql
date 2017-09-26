Insert INTO [ExpenseManager].[dbo].[User_Profile] (Username,EmailId,Password,PhoneNo,Name) 
values ('sibi','abc@gmail.com','sample123','1234567890','Sibi Ramesh')

Insert INTO [ExpenseManager].[dbo].[Account] (AccountType,Balance,Username) 
values ('Bank',10000,'bharathkumarna');

Insert INTO [ExpenseManager].[dbo].[Income] (AccountType,Amount,Type_Income,Username) 
values ('Bank',2500,'Friends','bharathkumarna');

Insert INTO [ExpenseManager].[dbo].[Expense] (AccountType,Amount,Type_Expense,Username) 
values ('Cash',500,'Fees','bharathkumarna');

Insert INTO [ExpenseManager].[dbo].[OweLend] (Amount,OweLend,Status,SenderAccountType,ReceiverAccountType,Username,FriendUsername) 
values (500,'Owe','Incomplete',NULL,NULL,'bharathkumarna','sibic');

Update [ExpenseManager].[dbo].[OweLend] set Status='Complete',SenderAccountType='Cash',ReceiverAccountType='Cash' where OweLendId=1

Insert INTO [ExpenseManager].[dbo].[Budget] (Amount,Month,Username) 
values (5000,9,'bharathkumarna');

