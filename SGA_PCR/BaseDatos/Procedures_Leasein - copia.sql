DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_categoria`(
	IN _nombre NVARCHAR(80),
	IN _subCategoria NVARCHAR(80),
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO categoria (nombre,subCategoria,estado,usuario_ins) values
	(_nombre,_subCategoria,1,_usuario_ins);
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_marca`(
	IN _nombre NVARCHAR(80),
	IN _idCategoria INT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO marca (nombre,idCategoria,estado,usuario_ins) values
	(_nombre,_idCategoria,1,_usuario_ins);
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_modelo`(
	IN _nombre NVARCHAR(80),
	IN _idMarca INT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO modelo (nombre,idMarca,estado,usuario_ins) values
	(_nombre,_idMarca,1,_usuario_ins);
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_procesador`(
	IN _idModelo INT,
	IN _idGeneracion INT,
	IN _generacion INT,
	IN _idVelocidad INT,
	IN _velocidad NVARCHAR(20),
	IN _idVelocidadMax INT,
	IN _velocidadMax DOUBLE,
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100), 
	OUT _idProcesador INT
)
BEGIN
	
	SET @codigo=(SELECT CONCAT("PRO-",MAX(idProcesador)+1) from procesador);
	INSERT INTO procesador (codigo,idModelo,idGeneracion,generacion,idVelocidad,velocidad,idVelocidadMax,velocidadMax,observacion,estado,usuario_ins) values
	(@codigo,_idModelo,_idGeneracion,_generacion,_idVelocidad,_velocidad,_idVelocidadMax,_velocidadMax,_observacion,1,_usuario_ins);
	COMMIT;
    SET _idProcesador = last_insert_id();
	
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_video`(
	IN _idModelo INT,
	IN _idCapacidad INT,
	IN _capacidad DOUBLE,
	IN _idTipo INT,
	IN _tipo NVARCHAR(20),
	IN _cantidad INT,
	IN _ubicacion NVARCHAR(80),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100), 
	OUT _idVideo INT
)
BEGIN
	SET @codigo=(SELECT CONCAT("VID-",MAX(idVideo)+1) from video);
	INSERT INTO video (codigo,idModelo,idCapacidad,capacidad,idTipo,tipo,cantidad,ubicacion,observacion,estado,usuario_ins) values
	(@codigo,_idModelo,_idCapacidad,_capacidad,_idTipo,_tipo,_cantidad,_ubicacion,_observacion,1,_usuario_ins);
	COMMIT;
    SET _idVideo = last_insert_id();
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_memoria`(
	IN _idModelo INT,
	IN _idBusFrecuencia INT,
	IN _busFrecuencia DOUBLE,
	IN _idCapacidad INT,
	IN _capacidad DOUBLE,
	IN _idTipo INT,
	IN _tipo NVARCHAR(20),
	IN _cantidad INT,
	IN _ubicacion NVARCHAR(80),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100), 
	OUT _idMemoria INT
)
BEGIN
	SET @codigo=(SELECT CONCAT("MEM-",MAX(idMemoria)+1) from memoria);
	INSERT INTO memoria (codigo,idModelo,idBusFrecuencia,busFrecuencia,idCapacidad,capacidad,idTipo,tipo,cantidad,ubicacion,observacion,estado,usuario_ins) values
	(@codigo,_idModelo,_idBusFrecuencia,_busFrecuencia,_idCapacidad,_capacidad,_idTipo,_tipo,_cantidad,_ubicacion,_observacion,1,_usuario_ins);
	COMMIT;
    SET _idMemoria = last_insert_id();
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_disco_duro`(
	IN _idModelo INT,
	IN _idTamano INT,
	IN _tamano DOUBLE,
	IN _idCapacidad INT,
	IN _capacidad DOUBLE,
	IN _cantidad INT,
	IN _ubicacion NVARCHAR(80),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100), 
	OUT _idDiscoDuro INT
)
BEGIN
	SET @codigo=(SELECT CONCAT("DIS-",MAX(idDisco)+1) from disco_duro);
	INSERT INTO disco_duro (codigo,idModelo,idTamano,tamano,idCapacidad,capacidad,cantidad,ubicacion,observacion,estado,usuario_ins) values
	(@codigo,_idModelo,_idTamano,_tamano,_idCapacidad,_capacidad,_cantidad,_ubicacion,_observacion,1,_usuario_ins);
	COMMIT;
    SET _idDiscoDuro = last_insert_id();
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_disco_duro`(
	IN _idDisco INT,
	IN _idModelo INT,
	IN _idTamano INT,
	IN _tamano DOUBLE,
	IN _idCapacidad INT,
	IN _capacidad DOUBLE,
	IN _estado INT,
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fec_mod=(SELECT now());
	UPDATE disco_duro
	SET idModelo=_idModelo,
		idTamano=_idTamano,
		tamano=_tamano,
		idCapacidad=_idCapacidad,
		capacidad=_capacidad,
		estado=_estado,
		fec_mod=@fec_mod,
		usuario_mod=_usuario_mod
	WHERE idDisco=_idDisco;
	COMMIT;
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_laptop_cpu`(
	IN _idModelo INT,
	IN _descripcion DOUBLE,
	IN _tamanoPantalla DOUBLE,
	IN _idProcesador INT,
	IN _idVideo INT,
	IN _partNumber NVARCHAR(80),
	IN _serieFabrica NVARCHAR(80),
	IN _garantia TINYINT,
	IN _fecInicioSeguro DATETIME,
	IN _fecFinSeguro DATETIME,
	IN _ubicacion NVARCHAR(80),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100), 
	OUT _idLC INT
)
BEGIN
	SET @codigo=(SELECT CONCAT("PCR-LAP",IFNULL( MAX( idLC ) , 0 )+1) from laptop_cpu);
	INSERT INTO laptop_cpu (codigo,idModelo,descripcion,tamanoPantalla,idProcesador,idVideo,partNumber,serieFabrica,garantia,fecInicioSeguro,fecFinSeguro,ubicacion,observacion,estado,usuario_ins) values
	(@codigo,_idModelo,_descripcion,_tamanoPantalla,_idProcesador,_idVideo,_partNumber,_serieFabrica,_garantia,_fecInicioSeguro,_fecFinSeguro,_ubicacion,_observacion,2,_usuario_ins);
	COMMIT;
    SET _idLC = last_insert_id();
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_seguro_laptop_cpu`(
	IN _idLC INT,
	IN _fecInicioSeguro DATETIME,
	IN _fecFinSeguro DATETIME,
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fec_mod=(NOW());
	INSERT INTO laptop_cpu (idLC,fecInicioSeguro,fecFinSeguro,fec_mod,usuario_mod) values
	(_idLC,_fecInicioSeguro,_fecFinSeguro,@fec_mod,_usuario_mod);
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_memoria_LC`(
	IN _idMemoria INT,
	IN _idLC INT,
	IN _cantidad INT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO memoria_LC (idMemoria,idLC,cantidad,usuario_ins) values
	(_idMemoria,_idLC,_cantidad,_usuario_ins);
END
$$ DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_disco_LC`(
	IN _idDisco INT,
	IN _idLC INT,
	IN _cantidad INT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO disco_LC (idDisco,idLC,cantidad,usuario_ins) values
	(_idMemoria,_idLC,_cantidad,_usuario_ins);
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_licencia`(
	IN _idModelo INT,
	IN _idLC INT,
	IN _clave NVARCHAR(80), 
	IN _fechaActivacion DATETIME, 
	IN _ubicacion NVARCHAR(80),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	SET @codigo=(SELECT CONCAT("LIC-",MAX(idLicencia)+1) from licencia);
	INSERT INTO licencia (codigo,idModelo,idLC,clave,fechaActivacion,ubicacion,observacion,estado,usuario_ins) values
	(@codigo,_idModelo,_idLC,_clave,_fechaActivacion,_ubicacion,_observacion,2,_usuario_ins);
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_cliente`(
	IN _tipoDocumento INT,
	IN _nroDocumento NVARCHAR(20),
	IN _nombre_razonSocial NVARCHAR(255),
	IN _telefono NVARCHAR(20),
	IN _email NVARCHAR(255),
	IN _idKAM INT,
	IN _nombreKam NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100), 
	OUT _idCliente INT
)
BEGIN
	SET @idCliente=(SELECT IFNULL( MAX( idCliente ) , 0 )+1 FROM cliente);
	INSERT INTO cliente (idCliente,tipoDocumento,nroDocumento,nombre_razonSocial,telefono,email,idKAM,nombreKam,estado,usuario_ins) values
	(@idCliente,_tipoDocumento,_nroDocumento,_nombre_razonSocial,_telefono,_email,_idKAM,_nombreKam,1,_usuario_ins);
	COMMIT;
    SET _idCliente = @idCliente;
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_cliente`(
	IN _idCliente INT,
	IN _tipoDocumento INT,
	IN _nroDocumento NVARCHAR(20),
	IN _nombre_razonSocial NVARCHAR(255),
	IN _telefono NVARCHAR(20),
	IN _email NVARCHAR(255),
	IN _idKAM INT,
	IN _nombreKam NVARCHAR(255),
	IN _estado INT,
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fec_mod=(SELECT now());
	UPDATE cliente
	SET tipoDocumento=_tipoDocumento,
		nroDocumento=_nroDocumento,
		nombre_razonSocial=_nombre_razonSocial,
		telefono=_telefono,
		email=_email,
		idKAM=_idKAM,
		nombreKam=_nombreKam,
		estado=_estado,
		fec_mod=@fec_mod,
		usuario_mod=_usuario_mod
	WHERE idCliente=_idCliente;
	COMMIT;
END
$$ DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_proveedor`(
	IN _ruc NVARCHAR(11),
	IN _razonSocial NVARCHAR(255),
	IN _nombreComercial NVARCHAR(255),
	IN _abreviacion NVARCHAR(11),
	IN _direccion NVARCHAR(255),
	IN _telefono NVARCHAR(20),
	IN _fax NVARCHAR(20),
	IN _email NVARCHAR(255),
	IN _observacion NVARCHAR(255),
	IN _nombreContacto NVARCHAR(255),
	IN _telefonoContacto NVARCHAR(255),
	IN _emailContacto NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100), 
	OUT _idProveedor INT
)
BEGIN
	INSERT INTO proveedor (ruc,razonSocial,nombreComercial,abreviacion,direccion,telefono,fax,email,observacion,nombreContacto,telefonoContacto,emailContacto,estado,usuario_ins) values
	(_ruc,_razonSocial,_nombreComercial,_abreviacion,_direccion,_telefono,_fax,_email,_observacion,_nombreContacto,_telefonoContacto,_emailContacto,1,_usuario_ins);
	COMMIT;
    SET _idProveedor = last_insert_id();
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_proveedor`(
	IN _idProveedor INT,
	IN _ruc NVARCHAR(11),
	IN _razonSocial NVARCHAR(255),
	IN _nombreComercial NVARCHAR(255),
	IN _abreviacion NVARCHAR(11),
	IN _direccion NVARCHAR(255),
	IN _telefono NVARCHAR(20),
	IN _fax NVARCHAR(20),
	IN _email NVARCHAR(255),
	IN _observacion NVARCHAR(255),
	IN _nombreContacto NVARCHAR(255),
	IN _telefonoContacto NVARCHAR(255),
	IN _emailContacto NVARCHAR(255),
	IN _estado INT,
	IN _usuario_mod NVARCHAR(100)
)
BEGIN
	SET @fec_mod=(SELECT now());
	UPDATE proveedor
	SET ruc=_ruc,
		razonSocial=_razonSocial,
		nombreComercial=_nombreComercial,
		abreviacion=_abreviacion,
		direccion=_direccion,
		telefono=_telefono,
		fax=_fax,
		email=_email,
		observacion=_observacion,
		nombreContacto=_nombreContacto,
		telefonoContacto=_telefonoContacto,
		emailContacto=_emailContacto,
		estado=_estado,
		fec_mod=@fec_mod,
		usuario_mod=_usuario_mod
	WHERE idProveedor=_idProveedor;
	COMMIT;
END
$$ DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_usuario`(
	IN _dni NVARCHAR(8),
	IN _nombre NVARCHAR(255),
	IN _usuario NVARCHAR(20),
	IN _password NVARCHAR(255),
    IN _perfil INT,
	IN _email NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO usuario (dni,nombre,usuario,password,perfil,estado,email,usuario_ins) values
	(_dni,_nombre,_usuario,_password,_perfil,1,_email,_usuario_ins);
END
$$ DELIMITER ;




DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_cliente_sucursal`(
	IN _idCliente INT,
	IN _nroDocumento NVARCHAR(100),
	IN _nombreContacto NVARCHAR(100),
	IN _direccion NVARCHAR(255),
	IN _telefono NVARCHAR(20),
	IN _email NVARCHAR(255),
	IN _observacion NVARCHAR(255),
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO cliente_sucursal (idCliente,nroDocumento,nombreContacto,direccion,telefono,email,observacion,estado,usuario_ins) values
	(_idCliente,_nroDocumento,_nombreContacto,_direccion,_telefono,_email,_observacion,1,_usuario_ins);
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_cliente_contacto`(
	IN _nombre NVARCHAR(100),
	IN _idSucursal INT,
	IN _email NVARCHAR(255),
	IN _telefono NVARCHAR(20),
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO cliente_contacto (nombre,idSucursal,email,telefono,estado,usuario_ins) values
	(_nombre,_idSucursal,_email,_telefono,1,_usuario_ins);
END
$$ DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_requerimiento_compra`(
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO requerimiento_compra (observacion,estado,usuario_ins) values
	(_observacion,_estado,_usuario_ins);
END
$$ DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_orden_compra`(
	IN _idRO INT,
	IN _idProveedor INT,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO orden_compra (idRO,idProveedor,observacion,estado,usuario_ins) values
	(_idRO,_idProveedor,_observacion,_estado,_usuario_ins);
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_ingreso`(
	IN _idOC INT,
	IN _fecIngresa DATETIME,
	IN _facturaIngreso NVARCHAR(255),
	IN _guiaIngreso NVARCHAR(255),
	IN _idProveedor INT,
	IN _total DOUBLE,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100), 
	OUT _idIngreso INT
)
BEGIN
	INSERT INTO ingreso (idOC,idProveedor,fecIngresa,facturaIngreso,guiaIngreso,total,observacion,estado,usuario_ins) values
	(_idOC,_idProveedor,_fecIngresa,_facturaIngreso,_guiaIngreso,_total,_observacion,_estado,_usuario_ins);
	COMMIT;
    SET _idIngreso = last_insert_id();
END
$$ DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_ingreso_det`(
	IN _idIngreso INT,
	IN _idLC INT,
	IN _idProcesador INT,
	IN _idVideo INT,
	IN _idDisco1 INT,
	IN _cantidadDisco1 INT,
	IN _idDisco2 INT,
	IN _cantidadDisco2 INT,
	IN _idMemoria1 INT,
	IN _cantidadMemoria1 INT,
	IN _idMemoria2 INT,
	IN _cantidadMemoria2 INT,
	IN _idWindows INT,
	IN _idOffice INT,
	IN _idAntivirus INT,
	IN _caracteristicas NVARCHAR(255),
	IN _subTotal DOUBLE,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO ingreso_det (idIngreso,idLC,idProcesador,idVideo,idDisco1,cantidadDisco1,idDisco2,cantidadDisco2,idMemoria1,cantidadMemoria1,idMemoria2,cantidadMemoria2,idWindows,idOffice,idAntivirus,caracteristicas,subTotal,observacion,estado,usuario_ins) values
	(_idIngreso,_idLC,_idProcesador,_idVideo,_idDisco1,_cantidadDisco1,_idDisco2,_cantidadDisco2,_idMemoria1,_cantidadMemoria1,_idMemoria2,_cantidadMemoria2,_idWindows,_idOffice,_idAntivirus,_caracteristicas,_subTotal,_observacion,_estado,_usuario_ins);
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_pedido`(
	IN _fecPedido DATETIME,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO pedido (fecPedido,observacion,estado,usuario_ins) values
	(_fecPedido,_observacion,_estado,_usuario_ins);
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_salida`(
	IN _idCliente INT,
	IN _idSucursal INT,
	IN _idPedido INT,
	IN _fecSalida DATETIME,
	IN _fecIniContrato DATETIME,
	IN _fecFinContrato DATETIME,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO salida (idCliente,idSucursal,idPedido,fecSalida,fecIniContrato,fecFinContrato,observacion,estado,usuario_ins) values
	(_idCliente,_idSucursal,_idPedido,_fecSalida,_fecIniContrato,_fecFinContrato,_observacion,_estado,_usuario_ins);
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_salida_det`(
	IN _idSalida INT,
	IN _idLC INT,
	IN _idProcesador INT,
	IN _idVideo INT,
	IN _idDisco1 INT,
	IN _cantidadDisco1 INT,
	IN _idDisco2 INT,
	IN _cantidadDisco2 INT,
	IN _idMemoria1 INT,
	IN _cantidadMemoria1 INT,
	IN _idMemoria2 INT,
	IN _cantidadMemoria2 INT,
	IN _idWindows INT,
	IN _idOffice INT,
	IN _idAntivirus INT,
	IN _caracteristicas NVARCHAR(255),
	IN _guiaSalida NVARCHAR(255),
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO salida_det (idSalida,idLC,idProcesador,idVideo,idDisco1,cantidadDisco1,idDisco2,cantidadDisco2,idMemoria1,cantidadMemoria1,idMemoria2,cantidadMemoria2,idWindows,idOffice,idAntivirus,caracteristicas,guiaSalida,observacion,estado,usuario_ins) values
	(_idSalida,_idLC,_idProcesador,_idVideo,_idDisco1,_cantidadDisco1,_idDisco2,_cantidadDisco2,_idMemoria1,_cantidadMemoria1,_idMemoria2,_cantidadMemoria2,_idWindows,_idOffice,_idAntivirus,_caracteristicas,_guiaSalida,_observacion,_estado,_usuario_ins);
END
$$ DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_factura`(
	IN _idSalida INT,
	IN _numFactura NVARCHAR(20),
	IN _fecIniPago DATETIME,
	IN _fecFinPago DATETIME,
	IN _fecEmisiom DATETIME,
	IN _ruc NVARCHAR(11),
	IN _codigoLC NVARCHAR(80),
	IN _guiaSalida NVARCHAR(255),
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO factura (idSalida,numFactura,fecIniPago,fecFinPago,fecEmisiom,ruc,codigoLC,guiaSalida,observacion,estado,usuario_ins) values
	(_idSalida,_numFactura,_fecIniPago,_fecFinPago,_fecEmisiom,_ruc,_codigoLC,_guiaSalida,_observacion,_estado,_usuario_ins);
END
$$ DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_cuota`(
	IN _idFactura INT,
	IN _idSalida INT,
	IN _numFactura NVARCHAR(20),
	IN _fecIniPago DATETIME,
	IN _fecFinPago DATETIME,
	IN _fecEmisiom DATETIME,
	IN _ruc NVARCHAR(11),
	IN _codigoLC NVARCHAR(80),
	IN _guiaSalida NVARCHAR(255),
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT
)
BEGIN
	INSERT INTO cuota (idFactura,idSalida,numFactura,fecIniPago,fecFinPago,fecEmisiom,ruc,codigoLC,guiaSalida,observacion,estado) values
	(_idFactura,_idSalida,_numFactura,_fecIniPago,_fecFinPago,_fecEmisiom,_ruc,_codigoLC,_guiaSalida,_observacion,_estado);
END
$$ DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_cambio`(
	IN _idCliente INT,
	IN _guiaSalidaCambio NVARCHAR(20),
	IN _guiaIngresoCambio NVARCHAR(20),
	IN _fechaCambio DATETIME,
	IN _ticketTecnico NVARCHAR(255),
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO cambio (idCliente,guiaSalidaCambio,guiaIngresoCambio,fechaCambio,ticketTecnico,observacion,estado,usuario_ins) values
	(_idCliente,_guiaSalidaCambio,_guiaIngresoCambio,_fechaCambio,_ticketTecnico,_observacion,_estado,_usuario_ins);
END
$$ DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_cambio_det`(
	IN _idCambio INT,
	IN _codigoLCIngreso NVARCHAR(80),
	IN _caracteristicasIngreso NVARCHAR(255),
    IN _fueDevuelto TINYINT,
    IN _estadoLCIngreso TINYINT,
	IN _codigoLCSalida NVARCHAR(80),
	IN _caracteristicasSalida NVARCHAR(255),
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO cambio_det (idCambio,codigoLCIngreso,caracteristicasIngreso,fueDevuelto,estadoLCIngreso,codigoLCSalida,caracteristicasSalida,observacion,estado,usuario_ins) values
	(_idCambio,_codigoLCIngreso,_caracteristicasIngreso,_fueDevuelto,_estadoLCIngreso,_codigoLCSalida,_caracteristicasSalida,_observacion,_estado,_usuario_ins);
END
$$ DELIMITER ;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_devolucion`(
	IN _idCliente INT,
	IN _guiaDevolucion NVARCHAR(20),
	IN _fechaDevolucion DATETIME,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO devolucion (idCliente,guiaDevolucion,fechaDevolucion,observacion,estado,usuario_ins) values
	(_idCliente,_guiaDevolucion,_fechaDevolucion,_observacion,_estado,_usuario_ins);
END
$$ DELIMITER ;



DROP PROCEDURE IF EXISTS `insert_devolucion_det`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_devolucion_det`(
	IN _idDevolucion INT,
	IN _idLC INT,
	IN _caracteristicas NVARCHAR(255),
    IN _estadoLC TINYINT,
	IN _observacion NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO devolucion_det (idDevolucion,idLC,caracteristicas,estadoLC,observacion,estado,usuario_ins) values
	(_idDevolucion,_idLC,_caracteristicas,_estadoLC,_observacion,_estado,_usuario_ins);
END
$$ DELIMITER ;



DROP PROCEDURE IF EXISTS `insert_observacionDeudas`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_observacionDeudas`(
	IN _idCliente INT,
	IN _idLC INT,
	IN _observacionDeuda NVARCHAR(20),
	IN _estadoObservacion TINYINT,
	IN _KAM NVARCHAR(255),
	IN _guiaLevantamiento NVARCHAR(255),
	IN _observacionLevantamiento NVARCHAR(255),
    IN _estado TINYINT,
	IN _usuario_ins NVARCHAR(100)
)
BEGIN
	INSERT INTO observacionDeudas (idCliente,idLC,observacionDeuda,estadoObservacion,KAM,guiaLevantamiento,observacionLevantamiento,estado,usuario_ins) values
	(_idCliente,_idLC,_observacionDeuda,_estadoObservacion,_KAM,_guiaLevantamiento,_observacionLevantamiento,_estado,_usuario_ins);
END
$$ DELIMITER ;



DROP PROCEDURE IF EXISTS `mostrar_componente_modelos`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrar_componente_modelos`(
	IN _idMarca INT
)
BEGIN
	Select idModelo, nombre
	from modelo
	where idMarca=_idMarca and estado=1;
END
$$ DELIMITER ;

