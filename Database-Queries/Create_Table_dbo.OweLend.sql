USE ExpenseManager
CREATE TABLE dbo.OweLend (
	OweLendId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Amount decimal NOT NULL,
	Check (Amount>0),
	OweLend varchar(50) NOT NULL,
	Check (OweLend IN ('Owe','Lend')),
	Status varchar(50) NOT NULL,
	Check (Status IN ('Complete','Incomplete')),
	SenderAccountType varchar(255),
	ReceiverAccountType varchar(255),
	CreatedAt date NOT NULL DEFAULT GETDATE(),
	UpdatedAt date,
	Username varchar(255) NOT NULL FOREIGN KEY REFERENCES dbo.User_Profile(Username),
	FriendUsername varchar(255) NOT NULL FOREIGN KEY REFERENCES dbo.User_Profile(Username),
	Check (FriendUsername <> Username)
);

DROP TABLE dbo.OweLend