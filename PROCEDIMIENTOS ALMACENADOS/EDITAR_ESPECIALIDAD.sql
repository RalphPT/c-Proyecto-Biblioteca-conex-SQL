CREATE PROCEDURE EDITAR_ESPECIALIDAD
@ID_ESPECIALIDAD INT,
@NOMBRE_ESP VARCHAR(40)
AS
BEGIN
	UPDATE ESPECIALIDAD
	SET NOMBRE_ESP=@NOMBRE_ESP
	WHERE ID_ESPECIALIDAD=@ID_ESPECIALIDAD
END