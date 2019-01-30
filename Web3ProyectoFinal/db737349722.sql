-- phpMyAdmin SQL Dump
-- version 4.1.14.8
-- http://www.phpmyadmin.net
--
-- Servidor: db737349722.db.1and1.com
-- Tiempo de generación: 25-05-2018 a las 13:56:28
-- Versión del servidor: 5.5.60-0+deb7u1-log
-- Versión de PHP: 5.4.45-0+deb7u14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";imagenes


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

create database gluzzer;
use gluzzer;
--
-- Base de datos: `db737349722`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Calificaciones`
--

CREATE TABLE IF NOT EXISTS `Calificaciones` (
  `_id` int(100) NOT NULL AUTO_INCREMENT,
  `idEntidad` int(100) NOT NULL,
  `contador` varchar(100) NOT NULL,
  `total` varchar(100) NOT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Categoria`
--

CREATE TABLE IF NOT EXISTS `Categoria` (
  `_idCategoria` int(100) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(200) COLLATE latin1_spanish_ci NOT NULL,
  PRIMARY KEY (`_idCategoria`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci AUTO_INCREMENT=15 ;

--
-- Volcado de datos para la tabla `Categoria`
--

INSERT INTO `Categoria` (`_idCategoria`, `descripcion`) VALUES
(1, 'PIZZA'),
(2, 'ENSALADAS'),
(3, 'PASTAS'),
(4, 'SANDWICH'),
(5, 'BOTANAS'),
(6, 'HAMBURGUESAS'),
(7, 'PARRILLADA'),
(8, 'CAMARONES'),
(9, 'PESCADO'),
(10, 'TOSTADAS'),
(11, 'COCTELES'),
(12, 'CALDOS'),
(13, 'ESPECIALIDADES'),
(14, 'TORTAS');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Ciudad`
--

CREATE TABLE IF NOT EXISTS `Ciudad` (
  `_id` int(100) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(2000) COLLATE latin1_spanish_ci NOT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `Ciudad`
--

INSERT INTO `Ciudad` (`_id`, `nombre`) VALUES
(1, 'Moroleon'),
(2, 'Uriangato');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Entidad`
--

CREATE TABLE IF NOT EXISTS `Entidad` (
  `_idEntidad` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(200) NOT NULL,
  `descripcion` varchar(2000) NOT NULL,
  `url_logo` varchar(300) NOT NULL,
  `estatus` varchar(100) NOT NULL,
  `lat` varchar(500) NOT NULL,
  `lng` varchar(500) NOT NULL,
  `estacionamiento_carro` varchar(100) NOT NULL,
  `wifi` varchar(100) NOT NULL,
  `nivel_ruido` varchar(100) NOT NULL,
  `tarjetas` varchar(100) NOT NULL,
  `alcohol` varchar(100) NOT NULL,
  `tv` varchar(100) NOT NULL,
  `estacionamiento_moto` varchar(100) NOT NULL,
  `estacionamienot_bici` varchar(100) NOT NULL,
  `para_llevar` varchar(100) NOT NULL,
  `servicio_domicilio` varchar(100) NOT NULL,
  `direccion` varchar(2000) NOT NULL,
  `reservas` varchar(10) NOT NULL,
  `telefono` varchar(2000) NOT NULL,
  `facebook` varchar(2000) NOT NULL,
  `web_page` varchar(2000) NOT NULL,
  `id_tag` int(11) NOT NULL,
  `_idCiudad` int(100) NOT NULL,
  PRIMARY KEY (`_idEntidad`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `Entidad`
--

INSERT INTO `Entidad` (`_idEntidad`, `nombre`, `descripcion`, `url_logo`, `estatus`, `lat`, `lng`, `estacionamiento_carro`, `wifi`, `nivel_ruido`, `tarjetas`, `alcohol`, `tv`, `estacionamiento_moto`, `estacionamienot_bici`, `para_llevar`, `servicio_domicilio`, `direccion`, `reservas`, `telefono`, `facebook`, `web_page`, `id_tag`, `_idCiudad`) VALUES
(1, 'Ristorante Y Pizzeria KIKIS', 'PIZZERIA', 'logos/KIKIS.jpg', '1', '20.120237281182', '-101.18830919266', 'NO', 'SI', 'Bajo', 'NO', 'NO', 'SI', 'NO', 'NO', 'NO', 'SI', 'BLVD. PONCIANO VEGA No.679', 'NO', '4451451241', 'https://www.facebook.com/RISTORANTEYPIZZERIAKIKIS/', '', 0, 1),
(2, 'Ensaladas Girasol', 'ENSALADAS', 'logos/FLOR.png', '1', '20.1318439', '-101.1957652', 'NO', 'NO', 'ALTO', 'NO', 'NO', 'NO', 'NO', 'NO', 'SI', 'SI', 'LERDO DE TEJADA No.22', 'NO', '4451003269', '', '', 0, 1),
(3, 'PLAYA DEL MAR', 'OSTIONERIA', 'logos/playa del mar.jpg', '1', '20.13215', '-101.19971', 'NO', 'NO', 'BAJO', 'NO', 'SI', 'SI', 'NO', 'NO', 'SI', 'SI', 'Fco. Perez Baeza #55', 'NO', '445 458 6736', 'https://www.facebook.com/ostioneriaplayadelmar/', '', 0, 1),
(4, 'STANDARD', 'TORTAS', 'logos/Standard', '1', '20.1263818', '-101.1939699', 'NO', 'NO', 'ALTO', 'NO', 'NO', 'SI', 'NO', 'NO', 'SI', 'SI', 'SANTOS DEGOLLADO #2A', 'NO', '4451036972', 'https://www.facebook.com/profile.php?id=100015761419124&lst=100002345993913%3A100015761419124%3A1511656962', '', 0, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Entidad_Ciudad`
--

CREATE TABLE IF NOT EXISTS `Entidad_Ciudad` (
  `_id` int(100) NOT NULL AUTO_INCREMENT,
  `_idEntidad` int(100) NOT NULL,
  `_idCiudad` int(100) NOT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `Entidad_Ciudad`
--

INSERT INTO `Entidad_Ciudad` (`_id`, `_idEntidad`, `_idCiudad`) VALUES
(1, 1, 1),
(2, 2, 1),
(3, 3, 1),
(4, 4, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `favoritos`
--

CREATE TABLE IF NOT EXISTS `favoritos` (
  `_id` int(100) NOT NULL AUTO_INCREMENT,
  `_idEntidad` int(100) NOT NULL,
  `_idUsuario` int(100) NOT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci AUTO_INCREMENT=26 ;

--
-- Volcado de datos para la tabla `favoritos`
--

INSERT INTO `favoritos` (`_id`, `_idEntidad`, `_idUsuario`) VALUES
(6, 1, 2),
(3, 1, 1),
(4, 3, 2),
(7, 2, 2),
(8, 2, 1),
(9, 1, 5),
(10, 1, 2147483647),
(11, 4, 2147483647),
(12, 4, 2147483647),
(13, 4, 2147483647),
(14, 4, 2147483647),
(15, 4, 2147483647),
(16, 4, 2147483647),
(17, 4, 2147483647),
(18, 4, 2147483647),
(19, 4, 2147483647),
(20, 4, 2147483647),
(21, 4, 2147483647),
(22, 1, 2147483647),
(23, 1, 2147483647),
(24, 1, 2147483647),
(25, 1, 2147483647);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Horarios`
--

CREATE TABLE IF NOT EXISTS `Horarios` (
  `_id` int(100) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `abre` varchar(100) NOT NULL,
  `cierra` varchar(100) NOT NULL,
  `id_Entidad` int(100) NOT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=27 ;

--
-- Volcado de datos para la tabla `Horarios`
--

INSERT INTO `Horarios` (`_id`, `nombre`, `abre`, `cierra`, `id_Entidad`) VALUES
(1, 'Domingo', '12:00', '22:30', 1),
(2, 'Sabado', '12:00', '23:30', 1),
(3, 'Viernes', '12:00', '22:30', 1),
(4, 'Jueves', '12:00', '22:30', 1),
(5, 'Miercoles', '12:00', '22:30', 1),
(6, 'Martes', '12:00', '22:30', 1),
(7, 'Lunes', '12:00', '22:30', 1),
(8, 'Lunes', '9:00', '17:00', 2),
(9, 'Martes', '9:00', '17:00', 2),
(10, 'Miercoles', '9:00', '17:00', 2),
(11, 'Jueves', '9:00', '17:00', 2),
(12, 'Viernes', '9:00', '17:00', 2),
(13, 'Sabado', '9:00', '17:00', 2),
(14, 'Lunes', '11:00', '17:30', 3),
(15, 'Martes', '09:00', '17:00', 3),
(16, 'Miercoles', '09:00', '17:30', 3),
(17, 'Viernes', '10:00', '18:00', 3),
(18, 'Sabado', '09:00', '18:00', 3),
(19, 'Domingo', '10:00', '18:00', 3),
(20, 'Lunes', '8:00', '13:00', 4),
(21, 'Martes', '8:00', '13:00', 4),
(22, 'Miercoles', '8:00', '13:00', 4),
(23, 'Jueves', '8:00', '13:00', 4),
(24, 'Viernes', '8:00', '13:00', 4),
(25, 'Sabado', '8:00', '13:00', 4),
(26, 'Domingo', '8:00', '13:00', 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Imagenes`
--

CREATE TABLE IF NOT EXISTS `Imagenes` (
  `_id` int(100) NOT NULL AUTO_INCREMENT,
  `url` varchar(2000) COLLATE latin1_spanish_ci NOT NULL,
  `_id_entidad` int(100) NOT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci AUTO_INCREMENT=27 ;

--
-- Volcado de datos para la tabla `Imagenes`
--

INSERT INTO `Imagenes` (`_id`, `url`, `_id_entidad`) VALUES
(1, 'kikis1.jpg', 1),
(2, 'kikis2.jpg', 1),
(3, 'kikis3.jpg', 1),
(4, 'kikis4.jpg', 1),
(5, 'kikis5.jpg', 1),
(6, 'ensalada1.jpeg', 2),
(7, 'ensalada2.jpeg', 2),
(8, 'ensalada3.jpeg', 2),
(9, 'ensalada4.jpeg', 2),
(10, 'playamar1.jpg', 3),
(11, 'playamar2.jpg', 3),
(12, 'playamar3.jpg', 3),
(13, 'playamar4.jpg', 3),
(14, 'playamar5.jpg', 3),
(15, 'playamar6.jpg', 3),
(16, 'playamar7.jpg', 3),
(17, 'playamar8.jpg', 3),
(18, 'playamar9.jpg', 3),
(19, 'standard1', 4),
(20, 'standard2', 4),
(21, 'standard3', 4),
(22, 'standard4', 4),
(23, 'standard5', 4),
(24, 'standard6', 4),
(25, 'standard7', 4),
(26, 'standard8', 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `notificaciones`
--

CREATE TABLE IF NOT EXISTS `notificaciones` (
  `id` int(155) NOT NULL AUTO_INCREMENT,
  `titulo` varchar(1000) COLLATE latin1_spanish_ci NOT NULL,
  `cuerpo` varchar(1000) COLLATE latin1_spanish_ci NOT NULL,
  `icono` varchar(1000) COLLATE latin1_spanish_ci NOT NULL,
  `estatus` int(100) NOT NULL DEFAULT '1',
  `id_entidad` int(255) NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `notificaciones`
--

INSERT INTO `notificaciones` (`id`, `titulo`, `cuerpo`, `icono`, `estatus`, `id_entidad`, `fecha`) VALUES
(1, 'test', 'test', 'test', 1, 2, '2018-05-13 21:56:13'),
(2, 'test2', 'test', 'test', 1, 1, '2018-05-13 21:56:13');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Precios`
--

CREATE TABLE IF NOT EXISTS `Precios` (
  `id_precio` int(100) NOT NULL AUTO_INCREMENT,
  `precio` int(100) NOT NULL,
  `etiqueta` varchar(200) COLLATE latin1_spanish_ci NOT NULL,
  `id_producto` int(11) NOT NULL,
  PRIMARY KEY (`id_precio`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci AUTO_INCREMENT=54 ;

--
-- Volcado de datos para la tabla `Precios`
--

INSERT INTO `Precios` (`id_precio`, `precio`, `etiqueta`, `id_producto`) VALUES
(1, 35, 'Chica', 47),
(2, 45, 'Mediana', 47),
(3, 50, 'Grande', 47),
(4, 35, 'Chica', 48),
(5, 45, 'Mediana', 48),
(6, 50, 'Grande', 48),
(7, 35, 'Chica', 49),
(8, 45, 'Mediana', 49),
(9, 50, 'Grande', 49),
(10, 35, 'Chica', 50),
(11, 45, 'Mediana', 50),
(12, 50, 'Grande', 50),
(13, 35, 'Chica', 51),
(14, 45, 'Mediana', 51),
(15, 50, 'Grande', 51),
(16, 35, 'Chica', 52),
(17, 45, 'Mediana', 52),
(18, 50, 'Grande', 52),
(19, 35, 'Chica', 53),
(20, 45, 'Mediana', 53),
(21, 50, 'Grande', 53),
(22, 35, 'Chica', 54),
(23, 45, 'Mediana', 54),
(24, 50, 'Grande', 54),
(25, 35, 'Chica', 55),
(26, 45, 'Mediana', 55),
(27, 50, 'Grande', 55),
(28, 35, 'Chica', 56),
(29, 45, 'Mediana', 56),
(30, 50, 'Grande', 56),
(31, 35, 'Chica', 57),
(32, 45, 'Mediana', 57),
(33, 50, 'Grande', 57),
(34, 45, 'CHICA', 58),
(35, 65, 'GRANDE', 58),
(36, 45, 'CHICA', 59),
(37, 65, 'GRANDE', 59),
(38, 35, 'CHICA', 60),
(39, 50, 'GRANDE', 60),
(40, 35, 'CHICA', 61),
(41, 50, 'GRANDE', 61),
(42, 70, 'CHICA', 62),
(43, 100, 'GRANDE', 62),
(44, 45, 'CHICA', 68),
(45, 65, 'GRANDE', 68),
(46, 45, 'CHICA', 69),
(47, 65, 'GRANDE', 69),
(48, 40, 'CHICA', 70),
(49, 60, 'GRANDE', 70),
(50, 45, 'CHICA', 71),
(51, 65, 'GRANDE', 71),
(52, 45, 'CHICA', 72),
(53, 65, 'GRANDE', 72);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Productos`
--

CREATE TABLE IF NOT EXISTS `Productos` (
  `_id` int(255) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(2000) NOT NULL,
  `imagen` varchar(2000) NOT NULL,
  `desc` varchar(2000) NOT NULL,
  `precio` varchar(2000) NOT NULL,
  `id_Entidad` int(255) NOT NULL,
  `categoria` varchar(100) NOT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=104 ;

--
-- Volcado de datos para la tabla `Productos`
--

INSERT INTO `Productos` (`_id`, `nombre`, `imagen`, `desc`, `precio`, `id_Entidad`, `categoria`) VALUES
(1, 'PIZZA CALZONE', 'null', 'ALGUSTO', '50', 1, '1'),
(2, 'PIZZA CARNES FRIAS', 'null', 'JAMON, SALCHICHA, PEPPERONI, CARNE MOLIDA', '120', 1, '1'),
(3, 'KIKIS COMBINADA', 'null', 'JAMON, SALCHICHA, PEPPERONI, CHORIZO, CHILE, MORRON, CHAMPIÑONES Y CEBOLLA', '130', 1, '1'),
(4, 'PIZZA ITALIANA', 'null', 'CARNE MOLIDA, PEPPERONI, CHAMPIÑONES, CHILE, MORRON Y CEBOLLA', '130', 1, '1'),
(5, 'HAWAIIANA', 'null', 'PIÑA, JAMON, SALCHICHA', '120', 1, '1'),
(6, 'PIZZA JALAPEÑA', 'null', 'CHORIZO, CARNE MOLIDA, CHILE MORRON, CEBOLLA Y JALAPEÑOS', '130', 1, '1'),
(7, 'PIZZA BBQ', 'null', 'QUESO MOZARELA, POLLO A LA PARRILLA, SALSA BBQ, CEBOLLA ROJA Y CILANTRO', '130', 1, '1'),
(8, 'PIZZA A LA ENSALATA', 'null', 'QUESO, PECHUGA DE POLLO, TOCINO Y UN TOPIN DE LECHUGA, AGUACATE, JITOMATE Y MAYONESA', '120', 1, '1'),
(9, 'PIZZA DE ARRACHERA', 'null', 'SALSA DE CILANTRO, QUESO, CEBOLLA, ARRACHERA, CHILE POBLANO Y TOPIN DE PICO DE GALLO Y SALSA DE TOMATILLO', '120', 1, '1'),
(10, 'PIZZA MAR Y TIERRA', 'null', 'QUESO, CAMARONES A LA PARRILLA, TOCINO, CEBOLLA Y CHILE MORRON', '120', 1, '1'),
(11, 'PIZZA 5 QUESOS', 'null', 'QUESO MOZARELLA, QUESO ASADERO, QUESO PARMESANO, QUESO MONTERREY Y QUESO GOUDA Y REBANADAS DE JITOMATE', '120', 1, '1'),
(12, 'PIZZA TOSTADA', 'null', 'FRIJOL NEGRO, QUESO MONTERREY, PECHUGA DE POLLO, ACOMPAÑADA CON UN TOPIN DE LECHUGA, TOSTADITAS, PICO DE GALLO Y ADEREZO RANCH', '120', 1, '1'),
(13, 'DE LA CASA', 'null', 'PECHUGA DE POLLO A LA PARRILLA, LECHUGA ITALIANA, ROMANA CON FRUTAS, TOCINO FRITO, QUESO AZUL, JITOMATE Y AGUACATE', '70', 1, '2'),
(14, 'ESPECIALIDAD DEL CHEF', 'null', 'COMBINACION DE LECHUGA FRESCA, ACOMPAÑADA DE NUECES CARAMELIZADAS, APIO, MANZANA, UVAS Y QUESO CON UN RICO ADEREZO DE LA CASA Y POLLO A LA PARRILLA', '70', 1, '2'),
(15, 'CESAR', 'null', 'POLLO A LA PARRILLA $70........ CON CAMARONES $90', '70', 1, '2'),
(47, 'INN', 'null', 'AGUACATE, PEPINO, QUESO PANELA, PAPA, COLIFLOR, BETABEL, JITOMATE, BROCOLI, ACEITUNAS, GERMEN DE ALFALFA, EJOTE, ELOTITOS CAMBRAY, CHILE MORRON, APIO, LECHUGA OREJONA Y ROMANA\n', '', 2, '2'),
(16, 'HAWAIANA', 'null', 'LECHUGA FRESCA, JAMON, PIÑA, SALCHICHA,TOCINO CRUJIENTE, ACOMPAÑADA CON ADEREZO CESAR RANCHERO O VINAGRETA', '70', 1, '2'),
(17, 'ENSALADA A LA DIABLA', 'null', 'LECHUGA ROMANA, AGUACATE, JITOMATE, CEBOLLA ROJA Y RICOS CAMARONES', '100', 1, '2'),
(18, 'ENSALADA DE FRUTAS', 'null', 'LECHUGA ROMANA, MELON, PAPAYA, UVAS, KIWI, JICAMA, AGUACATE, TORONJA, DEREZA, ADERESO, ACEITE DE OLIVO AL LIMON', '70', 1, '2'),
(19, 'ENSALADA A LA BBQ', 'null', 'LECHUGA ROMANA, JICAMA, QUESO MOZARELLA, FRIJOL NEGRO, ELOTE, JITOMATE Y PECHUGA DE POLLO A LA BBQ', '70', 1, '2'),
(20, 'KUNG PAO', 'null', 'CON POLLO $90.....COMBINADO CAMARON $130', '90', 1, '3'),
(21, 'MARINERA', 'null', 'CON POLLO $90.....COMBINADO CAMARON $130', '90', 1, '3'),
(22, 'ALFREDO', 'null', 'CON POLLO $90.....COMBINADO CAMARON $130', '90', 1, '3'),
(23, 'BOLOÑESA', 'null', 'SALCHICHA ITALIANA, CHAMPIÑONES, ACOMPAÑADA CON SU RICA SALSA CASERA EN HORNO DE LEÑA', '80', 1, '3'),
(24, 'LASAGNA ITALIANA', 'null', 'TODAS LAS PASTAS VIENEN ACOMPAÑADAS CON UN RICO PAN COCINADO EN HORNO DE LEÑA', '80', 1, '3'),
(25, 'ESPAGHETI FRUTTI DE MARE', 'null', 'ACEITE DE OLIVO, AJO, MEJILLONES, CALAMAR, PULPO Y PESCADO', '110', 1, '3'),
(26, 'RAVIOLES', 'null', 'SALSA MARINERA O ALFREDO', '90', 1, '3'),
(27, 'AL TEQUILA', 'null', 'CREMOSA SALSA AL TEQUILA, ACOMPAÑADA CON CHILE MORRON, POLLO Y CEBOLLA ROJA $90...... COMBINADO $130', '90', 1, '3'),
(28, 'LASAGNA DE ESPINACAS', 'null', 'SALSA BLANCA, ESPINACA, QUESO Y PASTA', '80', 1, '3'),
(29, 'CESAR', 'null', 'POLLO A LA PARRILLA, LECHUGA ROMANA, QUESO PARMESANO, JITOMATE, CEBOLLA Y ADEREZO CESAR', '50', 1, '4'),
(30, 'ITALIANO', 'null', 'SALCHICHA ITALIANA, VEGETALES A LA PARRILLA CON QUESO ASADERO', '50', 1, '4'),
(31, 'DE ARRACHERA', 'null', 'ARRACHERA A LA PARRILLA, JITOMATE, CEBOLLA, LECHUGA Y QUESO ASADERO', '60', 1, '4'),
(32, 'TAKIROS PIZZA', 'null', 'TAKIROS PIZZA', '55', 1, '5'),
(33, 'ALITAS DE POLLO', 'null', '6 PIEZAS A LA BBQ O PICOSAS', '60', 1, '5'),
(34, 'PAPAS A LA FRANCESA', 'null', 'PAPAS A LA FRANCESA', '15', 1, '5'),
(35, 'CHICKEN BAKE', 'null', 'POLLO, CEBOLLA Y TOCINO', '60', 1, '5'),
(36, 'DEDOS DE QUESO', 'null', 'DEDOS DE QUESO', '60', 1, '5'),
(37, 'GUACAMOLE CON TOTOPOS', 'null', 'GUACAMOLE CON TOTOPOS', '60', 1, '5'),
(38, 'QUESO FUNDIDO A LA CAMPECHANA', 'null', 'QUESO FUNDIDO A LA CAMPECHANA', '75', 1, '5'),
(39, 'QUESO FUNDIDO', 'null', 'QUESO FUNDIDO', '60', 1, '5'),
(40, 'CLASICA', 'null', 'CARNE DE RES, SAZON DE CASA, LECHUGA, QUESO AMARILLO, JITOMATE, CEBOLLA, PEPINILLO, CHILES EN VINAGRE Y MAYONESA', '35', 1, '6'),
(41, 'DE LA CASA', 'null', 'CARNE DE RES, SAZON DE CASA, QUESO AMARILLO, PIÑA, SALCHICHA, JAMON, QUESO ASADERO, LECHUGA, JITOMATE, CEBOLLA, PEPINILLOS, CHILES EN VINAGRE Y MAYONESA', '40', 1, '6'),
(42, 'DE POLLO', 'null', 'LECHUGA, JITOMATE, CEBOLLA, PEPINILLO Y CHILE EN VINAGRE', '40', 1, '6'),
(43, 'ESPECIAL KIKIS', 'null', 'CARNE DE RES, SAZON DE CASA, TOCINO, VEGETALES A LA PARRILLA, QUESO ASADERO Y MAYONESA AL CHILE CHIPOTLE', '45', 1, '6'),
(44, 'MEXICANA', 'null', 'CARNE DE RES, PICO DE GALLO, QUESO ASADERO Y AGUACATE', '45', 1, '6'),
(45, 'PARRILLADA', 'null', 'CAMARON, ARRACHERA, POLLO, SALCHICHA, CHORIZO, CHILE GUERO, CEBOLLITAS, NOPALITOS, FRIJOLES ACOMPAÑADOS CON UN RICO GUACAMOLE', '140', 1, '7'),
(46, 'ARRACHERA', 'null', 'ACOMPAÑADA CON QUESO FUNDIDO, SALCHICHA, FRIJOLES Y ENSALADA', '120', 1, '7'),
(48, 'PRIMAVERA', 'null', 'NARANJA, PIÑA, PEPINO, JICAMA, JITOMATE, AGUACATE, ZANAHORIA, AJONJOLI, LECHUGA OREJONA Y ROMANA', '', 2, '2'),
(49, 'ATUN', 'null', 'COMBINACION DE LECHUGA OREJONA Y ROMANA, JICAMA, ZANAHORIA, PEPINO Y AGUACATE', '', 2, '2'),
(50, 'MARINERA CON', 'null', 'CAMARON, PEPINO, JICAMA, JITOMATE, AGUACATE, ZANAHORIA, LECHUGA OREJONA Y ROMANA, ADEREZO, CHIMICHURRY Y CATSUP', '', 2, '2'),
(51, 'GREEN', 'null', 'AGUACATE, PEPINO, BROCOLI, ACEITUNAS, GERMEN DE ALFALFA, AJONJOLI, CHICHAROS, EJOTES, APIO, LECHUGA OREJONA Y ROMANA', '', 2, '2'),
(52, 'TROPICAL', 'null', 'PEPINO, JICAMA, BETABEL, PIÑA, NARANJA, AGUACATE, LECHUGA OREJONA Y ROMANA', '', 2, '2'),
(53, 'SUIZA', 'null', 'COMBINACION DE QUESO AMARILLO, COTEGE, PANELA, MANCHEGO, JICAMA, PEPINO, AGUACATE, ZANAHORIA, JITOMATE, LECHUGA OREJONA Y ROMANA', '', 2, '2'),
(54, 'EUROPEA', 'null', 'PECHUGA DE POLLO MARINADA, JAMON DE PAVO, SALCHICHA DE PAVO, JITOMATE, QUESO PANELA, PEPINO, AGUACATE, ZANAHORIA, LECHUGA OREJONA Y ROMANA', '', 2, '2'),
(55, 'FRUTAL', 'null', 'LECHUGA ROMANA Y OREJONA, ZANAHORIA, MANZANA, NARANJA, APIO, NUEZ Y BETABEL', '', 2, '2'),
(56, 'SURIMI', 'null', 'LECHUGA ROMANA Y OREJONA, JITOMATE, PEPINO, APIO, JICAMA, AGUACATE,SURIMI, GERMEN DE ALFALFA, ACEITUNA, SEMILLA DE ALFALFA', '', 2, '2'),
(57, 'POLLO', 'null', 'LECHUGA ROMANA Y OREJONA, PIMIENTO, MORRON, PAPA CAMBRAY, POLLO JARDINERA, JICAMA, ZANAHORIA, QUESO PANELA, AGUACATE, NARANJA, ACEITUNAS, AJONJOLI', '', 2, '2'),
(58, 'ENSALADA CAMARON', 'null', '', '45', 3, '2'),
(59, 'ENSALADA PULPO', 'null', '', '45', 3, '2'),
(60, 'ENSALADA JAIBA', 'null', '', '35', 3, '2'),
(61, 'ENSALADA CEVICHE', 'null', '', '35', 3, '2'),
(62, 'ENSALADA MIXTA', 'null', '', '70', 3, '2'),
(63, 'TOSTADAS CAMARON', 'null', '', '35', 3, '10'),
(64, 'TOSTADAS PULPO', 'null', '', '35', 3, '10'),
(65, 'TOSTADAS JAIBA', 'null', '', '10', 3, '10'),
(66, 'TOSTADAS CEVICHE', 'null', '', '10', 3, '10'),
(67, 'TOSTADAS MIXTA', 'null', '', '30', 3, '10'),
(68, 'COCTELE CAMARON', 'null', '', '45', 3, '11'),
(69, 'COCTELE PULPO', 'null', '', '45', 3, '11'),
(70, 'COCTELE OSTION', 'null', '', '40', 3, '11'),
(71, 'COCTELE CAMPECHANO', 'null', '', '45', 3, '11'),
(72, 'COCTELE CANCUN', 'null', '', '45', 3, '11'),
(73, 'COCTELE CHAVELA', 'null', '', '80', 3, '11'),
(74, 'COCTELE BALITA', 'null', '', '10', 3, '11'),
(75, 'FILETE EMPANIZADO', 'null', '', '50', 3, '9'),
(76, 'FILETE A LA DIABLA', 'null', '', '50', 3, '9'),
(77, 'FILETE AL MOJO DE AJO', 'null', '', '50', 3, '9'),
(78, '1/2 FILETE', 'null', '', '35', 3, '9'),
(79, 'ESPECIALIDAD PLAYA DEL MAR', 'null', '', '110', 3, '13'),
(80, 'ESPECIALIDAD PULPO A LA DIABLA', 'null', '', '60', 3, '13'),
(81, 'ESPECIALIDAD LA VOLTEADA', 'null', '', '55', 3, '13'),
(82, 'ESPECIALIDAD HUACHINANGO', 'null', '', '', 3, '13'),
(83, 'ESPECIALIDAD SALMON', 'null', '', '60', 3, '13'),
(84, 'CAMARONES A LA DIABLA', 'null', '', '60', 3, '8'),
(85, 'CAMARONES EMPANIZADOS', 'null', '', '60', 3, '8'),
(86, 'CAMARONES AL MOJO DE AJO', 'null', '', '60', 3, '8'),
(87, 'CAMARONES 3X3', 'null', '', '110', 3, '8'),
(88, 'CALDO DE PESCADO', 'null', '', '', 3, '12'),
(89, 'CALDO DE CAMARON', 'null', '', '55', 3, '12'),
(90, 'SOPA DE MARISCOS', 'null', '', '55', 3, '12'),
(91, 'CONSOME', 'null', '', '15', 3, '12'),
(92, 'MILANESA', 'null', 'ALGUSTO', '', 4, '14'),
(93, 'LOMO', 'null', 'ALGUSTO', '', 4, '14'),
(94, 'CHULETA', 'null', 'ALGUSTO', '', 4, '14'),
(95, 'CHORIQUESO', 'null', 'ALGUSTO', '', 4, '14'),
(96, 'POLLO', 'null', 'ALGUSTO', '', 4, '14'),
(97, 'SALCHICHA', 'null', 'ROJA/PAVO', '', 4, '14'),
(98, 'Q-PUERCO', 'null', 'ALGUSTO', '', 4, '14'),
(99, 'JAMON', 'null', 'ALGUSTO', '', 4, '14'),
(100, 'NATIONAL PORK', 'null', 'ALGUSTO', '', 4, '14'),
(101, 'STANDARD', 'null', 'ALGUSTO', '', 4, '14'),
(102, 'BALLENA', 'null', 'ALGUSTO', '', 4, '14'),
(103, 'HAWAIANA', 'null', 'ALGUSTO', '', 4, '14');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Promociones`
--

CREATE TABLE IF NOT EXISTS `Promociones` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `idProducto` int(255) NOT NULL,
  `descrip` varchar(2000) NOT NULL,
  `tipo` varchar(100) NOT NULL,
  `descuento` varchar(100) NOT NULL,
  `estatus` varchar(100) NOT NULL,
  `contador` varchar(2000) NOT NULL,
  `codigo` varchar(2000) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Tags`
--

CREATE TABLE IF NOT EXISTS `Tags` (
  `id_tag` int(100) NOT NULL AUTO_INCREMENT,
  `tag` varchar(2000) COLLATE latin1_spanish_ci NOT NULL,
  `id_entidad` int(100) NOT NULL,
  PRIMARY KEY (`id_tag`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci AUTO_INCREMENT=27 ;

--
-- Volcado de datos para la tabla `Tags`
--

INSERT INTO `Tags` (`id_tag`, `tag`, `id_entidad`) VALUES
(1, 'pizza', 1),
(2, 'pitza', 1),
(3, 'picza', 1),
(4, 'pitza', 1),
(5, 'pitsa', 1),
(6, 'picsa', 1),
(7, 'piza', 1),
(8, 'ensaladas', 2),
(9, 'enzaladas', 2),
(10, 'ensalada', 2),
(11, 'enzalada', 2),
(12, 'encaladas', 2),
(13, 'encalada', 2),
(14, 'enxaladas', 2),
(15, 'enxalada', 2),
(16, 'ostioneria', 3),
(17, 'oztioneria', 3),
(18, 'pescado', 3),
(19, 'camarones', 3),
(20, 'mariscos', 3),
(21, 'playa del mar', 3),
(22, 'kikis', 1),
(23, 'standard', 3),
(24, 'torta', 3),
(25, 'tortas', 3),
(26, 'burritos', 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE IF NOT EXISTS `usuarios` (
  `_id` int(100) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(2000) COLLATE latin1_spanish_ci NOT NULL,
  `correo` varchar(2000) COLLATE latin1_spanish_ci NOT NULL,
  `pass` varchar(2000) COLLATE latin1_spanish_ci NOT NULL,
  `status` int(100) DEFAULT '1',
  `hash` varchar(32) COLLATE latin1_spanish_ci NOT NULL,
  `url_profile` varchar(2000) COLLATE latin1_spanish_ci NOT NULL,
  `url_cover` varchar(2000) COLLATE latin1_spanish_ci NOT NULL,
  `token_id` varchar(2500) COLLATE latin1_spanish_ci NOT NULL,
  `id_facebook` varchar(1000) COLLATE latin1_spanish_ci NOT NULL,
  PRIMARY KEY (`_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci AUTO_INCREMENT=11 ;

CREATE TABLE IF NOT EXISTS users (
`_id` int(100) NOT NULL AUTO_INCREMENT,
`correo` varchar(100) not null,
`contrasena` varchar(100) not null,
`nombre` varchar(100) not null,
`apellidos` varchar(200) not null,
`telefono` varchar(20) not null,
`ciudad` varchar(100) not null,
PRIMARY KEY (`_id`)
);
--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`_id`, `nombre`, `correo`, `pass`, `status`, `hash`, `url_profile`, `url_cover`, `token_id`, `id_facebook`) VALUES
(10, 'Yessenia Lemus Orozco', 'lemusyess@gmail.com', '', 1, '', '', '', 'cBmTehUh9GE:APA91bH4x_4g1fK8iiV33-hj7Np983u73eFGdwYjgDGtf8V-EkQWRlm8W9Wohw9QqulPuvXwxQvW9_hQ63H6eMiJy3KLNNt-oENkRQYvMebbS-U2-ry5bfxgZzI7CYJKVQNkzVEEnlbP', '1698574396874642'),
(9, 'Mane Guzman', 'mane_0916@hotmail.com', '', 1, '', '', '', 'dmNYjk8iryo:APA91bHF02IArz835rj1lTypOFZR3U1g1NXuxBOzXy7u0sJmO5W5j8WINTFM99AMrbGFmmx8vhVUYa_byo9TF2Z3hPXAUAW-qZfShARnQTXkPSbIWPkrzh5g7w4lsOlt_mAe34hTm9OP', '1676151699139680'),
(8, 'Juvee Aguado Reyes', 'juve.ncx@icloud.com', '', 1, '', '', '', 'cW3xR34FN1g:APA91bFvxYFoQtFRg-VFIZfCVPFsjCzXKXIqYWp1YyqDgwi8GFsdHqQWd7UUeJEv1AAjxXho7h81cdsXHDkYSdA4TPfQ_Riw4GznfjzXorsOk3_en3eclr7KzR6aVH8XxjLzBDLIlgL2', '369079033589692');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios_v2`
--

CREATE TABLE IF NOT EXISTS `usuarios_v2` (
  `id_facebook` varchar(1000) COLLATE latin1_spanish_ci NOT NULL DEFAULT '',
  `user_name` varchar(1000) COLLATE latin1_spanish_ci DEFAULT NULL,
  `token_id` varchar(1000) COLLATE latin1_spanish_ci DEFAULT NULL,
  `correo` varchar(1000) COLLATE latin1_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_facebook`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
