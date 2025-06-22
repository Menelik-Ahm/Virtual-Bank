
CREATE DATABASE VirtualBankDB;


CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    FullName VARCHAR(100),
    Balance DECIMAL(18, 2) DEFAULT 0.00
);


CREATE TABLE Transactions (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    Type VARCHAR(20), -- Deposit, Withdraw, Transfer
    Amount DECIMAL(18,2),
    TargetUserID INT NULL, -- For transfers
    Timestamp DATETIME DEFAULT GETDATE()
);

INSERT INTO Users (Username, PasswordHash, FullName, Balance)
VALUES ('admin', 'admin123', 'Admin User', 10000.00);
GO
