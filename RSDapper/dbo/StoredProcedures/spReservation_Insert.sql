CREATE PROCEDURE [dbo].[spReservation_Insert]

	@Id	INT,
	@starting DATETIME,
	@ending	DATETIME,
	@title VARCHAR(30),
	@total NUMERIC(18,2),
	@primaryColor VARCHAR(30),
	@secondaryColor VARCHAR(30),
	@customerId INT
AS
begin
	insert into dbo.[Reservation] (Id, starting, ending, title, total, primaryColor,secondaryColor,customerId)
	values (@Id, @starting, @ending, @title, @total, @primaryColor, @secondaryColor, @customerId);
end