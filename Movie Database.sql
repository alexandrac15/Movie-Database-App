CREATE DATABASE MDB
GO
USE MDB
GO

--CREATE TABLE Genres (GID INT PRIMARY KEY IDENTITY,Genre VARCHAR(50))
--CREATE TABLE Directors (DID INT PRIMARY KEY IDENTITY ,DName VARCHAR(50))
--CREATE TABLE Companies (CID INT PRIMARY KEY IDENTITY , CName VARCHAR(50) )
--CREATE TABLE Movies (MID INT PRIMARY KEY IDENTITY,Title VARCHAR(50),Rating FLOAT ,Year INT , DID INT FOREIGN KEY REFERENCES Directors(DID))
--CREATE TABLE Talent_Agencies (TID INT PRIMARY KEY IDENTITY , AName VARCHAR(50))
--CREATE TABLE Actors (AID INT PRIMARY KEY IDENTITY, Name VARCHAR(50), Age DATE ,Gender Varchar (2), TID INT FOREIGN KEY REFERENCES Talent_Agencies(TID))
--CREATE TABLE AM (AID INT FOREIGN KEY REFERENCES Actors(AID),MID INT FOREIGN KEY REFERENCES Movies(MID))
--CREATE TABLE MG (MID INT FOREIGN KEY REFERENCES Movies(MID), GID INT FOREIGN KEY REFERENCES Genres(GID))
--CREATE TABLE MC (MID INT FOREIGN KEY REFERENCES Movies(MID), CID INT FOREIGN KEY REFERENCES Companies(CID))


-------inserts
insert into Directors
VALUES  ('Quentin Tarantino')
insert into Directors
VALUES  ('Martin Scorsese')
insert into Directors
VALUES  ('Christopher Nolan')

SELECT * From Directors
-------
insert into Director
VALUES  (4,'Francis Ford Coppola')
insert into Director
VALUES  (6,'David Fincher')
insert into Director
VALUES  (7,'Robert Zemeckis')




---Movies insert
insert into Movies
VALUES ('Pulp Fiction',8.9,1994,1)
insert into Movies
VALUES ('Taxi Driver',8.3,1976,2)
insert into Movies
VALUES ('The Dark Night',9.0,2008,3)

SELECT * From Movies

