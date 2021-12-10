DROP TABLE IF EXISTS account_types;
CREATE TABLE account_types
(
    Id           INTEGER PRIMARY KEY,
    Name         TEXT    NOT NULL,
    MonthlyFee   REAL NOT NULL,
    AnnualFee    REAL NOT NULL,
    Credit       TEXT    NOT NULL,
    Limited      TEXT    NOT NULL,
    OverDraftFee REAL    NOT NULL,
    MaxCredit    REAL    NOT NULL,
    InteresPct   REAL    NOT NULL
);

INSERT INTO account_types (Id, Name, MonthlyFee, AnnualFee, Credit, Limited, OverDraftFee, MaxCredit, InteresPct)
VALUES (0, 'Ahorro', 75, 0, 'false', '-', '-', '-', '-');
INSERT INTO account_types (Id, Name, MonthlyFee, AnnualFee, Credit, Limited, OverDraftFee, MaxCredit, InteresPct)
VALUES (1, 'Básica', 0, 500, 'true', 'true', 150, 10000, 5);
INSERT INTO account_types (Id, Name, MonthlyFee, AnnualFee, Credit, Limited, OverDraftFee, MaxCredit, InteresPct)
VALUES (2, 'Clásica', 0, 800, 'true', 'true', 150, 18000, 7);
INSERT INTO account_types (Id, Name, MonthlyFee, AnnualFee, Credit, Limited, OverDraftFee, MaxCredit, InteresPct)
VALUES (3, 'Ejecutiva', 0, 1200, 'true', 'false', 350, 30000, 10);
INSERT INTO account_types (Id, Name, MonthlyFee, AnnualFee, Credit, Limited, OverDraftFee, MaxCredit, InteresPct)
VALUES (4, 'Platino', 0, 2000, 'true', 'false', 350, 50000, 7);