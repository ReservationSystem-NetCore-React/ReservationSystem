CREATE TABLE [dbo].[Reservation]
(
	[Id] INT NOT NULL PRIMARY KEY,
	starting          DATETIME  NOT NULL,
	ending            DATETIME  NOT NULL,
	title          VARCHAR(30),
	--,fieldId        INT  NOT NULL,
	total          NUMERIC(18,2)  NOT NULL,
	primaryColor   VARCHAR(30),
	secondaryColor VARCHAR(30),
  customerId     INT  NOT NULL
     --FOREIGN KEY (customerId) REFERENCES Customer (customerId),

     FOREIGN KEY (customerId) REFERENCES Customer (customerId) ON DELETE CASCADE,
)
