CREATE DATABASE SellPoint

USE SellPoint

----CREACIÓN DE TABLAS 

CREATE TABLE Entidades
(
IdEntidad INT PRIMARY KEY IDENTITY NOT NULL,
Descripcion VARCHAR(120) NOT NULL,
Direccion VARCHAR(120) NOT NULL,
Localidad VARCHAR(40) NOT NULL,
TipoEntidad VARCHAR(8) NOT NULL,
TipoDocumento VARCHAR(9) NOT NULL,
NumeroDocumento VARCHAR(15) NOT NULL,
Telefonos VARCHAR(60) NOT NULL,
URLPaginaWeb VARCHAR(120),
URLFacebook VARCHAR(120),
URLInstagram VARCHAR(120),
URLTwitter VARCHAR(120),
URLtiktok VARCHAR(120),
IdGrupoEntidad  VARCHAR(120)NOT NULL,
IdTipoEntidad VARCHAR(120) NOT NULL,
LimiteCredito VARCHAR(120) NOT NULL,
UserNameEntidad VARCHAR(60) NOT NULL,
PassworEntidad VARCHAR(30) NOT NULL,
RolUserEntidad VARCHAR(10) NOT NULL,
Comentario TEXT,
StatusEntidad VARCHAR(10) NOT NULL,
NoEliminable BIT NOT NULL,
FechaRegistro DATE NOT NULL
)

CREATE TABLE GruposEntidades
(
IdGrupoEntidad INT PRIMARY KEY IDENTITY NOT NULL,
Descripcion VARCHAR(120) NOT NULL,
Comentario TEXT,
StatusGrupo VARCHAR(10) NOT NULL,
NoEliminable BIT NOT NULL,
FechaRegistro DATE NOT NULL
)

CREATE TABLE TiposEntidades
(
IdTipoEntidad INT PRIMARY KEY IDENTITY NOT NULL,
Descripcion VARCHAR(120) NOT NULL,
IdGrupoEntidad VARCHAR(120) NOT NULL,
Comentario TEXT,
StatusTiposEntidades VARCHAR(10) NOT NULL,
NoELiminable BIT NOT NULL,
FechaRegistro DATE NOT NULL
)


----REGISTROS

INSERT INTO TiposEntidades
(Descripcion,IdGrupoEntidad,Comentario,StatusTiposEntidades,NoELiminable,FechaRegistro)
VALUES 
('Hola', 1,'Buenos dias','Activo',1,'2022-01-12')

SELECT * FROM TiposEntidades

----PARA CARGAR LOS COMBOBOX


CREATE TABLE Statuss
(
Id INT PRIMARY KEY IDENTITY NOT NULL,
Estado VARCHAR(10) NOT NULL
)

INSERT INTO Statuss
(Estado) VALUES
('Activo'),('Inactivo')

CREATE TABLE Rol
(
Id INT PRIMARY KEY IDENTITY NOT NULL,
Roles VARCHAR(10) NOT NULL,
)

CREATE TABLE Documento
(
Id INT PRIMARY KEY IDENTITY NOT NULL,
Documento VARCHAR(9) NOT NULL
)

CREATE TABLE EntidadTipo
(
Id INT PRIMARY KEY IDENTITY NOT NULL,
Entidad VARCHAR(8) NOT NULL
)

SELECT * FROM Entidades
SELECT * FROM GruposEntidades
SELECT * FROM TiposEntidades



