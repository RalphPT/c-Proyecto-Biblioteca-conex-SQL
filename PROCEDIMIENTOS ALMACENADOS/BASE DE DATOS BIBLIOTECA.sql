CREATE DATABASE BIBLIOTECA
GO
USE BIBLIOTECA
GO
CREATE TABLE BIBLIOTECARIO(
ID int identity primary key not null,
DNI char(8) unique not null,
CONTRASEÑA varchar(40) not null,
NOMBRES varchar(40) not null,
APELLIDOS varchar(40) not null,
TURNO varchar(10) not null,
ESTADO CHAR(1))
GO
-------------------------------------------------
CREATE TABLE CATEGORIA(
ID_CATEGORIA int identity primary key not null, 
NOMBRE_CAT varchar(50) not null)
GO
-------------------------------------------------
CREATE TABLE LIBRO(
ID_LIBRO int identity primary key not null,
COD_LIBRO char(5) not null,
TITULO varchar(150) not null,
AUTOR varchar(40) not null,
EDITORIAL varchar(50),
ID_CATEGORIA INT foreign key references CATEGORIA NOT NULL,
DISPONIBILIDAD varchar(20),
DESCRIPCION varchar(500))
GO
CREATE TABLE COMPUTADORA(
ID_COMP int primary key identity not null,
NUMERO int not null ,
ESTADO varchar(20) not null)
GO
CREATE TABLE ESPECIALIDAD(
ID_ESPECIALIDAD int primary key identity not null,
NOMBRE_ESP varchar(40))
GO
----------------------------------------------------------
CREATE TABLE ALUMNO(
ID_ALUMNO int Identity primary key,
NOMBRE_ALUM varchar(40),
APELLIDOS_ALUM varchar(40),
DNI_ALUM char(8) UNIQUE,
SEMESTRE varchar(15),
ID_ESPECIALIDAD int foreign key references ESPECIALIDAD,
TURNO_ALUM varchar(15))
GO
CREATE TABLE PRESTAMOS_LIBRO(
ID_PRESTAMO_L INT IDENTITY,
ID_ALUMNO INT foreign key references ALUMNO,
ID_LIBRO INT foreign key references LIBRO,
ID_ESPECIALIDAD INT foreign key references ESPECIALIDAD,
ID INT foreign key references BIBLIOTECARIO,
FECHA datetime,
ESTADO VARCHAR(20))
GO
CREATE TABLE PRESTAMOS_COMPUTADORA(
ID_PRESTAMO_C INT IDENTITY,
ID_ALUMNO INT foreign key references ALUMNO,
ID_COMP int not null foreign key references COMPUTADORA,
ID_ESPECIALIDAD INT foreign key references ESPECIALIDAD,
ID INT foreign key references BIBLIOTECARIO,
HORA_ENTRADA time,
HORA_SALIDA time,
FECHA datetime,
ESTADO VARCHAR(20))
