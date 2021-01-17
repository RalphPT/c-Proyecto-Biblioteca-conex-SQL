CREATE PROCEDURE EDITAR_LIBRO
@ID_LIBRO INT,
@COD_LIBRO CHAR(5),
@TITULO VARCHAR(150),
@AUTOR VARCHAR(40),
@EDITORIAL VARCHAR(50),
@ID_CATEGORIA INT,
@DISPONIBILIDAD VARCHAR(20),
@DESCRIPCION VARCHAR(300)
AS
BEGIN
	UPDATE LIBRO
	SET	COD_LIBRO=@COD_LIBRO,
		TITULO=@TITULO,
		AUTOR=@AUTOR,
		EDITORIAL=@EDITORIAL,
		ID_CATEGORIA=@ID_CATEGORIA,
		DISPONIBILIDAD=@DISPONIBILIDAD,
		DESCRIPCION=@DESCRIPCION
	WHERE	ID_LIBRO=@ID_LIBRO
END