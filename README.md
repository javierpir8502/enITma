# enITma
Prueba Tecnica para EnITma

la prueba se desarrolla en dos proyectos independientes

Proyecto de servicio: 
  - WcfServiceEnITma: hecho en visual studio 2022, .Net Framework 4.8.1, c#
  - WinAppEnITma: hecho en visual studio 2022, .Net Framework 4.8.1, c#

A continuación dejo el script de creación de las tablas en base de datos y procedimientos

CREATE TABLE [dbo].[Exa_CatalogoProducto](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](256) NULL,
	[IdUsuario] [int] NULL,
	[FechaCreacion] [datetime] NULL,
 CONSTRAINT [PK_Exa_CatalogoProducto] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
) ON [PRIMARY]

CREATE PROCEDURE [dbo].[sp_GetAllCatalogoProd]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT IdProducto, Descripcion, IdUsuario, FechaCreacion
    FROM Exa_CatalogoProducto;
END;


CREATE PROCEDURE [dbo].[sp_InsCatalogoProd]
    @Descripcion VARCHAR(256)
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO Exa_CatalogoProducto (Descripcion, IdUsuario, FechaCreacion)
    VALUES (@Descripcion, 1, GETDATE());
END;