create proc SP_InsertarRegistro
(
@Descripcion VARCHAR(120)  ,
@Direccion VARCHAR(120)  ,
@Localidad VARCHAR(40)  ,
@TipoEntidad VARCHAR(8)  ,
@TipoDocumento VARCHAR(9)  ,
@NumeroDocumento VARCHAR(15)  ,
@Telefonos VARCHAR(60)  ,
@URLPaginaWeb VARCHAR(120),
@URLFacebook VARCHAR(120),
@URLInstagram VARCHAR(120),
@URLTwitter VARCHAR(120),
@URLtiktok VARCHAR(120),
@IdGrupoEntidad INT  ,
@IdTipoEntidad INT  ,
@LimiteCredito INT  ,
@UserNameEntidad VARCHAR(60)  ,
@PassworEntidad VARCHAR(30)  ,
@RolUserEntidad VARCHAR(10)  ,
@Comentario TEXT,
@StatusEntidad VARCHAR(10)  ,
@NoEliminable BIT  ,
@FechaRegistro DATE  
)
as
  begin  
    insert into Entidades(Descripcion,Direccion,TipoEntidad,NumeroDocumento,Telefonos,URLPaginaWeb,URLFacebook,URLInstagram,
    URLTwitter,URLtiktok,IdGrupoEntidad,IdTipoEntidad,LimiteCredito,UserNameEntidad,PassworEntidad,RolUserEntidad,Comentario,StatusEntidad,NoEliminable,FechaRegistro,Localidad,TipoDocumento)
    values(@Descripcion,@Direccion,@TipoEntidad,@NumeroDocumento,@Telefonos,@URLPaginaWeb,@URLFacebook,@URLInstagram,
    @URLTwitter,@URLtiktok,@IdGrupoEntidad,@IdTipoEntidad,@LimiteCredito,@UserNameEntidad,@PassworEntidad,@RolUserEntidad,@Comentario,@StatusEntidad,@NoEliminable,@FechaRegistro,@Localidad,@TipoDocumento)
  end

  create proc SP_UpdateRegistro
(
@Id int,
@Descripcion VARCHAR(120)  ,
@Direccion VARCHAR(120)  ,
@Localidad VARCHAR(40)  ,
@TipoEntidad VARCHAR(8)  ,
@TipoDocumento VARCHAR(9)  ,
@NumeroDocumento VARCHAR(15)  ,
@Telefonos VARCHAR(60)  ,
@URLPaginaWeb VARCHAR(120),
@URLFacebook VARCHAR(120),
@URLInstagram VARCHAR(120),
@URLTwitter VARCHAR(120),
@URLtiktok VARCHAR(120),
@IdGrupoEntidad INT  ,
@IdTipoEntidad INT  ,
@LimiteCredito INT  ,
@UserNameEntidad VARCHAR(60)  ,
@PassworEntidad VARCHAR(30)  ,
@RolUserEntidad VARCHAR(10)  ,
@Comentario TEXT,
@StatusEntidad VARCHAR(10)  ,
@NoEliminable BIT  ,
@FechaRegistro DATE  
)
as
  begin  
  Update Entidades set Descripcion = @Descripcion ,Direccion = @Direccion ,TipoEntidad = @TipoEntidad,NumeroDocumento = @NumeroDocumento,Telefonos = @Telefonos,URLPaginaWeb = @URLPaginaWeb,URLFacebook = @URLFacebook,URLInstagram = @URLInstagram,
      URLTwitter = @URLTwitter,URLtiktok= @URLtiktok,IdGrupoEntidad = @IdGrupoEntidad,IdTipoEntidad = @IdTipoEntidad,LimiteCredito = @LimiteCredito,UserNameEntidad = @UserNameEntidad,PassworEntidad = @PassworEntidad,RolUserEntidad = @RolUserEntidad,Comentario = @Comentario,StatusEntidad = @StatusEntidad,NoEliminable = @NoEliminable,FechaRegistro = @FechaRegistro
      where IdEntidad = @Id
  end


  create proc SP_DeleteRegistro
(
@Id int
)
as
  begin  
    delete Entidades where IdEntidad = @Id
  end


  insert into Entidades(Descripcion,Direccion,TipoEntidad,NumeroDocumento,Telefonos,URLPaginaWeb,URLFacebook,URLInstagram,
    URLTwitter,URLtiktok,IdGrupoEntidad,IdTipoEntidad,LimiteCredito,UserNameEntidad,PassworEntidad,RolUserEntidad,Comentario,StatusEntidad,NoEliminable,FechaRegistro,Localidad,TipoDocumento)
    values('fff','fff','fff','5454','5446','lflf','jfff','ffff',
    'ffff','ggg','1','2','5','JOJO','12','FFF','GGGG','ACTIVA',0,'2022-01-12', 'SS','DF')

