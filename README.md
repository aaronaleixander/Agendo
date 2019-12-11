# Agendo

This project is currently being built with Visual Studio 2019 using Entity Framework Core.

Agendo is a simple online planner using FullCalanderIO Library/API where Users can create an account and use website
as a personal planner.

Used SQL Server Management Studio to create database script.

Create Database: 

use Agendo
GO
CREATE TABLE Events
(
	[EventID] int NOT NULL PRIMARY KEY Identity,
	[Subject] nvarchar(50) NOT NULL,
	[Description] nvarchar(250) NULL,
	[Start] datetime NULL,
	[End] nvarchar(15) NULL,
	[IsFullDay] bit NOT NULL
)
GO

CREATE TABLE Users
(
	[UserID] int NOT NULL PRIMARY KEY Identity,
	[FirstName] nvarchar(30) NOT NULL,
	[LastName] nvarchar(30) NOT NULL,
	[UserName] nvarchar(30) NOT NULL,
	[EmailAddress] nvarchar(75) NOT NULL,
	[Password] nvarchar(50) NOT NULL,
	[DateOfBirth] datetime NOT NULL
)

Full Calendar implementation under construction...


