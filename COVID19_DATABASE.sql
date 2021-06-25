--****************************************************
-- Bases de datos: Base de datos de COVID-19 APP
-- Proyecto final de BD y POO
-- Integrantes: 
--Karen Alejandra Martinez Medrano
--Gerardo Ernesto Henriquez Rodriguez
--Paolo Alessandro Dueñas Martinez
--Angel Daniel Vásquez Campos

--****************************************************

-- Creando base de datos y seleccionandola para realizar consultas 

CREATE DATABASE COVID19_DATABASE;	
USE [COVID19_DATABASE]; 				
SET LANGUAGE us_english;

-- Creacion de tablas.

--TABLA EMPLEADO Y  TABLA TIPO
CREATE TABLE EMPLEADO(
	identificador INT PRIMARY KEY,
	nombre VARCHAR (50) NOT NULL,
	email VARCHAR (50) NOT NULL,
	direccion VARCHAR (150) NOT NULL,
	usuario VARCHAR (20) NULL,
	contrasenia VARCHAR (25) NULL,
	--FK
	id_tipo INT NOT NULL,
	id_cabina INT NOT NULL
);

CREATE TABLE TIPO(
	id INT PRIMARY KEY IDENTITY,
	tipo VARCHAR (50) NOT NULL
);

CREATE TABLE HISTORIAL(
	id INT PRIMARY KEY IDENTITY,
	fecha_hora DATETIME NOT NULL,
	--FK
	id_cabina INT NOT NULL
);

CREATE TABLE EMPLEADOXHISTORIAL(
	id INT PRIMARY KEY IDENTITY,
	--FK
	id_historial INT NOT NULL,
	id_empleado INT NOT NULL
);

--TABLA CABINA
CREATE TABLE CABINA(
	id INT PRIMARY KEY IDENTITY,
	direccion VARCHAR (150) NOT NULL,
	telefono VARCHAR (9) NOT NULL,
	email VARCHAR (50) NOT NULL,
);

--TABLA CITA, TABLA LUGAR Y TABLA HORA
CREATE TABLE CITA(
	id INT PRIMARY KEY IDENTITY,
	fecha_hora DATETIME NOT NULL,
	identificador_cita INT NOT NULL,
	--FK
	id_lugar INT NOT NULL,
	identificador_empleado INT NOT NULL,
	id_ciudadano VARCHAR(10) NOT NULL
);

CREATE TABLE LUGAR(
	id INT PRIMARY KEY IDENTITY,
	lugar VARCHAR (50) NOT NULL
);

--TABLA CIUDADANO, TABLA ENFERMEDAD Y TABLA NUMERO_IDENTIFICADOR
CREATE TABLE CIUDADANO(
	dui VARCHAR(10) PRIMARY KEY,
	nombre VARCHAR(50) NOT NULL,
	direccion VARCHAR(150) NOT NULL,
	telefono VARCHAR (9) NOT NULL,
	email VARCHAR(50) NULL,
	numero_identificador INT  NULL, 
	--FK
	identificador_empleado INT NOT NULL,
);

CREATE TABLE ENFERMEDAD(
	id INT PRIMARY KEY IDENTITY,
	enfermedad VARCHAR (50) NULL,
	--FK
	id_ciudadano VARCHAR(10) NOT NULL
);


--TABLA VACUNACION Y TABLA EFECTO_SECUNDARIO
CREATE TABLE VACUNACION(
	id INT PRIMARY KEY IDENTITY,
	fecha_hora_entrada DATETIME NOT NULL,
	fecha_hora_salida DATETIME NOT NULL,
	tiempo INT NULL,
	--FK
	id_efecto_secundario INT NOT NULL,
	id_ciudadano VARCHAR(10) NOT NULL
);


CREATE TABLE EFECTO_SECUNDARIO(
	id INT PRIMARY KEY IDENTITY,
	efecto_secundario VARCHAR(30) NULL
);


