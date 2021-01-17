CREATE PROCEDURE EDITAR_ALUMNO
@ID_ALUMNO INT,
@NOMBRE_ALUM VARCHAR(40),
@APELLIDOS_ALUM VARCHAR(40),
@DNI_ALUM CHAR(8),
@SEMESTRE VARCHAR(15),
@ID_ESPECIALIDAD INT,
@TURNO_ALUM VARCHAR(15)
AS
BEGIN
	UPDATE ALUMNO
	SET NOMBRE_ALUM=@NOMBRE_ALUM,
		APELLIDOS_ALUM=@APELLIDOS_ALUM,
		DNI_ALUM=@DNI_ALUM,
		SEMESTRE=@SEMESTRE,
		ID_ESPECIALIDAD=@ID_ESPECIALIDAD,
		TURNO_ALUM=@TURNO_ALUM
	WHERE ID_ALUMNO=@ID_ALUMNO
END 