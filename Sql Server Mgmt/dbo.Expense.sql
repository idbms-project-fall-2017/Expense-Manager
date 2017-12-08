USE ExpenseManager
CREATE TABLE dbo.Expense (
	ExpenseId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    AccountType varchar(255) NOT NULL,
    Amount float NOT NULL,
	Check (Amount>0),
	Type_Expense varchar(50) NOT NULL,
	CreatedAt date NOT NULL DEFAULT GETDATE(),
	Username varchar(255) NOT NULL,
	FOREIGN KEY (Username,AccountType) REFERENCES dbo.Account(Username,AccountType)
);