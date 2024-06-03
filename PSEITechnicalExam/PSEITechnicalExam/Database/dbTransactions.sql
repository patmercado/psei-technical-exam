DROP DATABASE IF EXISTS dbTransactions;

CREATE DATABASE dbTransactions;

USE dbTransactions;

CREATE TABLE Transactions (
    RefNo VARCHAR(20) NOT NULL PRIMARY KEY,
    Quantity BIGINT NOT NULL,
    Amount DECIMAL NOT NULL,
	Name VARCHAR(255) NOT NULL,
	TransactionDate DATETIME NOT NULL,
	Symbol VARCHAR(5) NOT NULL CHECK (len(Symbol) >= 3),
	OrderSide VARCHAR(5) NOT NULL,
	OrderStatus VARCHAR(20) NOT NULL
);