--Creacion de la base de datos

CREATE DATABASE BD_StockGuard;
GO 
USE BD_StockGuard;
GO


--Tabla de Roles 
CREATE TABLE tbl_Rol(
Id_Rol INT IDENTITY (1,1) NOT NULL,
DescripcionRol VARCHAR (200) NOT NULL,
FechaCreacionRol DATETIME DEFAULT GETDATE(),

CONSTRAINT PKtbl_Rol PRIMARY KEY (Id_rol)
);
GO

SELECT * FROM tbl_Rol 

--Tabla de Permisos
CREATE TABLE tbl_Permisos(
Id_Permiso INT IDENTITY(1,1) NOT NULL,
DescripcionPermiso VARCHAR (200) NOT NULL,
NombreMenuPermiso VARCHAR(50), --Es del video de prueba(revisar mas adelante)
FechaCreacionPermiso DATETIME DEFAULT GETDATE(),

Id_Rol_Permiso INT, 

CONSTRAINT PKtbl_Permisos PRIMARY KEY (Id_Permiso)
);
GO 

ALTER TABLE tbl_Permisos
ALTER COLUMN DescripcionPermiso Varchar(200) NULL;

SELECT * FROM tbl_Usuarios WHERE NombreUsuario IS NULL;

--Tabla de Usuarios 
CREATE TABLE tbl_Usuarios(
Id_Usuario INT IDENTITY(1,1) NOT NULL,
NombreUsuario VARCHAR(100),
ContrasennaUsuario VARCHAR (50) NOT NULL,
CorreoUsuario Varchar (50),
FechaRegistroUsuario DATETIME DEFAULT GETDATE(),
FechaInactivacionUsuario DATETIME DEFAULT GETDATE(),
EstadoUsuario VARCHAR (50) NOT NULL,

Id_Rol_Usuario INT NOT NULL,

CONSTRAINT PKtbl_Usuarios PRIMARY KEY (Id_Usuario)
);
GO 

--Tabla de Categoria 
CREATE TABLE tbl_Categoria(
Id_Categoria INT IDENTITY(1,1) NOT NULL,
NombreCategoria VARCHAR(100) NOT NULL,
DescripcionCategoria VARCHAR(200)NOT NULL,
EstadoCategoria VARCHAR (100) NOT NULL,

CONSTRAINT PKtbl_Categoria PRIMARY KEY (Id_Categoria)
);
GO 

--Tabla de Productos 
CREATE TABLE tbl_Productos(
Id_Producto INT IDENTITY(1,1) NOT NULL,
NombreProducto VARCHAR(100) NOT NULL,
DescripcionProducto VARCHAR (255) NOT NULL,
CantidadProducto INT NOT NULL,
EstadoProducto VARCHAR (100) NOT NULL,
StockProducto INT NOT NULL,

Id_CategoriaProducto INT NOT NULL,
Id_UsuarioProducto INT NOT NULL,

CONSTRAINT PKtbl_Productos PRIMARY KEY (Id_Producto)
);
GO 

--Tabla de Entradas 
CREATE TABLE tbl_Entradas(
Id_Entrada INT IDENTITY(1,1) NOT NULL,
FechaEntrada DATETIME DEFAULT GETDATE(),
NumeroFacturaEntrada VARCHAR (100) NOT NULL,
TipoDocumento VARCHAR (50) NULL


Id_UsuarioEntrada INT NOT NULL,
Id_ProveedorEntrada INT NOT NULL,

CONSTRAINT PKtbl_Entradas PRIMARY KEY (Id_Entrada)
);
GO 

ALTER TABLE tbl_Entradas
DROP COLUMN Id_ProveedorEntrada;

--Tabla del detalle de las entradas 
CREATE TABLE tbl_DetalleEntradas(
Id_DetalleEntrada INT IDENTITY(1,1) NOT NULL,
CantidadDetalleEntrada INT NOT NULL,
FechaDetalleEntrada DATETIME DEFAULT GETDATE(),

Id_EntradaDetalleEntrada INT NOT NULL,
Id_ProductoDetalleEntrada INT NOT NULL,

CONSTRAINT PKtbl_DetalleEntrada PRIMARY KEY (Id_DetalleEntrada)
);
GO 

--Tabla de salidas
CREATE TABLE tbl_Salidas(
Id_Salida INT IDENTITY (1,1) NOT NULL,
FechaSalida DATETIME DEFAULT GETDATE(),
NumeroDocumentoSalida INT NOT NULL,

IdUsuarioSalida INT NOT NULL,

CONSTRAINT PKtbl_Salidas PRIMARY KEY (Id_Salida)
);
GO

--Tabla de Detalle de salida
CREATE TABLE tbl_DetalleSalida(
Id_DetalleSalida INT IDENTITY (1,1) NOT NULL,
CantidadDetalleSalida INT NOT NULL,
FechaDetalleSalida DATETIME DEFAULT GETDATE(),

Id_SalidaDetalleSalida INT NOT NULL,
Id_ProductoDetalleSalida INT NOT NULL,

CONSTRAINT PKtbl_DetalleSalida PRIMARY KEY (Id_DetalleSalida)
);
GO



SELECT @Respuesta

SELECT @mensaje

SELECT * FROM tbl_Usuarios



SELECT * FROM tbl_Entradas;

 