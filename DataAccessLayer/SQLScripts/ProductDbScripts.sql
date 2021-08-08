CREATE DATABASE ProductDb

GO

USE ProductDb

GO

CREATE TABLE Product(
    Id INT PRIMARY KEY IDENTITY(1,1),
    ImageUrl NVARCHAR(255),
    Title NVARCHAR(50),
    Price FLOAT
)

GO

CREATE LOGIN ProductDbUser WITH PASSWORD = 'Product.pswd1';

GO

CREATE USER ProductDbUser FOR LOGIN ProductDbUser;

GO

EXEC sp_addrolemember N'db_owner', N'ProductDbUser'
