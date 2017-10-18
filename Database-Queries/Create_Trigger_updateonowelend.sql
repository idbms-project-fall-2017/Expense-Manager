CREATE TRIGGER trgAfterUpdateonOweLend ON [ExpenseManager].[dbo].[OweLend] 
FOR INSERT
AS
	declare @status varchar(50);
	declare @flag varchar(50) set @flag='Complete';
	declare @updatedat date set @updatedat = GETDATE();
	declare @senderaccounttype varchar(255);
	declare @username varchar(255);
	declare @receiveraccountype varchar(255);
	declare @owelend varchar(50);
	declare @friendusername varchar(255);
	declare @amount decimal;

	select @status=i.Status from inserted i;	
	select @senderaccounttype=i.SenderAccountType from inserted i;
	select @username=i.Username from inserted i;
	select @receiveraccountype=i.ReceiverAccountType from inserted i;
	select @owelend=i.OweLend from inserted i;
	select @friendusername=i.FriendUsername from inserted i;
	select @amount=i.Amount from inserted i;

	if update(Status) AND update(SenderAccountType) AND update(ReceiverAccountType)
	begin
	if(@status = @flag)
		begin
			if(@owelend = 'Owe')
			begin
				Update [ExpenseManager].[dbo].[Account] Set Balance = Balance-@amount 
				where AccountType = @senderaccounttype and Username = @username;
				Update [ExpenseManager].[dbo].[Account] Set Balance = Balance+@amount 
				where AccountType = @receiveraccountype and Username = @friendusername;
				Update [ExpenseManager].[dbo].[OweLend] Set UpdatedAt = @updatedat;
				Update [ExpenseManager].[dbo].[Budget] Set Transactions = Transactions-@amount 
				where Month = MONTH(@updatedat) and Username = @username;
				Update [ExpenseManager].[dbo].[Budget] Set Transactions = Transactions+@amount 
				where Month = MONTH(@updatedat) and Username = @friendusername;
			end
			if(@owelend = 'Lend')
			begin
				Update [ExpenseManager].[dbo].[Account] Set Balance = Balance+@amount 
				where AccountType = @senderaccounttype and Username = @username;
				Update [ExpenseManager].[dbo].[Account] Set Balance = Balance-@amount 
				where AccountType = @receiveraccountype and Username = @friendusername;
				Update [ExpenseManager].[dbo].[OweLend] Set UpdatedAt = @updatedat;
				Update [ExpenseManager].[dbo].[Budget] Set Transactions = Transactions+@amount 
				where Month = MONTH(@updatedat) and Username = @username;
				Update [ExpenseManager].[dbo].[Budget] Set Transactions = Transactions-@amount 
				where Month = MONTH(@updatedat) and Username = @friendusername;
			end
		end
	end
