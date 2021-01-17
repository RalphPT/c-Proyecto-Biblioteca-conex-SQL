CREATE PROCEDURE [dbo].[BUSCAR_DNI]
@DNI_ALUM CHAR(8)
AS
BEGIN	
	SELECT * FROM ALUMNO WHERE DNI_ALUM = @DNI_ALUM
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[EDITAR_ALUMNO]
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
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[EDITAR_BIBLIOTECARIO]
@ID INT,
@DNI CHAR(8),
@CONTRASEÑA VARCHAR(40),
@NOMBRES VARCHAR(40),
@APELLIDOS VARCHAR(40),
@TURNO VARCHAR(10)
AS
BEGIN
	UPDATE BIBLIOTECARIO
	SET DNI = @DNI,
		CONTRASEÑA = @CONTRASEÑA,
		NOMBRES = @NOMBRES,
		APELLIDOS = @APELLIDOS,
		TURNO = @TURNO
	WHERE ID = @ID
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[EDITAR_CATEGORIA]
@ID_CATEGORIA INT,
@NOMBRE_CAT VARCHAR(50)
AS
BEGIN
	UPDATE CATEGORIA
	SET NOMBRE_CAT = @NOMBRE_CAT	
	WHERE ID_CATEGORIA = @ID_CATEGORIA
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[EDITAR_COMPUTADORA]
@ID_COMP int,
@NUMERO int,
@ESTADO VARCHAR(20)
AS
BEGIN
	UPDATE COMPUTADORA
	SET	NUMERO=@NUMERO,
		ESTADO=@ESTADO
	WHERE ID_COMP=@ID_COMP
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[EDITAR_ESPECIALIDAD]
@ID_ESPECIALIDAD INT,
@NOMBRE_ESP VARCHAR(40)
AS
BEGIN
	UPDATE ESPECIALIDAD
	SET NOMBRE_ESP=@NOMBRE_ESP
	WHERE ID_ESPECIALIDAD=@ID_ESPECIALIDAD
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[EDITAR_LIBRO]
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
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[ELIMINAR_ALUMNO]
@ID_ALUMNO INT
AS
BEGIN
	DELETE FROM ALUMNO 
	WHERE ID_ALUMNO=@ID_ALUMNO
END
------------------------------------------------------------------
GO
------------------------------------------------------------------
CREATE PROCEDURE [dbo].[ELIMINAR_BIBLIOTECARIO]
@DNI CHAR(8)
AS
BEGIN
	DELETE FROM BIBLIOTECARIO
	WHERE DNI = @DNI 
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[ELIMINAR_CATEGORIA]
@ID_CATEGORIA INT
AS
BEGIN
	DELETE FROM CATEGORIA
	WHERE ID_CATEGORIA = @ID_CATEGORIA
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[ELIMINAR_COMPUTADORA]
@ID_COMP int
AS
BEGIN	
	DELETE FROM COMPUTADORA
	WHERE ID_COMP=@ID_COMP	
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[ELIMINAR_ESPECIALIDAD]
@ID_ESPECIALIDAD INT
AS
BEGIN
	DELETE FROM ESPECIALIDAD
	WHERE ID_ESPECIALIDAD=@ID_ESPECIALIDAD
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[ELIMINAR_LIBRO]
@COD_LIBRO CHAR(5)
AS
BEGIN
	DELETE FROM LIBRO
	WHERE COD_LIBRO=@COD_LIBRO
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[INSERTAR_ALUMNO]
@NOMBRE_ALUM VARCHAR(40),
@APELLIDOS_ALUM VARCHAR(40),
@DNI_ALUM CHAR(8),
@SEMESTRE VARCHAR(15),
@ID_ESPECIALIDAD INT,
@TURNO_ALUM VARCHAR(15)
AS
BEGIN
	INSERT INTO ALUMNO VALUES (@NOMBRE_ALUM,@APELLIDOS_ALUM,@DNI_ALUM,@SEMESTRE,@ID_ESPECIALIDAD,@TURNO_ALUM)    
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[INSERTAR_CATEGORIA]
@NOMBRE_CAT VARCHAR(50)
AS
BEGIN
	INSERT INTO CATEGORIA VALUES (@NOMBRE_CAT)
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[INSERTAR_COMPUTADORA]
@NUMERO INT,
@ESTADO VARCHAR(20)
AS
BEGIN
	INSERT INTO COMPUTADORA VALUES(@NUMERO,@ESTADO)
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[INSERTAR_ESPECIALIDAD]
@NOMBRE_ESP VARCHAR(40)
AS
BEGIN
	INSERT INTO ESPECIALIDAD VALUES (@NOMBRE_ESP)
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[INSERTAR_LIBRO]
@COD_LIBRO CHAR(5),
@TITULO VARCHAR(150),
@AUTOR VARCHAR(40),
@EDITORIAL VARCHAR(50),
@ID_CATEGORIA INT,
@DISPONIBILIDAD VARCHAR(20),
@DESCRIPCION VARCHAR(300)
AS
BEGIN
	INSERT INTO LIBRO VALUES (@COD_LIBRO,@TITULO,@AUTOR,@EDITORIAL,@ID_CATEGORIA,@DISPONIBILIDAD,@DESCRIPCION)
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[INSERTAR_PRESTAMO_LIBRO]
@ID_ALUMNO INT,
@ID_LIBRO INT,
@ID_ESPECIALIDAD INT,
@ID INT,
@FECHA DATETIME,
@ESTADO VARCHAR(30)
AS
BEGIN
	INSERT INTO PRESTAMOS_LIBRO VALUES (@ID_ALUMNO,@ID_LIBRO,@ID_ESPECIALIDAD,@ID,@FECHA,@ESTADO)
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE INSERTAR_PRESTAMOS_COMPUTADORA
@ID_ALUMNO INT,
@ID_COMP INT,
@ID_ESPECIALIDAD INT,
@ID INT,
@HORA_ENTRADA TIME,
@HORA_SALIDA TIME,
@FECHA DATETIME,
@ESTADO VARCHAR(20)
AS
BEGIN
	INSERT INTO PRESTAMOS_COMPUTADORA VALUES (@ID_ALUMNO,@ID_COMP,@ID_ESPECIALIDAD,@ID,@HORA_ENTRADA,@HORA_SALIDA,@FECHA,@ESTADO)
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[INSETAR_BIBLIOTECARIO]
@DNI VARCHAR(8),
@CONTRASEÑA VARCHAR(40),
@NOMBRES VARCHAR(40),
@APELLIDOS VARCHAR(40),
@TURNO VARCHAR (10),
@ESTADO CHAR(1)
AS
BEGIN	
	INSERT INTO BIBLIOTECARIO VALUES (@DNI,@CONTRASEÑA,@NOMBRES,@APELLIDOS,@TURNO,@ESTADO)		
