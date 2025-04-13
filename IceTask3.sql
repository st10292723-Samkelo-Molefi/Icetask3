-- DATABASE CREATION SECTION
use master
IF EXISTS (SELECT * FROM sys.databases WHERE NAME= 'Icetask3')
DROP DATABASE Icetask3
CREATE DATABASE Icetask3
use Icetask3

-- TABLE CREATION SECTION
CREATE TABLE Student(
	StudentID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] VARCHAR (20) NOT NULL,
	Surname VARCHAR (MAX) NOT NULL,
	STnumber VARCHAR (150) UNIQUE NOT NULL,
	ProfilePicture VARCHAR (MAX) NOT NULL

);

-- TABLE INSERTION SECTION
INSERT INTO Student ([Name], Surname, STnumber, ProfilePicture)
VALUES ('Samkelo', 'Molefi', 'ST10292723', 'https://thumbs.dreamstime.com/b/generic-person-gray-photo-placeholder-man-silhouette-white-background-144511705.jpg')


-- TABLE MANIPULATION SECTION
SELECT * FROM Student