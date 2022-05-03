use hotelSanCarlos;

-- --------------------------------------------------------------------------------------------------------------------------------------
-- Primer sprint - Angel Chacón - Tablasjornada y conceptos - Fecha: 04/04/2022
-- --------------------------------------------------------------------------------------------------------------------------------------
-- se hizo un alter a la tabla de banco ya que no tenia el campo estado
alter table banco add estado VARCHAR(1) NOT NULL;
-- se normalizo el campo esta de la tabla modena
alter table moneda drop estadomoneda;
alter table moneda add estado VARCHAR(1) NOT NULL;
-- tablas necesarias para los conceptos
CREATE TABLE excepciones (
    pkIdExcepcion VARCHAR(15) NOT NULL,         
    nombreExcepcion VARCHAR(50) NOT NULL,   #/valor unico, Valor Constante BD, Valor por periodo/        
    estado VARCHAR(1) NOT NULL,
    PRIMARY KEY (pkIdExcepcion)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE concepto (
    pkIdConcepto VARCHAR(15) NOT NULL,           #001
    nombreConcepto VARCHAR(60) NOT NULL,        #Horas Extras          
    efectoConcepto VARCHAR(1) NOT NULL,         #/Ingreso, Descuento/
    fkIdExcepcion VARCHAR(15) NOT NULL,     #/Todos, ninguno, Unicamente a, Exepto a/
    formulaConcepto VARCHAR(800) NOT NULL,      #/Abrir modulo formulas/
    estado VARCHAR(1) NOT NULL,        #/A, I/
    PRIMARY KEY (pkIdConcepto),    
    FOREIGN KEY (fkIdExcepcion) REFERENCES excepciones (pkIdExcepcion)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
-- cambio de datos para las ayudas de los mantenimientos de las tablas asignadas
UPDATE aplicacion SET rutaChm='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\Ayudas-Pareja2\\ayuda bancos y moneda.chm',rutaHtml='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\Ayudas-Pareja2\\Ayuda-para-la-vista-del-mantenimiento-de-bancos.html' WHERE pkId='0009';
UPDATE aplicacion SET rutaChm='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\Ayudas-Pareja2\\ayuda bancos y moneda.chm',rutaHtml='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\Ayudas-Pareja2\\Ayuda-para-la-vista-del-mantenimiento-de-moneda.html' WHERE pkId='0010';

UPDATE aplicacion SET rutaChm='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\Ayudas-Pareja2\\AyudaConceptosExcepciones.chm',rutaHtml='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\Ayudas-Pareja2\\Ayuda-para-la-vista-del-mantenimiento-de-conceptos.html' WHERE pkId='0007';
UPDATE aplicacion SET rutaChm='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\Ayudas-Pareja2\\AyudaConceptosExcepciones.chm',rutaHtml='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\Ayudas-Pareja2\\Ayuda-para-la-vista-del-mantenimiento-de-Excepciones.html' WHERE pkId='0008';
-- indicacion de las rutas de los reportes de conceptos y las excepciones
INSERT INTO reporte VALUES ('1','Reporte 1','C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\ModuloRRHH\\CapaVistaRRHH\\ReporteExcepciones.rpt','0008','1');
INSERT INTO reporte VALUES ('2','Reporte 2','C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\ModuloRRHH\\CapaVistaRRHH\\ReporteConceptos.rpt','0007','1');

-- inserts a la tabla de modulo para los reportes de conceptos y las excepciones
insert into modulo values ('2','Banco','Modulo Bancos','1');
insert into modulo values ('3','Conceptos','Modulo Coceptos','1');


-- Tabla para guardar las sentencias SQl
CREATE TABLE sentenciaSqlPlanilla (      
    fkIdConcepto VARCHAR(15), 
    sentenciaSql VARCHAR(100)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


-- --------------------------------------------------------------------------------------------------------------------------------------
-- Tercer sprint - Angel Chacón - Tabla ISR ENCABEZADO Y DETALLE E INSERTS - Fecha: 09/04/2022
-- --------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE isrencabezado (
    pkIdISR VARCHAR(15),
    periodoInicio DATE NOT NULL,
    periodoFinal DATE NOT NULL,
    isrTotal DOUBLE(10,2) NOT NULL,
    estado VARCHAR(1) NOT NULL,
    PRIMARY KEY (pkIdISR)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE isrdetalle (
    fkIdISR VARCHAR(15) NOT NULL,     
    fkIdEmpleado VARCHAR(15) NOT NULL,
    isrSubTotal DOUBLE(10,2) NOT NULL,
    estado VARCHAR(1) NOT NULL,
    FOREIGN KEY (fkIdISR) REFERENCES isrencabezado (pkIdISR),
    FOREIGN KEY (fkIdEmpleado) REFERENCES empleado (pkIdEmpleado)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `hotelsancarlos`.`empleado` (`pkIdEmpleado`, `nombre`, `apellido`, `fechaDeNacimiento`, `sueldo`, `correo`, `direccion`, `contratado`, `añosDeExperiencia`, `telefono`, `fechaContratacion`, `finDeContrato`, `fkIdPuesto`, `fkIdEmpresa`, `estado`) VALUES ('2', 'Pedro', 'Sanchez', '1998-05-23', '3500', 'spedro@gmail.com', 'zona 2', '4', '5', '65985874', '2016-11-03', '2021-12-01', '1', '1', '1');

INSERT INTO `hotelsancarlos`.`isrencabezado` (`pkIdISR`, `periodoInicio`, `periodoFinal`, `isrTotal`, `estado`) VALUES ('1', '2017-01-01', '2017-01-31', '13750', '1');
INSERT INTO `hotelsancarlos`.`isrencabezado` (`pkIdISR`, `periodoInicio`, `periodoFinal`, `isrTotal`, `estado`) VALUES ('2', '2017-02-01', '2017-02-28', '13650', '1');
INSERT INTO `hotelsancarlos`.`isrencabezado` (`pkIdISR`, `periodoInicio`, `periodoFinal`, `isrTotal`, `estado`) VALUES ('3', '2017-03-01', '2017-03-31', '13850', '1');
INSERT INTO `hotelsancarlos`.`isrencabezado` (`pkIdISR`, `periodoInicio`, `periodoFinal`, `isrTotal`, `estado`) VALUES ('4', '2017-04-01', '2017-04-30', '13750', '1');
INSERT INTO `hotelsancarlos`.`isrencabezado` (`pkIdISR`, `periodoInicio`, `periodoFinal`, `isrTotal`, `estado`) VALUES ('5', '2017-05-01', '2017-05-31', '13650', '1');
INSERT INTO `hotelsancarlos`.`isrencabezado` (`pkIdISR`, `periodoInicio`, `periodoFinal`, `isrTotal`, `estado`) VALUES ('6', '2017-06-01', '2017-06-30', '13850', '1');
INSERT INTO `hotelsancarlos`.`isrencabezado` (`pkIdISR`, `periodoInicio`, `periodoFinal`, `isrTotal`, `estado`) VALUES ('7', '2017-07-01', '2017-07-31', '13750', '1');
INSERT INTO `hotelsancarlos`.`isrencabezado` (`pkIdISR`, `periodoInicio`, `periodoFinal`, `isrTotal`, `estado`) VALUES ('8', '2017-08-01', '2017-08-31', '13650', '1');
INSERT INTO `hotelsancarlos`.`isrencabezado` (`pkIdISR`, `periodoInicio`, `periodoFinal`, `isrTotal`, `estado`) VALUES ('9', '2017-09-01', '2017-09-30', '13850', '1');
INSERT INTO `hotelsancarlos`.`isrencabezado` (`pkIdISR`, `periodoInicio`, `periodoFinal`, `isrTotal`, `estado`) VALUES ('10', '2017-10-01', '2017-10-31', '13750', '1');
INSERT INTO `hotelsancarlos`.`isrencabezado` (`pkIdISR`, `periodoInicio`, `periodoFinal`, `isrTotal`, `estado`) VALUES ('11', '2017-11-01', '2017-11-30', '13650', '1');
INSERT INTO `hotelsancarlos`.`isrencabezado` (`pkIdISR`, `periodoInicio`, `periodoFinal`, `isrTotal`, `estado`) VALUES ('12', '2017-12-01', '2017-12-31', '13850', '1');
INSERT INTO `hotelsancarlos`.`isrencabezado` (`pkIdISR`, `periodoInicio`, `periodoFinal`, `isrTotal`, `estado`) VALUES ('13', '2017-01-01', '2017-12-31', '165000', '1');
INSERT INTO `hotelsancarlos`.`isrencabezado` (`pkIdISR`, `periodoInicio`, `periodoFinal`, `isrTotal`, `estado`) VALUES ('14', '2018-01-01', '2018-01-31', '13750', '1');

insert into isrdetalle values ('1','1','2750','1');
insert into isrdetalle values ('1','2','2750','1');
insert into isrdetalle values ('1','4','2750','1');
insert into isrdetalle values ('1','5','2750','1');
insert into isrdetalle values ('1','6','2750','1');

insert into isrdetalle values ('13','1','33000','1');
insert into isrdetalle values ('13','2','33000','1');
insert into isrdetalle values ('13','4','33000','1');
insert into isrdetalle values ('13','5','33000','1');
insert into isrdetalle values ('13','6','33000','1');

-- --------------------------------------------------------------------------------------------------------------------------------------
-- Tercer sprint - Heydi Quemé, Kevin Flores - Tabla nomina detalle y encabezado - Fecha: 18/04/2022
-- --------------------------------------------------------------------------------------------------------------------------------------
create table nomina_e
(
CodigoNominaE varchar (15) primary key,
FechaInicialN date not null,
FechaFinalN date not null,
TotalPercepciones float,
TotalDeducciones float,
TotalLiquido float,
 estado char(1) not null
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table nomina_d
(
CodigoNominaE varchar (15) not null,
pkIdEmpleado varchar (15) not null,
pkIdConcepto varchar (15) not null,
SueldoBase decimal not null,
CalculoConcepto float not null,
SueldoLiquido float not null,
estado varchar(1) not null,

foreign key (CodigoNominaE) references
nomina_e(CodigoNominaE),
foreign key (pkIdEmpleado) references
empleado(pkIdEmpleado),
foreign key (pkIdConcepto) references
concepto(pkIdConcepto)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------------------------------------------------------------------------------------
-- Tercer sprint - Angel Chacón - Tabla conceptos - Fecha: 28/04/2022
-- --------------------------------------------------------------------------------------------------------------------------------------

use hotelsancarlos;

DROP TABLE concepto;
DROP TABLE excepciones;

CREATE TABLE concepto (
    pkIdConcepto VARCHAR(15) PRIMARY KEY,           #001
    nombreConcepto VARCHAR(60) NOT NULL,        #Horas Extras          
    efectoConcepto VARCHAR(1) NOT NULL,         #/Ingreso, Descuento/
    aplicacion VARCHAR(25) NOT NULL,     #/Todos, Unicamente a, Exepto a/
    formulaConcepto VARCHAR(800) NOT NULL,      #/Abrir modulo formulas/
    estado VARCHAR(1) NOT NULL       #/A, I/
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

insert into concepto values ("1","Concepto 1","+","todos","250","1");


-- --------------------------------------------------------------------------------------------------------------------------------------
-- Tercer sprint - Heydi Quemé, Kevin Flores - tabla jornada, empleado y periodo - Fecha: 18/04/2022
-- --------------------------------------------------------------------------------------------------------------------------------------

ALTER TABLE `hotelsancarlos`.`empleado` 
CHANGE COLUMN `contratado` `fkIdJornada` VARCHAR(15) NOT NULL ;

ALTER TABLE `hotelsancarlos`.`empleado` 
ADD CONSTRAINT `jornada_ibfk_1`
  FOREIGN KEY (`fkIdJornada`)
  REFERENCES `hotelsancarlos`.`jornada` (`pkId`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;

CREATE TABLE jornada (
    pkId VARCHAR(15) PRIMARY KEY,   
    nombre VARCHAR(60) NOT NULL,              
    horaInicio time NULL,
    horaFin time NULL,    
    horasJornada VARCHAR(10) not NULL, 
    estado VARCHAR(1) NOT NULL       
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

  ALTER TABLE empleado ADD FOREIGN KEY (fkIdJornada) REFERENCES jornada(pkid);
  
  INSERT INTO JORNADA VALUES ("1","Matutina", "8:00:00","17:00:00","8","1");
  INSERT INTO JORNADA VALUES ("2","Diurna", "15:00:00","22:00:00","6","1");

CREATE TABLE periodo (
    pkId VARCHAR(15) PRIMARY KEY,           
    nombre VARCHAR(60) NOT NULL,                  
    inicio date NOT NULL,         
    fin date NOT NULL,    
    estado VARCHAR(1) NOT NULL       
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
  

  -- --------------------------------------------------------------------------------------------------------------------------------------
-- Tercer sprint - Angel Chacón - tabla para la asignación de empleados a los conceptos - Fecha: 02/05/2022
-- --------------------------------------------------------------------------------------------------------------------------------------

create table empleado_concepto(
fkIdConcepto varchar(15) not null,
fkIdEmpleado varchar(15) not null
)ENGINE=InnoDB DEFAULT CHARSET=latin1;