/*Procedimientos almacenados*/

/* Procedimientos almacenados para Usuarios */

--Procedimineto almacenado de registro de ususarios

CREATE PROC SP_RegistrarUsuario(
@NombreUsuario VARCHAR (50),
@Contrasenna VARCHAR (100),
@Correo VARCHAR (100),
@Estado BIT,
@Id_Rol INT,
@IdUsuarioResultado INT OUTPUT,
@Mensaje Varchar(500) OUTPUT
)
AS
BEGIN
	SET @IdUsuarioResultado = 0
	SET @Mensaje = ''

	IF NOT EXISTS( SELECT * FROM tbl_Usuarios WHERE NombreUsuario = @NombreUsuario)
	BEGIN
		INSERT INTO tbl_Usuarios (NombreUsuario,ContrasennaUsuario,CorreoUsuario,EstadoUsuario,Id_Rol_Usuario) VALUES
		(@NombreUsuario,@Contrasenna,@Correo,@Estado,@Id_Rol)

		SET @IdUsuarioResultado = SCOPE_IDENTITY()
		
	END
	ELSE
		SET @Mensaje = 'No se puede crear con el nombre seleccionado, porque ya se encuentra en uso'
END
GO

--Procedimineto almacenado de edicion de ususarios
CREATE PROC SP_EditarUsuario(
@IdUsuario INT,
@NombreUsuario VARCHAR (50),
@Contrasenna VARCHAR (100),
@Correo VARCHAR (100),
@Estado BIT,
@Id_Rol INT,
@Respuesta BIT OUTPUT,
@Mensaje Varchar(500) OUTPUT
)
AS
BEGIN
	SET @Respuesta = 0
	SET @Mensaje = ''

	IF NOT EXISTS( SELECT * FROM tbl_Usuarios WHERE NombreUsuario = @NombreUsuario AND Id_Usuario != @IdUsuario)
	BEGIN
		UPDATE tbl_Usuarios SET
		NombreUsuario = @NombreUsuario,
		ContrasennaUsuario = @Contrasenna,
		CorreoUsuario = @Correo,
		EstadoUsuario = @Estado,
		Id_Rol_Usuario = @Id_Rol
		WHERE Id_Usuario = @IdUsuario

		SET @Respuesta = 1
		
	END
	ELSE
		SET @Mensaje = 'No se puede crear con el nombre ya se encuentra en uso'
END
GO


--Procedimineto almacenado de eliminacion de ususarios
CREATE PROC SP_EliminarUsuario(
@IdUsuario INT,
@Respuesta BIT OUTPUT,
@Mensaje Varchar(500) OUTPUT
)
AS
BEGIN
	SET @Respuesta = 0
	SET @Mensaje = ''
	DECLARE @PasoReglas BIT = 1

	IF EXISTS (SELECT* FROM tbl_Entradas C
	INNER JOIN tbl_Usuarios U ON Id_Usuario = C.Id_UsuarioEntrada
	WHERE U.Id_Usuario = @IdUsuario
	)
	BEGIN
		SET @PasoReglas = 0
		SET @Respuesta = 0
		SET @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una COMPRA\n'
	END	

	IF EXISTS (SELECT* FROM tbl_Salidas V
	INNER JOIN tbl_Usuarios U ON Id_Usuario = V.IdUsuarioSalida
	WHERE U.Id_Usuario = @IdUsuario
	)
	BEGIN
		SET @PasoReglas = 0
		SET @Respuesta = 0
		SET @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una VENTA\n'
	END	

	IF(@PasoReglas = 1)
	BEGIN
		DELETE FROM tbl_Usuarios WHERE Id_Usuario = @IdUsuario
		SET @Respuesta = 1
	END

END

DECLARE @Respuesta BIT
DECLARE @mensaje VARCHAR (500)

EXEC SP_EditarUsuario 2,'Fran','123','@lol',1,2,@Respuesta OUTPUT,@mensaje OUTPUT



EXEC sp_helptext 'SP_RegistrarUsuario';



----------------------------------------------------------------------------------------------------------------------------------------------------
/* Procedimientos almacenados para Productos */

--Procedimineto almacenado para guardar categoria

