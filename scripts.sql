CREATE DATABASE ExchangeItem
GO

USE ExchangeItem
GO

CREATE TABLE tblAccount (
	user_id INT IDENTITY (1,1) PRIMARY KEY,
	avatar Image,
	full_name NVARCHAR(50),
	address NVARCHAR(50),
	phone_number CHAR(10),
	gender BIT,
	email NVARCHAR(50),
	username NVARCHAR(20),
	password NVARCHAR(20),
	is_active BIT,
	role_id NVARCHAR(10)
)

CREATE TABLE tblRole (
	role_id NVARCHAR(10) PRIMARY KEY,
	role_name NVARCHAR(10)
)

