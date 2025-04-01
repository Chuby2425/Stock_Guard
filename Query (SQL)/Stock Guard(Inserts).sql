
/*Con esto lo que estoy haciendo es creando los roles para poder cambiar de lo que puede verse en el sistema */

INSERT INTO tbl_Rol (DescripcionRol)
VALUES('ADMINISTRADOR')

INSERT INTO tbl_Rol (DescripcionRol)
VALUES('COLABORADOR')

INSERT tbl_Usuarios(NombreUsuario, ContrasennaUsuario, CorreoUsuario,Id_Rol_Usuario,EstadoUsuario)
VALUES ('Jason', '123','jason@gmail.com',1,'activo')

INSERT tbl_Usuarios(NombreUsuario, ContrasennaUsuario, CorreoUsuario,Id_Rol_Usuario,EstadoUsuario)
VALUES ('Fran', '789','fran@gmail.com',2,'activo')


/*estos son los permisos de administrador*/
INSERT INTO tbl_Permisos(Id_Rol_Permiso,NombreMenuPermiso) 
VALUES (1,'btn_Usuario'),
	   (1,'menuMantenimientos'),
	   (1,'menuVnetas'),
	   (1,'MenuCompras'),
	   (1,'btn_Clientes'),
	   (1,'btn_Reportes'),
	   (1,'btn_Info');

/*estos son los permisos de colaborador*/
INSERT INTO tbl_Permisos(Id_Rol_Permiso,NombreMenuPermiso) 
VALUES (2,'menuVnetas'),
	   (2,'MenuCompras'),
	   (2,'btn_Clientes'),
	   (2,'btn_Proveedores'),
	   (2,'btn_Info');





/*INSERTS DE LA TABLA DE CATEGORIAS*/

SELECT * FROM tbl_Productos

INSERT INTO tbl_Categoria(DescripcionCategoria,EstadoCategoria) VALUES ('Mouse',1)
INSERT INTO tbl_Categoria(DescripcionCategoria,EstadoCategoria) VALUES ('Teclados',1)
INSERT INTO tbl_Categoria(DescripcionCategoria,EstadoCategoria) VALUES ('Estuches',1)

UPDATE tbl_Productos SET EstadoProducto =1

use BD_StockGuard

/*INSERTS DE LA TABLA DE Productos*/

INSERT INTO tbl_Productos(CodigoProducto,NombreProducto,DescripcionProducto,Id_CategoriaProducto) VALUES ('101010','Mouse','Inalambrico',5)


SELECT COLUMN_NAME  
FROM INFORMATION_SCHEMA.COLUMNS  
WHERE TABLE_NAME = 'tbl_Productos';

ALTER TABLE tbl_Productos 
ADD CONSTRAINT DF_StockProducto DEFAULT 0 FOR StockProducto;


ALTER TABLE tbl_Productos ALTER COLUMN Id_UsuarioProducto INT NULL;


select *from tbl_Permisos

UPDATE tbl_Permisos 
SET NombreMenuPermiso = 'menuReportes' 
WHERE NombreMenuPermiso = 'btn_Reportes';