END

------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[LISTAR_CATEGORIA]
AS
BEGIN
	SELECT * FROM CATEGORIA ORDER BY NOMBRE_CAT
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[LISTAR_ESPECIALIDAD]
AS
BEGIN
	SELECT * FROM ESPECIALIDAD ORDER BY NOMBRE_ESP
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[MOSTRAR_ALUMNO]
AS
BEGIN
	SELECT A.ID_ALUMNO AS ID,A.NOMBRE_ALUM AS NOMBRES,A.APELLIDOS_ALUM AS APELLIDOS,A.DNI_ALUM AS DNI,A.SEMESTRE,E.NOMBRE_ESP AS ESPECIALIDAD,A.TURNO_ALUM AS TURNO FROM ALUMNO A,ESPECIALIDAD E
	WHERE A.ID_ESPECIALIDAD=E.ID_ESPECIALIDAD
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE MOSTRAR_BIBLIOTECARIO
AS
BEGIN
	SELECT ID,DNI,CONTRASEÑA,NOMBRES,APELLIDOS,TURNO FROM BIBLIOTECARIO
END

------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[MOSTRAR_CATEGORIA]
AS
BEGIN
	SELECT * FROM CATEGORIA
END

------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[MOSTRAR_COMPUTADORA]
AS
BEGIN
	SELECT * FROM COMPUTADORA
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[MOSTRAR_ESPECIALIDAD]
AS
BEGIN
	SELECT ID_ESPECIALIDAD AS ID, NOMBRE_ESP AS NOMBRE FROM ESPECIALIDAD
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[MOSTRAR_LIBRO]
AS
BEGIN
	SELECT L.ID_LIBRO AS ID,L.COD_LIBRO AS CODIGO,L.TITULO,L.AUTOR,L.EDITORIAL,C.NOMBRE_CAT AS CATEGORIA,L.DISPONIBILIDAD,L.DESCRIPCION FROM LIBRO L,CATEGORIA C
	WHERE L.ID_CATEGORIA=C.ID_CATEGORIA
END

------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[MOSTRAR_PRESTAMOS]
AS
BEGIN
	SELECT ID_PRESTAMO_L AS #,A.NOMBRE_ALUM + ' ' + A.APELLIDOS_ALUM AS ALUMNO,L.TITULO AS LIBRO,E.NOMBRE_ESP AS ESPECIALIDAD,B.NOMBRES + ' '+ B.APELLIDOS AS BIBLIOTECARIO,FECHA, PRESTAMOS_LIBRO.ESTADO FROM PRESTAMOS_LIBRO, ALUMNO A,ESPECIALIDAD E,BIBLIOTECARIO B, LIBRO L
	WHERE A.ID_ALUMNO = PRESTAMOS_LIBRO.ID_ALUMNO AND E.ID_ESPECIALIDAD=PRESTAMOS_LIBRO.ID_ESPECIALIDAD AND B.ID= PRESTAMOS_LIBRO.ID AND L.ID_LIBRO = PRESTAMOS_LIBRO.ID_LIBRO 
END

------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE [dbo].[MOSTRAR_PRESTAMOS_COMPUTADORA] 
AS
BEGIN
	SELECT PC.ID_PRESTAMO_C AS ID,A.NOMBRE_ALUM AS ALUMNO,C.NUMERO AS PC_#,E.NOMBRE_ESP AS ESPECIALIDAD,B.NOMBRES + ' '+ B.APELLIDOS AS BIBLIOTECARIO,PC.HORA_ENTRADA AS ENTRADA,PC.HORA_SALIDA AS SALIDA,PC.FECHA FROM PRESTAMOS_COMPUTADORA PC,BIBLIOTECARIO B, COMPUTADORA C, ALUMNO A,ESPECIALIDAD E
	WHERE PC.ID_ALUMNO=A.ID_ALUMNO AND PC.ID_ESPECIALIDAD = E.ID_ESPECIALIDAD AND PC.ID = B.ID AND PC.ID_COMP = C.ID_COMP
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE MOSTRAR_BUSQUEDA_LIBRO
AS
BEGIN
	SELECT L.COD_LIBRO AS CODIGO,L.TITULO AS NOMBRE FROM LIBRO L
	ORDER BY TITULO
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------
CREATE PROCEDURE FILTRAR_BUSQUEDA_LIBRO
@NOMBRE VARCHAR(20)
AS
BEGIN
	SELECT COD_LIBRO AS  CODIGO, TITULO FROM LIBRO WHERE TITULO LIKE '%'+@NOMBRE+'%'
END
------------------------------------------------------------------
GO
-----------------------------------------------------------------