
--Creacion de la base de datos

CREATE DATABASE BD_ControlInventario;
GO 
USE BD_ControlInventario;
GO

--Creacion de las tablas

--Tabla de proveedores 
CREATE TABLE tbl_Proveedores(
Id_proveedores INT IDENTITY(1,1) NOT NULL,
NombreProveedor VARCHAR(100) NOT NULL,
TelefonoProveedor VARCHAR (100) NOT NULL,
CorreoProveedro VARCHAR (100) NOT NULL,
DireccionProveedor VARCHAR (250) NOT NULL,
EstadoProveedor VARCHAR (250) NOT NULL

CONSTRAINT PKtbl_Proveedores PRIMARY KEY (Id_proveedores)
);
GO 

--Tabla de Marca 
CREATE TABLE tbl_Marca(
Id_marca INT IDENTITY(1,1) NOT NULL,
NombreMarca VARCHAR(100) NOT NULL,
EstadoMarca VARCHAR (100) NOT NULL

CONSTRAINT PKtbl_Marca PRIMARY KEY (Id_Marca)
);
GO 

--Tabla de Ajustes
CREATE TABLE tbl_Ajustes(
Id_Ajustes INT IDENTITY(1,1) NOT NULL,
FechaAjuste DATE NOT NULL,
CantidadProductoAjuste INT NOT NULL,
TipoAjuste INT NOT NULL,
DescripcionAjuste VARCHAR (250) NOT NULL,

Id_ProductoAjuste VARCHAR (100) NOT NULL,
Id_UsuarioAjuste INT NOT NULL,

CONSTRAINT PKtbl_Ajustes PRIMARY KEY (Id_Ajustes)
);
GO 

--Tabla de Entradas 
CREATE TABLE tbl_Entradas(
Id_Entrada INT IDENTITY(1,1) NOT NULL,
FechaEntrada DATE NOT NULL,
NumeroFacturaEntrada VARCHAR (100) NOT NULL,
FechaFacturaEntrada DATE NOT NULL,

Id_UsuarioEntrada INT NOT NULL,
Id_ProveedorEntrada INT NOT NULL,

CONSTRAINT PKtbl_Entradas PRIMARY KEY (Id_Entrada)
);
GO 

--Tabla de Productos 
CREATE TABLE tbl_Productos(
Id_Producto INT IDENTITY(1,1) NOT NULL,
NombreProducto VARCHAR(100) NOT NULL,
DescripcionProducto VARCHAR (255) NOT NULL,
CantidadProducto INT NOT NULL,
CostoProducto NUMERIC NOT NULL,
PrecioProducto Numeric NOT NULL,
EstadoProducto VARCHAR (100) NOT NULL,

Id_TipoProducto INT NOT NULL,
Id_MarcaProducto INT NOT NULL,
Id_UsuarioProducto INT NOT NULL,

CONSTRAINT PKtbl_Productos PRIMARY KEY (Id_Producto)
);
GO 

--Tabla de Usuarios 
CREATE TABLE tbl_Usuarios(
Id_Usuario INT IDENTITY(1,1) NOT NULL,
NombreUsuario VARCHAR(100) NOT NULL,
ContrasennaUsuario VARCHAR (50) NOT NULL,
FechaRegistroUsuario DATE NOT NULL,
FechaInactivacionUsuario DATE NOT NULL,

Id_PermisosUsuario INT NOT NULL,

CONSTRAINT PKtbl_Usuarios PRIMARY KEY (Id_Usuario)
);
GO 

--Tabla de Salidas 
CREATE TABLE tbl_Salidas(
Id_Salida INT IDENTITY(1,1) NOT NULL,
FechaSalida DATE NOT NULL,

CONSTRAINT PKtbl_Salidas PRIMARY KEY (Id_Salida)
);
GO 

--Tabla de Detalle de entradas
CREATE TABLE tbl_DetalleEntradas(
Id_DetalleEntrada INT IDENTITY(1,1) NOT NULL,
CantidadDetalleEntrada INT NOT NULL,

Id_EntradaDetalleEntrada INT NOT NULL,
Id_ProductoDetalleEntrada INT NOT NULL,

CONSTRAINT PKtbl_DetalleEntrada PRIMARY KEY (Id_DetalleEntrada)
);
GO 

--Tabla de Permisos
CREATE TABLE tbl_Permisos(
Id_Permiso INT IDENTITY(1,1) NOT NULL,
DescripcionPermiso VARCHAR (200) NOT NULL,

CONSTRAINT PKtbl_Permisos PRIMARY KEY (Id_Permiso)
);
GO 

--Tabla de Tipos
CREATE TABLE tbl_Tipos(
Id_Tipo INT IDENTITY(1,1) NOT NULL,
NombreTipo VARCHAR (100) NOT NULL,
EstadoTipo VARCHAR (250) NOT NULL,

CONSTRAINT PKtbl_Tipos PRIMARY KEY (Id_Tipo)
);
GO 

--Tabla de Detalle de salida
CREATE TABLE tbl_DetalleSalida(
Id_DetalleSalida INT IDENTITY (1,1) NOT NULL,
CantidadDetalleSalida INT NOT NULL,

Id_SalidaDetalleSalida INT NOT NULL,
Id_ProductoDetalleSalida INT NOT NULL,

CONSTRAINT PKtbl_DetalleSalida PRIMARY KEY (Id_DetalleSalida)
);
GO


/*aca se cambio por un error en el tipo de datos se hizo un alter 
para pasar de varchar a int*/

ALTER TABLE tbl_Ajustes
ALTER COLUMN Id_ProductoAjuste INT;
GO

--Create Foreign Key Ajustes

ALTER TABLE tbl_Ajustes
ADD CONSTRAINT FK_Producto_Ajuste FOREIGN KEY (Id_ProductoAjuste)
REFERENCES tbl_Productos (Id_Producto);
GO

ALTER TABLE tbl_Ajustes
ADD CONSTRAINT FK_Usuario_Ajuste FOREIGN KEY (Id_UsuarioAjuste)
REFERENCES tbl_Usuarios (Id_Usuario);
GO


--Create Foreign Key Entradas

ALTER TABLE tbl_Entradas
ADD CONSTRAINT FK_Usuario_Entrada FOREIGN KEY (Id_UsuarioEntrada)
REFERENCES tbl_Usuarios (Id_Usuario);
GO

ALTER TABLE tbl_Entradas
ADD CONSTRAINT FK_Proveedor_Entrada FOREIGN KEY (Id_ProveedorEntrada)
REFERENCES tbl_Proveedores (Id_proveedores);
GO