CREATE PROC SP_RegistrarCategoria(
@Descripcion VARCHAR (50),
@Estado BIT,
@Resultado INT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)AS
BEGIN
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM tbl_Categoria Where DescripcionCategoria =@Descripcion)
	BEGIN
		INSERT INTO tbl_Categoria(DescripcionCategoria,EstadoCategoria) VALUES (@Descripcion,@Estado)
		SET @Resultado = SCOPE_IDENTITY()
	END
	ELSE
		SET @Mensaje = 'No se puede repetir la descripcion de una categoria'
END
GO

--Procedimineto almacenado para editar categoria
CREATE PROC SP_EditarCategoria(
@IdCategoria INT,
@Descripcion VARCHAR (50),
@Estado BIT,
@Resultado INT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)AS
BEGIN
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM tbl_Categoria Where DescripcionCategoria =@Descripcion AND Id_Categoria != @IdCategoria)
	
		UPDATE tbl_Categoria SET
		DescripcionCategoria =@Descripcion,
		EstadoCategoria = @Estado
		WHERE Id_Categoria = @IdCategoria
	ELSE
	BEGIN
		SET @Resultado = 0
		SET @Mensaje = 'No se puede repetir la descripcion de una categoria'
	END
END
GO

--Procedimineto almacenado para eliminar categoria
CREATE PROC SP_EliminarCategoria(
@IdCategoria INT,
@Resultado INT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)AS
BEGIN
	SET @Resultado = 1
	IF NOT EXISTS (
	SELECT * FROM tbl_Categoria c 
	INNER JOIN tbl_Productos p ON p.Id_CategoriaProducto = c.Id_Categoria
	WHERE c.Id_Categoria = @IdCategoria
	)
	BEGIN
		DELETE TOP (1) FROM tbl_Categoria WHERE Id_Categoria =@IdCategoria
	END
	ELSE
	BEGIN
		SET @Resultado = 0
		SET @Mensaje = 'La categoria se enceuntra relacionada a un producto'
	END
END
GO

select * from tbl_Productos
----------------------------------------------------------------------------------------------------------------------------------------------------
/* Procedimientos almacenados para Producto */

--Procedimineto almacenado para guardar Producto

CREATE PROC SP_RegistrarProducto(
@Codigo VARCHAR (50),
@Nombre VARCHAR (50),
@Descripcion VARCHAR (50),
@IdCategoria INT,
@Estado BIT,
@Resultado INT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT

)AS
BEGIN
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM tbl_Productos Where CodigoProducto = @Codigo)
	BEGIN
		INSERT INTO tbl_Productos(CodigoProducto,NombreProducto,DescripcionProducto,Id_CategoriaProducto,EstadoProducto) 
		VALUES (@Codigo,@Nombre,@Descripcion,@IdCategoria,@Estado)

		SET @Resultado = SCOPE_IDENTITY()
	END
	ELSE
		SET @Mensaje = 'Ya existe un producto con el mismo codigo'
END
GO

--Procedimineto almacenado para editar Producto

CREATE PROC SP_EditarProducto(
@IdProducto int,
@Codigo VARCHAR (50),
@Nombre VARCHAR (50),
@Descripcion VARCHAR (50),
@IdCategoria INT,
@Estado BIT,
@Resultado INT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT

)AS
BEGIN
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM tbl_Productos Where CodigoProducto = @Codigo AND Id_Producto != @IdProducto)

		UPDATE tbl_Productos SET
		CodigoProducto = @Codigo,
		NombreProducto = @Nombre,
		DescripcionProducto = @Descripcion,
		Id_CategoriaProducto = @IdCategoria,
		EstadoProducto = @Estado
		WHERE Id_Producto = @IdProducto
	ELSE
	BEGIN
		SET @Resultado = 0
		SET @Mensaje = 'Ya existe un producto con el mismo codigo'
	END
END
GO


--Procedimineto almacenado para editar Producto

