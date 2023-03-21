CREATE PROCEDURE [dbo].[spReservation_Update]
	@Id				INT,
	@starting		DATETIME,
	@ending			DATETIME,
	@title          VARCHAR(30),
	@total          NUMERIC(18,2),
	@primaryColor   VARCHAR(30),
	@secondaryColor VARCHAR(30),
	@customerId     INT
AS
begin
	update dbo.[Reservation]
	set Id = @Id, 
	starting = @starting, 
	ending = @ending, 
	title = @title,
	total = @total, 
	primaryColor = @primaryColor, 
	secondaryColor = @secondaryColor,
	customerId = @customerId
	WHERE Id = @Id;
end