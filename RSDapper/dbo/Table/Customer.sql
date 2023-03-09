CREATE TABLE [dbo].[Customer]
(
   customerId   INT  NOT NULL PRIMARY KEY,
   emailAddress VARCHAR(30),
   firstName    VARCHAR(30),
   lastName     VARCHAR(30),
   phoneNo      VARCHAR(30),
   passwordHash VARCHAR(30),
   passwordSalt VARCHAR(30),
)
