CREATE PROCEDURE [dbo].[MOSTRAR_ESPECIALIDAD]
AS
BEGIN
	SELECT ID_ESPECIALIDAD AS ID, NOMBRE_ESP AS NOMBRE FROM ESPECIALIDAD
END