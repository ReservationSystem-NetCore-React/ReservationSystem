CREATE PROCEDURE [dbo].[spReservation_GetAll]
AS
begin
	SELECT Id, starting, ending, title,total, primaryColor, secondaryColor,customerId
	FROM dbo.[Reservation]
end