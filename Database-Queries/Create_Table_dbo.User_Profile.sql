USE ExpenseManager
CREATE TABLE dbo.User_Profile (
    Username varchar(255) NOT NULL PRIMARY KEY UNIQUE,
    EmailId varchar(255) NOT NULL UNIQUE,
    Password varchar(255) NOT NULL,
    PhoneNo varchar(15),
	Name varchar(255) NOT NULL
);

DROP TABLE dbo.User_Profile