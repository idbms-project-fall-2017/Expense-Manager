CREATE TRIGGER trgAfterInsertonExpense ON [ExpenseManager].[dbo].[Expense] 
FOR INSERT
AS
	declare @username varchar(255);
	declare @accounttype varchar(50);
	declare @amount decimal;
	declare @createdat date;
	
	select @username=i.Username from inserted i;	
	select @accounttype=i.AccountType from inserted i;	
	select @amount=i.Amount from inserted i;	
	select @createdat=i.CreatedAt from inserted i;

	Update [ExpenseManager].[dbo].[Account] Set Balance = Balance-@amount 
	where AccountType = @accounttype and Username = @username;
	
	Update [ExpenseManager].[dbo].[Budget] Set Transactions = Transactions-@amount 
	where Month = MONTH(@createdat) and Username = @username;

GO