UPDATE TiposEntidades SET Descripcion='F',IdGrupoEntidad='FR',Comentario='NADA',StatusTiposEntidades='ACTIVO',NoEliminable= 0,FechaRegistro='2022-01-12' WHERE IdTipoEntidad  = 1

SELECT * FROM Entidades

SELECT Descripcion,Direccion,TipoEntidad,NumeroDocumento,Telefonos,URLPaginaWeb,URLFacebook,URLInstagram,URLTwitter, URLtiktok, IdGrupoEntidad, IdTipoEntidad, LimiteCredito, UserNameEntidad, PassworEntidad, RolUserEntidad, Comentario, StatusEntidad, NoEliminable, FechaRegistro, Localidad, TipoDocumento FROM Entidades WHERE IdEntidad = 1

SELECT UserNameEntidad, PassworEntidad FROM Entidades WHERE UserNameEntidad = 'JOJO' AND PassworEntidad = '12'



insert into Entidades(Descripcion,Direccion,TipoEntidad,NumeroDocumento,Telefonos,URLPaginaWeb,URLFacebook,URLInstagram,
    URLTwitter,URLtiktok,IdGrupoEntidad,IdTipoEntidad,LimiteCredito,UserNameEntidad,PassworEntidad,RolUserEntidad,Comentario,StatusEntidad,NoEliminable,FechaRegistro,Localidad,TipoDocumento)
    values('Comercial','Los Melones','Física','4502478963','8096558487','Laweb@gmail.com','Facebook@gmail.com',
    'Instagram@gmail.com','Twtter@gmail.com','Tiktok@gmail.com','Bussines','Negocios',6,'JOJO','FFF','Supervisor','Nueva','Activa',0,'2022-01-12', 'Santo Domingo','RNC')


	insert into Entidades(Descripcion,Direccion,TipoEntidad,NumeroDocumento,Telefonos,URLPaginaWeb,URLFacebook,URLInstagram,
    URLTwitter,URLtiktok,IdGrupoEntidad,IdTipoEntidad,LimiteCredito,UserNameEntidad,PassworEntidad,RolUserEntidad,Comentario,StatusEntidad,NoEliminable,FechaRegistro,Localidad,TipoDocumento)
    values('Comercial','Villa','Jurídica','4502478963','8096558487','Laweb@gmail.com','Facebook@gmail.com',
    'Instagram@gmail.com','Twtter@gmail.com','Tiktok@gmail.com','Bussines','Negocios',6,'Carlos','12','Admin','Nueva','Activa',0,'2022-01-12', 'Santo Domingo','RNC')

	insert into Entidades(Descripcion,Direccion,TipoEntidad,NumeroDocumento,Telefonos,URLPaginaWeb,URLFacebook,URLInstagram,
    URLTwitter,URLtiktok,IdGrupoEntidad,IdTipoEntidad,LimiteCredito,UserNameEntidad,PassworEntidad,RolUserEntidad,Comentario,StatusEntidad,NoEliminable,FechaRegistro,Localidad,TipoDocumento)
    values('Comercial','Los Melones','Física','4502478963','8096558487','Laweb@gmail.com','Facebook@gmail.com',
    'Instagram@gmail.com','Twtter@gmail.com','Tiktok@gmail.com','Bussines','Negocios',6,'Maria','14','Admin','Nueva','Activa',0,'2022-01-12', 'Bani','RNC')

	insert into Entidades(Descripcion,Direccion,TipoEntidad,NumeroDocumento,Telefonos,URLPaginaWeb,URLFacebook,URLInstagram,
    URLTwitter,URLtiktok,IdGrupoEntidad,IdTipoEntidad,LimiteCredito,UserNameEntidad,PassworEntidad,RolUserEntidad,Comentario,StatusEntidad,NoEliminable,FechaRegistro,Localidad,TipoDocumento)
    values('Comercial','Los Melones','Física','4502478963','8096558487','Laweb@gmail.com','Facebook@gmail.com',
    'Instagram@gmail.com','Twtter@gmail.com','Tiktok@gmail.com','Bussines','Negocios',6,'Geg','15','User','Nueva','Activa',0,'2022-01-12', 'San Pedro','RNC')

	insert into Entidades(Descripcion,Direccion,TipoEntidad,NumeroDocumento,Telefonos,URLPaginaWeb,URLFacebook,URLInstagram,
    URLTwitter,URLtiktok,IdGrupoEntidad,IdTipoEntidad,LimiteCredito,UserNameEntidad,PassworEntidad,RolUserEntidad,Comentario,StatusEntidad,NoEliminable,FechaRegistro,Localidad,TipoDocumento)
    values('Hospital','AliYen care Hospital','Salud','4502478963','8096558487','lflf','jfff','ffff',
    'ffff','eee','2','1','3','JOJO','1000','Ada','wong','ACTIVA',0,'2022-01-12', 'Raccon City','pasaporte')

	insert into Entidades(Descripcion,Direccion,TipoEntidad,NumeroDocumento,Telefonos,URLPaginaWeb,URLFacebook,URLInstagram,
    URLTwitter,URLtiktok,IdGrupoEntidad,IdTipoEntidad,LimiteCredito,UserNameEntidad,PassworEntidad,RolUserEntidad,Comentario,StatusEntidad,NoEliminable,FechaRegistro,Localidad,TipoDocumento)
    values('Comercial','Los Melones','Física','4502478963','8096558487','Laweb@gmail.com','Facebook@gmail.com',
    'Instagram@gmail.com','Twtter@gmail.com','Tiktok@gmail.com','Bussines','Negocios',6,'Geg','15','User','Nueva','Activa',0,'2022-01-12', 'San Pedro','RNC')


	Update Entidades set Descripcion = 'SuperMercado' ,Direccion = 'Villa' ,TipoEntidad = 'Física',NumeroDocumento = '4502478963',Telefonos = '8096558487',URLPaginaWeb = 'Laweb@gmail.com',URLFacebook = 'Facebook@gmail.com',URLInstagram = 'Instagram@gmail.com',
      URLTwitter = 'Twtter@gmail.com',URLtiktok= 'Tiktok@gmail.com',IdGrupoEntidad = 'Bussines',IdTipoEntidad = 'RNC',LimiteCredito = 4,UserNameEntidad = 'Lucia',PassworEntidad = 'ITLA',RolUserEntidad = 'Supervisor',Comentario = 'Editado',StatusEntidad = 'Activo',NoEliminable = 0,FechaRegistro = '2022-04-27'
      where IdEntidad = 7

INSERT INTO TiposEntidades
(Descripcion,IdGrupoEntidad,Comentario,StatusTiposEntidades,NoELiminable,FechaRegistro)
VALUES 
('Mercadito', '','Buenos dias',1,1,'2022-01-12')

insert into TiposEntidades(Descripcion, IdGrupoEntidad, Comentario, StatusTiposEntidades, NoELiminable, FechaRegistro)
                   Values ('Agencia', 'Comercios','Negocio', 'ACTIVA', 1, '2022-01-12' );

insert into TiposEntidades(Descripcion, IdGrupoEntidad, Comentario, StatusTiposEntidades, NoELiminable, FechaRegistro)
                   Values ('Cine', 'Colmado','Entretenimiento', 'ACTIVA', 0, '2022-01-12' );

SELECT * FROM TiposEntidades

UPDATE TiposEntidades SET Descripcion = 'Teatro', IdGrupoEntidad = 'Comercios',Comentario =  'Entretenimiento',
	StatusTiposEntidades = 'ACTIVA', NoELiminable = 0, FechaRegistro = '2022-01-12' WHERE IdTipoEntidad = 7