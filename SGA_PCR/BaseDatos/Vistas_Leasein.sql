DROP VIEW IF EXISTS `bd_leasein`.`vista_disco_capacidad`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_disco_modelo`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_disco_tamano`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_documento_tipo`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_kam_activos`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_laptops_almacen_lista`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_laptops_discos`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_laptops_memorias`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_licencia_lista`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_licencia_office_tipos`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_licencia_windows_tipos`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_maestro_cliente`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_maestro_disco`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_maestro_laptops`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_maestro_memoria`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_maestro_procesador`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_maestro_sucursal_cliente`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_maestro_video`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_memoria_capacidad`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_memoria_categoria`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_memoria_frecuencia`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_memoria_modelo`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_procesador_generacion`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_procesador_marca`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_procesador_velocidad`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_procesador_velocidad_maxima`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_productos_por_facturar`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_productos_por_recoger`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_proveedor_lista`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_stock_disco_lc_almacen`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_stock_disco_lc_cliente`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_stock_disco_libre`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_stock_memoria_lc_almacen`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_stock_memoria_lc_cliente`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_stock_memoria_libre`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_stockdisponible_disco_libre`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_stockdisponible_memoria_libre`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_usuario_perfil`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_video_capacidad`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_video_marca`;
DROP VIEW IF EXISTS `bd_leasein`.`vista_video_tipo`;

/*En la tabla salida se comparara la fecha final de alquiler con el dia actual.*/
create view vista_productos_por_recoger as
	Select (Select c.nombre_razonSocial from cliente c where c.idCliente=s.idCliente) as cliente, 
			s.fecIniContrato as fecIniPlazoAlquiler,
			s.fecFinContrato as fecFinPlazoAlquiler,
			lc.codigo as codigoEquipo,
			d.guiaSalida as guia,
			DATEDIFF(CURDATE(),s.fecFinContrato) as diasAtrasoRecojo,
			d.motivoNoRecojo as motivoNoRecojo,
			(Select c.nombreKam from cliente c where c.idCliente=s.idCliente) as KAM 
	From salida s inner join salida_det d on s.idSalida=d.idSalida inner join laptop_cpu lc on lc.idLC=d.idLC
	where s.estado="Atendido" and d.estado="Activo" and Not(lc.ubicacion="Almacen") and s.fecFinContrato<CURDATE()
	order by cliente,codigoEquipo;
	
 
/*En la tabla de cuota se va a poner la ultima factura que se tenga de este producto, si se ingresa una nueva, se elimina esta fila y se inserta la nueva factura aqui. Si no hay ninguna factura en cuota significa que a ese producto nunca se ha facturado.*/

create view vista_productos_por_facturar as
	Select (Select c.nombre_razonSocial from cliente c where c.idCliente=s.idCliente) as cliente, 
			s.fecIniContrato as fecIniPlazoAlquiler,
			s.fecFinContrato as fecFinPlazoAlquiler,
			"" as factura,
			"" as fecInicioFactura,
			"" as fecFinFactura,
			lc.codigo as codigoEquipo,
			d.guiaSalida as guia,
			DATEDIFF(CURDATE(),s.fecIniContrato) as diasVencidos,
			(Select c.nombreKam from cliente c where c.idCliente=s.idCliente) as KAM 
	From salida s inner join salida_det d on s.idSalida=d.idSalida inner join laptop_cpu lc on lc.idLC=d.idLC
	where s.estado=4
		and d.estado=4 
		and Not(lc.ubicacion="Almacen") 
		and	d.idLC not in (Select codigoLC from cuota)

	UNION

	Select (Select c.nombre_razonSocial from cliente c where c.idCliente=s.idCliente) as cliente, 
			s.fecIniContrato as fecIniPlazoAlquiler,
			s.fecFinContrato as fecFinPlazoAlquiler,
			cu.numFactura as factura,
			cu.fecInicioPago as fecInicioFactura,
			cu.fecFinPago as fecFinFactura,
			lc.codigo as codigoEquipo,
			d.guiaSalida as guia,
			DATEDIFF(CURDATE(),cu.fecFinPago) as diasVencidos,
			(Select c.nombreKam from cliente c where c.idCliente=s.idCliente) as KAM 
	From salida s 
			inner join salida_det d on s.idSalida=d.idSalida 
			inner join laptop_cpu lc on lc.idLC=d.idLC
			inner join cuota cu on d.idLC=cu.codigoLC
	where s.estado=4
		and d.estado=4 
		and Not(lc.ubicacion="Almacen") 
		and cu.fecFinPago<CURDATE() 
	order by cliente,codigoEquipo;


/*Se mostrará la tabla de discos duros en el maestro de discos*/
create view vista_maestro_disco as
Select 	d.idDisco as idDisco,
		m.idModelo as idTipo,
		m.nombre as tipo,
		d.idTamano as idTamano,
		d.tamano as tamano,
		d.idCapacidad as idCapacidad,
		d.capacidad as capacidad,
		d.estado as estado
From disco_duro d
	inner join modelo m on m.idModelo = d.idModelo ;
	
/*Se mostrará el stock de discos duros libres ubicados en almacen*/
create view vista_stock_disco_libre as
Select 	d.idDisco as idDisco,
		m.nombre as tipo,
		d.tamano as tamano,
		d.capacidad as capacidad,
		d.cantidad as cantidad,
		d.estado as estado
From disco_duro d
	inner join modelo m on m.idModelo = d.idModelo;


/*Se mostrará la lista de discos duros con stock mayor a 1*/
create view vista_stockDisponible_disco_libre as
Select 	d.idDisco as IdDisco,
		m.nombre as TipoDisco,
		d.tamano as Tamano,
		d.capacidad as Capacidad,
		d.cantidad as Cantidad,
		d.estado as Estado
From disco_duro d
	inner join modelo m on m.idModelo = d.idModelo 
where d.cantidad>0 and d.estado=1;

/*Se mostrará el stock de discos duros en almacen relacionados a una laptop_cpu*/
create view vista_stock_disco_LC_almacen as
Select dlc.idDisco,
		m.nombre as tipo,
		d.tamano as tamano,
		d.capacidad as capacidad,
		sum(dlc.cantidad) as Cantidad
From disco_LC dlc, laptop_cpu lc,
	disco_duro d inner join modelo m on m.idModelo = d.idModelo
where dlc.idDisco=d.idDisco and dlc.idLC=lc.idLC and lc.ubicacion="Almacen" 
group by dlc.idDisco;


/*Se mostrará el stock de discos duros en cliente relacionados a una laptop_cpu*/
create view vista_stock_disco_LC_cliente as
Select dlc.idDisco,
		m.nombre as tipo,
		d.tamano as tamano,
		d.capacidad as capacidad,
		sum(dlc.cantidad) as Cantidad
From disco_LC dlc, laptop_cpu lc,
	disco_duro d inner join modelo m on m.idModelo = d.idModelo
where dlc.idDisco=d.idDisco and dlc.idLC=lc.idLC and Not(lc.ubicacion="Almacen")
group by dlc.idDisco;


/*Se mostrará la tabla de memorias en el maestro de memorias*/
create view vista_maestro_memoria as
Select 	me.idMemoria as idMemoria,
		ma.idMarca as idCategoria,
		ma.nombre as categoria,
		m.idModelo as idTipo,
		m.nombre as tipo,
		me.idBusFrecuencia as idBusFrecuencia,
		me.busFrecuencia as frecuencia,
		me.idCapacidad as idCapacidad,
		me.capacidad as capacidad,
		me.estado as estado
From memoria me
	inner join modelo m on m.idModelo = me.idModelo
	inner join marca ma on m.idMarca = ma.idMarca ;
	
/*Se mostrará el stock de memorias libres ubicados en almacen*/
create view vista_stock_memoria_libre as
Select 	me.idMemoria as idMemoria,
		ma.nombre as categoria,
		m.nombre as tipo,
		me.busFrecuencia as frecuencia,
		me.capacidad as capacidad,
		me.cantidad as cantidad,
		me.estado as estado
From memoria me
	inner join modelo m on m.idModelo = me.idModelo
	inner join marca ma on m.idMarca = ma.idMarca ;

/*Se mostrará la lista de memorias con stock mayor a 1*/
create view vista_stockDisponible_memoria_libre as
Select 	me.idMemoria as IdMemoria,
		ma.nombre as categoria,
		m.nombre as TipoMemoria,
		me.busFrecuencia as frecuencia,
		me.capacidad as Capacidad,
		me.cantidad as Cantidad,
		me.estado as estado
From memoria me
	inner join modelo m on m.idModelo = me.idModelo
	inner join marca ma on m.idMarca = ma.idMarca 
where me.cantidad>0 and me.estado=1;
	

/*Se mostrará el stock de memorias en almacen relacionados a una laptop_cpu*/
create view vista_stock_memoria_LC_almacen as
Select mlc.idMemoria,
		ma.nombre as categoria,
		m.nombre as tipo,
		me.busFrecuencia as frecuencia,
		me.capacidad as capacidad,
		sum(mlc.cantidad) as Cantidad
From memoria_LC mlc, laptop_cpu lc,
	memoria me
	inner join modelo m on m.idModelo = me.idModelo
	inner join marca ma on m.idMarca = ma.idMarca
where mlc.idMemoria=me.idMemoria and mlc.idLC=lc.idLC and lc.ubicacion="Almacen" 
group by mlc.idMemoria;

/*Se mostrará el stock de memorias en cliente relacionados a una laptop_cpu*/
create view vista_stock_memoria_LC_cliente as
Select mlc.idMemoria,
		ma.nombre as categoria,
		m.nombre as tipo,
		me.busFrecuencia as frecuencia,
		me.capacidad as capacidad,
		sum(mlc.cantidad) as Cantidad
From memoria_LC mlc, laptop_cpu lc,
	memoria me
	inner join modelo m on m.idModelo = me.idModelo
	inner join marca ma on m.idMarca = ma.idMarca
where mlc.idMemoria=me.idMemoria and mlc.idLC=lc.idLC and Not(lc.ubicacion="Almacen") 
group by mlc.idMemoria;


/*Se mostrará la tabla de procesador en el maestro de procesador*/
create view vista_maestro_procesador as
Select 	p.idProcesador as idProcesador,
		ma.idMarca as idMarca,
		ma.nombre as marca,
		m.idModelo as idTipo,
		m.nombre as tipo,
		p.idGeneracion as idGeneracion,
		p.generacion as generacion,
		p.idVelocidad as idVelocidad,
		p.velocidad as velocidad,
		p.idVelocidadMax as idVelocidadMax,
		p.velocidadMax as velocidadMax,
		p.estado as estado
From procesador p
	inner join modelo m on m.idModelo = p.idModelo
	inner join marca ma on m.idMarca = ma.idMarca ;

/*Se mostrará la tabla de videos en el maestro de videos*/
create view vista_maestro_video as
Select 	v.idVideo as idVideo,
		ma.idMarca as idMarca,
		ma.nombre as marca,
		m.idModelo as idModelo,
		m.nombre as nombreModelo,
		v.idTipo as idTipo,
		v.tipo as tipo,
		v.idCapacidad as idCapacidad,
		v.capacidad as capacidad,
		v.estado as estado
From video v
	inner join modelo m on m.idModelo = v.idModelo
	inner join marca ma on m.idMarca = ma.idMarca ;
	


/*Se mostrará las capacidades de los discos*/
create view vista_disco_capacidad as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="DISCO_CAPACIDAD" and activo=1;


/*Se mostrará el tamano de los discos*/
create view vista_disco_tamano as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="DISCO_TAMANO" and activo=1;

		
/*Se mostrará los tipos de licencia de ofice*/
create view vista_licencia_office_tipos as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="LICENCIA_OFFICE_TIPO" and activo=1;

		
/*Se mostrará los tipos de licencia de windows*/
create view vista_licencia_windows_tipos as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="LICENCIA_WINDOWS_TIPO" and activo=1;

		
/*Se mostrará las capacidades de la memoria*/
create view vista_memoria_capacidad as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="MEMORIA_CAPACIDAD" and activo=1;

		
/*Se mostrará las categorias de la memoria*/
create view vista_memoria_categoria as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="MEMORIA_CATEGORIA" and activo=1;

		
/*Se mostrará las frecuencias de la memoria*/
create view vista_memoria_frecuencia as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="MEMORIA_FRECUENCIA" and activo=1;

		
/*Se mostrará las generaciones de los procesadores*/
create view vista_procesador_generacion as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="PROCESADOR_GENERACION" and activo=1;

		
/*Se mostrará las velocidades de los procesadores*/
create view vista_procesador_velocidad as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="PROCESADOR_VELOCIDAD" and activo=1;

		
/*Se mostrará las velocidades maxima de los procesadores*/
create view vista_procesador_velocidad_maxima as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="PROCESADOR_VELOCIDAD_MAXIMA" and activo=1;

		
/*Se mostrará perfiles de los usuarios*/
create view vista_usuario_perfil as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="USUARIO_PERFIL" and activo=1;

		
/*Se mostrará tipos de tarjeta de video*/
create view vista_video_tipo as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="VIDEO_TIPO" and activo=1;

/*Se mostrará las capacidad de tarjeta de video*/
create view vista_video_capacidad as
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="VIDEO_CAPACIDAD" and activo=1;
		
/*Se mostrará los modelos de los discos SSD, HHD*/
create view vista_disco_modelo as
Select idModelo, nombre
from modelo
where idMarca=10 and estado=1;

		
/*Se mostrará los modelos de memoria DDR3, DDR4*/
create view vista_memoria_modelo as
Select idModelo, nombre
from modelo
where idMarca=7 and estado=1;

		
/*Se mostrará las marcas de los procesadores*/
create view vista_procesador_marca as
Select mo.idModelo, mo.nombre
from marca m INNER JOIN modelo mo on m.idMarca=mo.IdMarca
where m.idCategoria=9 and m.estado=1 ;


		
/*Se mostrará las marcas de las tarjetas de videos*/
create view vista_video_marca as
Select idMarca, nombre
from marca
where idCategoria=11 and estado=1;
		

/*Se mostrará todas las licencias*/
create view vista_licencia_lista as
Select l.idLicencia as IdLicencia,
				c.idCategoria as IdCategoria,
				c.nombre as Categoria,
				ma.idMarca as IdMarca,
				ma.nombre as Marca,
				mo.idModelo as IdModelo,
				mo.nombre as Version,
				l.idLC as IdLC,
				l.clave as Clave,
				l.ubicacion as Ubicacion
from licencia l, modelo mo, marca ma, categoria c
where l.idModelo=mo.idModelo and ma.idMarca=mo.idMarca and c.idCategoria=ma.idCategoria;


/*Este es parecido al vista_licencia_lista, se usará para llamarlo junto a un where y colocar un idLC, pero la diferencia es que solo mostrará las que están actualmente a una laptop y activos, puede que haya licencias relacionadas a una laptop pero el estado este en 0, lo cual quiere decir que ya caduco, 1 es porque está activo*/
create view vista_licencia_lc_lista as
Select l.idLicencia as IdLicencia,
				c.idCategoria as IdCategoria,
				c.nombre as Categoria,
				ma.idMarca as IdMarca,
				ma.nombre as Marca,
				mo.idModelo as IdModelo,
				mo.nombre as Version,
				l.idLC as IdLC,
				l.clave as Clave,
				l.ubicacion as Ubicacion
from licencia l, modelo mo, marca ma, categoria c
where l.idModelo=mo.idModelo and ma.idMarca=mo.idMarca and c.idCategoria=ma.idCategoria and l.estado=1;

/*Se mostrará todas las licencias*/
create view vista_stockDisponible_licencia_libre as
Select l.idLicencia as IdLicencia,
				c.idCategoria as IdCategoria,
				c.nombre as Categoria,
				ma.idMarca as IdMarca,
				ma.nombre as Marca,
				mo.idModelo as IdModelo,
				mo.nombre as Version,
				l.idLC as IdLC,
				l.clave as Clave,
				l.ubicacion as Ubicacion
from licencia l, modelo mo, marca ma, categoria c
where l.idModelo=mo.idModelo and ma.idMarca=mo.idMarca and c.idCategoria=ma.idCategoria and l.estado=2 and l.idLC is null;
		
		
/*Se mostrará todas los proveedor*/
create view vista_proveedor_lista as		
Select 	idProveedor as idProveedor,
		ruc as ruc,
		razonSocial as razonSocial,
		nombreComercial as nombreComercial,
		abreviacion as abreviacion,
		direccion as direccion,
		telefono as telefono,
		fax as fax,
		email as email,
		observacion as observacion,
		nombreContacto as nombreContacto,
		telefonoContacto as telefonoContacto,
		emailContacto as emailContacto,
		estado as estado
From proveedor;
		
/*Se mostrará todos los tipos de documentos*/
create view vista_documento_tipo as	
Select idAuxiliar, descripcion
from auxiliar
where cod_tabla="TIPO_DOCUMENTO" and activo=1;
		
/*Se mostrará todos los KAMS activos*/
create view vista_KAM_activos as	
Select idUsuario as idUsuario,
		nombre as nombre
from usuario
where perfil=2 and estado=1 ;

/*Se mostrará la tabla de clientes en el maestro de clientes*/
create view vista_maestro_Cliente as
Select idCliente as idCliente,
		tipoDocumento as tipoDocumento,
		descripcion as nombreTipoDocumento,
		nroDocumento as nroDocumento,
		nombre_razonSocial as nombre_razonSocial,
		telefono as telefono,
		email as email,
		idKAM as idKAM,
		nombreKam as nombreKam,
    estado as estado
from cliente , auxiliar 
where tipoDocumento=idAuxiliar and cod_tabla='TIPO_DOCUMENTO';

/*Se mostrará la tabla de sucursales de un cliente en el maestro de sucursales clientes*/
create view vista_maestro_Sucursal_Cliente as
Select 	cs.idSucursal as idSucursal,
		cs.idCliente as idCliente,
		c.nombre_razonSocial as nombreCliente,
		cs.nroDocumento as nroDocumento,
		cs.nombreContacto as nombreContacto,
		cs.direccion as direccion,
		cs.telefono as telefono,
		cs.email as email,
		cs.observacion as observacion,
		cs.estado as estado
from cliente_sucursal cs , cliente c 
where cs.idCliente=c.idCliente;

/*Se mostrará la tabla de laptops en el maestro de laptops*/
create view vista_maestro_laptops as
Select 	l.idLC as idLC,
		ma.idMarca as idMarca,
		ma.nombre as marca,
		m.idModelo as idModelo,
		m.nombre as nombreModelo,
		l.codigo as codigo,
		l.tamanoPantalla as tamanoPantalla,
		l.idProcesador as idProcesador,
		l.idVideo as idVideo,
		l.partNumber as partNumber,
		l.serieFabrica as serieFabrica,
		l.garantia as garantia,
		l.fecInicioSeguro as fecInicioSeguro,
		l.fecFinSeguro as fecFinSeguro,
		l.ubicacion as ubicacion,
		l.observacion as observacion,
		l.estado as estado
From laptop_cpu l
	inner join modelo m on m.idModelo = l.idModelo
	inner join marca ma on m.idMarca = ma.idMarca ;
	
/*Se mostrará la tabla de laptops en el maestro de laptops*/
create view vista_laptops_almacen_lista as
SELECT lc.idLC as idLC,
		lc.idMarca as idMarca,
		lc.marca as marcaLC,
		lc.idModelo as idModelo,
		lc.nombreModelo as nombreModeloLC,
		lc.codigo as codigo,
		lc.tamanoPantalla as tamanoPantalla,
		p.idProcesador as idProcesador,
		p.marca as marcaProcesador,
		p.tipo as tipoProcesador,
		p.generacion as generacionProcesador,
		if(v.idVideo is null,0,v.idVideo) as idVideo,
		if(v.marca is null,'',v.marca) as marcaVideo,
		if(v.nombreModelo is null,'',v.nombreModelo) as nombreModeloVideo,
		if(v.capacidad is null,0,v.capacidad) as capacidadVideo,
		if(v.tipo is null,'',v.tipo) as tipoVideo,
		lc.partNumber as partNumber,
		lc.serieFabrica as serieFabrica,
		lc.garantia as garantia,
		lc.fecInicioSeguro as fecInicioSeguro,
		lc.fecFinSeguro as fecFinSeguro,
		lc.ubicacion as ubicacion,
		lc.observacion as observacion,
		lc.estado as estado
FROM vista_maestro_laptops lc 
		left join  vista_maestro_procesador p on lc.idProcesador=p.idProcesador 
		left join vista_maestro_video v on lc.idVideo=v.idVideo 
where lc.estado=2 and lc.ubicacion='ALMACEN'
ORDER BY lc.idLC;
	
/*Se mostrará la tabla de discos relacinados a una laptop*/
create view vista_laptops_discos as
SELECT lc.idLC as IdLC,
		d.idDisco as IdDisco,
		d.tipo as TipoDisco,
		d.tamano as Tamano,
		d.capacidad as Capacidad,
		dlc.cantidad as Cantidad
FROM vista_maestro_laptops lc, vista_maestro_disco d, disco_lc dlc
where lc.idLC=dlc.idLC and d.idDisco=dlc.idDisco 
ORDER BY d.tipo;


/*Se mostrará la tabla de discos relacinados a una laptop*/
create view vista_laptops_memorias as
SELECT lc.idLC as idLC,
		m.idMemoria as IdMemoria,
		m.tipo as TipoMemoria,
		m.capacidad as Capacidad,
		mlc.cantidad as Cantidad
FROM vista_maestro_laptops lc, vista_maestro_memoria m,  memoria_lc mlc
where lc.idLC=mlc.idLC and m.idMemoria=mlc.idMemoria
ORDER BY m.tipo;


/*Se mostrará los alquileres realizado*/
create view vista_lista_alquileres as
Select a.idSalida as idAlquiler,
			 a.idCliente as idCliente,
			 a.usuario_ins as nombreKam,
			 a.estado as idEstado,
			 c.nombre_razonSocial as nombreCliente,
			 cast(a.fec_ins as date) as fechaProceso,
			 e.nombreEstado as estado
From salida a inner join cliente c on a.idCliente=c.idCliente 
				inner join estados e on a.estado=e.idEstado;

/*Se mostrará los alquileres realizado*/
create view vista_laptops_almacen_lista_sin_filtro as
SELECT lc.idLC as idLC,
		lc.idMarca as idMarca,
		lc.marca as marcaLC,
		lc.idModelo as idModelo,
		lc.nombreModelo as nombreModeloLC,
		lc.codigo as codigo,
		lc.tamanoPantalla as tamanoPantalla,
		p.idProcesador as idProcesador,
		p.marca as marcaProcesador,
		p.tipo as tipoProcesador,
		p.generacion as generacionProcesador,
		if(v.idVideo is null,0,v.idVideo) as idVideo,
		if(v.marca is null,'',v.marca) as marcaVideo,
		if(v.nombreModelo is null,'',v.nombreModelo) as nombreModeloVideo,
		if(v.capacidad is null,0,v.capacidad) as capacidadVideo,
		if(v.tipo is null,'',v.tipo) as tipoVideo,
		lc.partNumber as partNumber,
		lc.serieFabrica as serieFabrica,
		lc.garantia as garantia,
		lc.fecInicioSeguro as fecInicioSeguro,
		lc.fecFinSeguro as fecFinSeguro,
		lc.ubicacion as ubicacion,
		lc.observacion as observacion,
		lc.estado as estado
FROM vista_maestro_laptops lc 
		left join  vista_maestro_procesador p on lc.idProcesador=p.idProcesador 
		left join vista_maestro_video v on lc.idVideo=v.idVideo 
ORDER BY lc.idLC ;

/*Se mostrará todas las laptops que pertenezcan a un cliente cuando se le filtre por idCliente y que además estén en estado alquilado*/
create view vista_laptops_detalle_alquiler_cliente_estado_alquilado as
Select d.idSalidaDet as IdSalidaDetalle,
		s.idSucursal as IdSucursal,
		d.idLC as IdLC,
		s.idCliente as IdCliente,
		lc.idMarca as idMarca,
		lc.marca as MarcaLC,
		lc.idModelo as idModelo,
		lc.nombreModelo as NombreModeloLC,
		lc.codigo as Codigo,
		lc.tamanoPantalla as TamanoPantalla,
		p.idProcesador as idProcesador,
		p.marca as marcaProcesador,
		p.tipo as TipoProcesador,
		p.generacion as GeneracionProcesador,
		if(v.idVideo is null,0,v.idVideo) as idVideo,
		if(v.marca is null,'',v.marca) as marcaVideo,
		if(v.nombreModelo is null,'',v.nombreModelo) as NombreModeloVideo,
		if(v.capacidad is null,0,v.capacidad) as CapacidadVideo,
		if(v.tipo is null,'',v.tipo) as tipoVideo
From salida s INNER JOIN salida_det d on s.idSalida=d.idSalida
		left join  vista_maestro_laptops lc on d.idLC=lc.idLC
		left join  vista_maestro_procesador p on d.idProcesador=p.idProcesador 
		left join vista_maestro_video v on d.idVideo=v.idVideo 
where d.fueDevuelto=0 and (d.estado=4 or d.estado=9)
ORDER BY lc.idLC ;


create view vista_lista_devoluciones as
Select a.idDevolucion as IdDevolucion,
			 a.idCliente as IdCliente,
			 a.usuario_ins as NombreKam,
			 a.estado as IdEstado,
			 c.nombre_razonSocial as NombreCliente,
			 cast(a.fec_ins as date) as FechaProceso,
			 e.nombreEstado as Estado
From devolucion a inner join cliente c on a.idCliente=c.idCliente 
				inner join estados e on a.estado=e.idEstado;
				
				
create view vista_lista_cambios as
Select a.idCambio as IdCambio,
			 a.idCliente as IdCliente,
			 a.usuario_ins as NombreKam,
			 a.estado as IdEstado,
			 c.nombre_razonSocial as NombreCliente,
			 cast(a.fec_ins as date) as FechaProceso,
			 e.nombreEstado as Estado
From cambio a inner join cliente c on a.idCliente=c.idCliente 
				inner join estados e on a.estado=e.idEstado;

create view vista_datos_laptop_por_cambiar as
SELECT d.idLC as IdLCAntiguo,
		s.idSalida as IdSalida ,
		d.idSalidaDet as IdSalidaDet ,
		l.codigo as CodigoLCAntiguo,
		s.idCliente as IdCliente,
		s.idSucursal as IdSucursal,
		c.nombre_razonSocial as NombreCliente,
		s.rucDni as RucDni
FROM salida_det d 
		INNER JOIN salida s on d.idSalida=s.idSalida 
		INNER JOIN laptop_cpu l on d.idLC=l.idLC 
		INNER JOIN cliente c on s.idCliente=c.IdCliente
where d.estado=4 and fueDevuelto=0;