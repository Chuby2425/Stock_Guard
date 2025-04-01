USE BD_StockGuard
GO

select u.Id_Usuario,u.NombreUsuario,u.ContrasennaUsuario,u.CorreoUsuario,u.EstadoUsuario,r.Id_Rol,r.DescripcionRol from tbl_Usuarios u
INNER JOIN tbl_Rol r on r.Id_Rol = u.Id_Rol_Usuario


SELECT p.Id_Rol_Permiso,p.NombreMenuPermiso FROM tbl_Permisos p
INNER JOIN tbl_Rol r on r.Id_Rol = p.Id_Rol_Permiso
INNER JOIN tbl_Usuarios u on u.Id_Rol_Usuario = r.Id_Rol
WHERE U.Id_Usuario = 1;


SELECT * FROM tbl_Rol


SELECT Id_Categoria,DescripcionCategoria,EstadoCategoria FROM tbl_Categoria


--Para los productos

SELECT Id_Producto,NombreProducto,p.DescripcionProducto,c.Id_Categoria,c.DescripcionCategoria[DescripcionCategoria],StockProducto,CodigoProducto,p.EstadoProducto FROM tbl_Productos p
INNER JOIN tbl_Categoria c ON  c.Id_Categoria = p.Id_CategoriaProducto



ALTER TABLE tbl_Productos  
DROP COLUMN CantidadProducto;

SELECT COUNT(*) +1 FROM tbl_Entradas




SELECT C.Id_Entrada,
U.NombreUsuario,
c.TipoDocumento,c.NumeroFacturaEntrada,CONVERT(CHAR(10), c.FechaEntrada,103)[FechaRegistro]
FROM tbl_Entradas c
inner join tbl_Usuarios u on u.Id_Usuario = c.Id_UsuarioEntrada
where c.NumeroFacturaEntrada = '00001'

SELECT p.NombreProducto,dc.CantidadDetalleEntrada 
FROM tbl_DetalleEntradas dc
INNER JOIN tbl_Productos p ON p.Id_Producto = dc.Id_ProductoDetalleEntrada 
WHERE dc.Id_EntradaDetalleEntrada = 8


select * from tbl_Productos

SELECT COALESCE(MAX(CAST(NumeroFacturaEntrada AS INT)), 0) + 1 FROM tbl_Entradas

SELECT COALESCE(MAX(CAST(NumeroDocumentoSalida AS INT)), 0) + 1 FROM tbl_Salidas


update tbl_Productos set StockProducto = StockProducto - @cantidad where Id_Producto = @idproducto


select *from tbl_Salidas where NumeroDocumentoSalida = '00001'
select *from tbl_DetalleSalida where Id_SalidaDetalleSalida = 1

select v.Id_Salida,u.NombreUsuario,
v.TipoDocumento,v.NumeroDocumentoSalida,
CONVERT(CHAR(10), v.FechaSalida,103)[FechaRegistro]
from tbl_Salidas v
INNER JOIN tbl_Usuarios u ON u.Id_Usuario = v.IdUsuarioSalida
Where v.NumeroDocumentoSalida = '00001'

SELECT p.NombreProducto,dv.CantidadDetalleSalida
from tbl_DetalleSalida dv
INNER JOIN tbl_Productos p ON p.Id_Producto = dv.Id_ProductoDetalleSalida
WHERE dv.Id_DetalleSalida = 1






alter PROC sp_ReporteCompras(
@fechainicio VARCHAR (10),
@fechafin VARCHAR (10),
@idProducto int
)
AS
BEGIN
	SET DATEFORMAT dmy;
	SELECT 
CONVERT(char(10),c.FechaEntrada,103)[FechaRegistro],c.TipoDocumento,c.NumeroFacturaEntrada[NumeroDocumento],
u.NombreUsuario[UsuarioRegistrado],
p.CodigoProducto[CodigoProducto],p.NombreProducto[NombreProducto],ca.DescripcionCategoria[Categoria],dc.CantidadDetalleEntrada[Cantidad]
FROM tbl_Entradas C
INNER JOIN tbl_Usuarios u ON u.Id_Usuario = c.Id_UsuarioEntrada
INNER JOIN tbl_DetalleEntradas dc ON dc.Id_EntradaDetalleEntrada = c.Id_Entrada
INNER JOIN tbl_Productos p ON p.Id_Producto = dc.Id_ProductoDetalleEntrada
INNER JOIN tbl_Categoria ca ON ca.Id_Categoria = p.Id_CategoriaProducto
WHERE CONVERT (DATE,c.FechaEntrada)BETWEEN @fechainicio AND @fechafin
and p.Id_Producto = iif(@idProducto=0,p.Id_Producto,@idProducto)
end

EXEC sp_ReporteCompras 
    @fechainicio = '01/01/2023', 
    @fechafin = '31/12/2023', 
    @idProducto =6; -- 0 para todos los productos

EXEC sp_ReporteCompras'10/03/2025','18/03/2025'


CREATE PROC sp_ReporteVentas(
@fechainicio VARCHAR (10),
@fechafin VARCHAR (10)
)
AS
BEGIN
	SET DATEFORMAT dmy;
	SELECT 
CONVERT(char(10),v.FechaSalida,103)[FechaRegistro],v.TipoDocumento,v.NumeroDocumentoSalida[NumeroDocumento],
u.NombreUsuario[UsuarioRegistrado],
p.CodigoProducto[CodigoProducto],p.NombreProducto[NombreProducto],ca.DescripcionCategoria[Categoria],dv.CantidadDetalleSalida[Cantidad]
FROM tbl_Salidas V
INNER JOIN tbl_Usuarios u ON u.Id_Usuario = v.IdUsuarioSalida
INNER JOIN tbl_DetalleSalida dv ON dv.Id_SalidaDetalleSalida = v.Id_Salida
INNER JOIN tbl_Productos p ON p.Id_Producto = dv.Id_ProductoDetalleSalida
INNER JOIN tbl_Categoria ca ON ca.Id_Categoria = p.Id_CategoriaProducto
WHERE CONVERT (DATE,v.FechaSalida)BETWEEN @fechainicio AND @fechafin
end


EXEC sp_ReporteVentas '18/03/2025', '20/03/2025'
