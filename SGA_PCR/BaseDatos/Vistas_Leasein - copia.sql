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
	where s.estado="Atendido" 
		and d.estado="Activo" 
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
	where s.estado="Atendido" 
		and d.estado="Activo" 
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
Select 	d.idDisco as idDisco,
		m.nombre as tipo,
		d.tamano as tamano,
		d.capacidad as capacidad,
		d.cantidad as cantidad,
		d.estado as estado
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
Select 	me.idMemoria as idMemoria,
		ma.nombre as categoria,
		m.nombre as tipo,
		me.busFrecuencia as frecuencia,
		me.capacidad as capacidad,
		me.cantidad as cantidad,
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
Select idMarca, nombre
from marca
where idCategoria=9 and estado=1;

		
/*Se mostrará las marcas de las tarjetas de videos*/
create view vista_video_marca as
Select idMarca, nombre
from marca
where idCategoria=11 and estado=1;
		

/*Se mostrará todas las licencias*/
create view vista_licencia_lista as
Select l.idLicencia as idLicencia,
				c.nombre as categoria,
				ma.nombre as marca,
				mo.nombre as version,
				l.idLC as idLC,
				l.clave as clave,
				l.ubicacion as ubicacion
from licencia l, modelo mo, marca ma, categoria c
where l.idModelo=mo.idModelo and ma.idMarca=mo.idMarca and c.idCategoria=ma.idCategoria;
		
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


