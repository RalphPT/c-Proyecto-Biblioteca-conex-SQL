CREATE PROCEDURE INSERTAR_COMPUTADORA
@NUMERO_COMP INT,
@ESTADO_COMP VARCHAR(20)
AS
BEGIN
	INSERT INTO COMPUTADORA VALUES(@NUMERO_COMP,@ESTADO_COMP)
END