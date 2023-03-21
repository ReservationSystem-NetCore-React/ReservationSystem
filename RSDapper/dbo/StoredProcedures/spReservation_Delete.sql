CREATE PROCEDURE [dbo].[spReservation_Delete]
	@Id int
AS
begin
	delete 
	from dbo.[Reservation]
	WHERE Id = @Id
end