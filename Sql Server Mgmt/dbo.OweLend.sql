USE ExpenseManager
CREATE TABLE dbo.OweLend (
	OweLendId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Amount float NOT NULL,
	Check (Amount>0),
	OweLend varchar(50) NOT NULL,
	Description varchar(255),
	Check (OweLend IN ('Owe','Lend')),
	Status varchar(50) NOT NULL,
	Check (Status IN ('Complete','Incomplete')),
	SenderAccountType varchar(255),
	ReceiverAccountType varchar(255),
	Username varchar(255) NOT NULL,
	FOREIGN KEY (Username,SenderAccountType) REFERENCES dbo.Account(Username,AccountType),
	FriendUsername varchar(255) NOT NULL,
	FOREIGN KEY (FriendUsername,ReceiverAccountType) REFERENCES dbo.Account(Username,AccountType),
	Check (FriendUsername <> Username)
);