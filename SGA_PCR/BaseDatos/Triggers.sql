DROP TRIGGER IF EXISTS `after_memorias_lc_delete`;
DELIMITER $$

CREATE TRIGGER after_memorias_lc_delete
AFTER DELETE
ON memoria_lc FOR EACH ROW
BEGIN

	UPDATE memoria SET cantidad = cantidad + old.cantidad where idMemoria=old.idMemoria;

END$$    

DELIMITER ;


DROP TRIGGER IF EXISTS `after_memorias_lc_insert`;
DELIMITER $$

CREATE TRIGGER after_memorias_lc_insert
AFTER INSERT
ON memoria_lc FOR EACH ROW
BEGIN

    UPDATE memoria SET cantidad = cantidad - new.cantidad where idMemoria=new.idMemoria;

END$$

DELIMITER ;

DROP TRIGGER IF EXISTS `after_alquiler_detalle_delete`;
DELIMITER $$

CREATE TRIGGER after_alquiler_detalle_delete
AFTER DELETE
ON salida_det FOR EACH ROW
BEGIN

	UPDATE laptop_cpu SET estado = 2 , ubicacion='ALMACEN' where idLC=old.idLC;

END$$    

DELIMITER ;

DROP TRIGGER IF EXISTS `after_devolucion_detalle_delete`;
DELIMITER $$

CREATE TRIGGER after_devolucion_detalle_delete
AFTER DELETE
ON devolucion_det FOR EACH ROW
BEGIN

	UPDATE salida_det SET fueDevuelto = 0 where idSalidaDet=old.idSalidaDet;
	UPDATE laptop_cpu SET estado = 4 , ubicacion=old.idSucursal where idLC=old.idLC;
	DELETE FROM observacion_deudas where idDevolucion=old.idDevolucion;

END$$    

DELIMITER ;