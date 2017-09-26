USE ExpenseManager
CREATE TABLE dbo.User_Profile (
    Username varchar(255) NOT NULL PRIMARY KEY,
    EmailId varchar(255) NOT NULL,
    Password varchar(255) NOT NULL,
    PhoneNo varchar(15),
	Name varchar(255) NOT NULL
);

ALTER TABLE dbo.User_Profile ADD CONSTRAINT c1 UNIQUE(EmailId);
ALTER TABLE dbo.User_Profile ADD CONSTRAINT c2 UNIQUE(PhoneNo);

DROP TABLE dbo.User_Profile