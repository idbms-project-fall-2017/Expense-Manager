SELECT ExpenseId, Account.AccountType, Balance, Account.Username, Amount, Type_Expense, CreatedAt AS DATE FROM Expense JOIN Account ON Expense.AccountType = Account.AccountType AND Expense.Username = Account.Username;

SELECT * FROM Expense;

USE ExpenseManager;

INSERT INTO dbo.OweLend (Amount, OweLend, Status, SenderAccountType, ReceiverAccountType, Username, FriendUsername) VALUES(10, 'Owe', 'Personal', 'Pending', 'Personal Cash', 'Balaji', 'Abc');

update dbo.Account set AccountType='Personal Cash', Balance=65 WHERE Username='Abc' AND AccountType = 'Persona Cash';

UPDATE dbo.Account SET Balance = 65 WHERE Username = 'Abc' AND AccountType='Persona Cash';

select * from dbo.Income;

DECLARE @row_num INT;
set @row_num = 0; 
SELECT Password,Username,EmailId, @row_num = @row_num + 1 FROM dbo.User_Profile;

SELECT ACC.AccountType, (Balance + EXPENDITURE_AMT) AS CURRENT_BALANCE FROM (SELECT AccountType, Balance FROM dbo.Account WHERE Username = 'Abc') AS ACC JOIN
(SELECT EXPENSE.AccountType, (INCOME_AMOUNT - EXPENSE_AMOUNT) AS EXPENDITURE_AMT FROM (
SELECT tmp.EXPENSE_AMOUNT, tmp.AccountType FROM (select SUM(Amount) AS EXPENSE_AMOUNT, AccountType, Username from dbo.Expense GROUP BY AccountType, Username) AS tmp WHERE tmp.Username = 'Abc') AS EXPENSE JOIN
(SELECT tmp.INCOME_AMOUNT, tmp.AccountType FROM (select SUM(Amount) AS INCOME_AMOUNT, AccountType, Username from dbo.Income GROUP BY AccountType, Username) AS tmp WHERE tmp.Username = 'Abc') AS INCOME ON EXPENSE.AccountType = INCOME.AccountType) AS EXPEND
ON EXPEND.AccountType = ACC.AccountType;

select dbo.Expense.AccountType, dbo.Account.Username, Balance - (select SUM(Amount) from dbo.Expense)  from dbo.account JOIN dbo.Expense ON dbo.account.Username = dbo.Expense.Username;

select SUM(Amount), USERNAME from dbo.Expense GROUP BY Username ;

select SUM(Amount), USERNAME from dbo.Income GROUP BY Username ;


SELECT ACCOUNT_P.AccountType, Balance AS Account_Balance, CURRENT_BALANCE, Username FROM (select * from dbo.Account WHERE Username = 'Abc') AS ACCOUNT_P JOIN (SELECT ACC.AccountType, (Balance + EXPENDITURE_AMT) AS CURRENT_BALANCE FROM (SELECT AccountType, Balance FROM dbo.Account WHERE Username = 'Abc') AS ACC JOIN (SELECT EXPENSE.AccountType, (INCOME_AMOUNT - EXPENSE_AMOUNT) AS EXPENDITURE_AMT FROM( SELECT tmp.EXPENSE_AMOUNT, tmp.AccountType FROM(select SUM(Amount) AS EXPENSE_AMOUNT, AccountType, Username from dbo.Expense GROUP BY AccountType, Username) AS tmp WHERE tmp.Username = 'Abc') AS EXPENSE JOIN (SELECT tmp.INCOME_AMOUNT, tmp.AccountType FROM(select SUM(Amount) AS INCOME_AMOUNT, AccountType, Username from dbo.Income GROUP BY AccountType, Username) AS tmp WHERE tmp.Username = 'Abc') AS INCOME ON EXPENSE.AccountType = INCOME.AccountType) AS EXPEND ON EXPEND.AccountType = ACC.AccountType) AS NEW_Q ON ACCOUNT_P.AccountType = NEW_Q.AccountType;



INSERT INTO dbo.OweLend (Amount, OweLend, Description, Status, SenderAccountType, ReceiverAccountType, Username, FriendUsername) VALUES(10, 'Owe', 'Taxi', 'Complete','Persona Cash', 'Personal', 'Abc', 'Balaji');

INSERT INTO dbo.OweLend (Amount, OweLend, Description, Status, SenderAccountType, ReceiverAccountType, Username, FriendUsername) VALUES(10, 'Lend', 'Taxi', 'Complete','Persona Cash', 'Personal', 'Abc', 'Balaji');

select * from dbo.OweLend;

DELETE FROM dbo.OweLend;

SELECT * FROM dbo.Income;

SELECT * FROM dbo.Expense;

SELECT * FROM dbo.Account;

INSERT INTO dbo.Expense (AccountType, Amount, Type_Expense, CreatedAt, Username) VALUES ('US BANK', 30, 'FINE', '2017-11-30', 'Abc');

DROP TRIGGER trgAfterUpdateonOweLend

INSERT INTO dbo.OweLend (Amount, OweLend, Description, Status, SenderAccountType, ReceiverAccountType, Username, FriendUsername) VALUES(10, 'Lend', 'test2', 'Complete', 'Persona cash', 'Personal', 'Abc', 'Balaji');