--CREANDO LLAVES FORANEAS
-- FK
-- TIPO -> EMPLEADO
ALTER TABLE EMPLEADO ADD FOREIGN KEY (id_tipo) REFERENCES TIPO(id);
-- CABINA -> HISTORIAL
ALTER TABLE HISTORIAL ADD FOREIGN KEY (id_cabina) REFERENCES CABINA(id);
-->CABINA -> EMPLEADO 
ALTER TABLE EMPLEADO ADD FOREIGN KEY (id_cabina) REFERENCES CABINA (id);
--EMPLEADO -> EMPLEADOXHISTORIAL
ALTER TABLE EMPLEADOXHISTORIAL ADD FOREIGN KEY (id_empleado) REFERENCES EMPLEADO(identificador);
--HISTORIAL -> EMPLEADOXHISTORIAL
ALTER TABLE EMPLEADOXHISTORIAL ADD FOREIGN KEY (id_historial) REFERENCES HISTORIAL(id);
-- EMPLEADO -> CITA
ALTER TABLE CITA ADD FOREIGN KEY (identificador_empleado) REFERENCES EMPLEADO(identificador);
-- LUGAR -> CITA
ALTER TABLE CITA ADD FOREIGN KEY (id_lugar) REFERENCES LUGAR(id);
--CITA -> CIUDADANO
ALTER TABLE CITA ADD FOREIGN KEY (id_ciudadano) REFERENCES CIUDADANO(dui);
-- EMPLEADO -> CIUDADANO
ALTER TABLE CIUDADANO ADD FOREIGN KEY (identificador_empleado) REFERENCES EMPLEADO(identificador);
-- CIUDADANO -> VACUNACION
ALTER TABLE VACUNACION ADD FOREIGN KEY (id_ciudadano) REFERENCES CIUDADANO(dui);
-- CIUDADANO -> ENFERMEDAD
ALTER TABLE ENFERMEDAD ADD FOREIGN KEY (id_ciudadano) REFERENCES CIUDADANO(dui);
-- EFECTO SECUNDARIO -> VACUNACION
ALTER TABLE VACUNACION ADD FOREIGN KEY (id_efecto_secundario) REFERENCES EFECTO_SECUNDARIO(id);


--INSERTANDO VALORES DE TABLA TIPO EMPLEADO
INSERT INTO TIPO VALUES('Gestor');
INSERT INTO TIPO VALUES('Encargado');
INSERT INTO TIPO VALUES('Vacunador');
INSERT INTO TIPO VALUES('Asistente de salud');
INSERT INTO TIPO VALUES('Seguridad');

--INSERTANDO VALORES A TABLA CABINA
INSERT INTO CABINA VALUES('Hospital El Salvador ,Ave.La revolución 222,Colonia San Benito San Salvador','2594-2100','HospitalElSalvador@salud.gob.sv');
INSERT INTO CABINA VALUES('Carretera Panamericana y Calle Chiltiupan Antiguo Cuscatlán, La Libertad Centroamérica, Cd Merliot','2249-3800','CabinaLaGranvia@salud.gob.sv');
INSERT INTO CABINA VALUES('Unidad de salud,Segunda calle oriente, Lourdes Colón, La Libertad','7924-6281','FosaludLourdes@salud.gob.sv');
INSERT INTO CABINA VALUES('25 AV.Norte,entre Primera Calle Poniente y Alameda Roosevelt. San Salvador, El Salvador, C.A.','2231-9200','HospitalRosales@salud.gob.sv');
INSERT INTO CABINA VALUES('Final 25 Avenida Norte y 27 Calle Poniente San Salvador El Salvador','2225-4114','HospitalBloom@salud.gob.sv');


