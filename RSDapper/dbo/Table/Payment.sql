CREATE TABLE [dbo].[Payment]
(
   paymentId   INTEGER  NOT NULL PRIMARY KEY,
   id          INT  NOT NULL,
   totalAmount NUMERIC(8,2) NOT NULL,
  paymentDate DATETIME  NOT NULL
  FOREIGN KEY (id)  REFERENCES Reservation (id)
)
