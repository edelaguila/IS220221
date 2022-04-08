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
    formulaConcepto VARCHAR(60) NOT NULL,      #/Abrir modulo formulas/
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
