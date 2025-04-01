/*Updates*/


UPDATE tbl_Usuarios set EstadoUsuario = 0 WHERE Id_Usuario = 2

/*Con esto modifique el erro de las columnas para poder pasarlo a tipo bit y poder utilizarlo mejor en la base de datos*/

UPDATE tbl_Usuarios SET EstadoUsuario = 1 WHERE EstadoUsuario = 'activo';
UPDATE tbl_Usuarios SET EstadoUsuario = 0 WHERE EstadoUsuario = 'inactivo';

UPDATE tbl_Permisos
SET NombreMenuPermiso = 'MenuVentas'
WHERE NombreMenuPermiso = 'MenuVnetas';