CREATE PROC SP_EliminarProducto(
@IdProducto int,
@Respuesta INT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT

)AS
BEGIN
	SET @Respuesta = 0
	SET @Mensaje = ''
	DECLARE @PasoReglas BIT = 1

	IF EXISTS (SELECT * FROM tbl_DetalleEntradas dc 
	INNER JOIN tbl_Productos p ON p.Id_Producto = dc.Id_ProductoDetalleEntrada
	WHERE p.Id_Producto = @IdProducto)
	BEGIN
		SET @PasoReglas = 0
		SET @Respuesta = 0
		SET @Mensaje = @Mensaje +'No se puede eliminar poque se encuentra relacionado a una compra'
	END
	
	IF EXISTS (SELECT * FROM tbl_DetalleSalida dv
	INNER JOIN tbl_Productos p ON p.Id_Producto = DV.Id_DetalleSalida
	WHERE p.Id_Producto = @IdProducto)
	BEGIN
		SET @PasoReglas = 0
		SET @Respuesta = 0
		SET @Mensaje = @Mensaje +'No se puede eliminar poque se encuentra relacionado a una venta'
	END
	IF(@PasoReglas = 1)
	BEGIN
		DELETE FROM tbl_Productos WHERE Id_Producto = @IdProducto
		SET @Respuesta = 1
	END
	
END
GO


ALTER TABLE tbl_Productos  
ADD CodigoProducto VARCHAR(50) NULL;

EXEC sp_help 'tbl_Productos';


SELECT * FROM tbl_Productos


/*Procesos para registrar una compra */

CREATE TYPE [dbo].[EDetalle_Compra]AS TABLE(
	[Id_ProductoDetalleEntrada]INT NULL,
	[CantidadDetalleEntrada] INT NULL
)
go


CREATE PROCEDURE sp_RegistrarEntrada(
@Id_UsuarioEntrada INT,
@TipoDocumento VARCHAR (500),
@NumeroFacturaEntrada VARCHAR (500),
@DetalleCompra [EDetalle_Compra] READONLY,
@Resultado BIT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)
AS
BEGIN
	BEGIN TRY
		DECLARE @IdEntrada INT = 0
		SET @Resultado = 1
		SET @Mensaje = ''

		BEGIN TRANSACTION registro
			
			INSERT INTO tbl_Entradas(Id_UsuarioEntrada,TipoDocumento,NumeroFacturaEntrada)
			VALUES(@Id_UsuarioEntrada,@TipoDocumento,@NumeroFacturaEntrada)

			SET @IdEntrada = SCOPE_IDENTITY()

			INSERT INTO tbl_DetalleEntradas(Id_EntradaDetalleEntrada,Id_ProductoDetalleEntrada,CantidadDetalleEntrada)
			SELECT @IdEntrada,Id_ProductoDetalleEntrada,CantidadDetalleEntrada FROM @DetalleCompra

			UPDATE p SET p.StockProducto = p.StockProducto + dc.CantidadDetalleEntrada
			FROM tbl_Productos P
			INNER JOIN @DetalleCompra dc ON dc.Id_ProductoDetalleEntrada = p.Id_Producto

		COMMIT TRANSACTION registro
	END TRY
	BEGIN CATCH

		SET @Resultado = 0
		SET @Mensaje = ERROR_MESSAGE()
		ROLLBACK TRANSACTION
	END CATCH
END




/*Procesos para registrar una salida */

CREATE TYPE [dbo].[EDetalle_Venta]AS TABLE(
	[Id_ProductoDetalleSalida]INT NULL,
	[CantidadDetalleSalida] INT NULL
)
go


CREATE PROCEDURE sp_RegistrarVenta(
@Id_UsuarioSalida INT,
@TipoDocumento VARCHAR (500),
@NumeroFacturaSalida VARCHAR (500),
@DetalleVenta [EDetalle_Venta] READONLY,
@Resultado BIT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)
AS
BEGIN
	BEGIN TRY
		DECLARE @idventa INT = 0
		SET @Resultado = 1
		SET @Mensaje = ''

		BEGIN TRANSACTION registro
			
			INSERT INTO tbl_Salidas(IdUsuarioSalida,TipoDocumento,NumeroDocumentoSalida)
			VALUES(@Id_UsuarioSalida,@TipoDocumento,@NumeroFacturaSalida)

			SET @idventa = SCOPE_IDENTITY()

			INSERT INTO tbl_DetalleSalida(Id_SalidaDetalleSalida,Id_ProductoDetalleSalida,CantidadDetalleSalida)
			SELECT @idventa,Id_ProductoDetalleSalida,CantidadDetalleSalida FROM @DetalleVenta

		COMMIT TRANSACTION registro
	END TRY
	BEGIN CATCH

		SET @Resultado = 0
		SET @Mensaje = ERROR_MESSAGE()
		ROLLBACK TRANSACTION registro
	END CATCH
END


select * from tbl_Entradas

select * from tbl_Salidas
select * from tbl_DetalleEntradas




