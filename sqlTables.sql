CREATE TABLE Notifications (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserId NVARCHAR(100) NOT NULL,
    Message NVARCHAR(MAX) NOT NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    IsRead BIT NOT NULL DEFAULT 0
);
