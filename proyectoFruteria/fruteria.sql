create database fruteria;
use fruteria;

CREATE TABLE `categoria` (
  `idCategoria` int(11) NOT NULL AUTO_INCREMENT,
  `nombreCategoria` varchar(300) NOT NULL,
  PRIMARY KEY (`idCategoria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `productos` (
  `idProductos` int(11) NOT NULL AUTO_INCREMENT,
  `nombreCompleto` varchar(500) NOT NULL,
  `precioAdquirido` double NOT NULL,
  `precioVendido` double NOT NULL,
  `cantidad` double NOT NULL,
  `idCategoria` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`idProductos`),
  KEY `idCategoria` (`idCategoria`),
  CONSTRAINT `productos_ibfk_1` FOREIGN KEY (`idCategoria`) REFERENCES `categoria` (`idCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;


CREATE TABLE `ventas` (
  `idVenta` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  `totalPagar` double NOT NULL,
  PRIMARY KEY (`idVenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;



CREATE TABLE `venta_Producto` (
  `idVentaP` int(11) NOT NULL,
  `idProductos` int(11) NOT NULL,
  `nombres` varchar(800) NOT NULL,
  `total` double NOT NULL,
  `precio` double NOT NULL,
  `cantidad` double NOT NULL,
  KEY `idVentaP` (`idVentaP`),
  KEY `idProductos` (`idProductos`),
  -- CONSTRAINT `productos_ibfk_2` FOREIGN KEY (`idVenta`) REFERENCES `ventas` (`idVenta`),
  CONSTRAINT `productos_ibfk_2` FOREIGN KEY (`idProductos`) REFERENCES `productos` (`idProductos`)  
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


Delimiter $$
create procedure
EditarProducto(IN id int(11), IN nombre varchar(100), 
IN precioA double,IN precioV double,
IN cant double,IN idCat int(11), IN fech datetime)
begin
UPDATE `fruteria`.`productos`
SET
`idProductos` = id,
`nombreCompleto` = nombre,
`precioAdquirido` = precioA,
`precioVendido` = precioV,
`cantidad` = cant,
`idCategoria` = idCat,
`fecha` = fech
WHERE `idProductos` = id;
END$$
DELIMITER ;


Delimiter $$
CREATE PROCEDURE reporte(IN idPro INT, IN fechIni datetime, IN fechFin datetime )
BEGIN
select v.fecha as Fecha, vp.nombres as Nombre, count(vp.idVentaP) as 'Total de ventas', sum(vp.cantidad) as 'Kg Vendidos',
   p.precioVendido as 'Precio dado', vp.precio as 'Precio cobrado', p.precioAdquirido as'Precio adquirido',
   p.cantidad as 'Kg Restantes',abs(((sum(vp.cantidad)*vp.precio)-(sum(vp.cantidad)* p.precioAdquirido)))as 'Ganancias' 
  from venta_producto vp INNER JOIN productos p on vp.idProductos = p.idProductos INNER JOIN ventas v 
  on vp.idVentaP = v.idVenta where vp.idProductos= idPro and v.fecha BETWEEN fechIni AND fechFin;
END$$
DELIMITER ;

Delimiter $$
CREATE PROCEDURE reporteT(IN fechIni datetime, IN fechFin datetime )
BEGIN
select v.fecha as Fecha, vp.nombres as Nombre, count(vp.idVentaP) as 'Total de ventas', sum(vp.cantidad) as 'Kg Vendidos',
   p.precioVendido as 'Precio dado', vp.precio as 'Precio cobrado', p.precioAdquirido as'Precio adquirido',
   p.cantidad as 'Kg Restantes',abs(((sum(vp.cantidad)*vp.precio)-(sum(vp.cantidad)* p.precioAdquirido)))as 'Ganancias' 
  from venta_producto vp INNER JOIN productos p on vp.idProductos = p.idProductos INNER JOIN ventas v 
  on vp.idVentaP = v.idVenta where v.fecha BETWEEN fechIni AND fechFin
 GROUP BY vp.nombres ;
END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS `reporteT`;

DROP PROCEDURE IF EXISTS `EditarProducto`;

INSERT INTO `fruteria`.`categoria`
(
`nombreCategoria`)
VALUES
('FRUTA'),('VERDURA');

