CREATE PROCEDURE ELIMINAR_ESPECIALIDAD
@ID_ESPECIALIDAD INT
AS
BEGIN
	DELETE FROM ESPECIALIDAD
	WHERE ID_ESPECIALIDAD=@ID_ESPECIALIDAD
END