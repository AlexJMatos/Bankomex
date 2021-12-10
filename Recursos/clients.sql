DROP TABLE IF EXISTS clients;
CREATE TABLE clients
(
    Id        INTEGER PRIMARY KEY AUTOINCREMENT,
    UserName  TEXT    NOT NULL,
    PIN       TEXT NOT NULL,
    FirstName TEXT    NOT NULL,
    LastName  TEXT    NOT NULL
);

INSERT INTO clients (Id, UserName, PIN, FirstName, LastName)
VALUES (0, 'jgomez', '4856', 'Juan', 'Gomez');
INSERT INTO clients (UserName, PIN, FirstName, LastName)
VALUES ('pperez', '2957', 'Pedro', 'Perez');
INSERT INTO clients (UserName, PIN, FirstName, LastName)
VALUES ('srodriguez', '8602', 'Silverio', 'Rodriguez');
INSERT INTO clients (UserName, PIN, FirstName, LastName)
VALUES ('elopez', '3484', 'Erika', 'Lopez');
INSERT INTO clients (UserName, PIN, FirstName, LastName)
VALUES ('mvargas', '6023', 'Miguel', 'Vargas');
INSERT INTO clients (UserName, PIN, FirstName, LastName)
VALUES ('lsoberanis', '3962', 'Lorena', 'Soberanis');