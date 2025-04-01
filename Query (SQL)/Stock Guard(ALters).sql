use BD_StockGuard


/*CREACION DE LLAVE FORANEAS*/

ALTER TABLE tbl_Permisos
ADD CONSTRAINT FK_PermisoXrol FOREIGN KEY (Id_Rol_Permiso)
REFERENCES tbl_Rol (Id_Rol);
GO

ALTER TABLE tbl_Usuarios
ADD CONSTRAINT FK_UsuarioXrol FOREIGN KEY (Id_Rol_Usuario)
REFERENCES tbl_Rol (Id_Rol);
GO

ALTER TABLE tbl_Productos
ADD CONSTRAINT FK_ProductoXmarca FOREIGN KEY (Id_MarcaProducto)
REFERENCES tbl_Marca (Id_Marca);
GO

ALTER TABLE tbl_Entradas 
ADD CONSTRAINT FK_EntradaXusuario FOREIGN KEY (ID_UsuarioEntrada)
REFERENCES tbl_Usuarios (Id_Usuario);
GO

ALTER TABLE tbl_Entradas 
ADD CONSTRAINT FK_EntradaXproveedor FOREIGN KEY (Id_ProveedorEntrada)
REFERENCES tbl_Proveedores (Id_Proveedores);
GO

ALTER TABLE tbl_DetalleEntradas
ADD CONSTRAINT FK_EntradaXdetalleEntrada FOREIGN KEY (Id_EntradaDetalleEntrada)
REFERENCES tbl_Entradas(Id_Entrada);
GO

ALTER TABLE tbl_DetalleEntradas
ADD CONSTRAINT FK_ProductoXdetalleEntrada FOREIGN KEY (Id_ProductoDetalleEntrada)
REFERENCES tbl_Productos(Id_Producto);
GO

ALTER TABLE tbl_Salidas 
ADD CONSTRAINT FK_UsuarioXsalida FOREIGN KEY (IdUsuarioSalida)
REFERENCES tbl_Usuarios(Id_Usuario);
GO

ALTER TABLE tbl_DetalleSalida 
ADD CONSTRAINT FK_SalidaXdetalleSalida FOREIGN KEY (Id_SalidaDetalleSalida)
REFERENCES tbl_Salidas(Id_Salida);
GO

ALTER TABLE tbl_DetalleSalida 
ADD CONSTRAINT FK_ProductoXdetalleSalida FOREIGN KEY (Id_ProductoDetalleSalida)
REFERENCES tbl_Productos(Id_Producto);
GO

--Esto es una modificacion que tuve que hacer a una de las llaves foraneas


ALTER TABLE tbl_DetalleSalida 
DROP CONSTRAINT FK_ProductoXdetalleSalida 
GO

ALTER TABLE tbl_Entradas
DROP CONSTRAINT FK_EntradaXproveedor
GO

ALTER TABLE tbl_Productos
DROP CONSTRAINT FK_ProductoXmarca
GO



ALTER TABLE tbl_Productos
ALTER COLUMN EstadoProducto BIT NULL;