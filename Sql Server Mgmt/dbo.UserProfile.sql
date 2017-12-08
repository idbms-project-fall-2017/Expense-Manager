USE ExpenseManager
CREATE TABLE dbo.User_Profile (
    Username varchar(255) NOT NULL PRIMARY KEY,
    EmailId varchar(255) NOT NULL UNIQUE,
    Password varchar(255) NOT NULL
);