--INSERTANDO VALORES A TABLE EMPLEADO
INSERT INTO EMPLEADO VALUES(1,'Gerardo Henriquez','gerardohenriquez@salud.gob.sv','miralvalle, san salvador, casa #P10','GerardoHqz','pikachu123',1,1);
INSERT INTO EMPLEADO VALUES(2,'Juanca Galindo','JuancaGalindo@salud.gob.sv','Colonia La Campanera, Soyapango, casa #18',null,null,3,1);
INSERT INTO EMPLEADO VALUES(3,'Paolo Duenas','PaoloDuenas@salud.gob.sv','Arcos de Santa Elena,Calla de Verapaz, #E-11','Paolin','paolin',1,2);
INSERT INTO EMPLEADO VALUES(4,'Karen Martinez','KarenMartinez@salud.gob.sv','Colonia Altos de Guadalupe, casa #209','KarenMartz','karen123',1,3);
INSERT INTO EMPLEADO VALUES(5,'Angel Vasquez','AngelVasquez@salud.gob.sv','Colonia Libertad av. Washington casa n° 56 San Salvador','AVasquez','angel123',1,4);
INSERT INTO EMPLEADO VALUES(6,'Monolo Diaz','ManoloDiaz@salud.gob.sv','Condado Santa Elena, Casa #29',null,null,2,4);
INSERT INTO EMPLEADO VALUES(7,'Marvin Rodriguez','MarvinRodriguez@salud.gob.sv','Bosquez de Lourdes, casa #9,Lourde Colon',null,null,2,4);
INSERT INTO EMPLEADO VALUES(8,'Dolores Delano','DoloresDelano@salud.gob.sv','Ave.Bernald, casa #63, San Salvador',null,null,2,3);
INSERT INTO EMPLEADO VALUES(9,'Walter Morales','WalterMorales@salud.gob.sv','Residencial Las Acasias, casa #18, Lourdes Colon',null,null,2,3);
INSERT INTO EMPLEADO VALUES(10,'Diego Maradona','DiegoMaradona@salud.gob.sv','Ave.Paraiso, Residencial Los Angeles, casa #10',null,null,5,1);

--INSERTANDO VALORES A TABLA LUGAR 
INSERT INTO LUGAR VALUES('Hospital El Salvador');
INSERT INTO LUGAR VALUES('Parqueo la Gran Vía');
INSERT INTO LUGAR VALUES('Fosalud Colonia Lourdes');
INSERT INTO LUGAR VALUES('Hospital Rosales');
INSERT INTO LUGAR VALUES('Hospital Bloom');

--INSERTANDO VALORES A TABLA EFECTO SECUNDARIO
INSERT INTO EFECTO_SECUNDARIO VALUES('Dolor o sensiblidad');
INSERT INTO EFECTO_SECUNDARIO VALUES('Enrojecimiento');
INSERT INTO EFECTO_SECUNDARIO VALUES('Fatiga');
INSERT INTO EFECTO_SECUNDARIO VALUES('Dolor de cabeza');
INSERT INTO EFECTO_SECUNDARIO VALUES('Fiebre');
INSERT INTO EFECTO_SECUNDARIO VALUES('Mialgia');
INSERT INTO EFECTO_SECUNDARIO VALUES('Artralgia');
INSERT INTO EFECTO_SECUNDARIO VALUES('Anafilaxia');
INSERT INTO EFECTO_SECUNDARIO VALUES('Otros..');
INSERT INTO EFECTO_SECUNDARIO VALUES('Ninguna.');

--INSERTANDO VALORES A TABLA CIUDADANO
INSERT INTO CIUDADANO VALUES('06265092-6','Karen Alejandra Martinez Medrano','en nunca jamas','76368036','KarenAlejandra@gmail.com',1,1);

--INSERTANDO VALORES A TABLA ENFERMEDAD
INSERT INTO ENFERMEDAD VALUES('Diabetes M','06265092-6');
INSERT INTO ENFERMEDAD VALUES('Hipertension','06265092-6');

--INSERTANDO VALORES A TABLA CITA
INSERT INTO CITA VALUES('2021-06-28 13:00:00',1,1,5,'06265092-6');

--iNSERTANDO VALORES A TABLA VACUNACION
INSERT INTO VACUNACION VALUES('2021-06-28 13:00:00', '2021-06-28 13:30:00',15,1,'06265092-6');

select * from EMPLEADO


--DROP TABLE VACUNACION
--DROP TABLE CITA
--DROP TABLE LUGAR
--DROP TABLE ENFERMEDAD
--DROP TABLE EMPLEADOXHISTORIAL
--DROP TABLE HISTORIAL
--DROP TABLE CABINA
--DROP TABLE CIUDADANO
--DROP TABLE EMPLEADO
--DROP TABLE TIPO
--DROP TABLE EFECTO_SECUNDARIO
--DROP DATABASE COVID19_DATABASE

--DELETE CABINA
--DELETE CITA
--DELETE LUGAR
--DELETE ENFERMEDAD
--DELETE CIUDADANO
--DELETE EMPLEADO
--DROP TABLE TIPO
--DROP TABLE EFECTO_SECUNDARIO
--DROP TABLE VACUNACION


select * from ciudadano
select * from CITA



