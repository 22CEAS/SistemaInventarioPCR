BEGIN;
LOCK TABLES `bd_leasein`.`auxiliar` WRITE;
DELETE FROM `bd_leasein`.`auxiliar`;
INSERT INTO `bd_leasein`.`auxiliar` (`idAuxiliar`,`cod_tabla`,`descripcion`,`activo`) VALUES (1, 'DISCO_CAPACIDAD', '120', 1),(1, 'DISCO_TAMANO', '2.5', 1),(1, 'LICENCIA_OFFICE_TIPO', 'OLP', 1),(1, 'LICENCIA_WINDOWS_TIPO', 'OLP', 1),(1, 'MEMORIA_CAPACIDAD', '2', 1),(1, 'MEMORIA_CATEGORIA', 'DIMM', 1),(1, 'MEMORIA_FRECUENCIA', '206', 1),(1, 'PROCESADOR_GENERACION', '7', 1),(1, 'PROCESADOR_VELOCIDAD', '1.00 - 1.60', 1),(1, 'PROCESADOR_VELOCIDAD_MAXIMA', '3.5', 1),(1, 'USUARIO_PERFIL', 'ADMIN', 1),(1, 'VIDEO_CAPACIDAD', '1', 1),(1, 'VIDEO_TIPO', 'INTERNA', 1),(2, 'DISCO_CAPACIDAD', '240', 1),(2, 'DISCO_TAMANO', '3.5', 1),(2, 'LICENCIA_WINDOWS_TIPO', 'OEM', 1),(2, 'MEMORIA_CAPACIDAD', '4', 1),(2, 'MEMORIA_CATEGORIA', 'SODIM', 1),(2, 'MEMORIA_FRECUENCIA', '1333', 1),(2, 'PROCESADOR_GENERACION', '8', 1),(2, 'PROCESADOR_VELOCIDAD', '1.60 - 2.30', 1),(2, 'PROCESADOR_VELOCIDAD_MAXIMA', '3.7', 1),(2, 'USUARIO_PERFIL', 'KAM', 1),(2, 'VIDEO_CAPACIDAD', '2', 1),(2, 'VIDEO_TIPO', 'EXTERNA', 1),(3, 'DISCO_CAPACIDAD', '250', 1),(3, 'LICENCIA_WINDOWS_TIPO', 'ESD', 1),(3, 'MEMORIA_CAPACIDAD', '8', 1),(3, 'MEMORIA_CATEGORIA', 'RDIMM', 1),(3, 'MEMORIA_FRECUENCIA', '1600', 1),(3, 'PROCESADOR_GENERACION', '9', 1),(3, 'PROCESADOR_VELOCIDAD', '2.30 - 3.00', 1),(3, 'PROCESADOR_VELOCIDAD_MAXIMA', '4', 1),(3, 'USUARIO_PERFIL', 'LOGISTICA', 1),(3, 'VIDEO_CAPACIDAD', '4', 1),(4, 'DISCO_CAPACIDAD', '256', 1),(4, 'MEMORIA_CAPACIDAD', '12', 1),(4, 'MEMORIA_FRECUENCIA', '2133', 1),(4, 'PROCESADOR_GENERACION', '10', 1),(4, 'VIDEO_CAPACIDAD', '6', 1),(5, 'DISCO_CAPACIDAD', '480', 1),(5, 'MEMORIA_CAPACIDAD', '16', 1),(5, 'MEMORIA_FRECUENCIA', '2400', 1),(6, 'DISCO_CAPACIDAD', '500', 1),(6, 'MEMORIA_FRECUENCIA', '2660', 1),(7, 'DISCO_CAPACIDAD', '512', 1),(7, 'MEMORIA_FRECUENCIA', '2666', 1),(8, 'DISCO_CAPACIDAD', '960', 1),(9, 'DISCO_CAPACIDAD', '1000', 1),(10, 'DISCO_CAPACIDAD', '2000', 1),(1, 'TIPO_DOCUMENTO', 'DNI', 1),(2, 'TIPO_DOCUMENTO', 'RUC', 1);
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`usuario` WRITE;
DELETE FROM `bd_leasein`.`usuario`;
INSERT INTO `bd_leasein`.`usuario` (`idUsuario`,`dni`,`nombre`,`usuario`,`PASSWORD`,`perfil`,`estado`,`fec_ins`,`fec_mod`,`usuario_ins`,`usuario_mod`) VALUES (1, '71337110', 'CARLOS ARANGO', 'CEAS', '123456789', 1, 1, '2020-07-05 21:48:40', '2020-07-05 21:48:40', 'CEAS', 'CEAS'),(2, '71337111', 'ANDRES', 'ANDRES', '123456789', 2, 1, '2020-07-05 21:52:44', '2020-07-05 21:52:44', NULL, NULL),(3, '730261568', 'KEVIN', 'KEVIN', '123456789', 2, 1, '2020-07-05 21:52:44', '2020-07-05 21:52:44', NULL, NULL);
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`estados` WRITE;
DELETE FROM `bd_leasein`.`estados`;
INSERT INTO `bd_leasein`.`estados` (`idEstado`,`nombreEstado`,`descripcion`) VALUES (0, 'DESACTIVO', NULL),(1, 'ACTIVO', NULL),(2, 'DISPONIBLE', NULL),(3, 'DAÑADO', NULL),(4, 'ALQUILADO', NULL),(5, 'VENDIDO', NULL),(6, 'PRE-ALQUILER', NULL),(7, 'FINALIZADO', NULL);
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`categoria` WRITE;
DELETE FROM `bd_leasein`.`categoria`;
INSERT INTO `bd_leasein`.`categoria` (`idCategoria`,`nombre`,`subCategoria`,`estado`,`fec_ins`,`fec_mod`,`usuario_ins`,`usuario_mod`) VALUES (1, 'LAPTOP', 'EQUIPO', 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(2, 'CPU', 'EQUIPO', 1, '2020-07-04 13:39:03', '2020-07-04 13:39:03', NULL, NULL),(3, 'TABLET', 'EQUIPO', 1, '2020-07-04 13:39:19', '2020-07-04 13:39:19', NULL, NULL),(4, 'MONITOR', 'EQUIPO', 1, '2020-07-04 13:39:50', '2020-07-04 13:39:50', NULL, NULL),(5, 'IMPRESORA', 'EQUIPO', 1, '2020-07-04 13:40:00', '2020-07-04 13:40:00', NULL, NULL),(6, 'PROYECTOR', 'EQUIPO', 1, '2020-07-04 21:34:25', '2020-07-04 21:34:25', NULL, NULL),(7, 'ECRAN', 'EQUIPO', 1, '2020-07-04 21:35:00', '2020-07-04 21:35:00', NULL, NULL),(8, 'MEMORIA', 'COMPONENTES', 1, '2020-07-04 21:35:03', '2020-07-04 21:35:03', NULL, NULL),(9, 'PROCESADOR', 'COMPONENTES', 1, '2020-07-04 21:35:05', '2020-07-04 21:35:05', NULL, NULL),(10, 'DISCO', 'COMPONENTES', 1, '2020-07-04 21:35:08', '2020-07-04 21:35:08', NULL, NULL),(11, 'TARJETA DE VIDEO', 'COMPONENTES', 1, '2020-07-04 21:35:11', '2020-07-04 21:35:11', NULL, NULL),(12, 'WINDOWS', 'LICENCIAS', 1, '2020-07-04 21:36:03', '2020-07-04 21:36:03', NULL, NULL),(13, 'OFFICE', 'LICENCIAS', 1, '2020-07-04 21:36:05', '2020-07-04 21:36:05', NULL, NULL),(14, 'ANTIVIRUS', 'LICENCIAS', 1, '2020-07-04 21:36:06', '2020-07-04 21:36:06', NULL, NULL);
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`marca` WRITE;
DELETE FROM `bd_leasein`.`marca`;
INSERT INTO `bd_leasein`.`marca` (`idMarca`,`nombre`,`idCategoria`,`estado`,`fec_ins`,`fec_mod`,`usuario_ins`,`usuario_mod`) VALUES (1, 'APPLE', 1, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(2, 'COMPATIBLE', 1, 1, '2020-07-04 13:39:03', '2020-07-04 13:39:03', NULL, NULL),(3, 'DELL ', 1, 1, '2020-07-04 13:39:19', '2020-07-04 13:39:19', NULL, NULL),(4, 'HP', 1, 1, '2020-07-04 21:34:25', '2020-07-04 21:34:25', NULL, NULL),(5, 'LENOVO', 1, 1, '2020-07-04 21:35:00', '2020-07-04 21:35:00', NULL, NULL),(6, 'TOSHIBA', 1, 1, '2020-07-04 21:35:03', '2020-07-04 21:35:03', NULL, NULL),(7, 'MEMORIA', 8, 1, '2020-07-04 21:35:05', '2020-07-04 21:35:05', NULL, NULL),(8, 'INTEL', 9, 1, '2020-07-04 21:36:03', '2020-07-04 21:36:03', NULL, NULL),(9, 'AMD', 9, 1, '2020-07-04 21:36:05', '2020-07-04 21:36:05', NULL, NULL),(10, 'DISCO', 10, 1, '2020-07-04 21:36:06', '2020-07-04 21:36:06', NULL, NULL),(11, 'AMD', 11, 1, '2020-07-04 21:35:05', '2020-07-04 21:35:05', NULL, NULL),(12, 'NVIDIA', 11, 1, '2020-07-04 21:35:08', '2020-07-04 21:35:08', NULL, NULL),(13, 'WINDOWS', 12, 1, '2020-07-04 21:36:03', '2020-07-04 21:36:03', NULL, NULL),(14, 'OFFICE', 13, 1, '2020-07-04 21:35:08', '2020-07-04 21:35:08', NULL, NULL),(15, 'McAFee', 14, 1, '2020-07-04 21:35:11', '2020-07-04 21:35:11', NULL, NULL),(16, 'NOD32', 14, 1, '2020-07-04 21:36:03', '2020-07-04 21:36:03', NULL, NULL),(17, 'Kaspersky', 14, 1, '2020-07-04 21:36:05', '2020-07-04 21:36:05', NULL, NULL);
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`modelo` WRITE;
DELETE FROM `bd_leasein`.`modelo`;
INSERT INTO `bd_leasein`.`modelo` (`idModelo`,`nombre`,`idMarca`,`estado`,`fec_ins`,`fec_mod`,`usuario_ins`,`usuario_mod`) VALUES (1, 'MACK BOOK PRO', 1, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(2, 'ENTERPRISE', 2, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(3, 'Inspiron 14” 5480', 3, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(4, '2-in-1 Inspiron 15 serie 5000', 3, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(5, 'Inspiron 13” 7380', 3, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(6, 'HP PROBOOK', 4, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(7, 'ThinkPad P52', 5, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(8, 'Legion Y540', 5, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(9, 'Satellite', 6, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(10, 'DDR3', 7, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(11, 'DDR3L', 7, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(12, 'DDR4', 7, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(13, 'CORE I3', 8, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(14, 'CORE I5', 8, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(15, 'CORE I7', 8, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(16, 'CORE I9', 8, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(17, 'AMD AFX', 9, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(18, 'RYZEN', 9, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(19, 'SSD', 10, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(20, 'SHDD', 10, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(21, 'HDD', 10, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(22, 'RX5700-8G', 11, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(23, 'GEFORCE GTX 1660 SUPER', 12, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(24, 'GEFORCE RTX 2080 SUPER', 12, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(25, 'GEFORCE RTX 2070 SUPER', 12, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(26, 'WINDOWS 10 HOME', 13, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(27, 'WINDOWS 10 PRO', 13, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(28, 'WINDOWS 10 ULTIMATE', 13, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(29, 'OFFICE 2013', 14, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(30, 'OFFICE 2016', 14, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(31, 'OFFICE 2019', 14, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(32, 'INDIVIDUAL', 15, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(33, 'PARENTAL CONTROL', 16, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(34, 'ESET SMART SECURITY 12', 16, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL),(35, 'AVAST PREMIUM', 17, 1, '2020-07-04 13:38:31', '2020-07-04 13:38:31', NULL, NULL);
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`procesador` WRITE;
DELETE FROM `bd_leasein`.`procesador`;
INSERT INTO `bd_leasein`.`procesador` (`idProcesador`,`codigo`,`idModelo`,`idGeneracion`,`generacion`,`idVelocidad`,`velocidad`,`idVelocidadMax`,`velocidadMax`,`observacion`,`estado`,`fec_ins`,`fec_mod`,`usuario_ins`,`usuario_mod`) VALUES (1, 'PRO-1', 15, 4, 10, 1, '1.00 - 1.60', 1, 3.5, NULL, 1, '2020-07-05 00:50:19', '2020-07-05 00:50:19', 'CEAS', 'CEAS'),(2, 'PRO-2', 16, 4, 10, 3, '2.30 - 3.00', 2, 3.7, NULL, 1, '2020-07-05 00:51:35', '2020-07-05 00:51:35', 'CEAS', 'CEAS'),(3, 'PRO-3', 18, 1, 7, 2, '1.60 - 2.30', 3, 4, NULL, 1, '2020-07-05 00:52:38', '2020-07-05 00:52:38', 'CEAS', 'CEAS'),(4, 'PRO-4', 16, 2, 8, 2, '1.60 - 2.30', 3, 4, 'Prueba', 1, '2020-07-05 00:52:38', '2020-07-06 11:19:40', 'CEAS', NULL),(5, 'PRO-5', 17, 4, 10, 2, '1.60 - 2.30', 3, 4, 'Prueba', 1, '2020-07-06 12:47:17', '2020-07-06 12:47:17', 'CEAS', NULL);
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`video` WRITE;
DELETE FROM `bd_leasein`.`video`;
INSERT INTO `bd_leasein`.`video` (`idVideo`,`codigo`,`idModelo`,`idCapacidad`,`capacidad`,`idTipo`,`tipo`,`cantidad`,`ubicacion`,`observacion`,`estado`,`fec_ins`,`fec_mod`,`usuario_ins`,`usuario_mod`) VALUES (1, 'VID-1', 22, 3, 4, 2, 'EXTERNA', 5, 'ALMACEN', NULL, 1, '2020-07-05 01:46:37', '2020-07-05 01:46:37', NULL, NULL),(2, 'VID-2', 23, 3, 4, 1, 'INTERNA', 10, 'ALMACEN', NULL, 1, '2020-07-05 01:47:03', '2020-07-05 01:47:03', NULL, NULL),(3, 'VID-3', 23, 2, 2, 1, 'INTERNA', 3, 'ALMACEN', NULL, 1, '2020-07-05 01:47:43', '2020-07-05 01:47:43', NULL, NULL),(4, 'VID-4', 24, 4, 6, 2, 'EXTERNA', 8, 'ALMACEN', NULL, 1, '2020-07-05 01:48:10', '2020-07-05 01:48:10', NULL, NULL),(5, 'VID-5', 24, 4, 6, 1, 'INTERNA', 5, 'ALMACEN', NULL, 1, '2020-07-05 01:48:49', '2020-07-05 01:48:49', NULL, NULL),(6, 'VID-6', 22, 2, 2, 1, 'INTERNA', 5, 'ALMACEN', 'Prueba', 1, '2020-07-06 12:50:37', '2020-07-06 12:50:37', 'CEAS', NULL);
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`disco_duro` WRITE;
DELETE FROM `bd_leasein`.`disco_duro`;
INSERT INTO `bd_leasein`.`disco_duro` (`idDisco`,`codigo`,`idModelo`,`idTamano`,`tamano`,`idCapacidad`,`capacidad`,`cantidad`,`ubicacion`,`observacion`,`estado`,`fec_ins`,`fec_mod`,`usuario_ins`,`usuario_mod`) VALUES (1, 'DIS-1', 19, 1, 2.5, 3, 250, 3, 'ALMACEN', NULL, 1, '2020-07-05 00:40:59', '2020-07-05 00:40:59', NULL, NULL),(2, 'DIS-2', 19, 1, 2.5, 6, 500, 5, 'ALMACEN', NULL, 1, '2020-07-05 00:44:51', '2020-07-05 00:44:51', NULL, NULL),(3, 'DIS-3', 21, 2, 3.5, 6, 500, 8, 'ALMACEN', NULL, 1, '2020-07-05 00:45:54', '2020-07-05 00:45:54', NULL, NULL),(4, 'DIS-4', 20, 1, 2.5, 4, 256, 15, 'ALMACEN', 'Prueba', 1, '2020-07-06 12:55:26', '2020-07-06 12:55:26', 'CEAS', NULL);
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`memoria` WRITE;
DELETE FROM `bd_leasein`.`memoria`;
INSERT INTO `bd_leasein`.`memoria` (`idMemoria`,`codigo`,`idModelo`,`idBusFrecuencia`,`busFrecuencia`,`idCapacidad`,`capacidad`,`idTipo`,`tipo`,`cantidad`,`ubicacion`,`observacion`,`estado`,`fec_ins`,`fec_mod`,`usuario_ins`,`usuario_mod`) VALUES (1, 'MEM-1', 10, 2, 1333, 3, 8, 1, 'DIMM', 10, 'ALMACEN', NULL, 1, '2020-07-05 01:30:29', '2020-07-05 01:30:29', NULL, NULL),(2, 'MEM-2', 12, 4, 2133, 3, 8, 3, 'RDIMM', 20, 'ALMACEN', NULL, 1, '2020-07-05 01:31:44', '2020-07-05 01:31:44', NULL, NULL),(3, 'MEM-3', 11, 3, 1600, 4, 12, 2, 'SODIM', 0, 'ALMACEN', 'Prueba', 1, '0000-00-00 00:00:00', '0000-00-00 00:00:00', 'CEAS', 'CEAS'),(4, 'MEM-4', 11, 3, 1600, 5, 16, 2, 'SODIM', 10, 'ALMACEN', '', 1, '2020-07-06 12:43:19', '2020-07-06 12:43:19', 'CEAS', NULL);
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`laptop_cpu` WRITE;
DELETE FROM `bd_leasein`.`laptop_cpu`;
INSERT INTO `bd_leasein`.`laptop_cpu` (`idLC`,`codigo`,`idModelo`,`descripcion`,`tamanoPantalla`,`idProcesador`,`idVideo`,`partNumber`,`serieFabrica`,`garantia`,`fecInicioSeguro`,`fecFinSeguro`,`ubicacion`,`observacion`,`estado`,`fec_ins`,`fec_mod`,`usuario_ins`,`usuario_mod`) VALUES (1, 'PCR-LAP1', 1, '', 14, 1, 1, '123456', 'YB06087415', '1', NULL, NULL, 'ALMACEN', NULL, 2, '2020-07-05 09:05:52', '2020-07-05 09:05:52', NULL, NULL),(2, 'PCR-LAP2', 2, '', 14, 2, 2, '123456', 'YB06087415', '1', NULL, NULL, 'ALMACEN', NULL, 2, '2020-07-05 09:14:46', '2020-07-05 09:14:46', NULL, NULL),(3, 'PCR-LAP3', 3, '', 14, 3, 3, '123456', 'YB06087415', '1', NULL, NULL, 'ALMACEN', NULL, 2, '2020-07-05 09:14:46', '2020-07-05 09:14:46', NULL, NULL),(4, 'PCR-LAP4', 4, '', 14, 1, 4, '123456', 'YB06087415', '1', NULL, NULL, 'ALMACEN', NULL, 2, '2020-07-05 09:14:46', '2020-07-05 09:14:46', NULL, NULL),(5, 'PCR-LAP5', 5, '', 14, 2, 5, '123456', 'YB06087415', '1', NULL, NULL, 'ALMACEN', NULL, 2, '2020-07-05 09:14:46', '2020-07-05 09:14:46', NULL, NULL),(6, 'PCR-LAP6', 6, '', 14, 3, 1, '123456', 'YB06087415', '1', NULL, NULL, 'ALMACEN', NULL, 2, '2020-07-05 09:14:46', '2020-07-05 09:14:46', NULL, NULL),(7, 'PCR-LAP7', 7, '', 14, 1, 2, '123456', 'YB06087415', '1', NULL, NULL, 'ALMACEN', NULL, 2, '2020-07-05 09:14:46', '2020-07-05 09:14:46', NULL, NULL),(8, 'PCR-LAP8', 8, '', 14, 2, 3, '123456', 'YB06087415', '1', NULL, NULL, 'ALMACEN', NULL, 2, '2020-07-05 09:14:46', '2020-07-05 09:14:46', NULL, NULL),(9, 'PCR-LAP9', 9, '', 14, 3, 4, '123456', 'YB06087415', '1', NULL, NULL, 'ALMACEN', NULL, 2, '2020-07-05 09:14:46', '2020-07-05 09:14:46', NULL, NULL),(10, 'PCR-LAP10', 1, '', 14, 1, 1, '123456', 'YB06087415', '1', NULL, NULL, 'ALMACEN', NULL, 2, '2020-07-05 09:05:52', '2020-07-05 09:05:52', NULL, NULL),(11, 'PCR-LAP11', 8, '', 14, 2, 3, '123456', 'YB06087415', '1', NULL, NULL, 'ALMACEN', NULL, 2, '2020-07-05 09:14:46', '2020-07-05 09:14:46', NULL, NULL),(12, 'PCR-LAP12', 8, '', 14, 2, 3, '123456', 'YB06087415', '1', NULL, NULL, 'ALMACEN', NULL, 2, '2020-07-05 09:14:46', '2020-07-05 09:14:46', NULL, NULL),(13, 'PCR-LAP13', 8, '', 14, 3, NULL, '123456', 'YB06087415', '1', NULL, NULL, 'ALMACEN', NULL, 2, '2020-07-05 09:14:46', '2020-07-05 09:14:46', NULL, NULL),(14, 'PCR-LAP14', 2, '', 14, 2, 2, '123456', 'YB06087415', '0', NULL, NULL, 'ALMACEN', 'Prueba', 2, '2020-07-06 13:05:50', '2020-07-06 13:05:50', 'CEAS', NULL);
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`memoria_lc` WRITE;
DELETE FROM `bd_leasein`.`memoria_lc`;
INSERT INTO `bd_leasein`.`memoria_lc` (`idMemoria`,`idLC`,`cantidad`,`fec_ins`,`fec_mod`,`usuario_ins`,`usuario_mod`) VALUES (1, 1, 2, '2020-07-05 09:59:24', '2020-07-05 09:59:24', NULL, NULL),(1, 2, 1, '2020-07-05 09:59:24', '2020-07-05 09:59:24', NULL, NULL),(1, 4, 2, '2020-07-05 09:59:24', '2020-07-05 09:59:24', NULL, NULL),(1, 5, 1, '2020-07-05 09:59:24', '2020-07-05 09:59:24', NULL, NULL),(1, 6, 1, '2020-07-05 09:59:24', '2020-07-05 09:59:24', NULL, NULL),(1, 8, 1, '2020-07-05 09:59:24', '2020-07-05 09:59:24', NULL, NULL),(1, 10, 1, '2020-07-05 09:59:24', '2020-07-05 09:59:24', NULL, NULL),(1, 12, 1, '2020-07-05 09:59:24', '2020-07-05 09:59:24', NULL, NULL),(1, 13, 1, '2020-07-05 09:59:24', '2020-07-05 09:59:24', NULL, NULL),(2, 3, 1, '2020-07-05 09:59:24', '2020-07-05 09:59:24', NULL, NULL),(2, 6, 1, '2020-07-05 09:59:24', '2020-07-05 09:59:24', NULL, NULL),(2, 7, 2, '2020-07-05 09:59:24', '2020-07-05 09:59:24', NULL, NULL),(2, 9, 1, '2020-07-05 09:59:24', '2020-07-05 09:59:24', NULL, NULL),(2, 10, 1, '2020-07-05 09:59:24', '2020-07-05 09:59:24', NULL, NULL),(2, 11, 2, '2020-07-05 09:59:24', '2020-07-05 09:59:24', NULL, NULL),(2, 13, 1, '2020-07-05 09:59:24', '2020-07-05 09:59:24', NULL, NULL);
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`disco_lc` WRITE;
DELETE FROM `bd_leasein`.`disco_lc`;
INSERT INTO `bd_leasein`.`disco_lc` (`idDisco`,`idLC`,`cantidad`,`fec_ins`,`fec_mod`,`usuario_ins`,`usuario_mod`) VALUES (1, 1, 2, '2020-07-05 09:51:17', '2020-07-05 09:51:17', NULL, NULL),(1, 2, 1, '2020-07-05 09:51:48', '2020-07-05 09:51:48', NULL, NULL),(1, 4, 1, '2020-07-05 09:52:43', '2020-07-05 09:52:43', NULL, NULL),(1, 7, 1, '2020-07-05 09:55:41', '2020-07-05 09:55:41', NULL, NULL),(1, 10, 1, '2020-07-05 09:57:35', '2020-07-05 09:57:35', NULL, NULL),(2, 3, 1, '2020-07-05 09:52:23', '2020-07-05 09:52:23', NULL, NULL),(2, 5, 1, '2020-07-05 09:53:03', '2020-07-05 09:53:03', NULL, NULL),(2, 6, 1, '2020-07-05 09:53:45', '2020-07-05 09:53:45', NULL, NULL),(2, 8, 1, '2020-07-05 09:55:53', '2020-07-05 09:55:53', NULL, NULL),(2, 11, 1, '2020-07-05 09:57:48', '2020-07-05 09:57:48', NULL, NULL),(2, 12, 1, '2020-07-05 09:58:15', '2020-07-05 09:58:15', NULL, NULL),(2, 13, 1, '2020-07-05 09:58:30', '2020-07-05 09:58:30', NULL, NULL),(3, 2, 1, '2020-07-05 09:52:08', '2020-07-05 09:52:08', NULL, NULL),(3, 6, 1, '2020-07-05 09:53:29', '2020-07-05 09:53:29', NULL, NULL),(3, 9, 1, '2020-07-05 09:57:11', '2020-07-05 09:57:11', NULL, NULL),(3, 11, 1, '2020-07-05 09:57:58', '2020-07-05 09:57:58', NULL, NULL);
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`licencia` WRITE;
DELETE FROM `bd_leasein`.`licencia`;
INSERT INTO `bd_leasein`.`licencia` (`idLicencia`,`codigo`,`idModelo`,`idLC`,`clave`,`fechaActivacion`,`ubicacion`,`observacion`,`estado`,`fec_ins`,`fec_mod`,`usuario_ins`,`usuario_mod`) VALUES (1, 'LIC-1', 26, NULL, '28C9P-PHX4D-42H7T-DHXVV-M776G', '0000-00-00 00:00:00', 'ALMACEN', NULL, 2, '2020-07-05 01:56:53', '2020-07-05 01:56:53', NULL, NULL),(2, 'LIC-2', 26, NULL, '28C9P-PHX4D-42H7T-DHXVV-M776G', NULL, 'ALMACEN', NULL, 2, '2020-07-05 01:59:56', '2020-07-05 01:59:56', NULL, NULL),(3, 'LIC-3', 31, NULL, '9HJ7X-7KHTT-KW3HV-3J7FY-746Y8', NULL, 'ALMACEN', NULL, 2, '2020-07-05 02:02:02', '2020-07-05 02:02:02', NULL, NULL),(4, 'LIC-4', 31, NULL, '6VRD9-JW4V7-P8K8C-DFXMH-KDRWY', NULL, 'ALMACEN', NULL, 2, '2020-07-05 02:03:04', '2020-07-05 02:03:04', NULL, NULL),(5, 'LIC-5', 30, NULL, 'H8X8D-P88KD-32KWB-WFQ44-W2RVP', NULL, 'ALMACEN', NULL, 2, '2020-07-05 02:03:42', '2020-07-05 02:03:42', NULL, NULL),(6, 'LIC-6', 34, NULL, 'BJ2XD-W67JY-W6VDH-8HPDR-RY2R10', NULL, 'ALMACEN', NULL, 2, '2020-07-05 02:05:10', '2020-07-05 02:05:10', NULL, NULL),(7, 'LIC-7', 34, NULL, 'BJ2XD-W67JY-W6VDH-8HPDR-RY2R10', NULL, 'ALMACEN', NULL, 2, '2020-07-05 02:05:10', '2020-07-05 02:05:10', NULL, NULL),(8, 'LIC-8', 34, NULL, 'BJ2XD-W67JY-W6VDH-8HPDR-RY2R10', NULL, 'ALMACEN', NULL, 2, '2020-07-05 02:05:10', '2020-07-05 02:05:10', NULL, NULL),(9, 'LIC-9', 35, NULL, 'BJ2XD-W67JY-W6VDH-8HPDR-RY2K23', NULL, 'ALMACEN', NULL, 2, '2020-07-05 02:05:10', '2020-07-05 02:05:10', NULL, NULL),(10, 'LIC-10', 35, NULL, 'BJ2XD-W67JY-W6VDH-8HPDR-RY2K23', NULL, 'ALMACEN', NULL, 2, '2020-07-05 02:05:10', '2020-07-05 02:05:10', NULL, NULL),(11, 'LIC-11', 26, NULL, '28C9P-PHX4D-42H7T-DHXVV-MMMM', NULL, 'ALMACEN', 'Prueba', 2, '2020-07-06 13:00:53', '2020-07-06 13:00:53', 'CEAS', NULL);
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`factura` WRITE;
DELETE FROM `bd_leasein`.`factura`;
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`ingreso` WRITE;
DELETE FROM `bd_leasein`.`ingreso`;
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`ingreso_det` WRITE;
DELETE FROM `bd_leasein`.`ingreso_det`;
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`observaciondeudas` WRITE;
DELETE FROM `bd_leasein`.`observaciondeudas`;
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`orden_compra` WRITE;
DELETE FROM `bd_leasein`.`orden_compra`;
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`pedido` WRITE;
DELETE FROM `bd_leasein`.`pedido`;
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`proveedor` WRITE;
DELETE FROM `bd_leasein`.`proveedor`;
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`requerimiento_compra` WRITE;
DELETE FROM `bd_leasein`.`requerimiento_compra`;
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`salida` WRITE;
DELETE FROM `bd_leasein`.`salida`;
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`salida_det` WRITE;
DELETE FROM `bd_leasein`.`salida_det`;
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`cambio` WRITE;
DELETE FROM `bd_leasein`.`cambio`;
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`cambio_det` WRITE;
DELETE FROM `bd_leasein`.`cambio_det`;
UNLOCK TABLES;
COMMIT;;
BEGIN;
LOCK TABLES `bd_leasein`.`cliente` WRITE;
DELETE FROM `bd_leasein`.`cliente`;
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`cliente_sucursal` WRITE;
DELETE FROM `bd_leasein`.`cliente_sucursal`;
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`cliente` WRITE;
DELETE FROM `bd_leasein`.`cliente`;
INSERT INTO `bd_leasein`.`cliente` (`idCliente`,`tipoDocumento`,`nroDocumento`,`nombre_razonSocial`,`telefono`,`email`,`idKAM`,`nombreKam`,`estado`,`fec_ins`,`fec_mod`,`usuario_ins`,`usuario_mod`) VALUES (1, 2, '20601329256', 'LUCET SAC', '', 'correo@lucet.com.pe', 2, 'ANDRES', 1, '2020-07-13 13:45:07', '2020-07-16 13:08:39', 'CEAS', 'CEAS'),(2, 1, '71337110', 'CARLOS ARANGO SAENZ', '935753210', 'carlos.arango@pucp.pe', 2, 'ANDRES', 1, '2020-07-13 13:45:48', '2020-07-16 13:09:15', 'CEAS', 'CEAS'),(3, 2, '20601325694', 'LEASEIN SAC', '516113213', 'correo@leasein.com.pe', 2, 'ANDRES', 1, '2020-07-13 15:31:24', '2020-07-16 13:10:01', 'CEAS', 'CEAS');
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`cliente_sucursal` WRITE;
DELETE FROM `bd_leasein`.`cliente_sucursal`;
INSERT INTO `bd_leasein`.`cliente_sucursal` (`idSucursal`,`idCliente`,`nroDocumento`,`nombreContacto`,`direccion`,`telefono`,`email`,`observacion`,`estado`,`fec_ins`,`fec_mod`,`usuario_ins`,`usuario_mod`) VALUES (1, 1, '71337110', 'CARLOS ENRIQUE', 'Avenida Universitaria 1801', '1234546312', 'enrique@correo.pucp.edu.pe', '', 1, '2020-07-13 14:49:24', '2020-07-16 13:14:24', 'CEAS', 'CEAS'),(2, 1, '76040953', 'DIANA PAREDES', 'Avenida Universitaria 2200', '01-2060598', 'diana@correo.com.pe', '', 1, '2020-07-13 15:07:34', '2020-07-16 13:14:17', 'CEAS', 'CEAS'),(3, 3, '76400951', 'NEUS GILVONIO', 'Pasaje Sor Angélica 125', '938126533', 'neus@correo.com.pe', '', 1, '2020-07-16 13:11:36', '2020-07-16 13:11:36', 'CEAS', NULL),(4, 2, '71337110', 'CARLOS ENRIQUE ARANGO SAENZ', 'Pasaje sor Angélica 125', '1354321351', 'carlos@pucp.com.pe', '', 1, '2020-07-16 13:12:48', '2020-07-16 13:12:48', 'CEAS', NULL);
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`cuota` WRITE;
DELETE FROM `bd_leasein`.`cuota`;
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`devolucion` WRITE;
DELETE FROM `bd_leasein`.`devolucion`;
UNLOCK TABLES;
COMMIT;
BEGIN;
LOCK TABLES `bd_leasein`.`devolucion_det` WRITE;
DELETE FROM `bd_leasein`.`devolucion_det`;
UNLOCK TABLES;
COMMIT;
