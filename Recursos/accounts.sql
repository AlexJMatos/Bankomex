DROP TABLE IF EXISTS accounts;
CREATE TABLE accounts
(
    Id          INTEGER PRIMARY KEY AUTOINCREMENT ,
    ClientId    INTEGER NOT NULL,
    AccountType INTEGER NOT NULL,
    Balance     REAL NOT NULL,
    FOREIGN KEY (ClientId) REFERENCES clients (Id),
    FOREIGN KEY (AccountType) REFERENCES account_types (Id)
);

INSERT INTO accounts (Id, ClientId, AccountType, Balance)
VALUES (367450, 0, 0, 20175);
INSERT INTO accounts (ClientId, AccountType, Balance)
VALUES (5, 2, 3500);
INSERT INTO accounts (ClientId, AccountType, Balance)
VALUES (1, 2, 12500);
INSERT INTO accounts (ClientId, AccountType, Balance)
VALUES (3, 2, 5750);
INSERT INTO accounts (ClientId, AccountType, Balance)
VALUES (2, 0, 7675);
INSERT INTO accounts (ClientId, AccountType, Balance)
VALUES (5, 4, 2500);
INSERT INTO accounts (ClientId, AccountType, Balance)
VALUES (5, 3, 5750);
INSERT INTO accounts (ClientId, AccountType, Balance)
VALUES (4, 1, 1250);
INSERT INTO accounts (ClientId, AccountType, Balance)
VALUES (5, 0, 35175);
INSERT INTO accounts (ClientId, AccountType, Balance)
VALUES (3, 4, 35000);
INSERT INTO accounts (ClientId, AccountType, Balance)
VALUES (1, 3, 5000);
INSERT INTO accounts (ClientId, AccountType, Balance)
VALUES (2, 3, 22000);
INSERT INTO accounts (ClientId, AccountType, Balance)
VALUES (0, 1, 5000);