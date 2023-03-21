CREATE PROCEDURE [dbo].[spReservation_Get]
	@Id int
AS
begin
	SELECT Id, starting, ending, title,total, primaryColor, secondaryColor,customerId
	FROM dbo.[Reservation]
	WHERE Id = @Id
end