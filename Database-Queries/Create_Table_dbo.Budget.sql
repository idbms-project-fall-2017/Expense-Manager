USE ExpenseManager
CREATE TABLE dbo.Budget (
    Amount decimal NOT NULL,
	Check (Amount>0),
	Month int NOT NULL,
	Transactions decimal default 0,
	Username varchar(255) NOT NULL FOREIGN KEY REFERENCES dbo.User_Profile(Username),
	Primary Key(Username, Month)
);

DROP TABLE dbo.Budget