USE [master]
GO
/****** Object:  Database [db_consultorio_odontologico]    Script Date: 11/13/2017 21:50:53 ******/
CREATE DATABASE [db_consultorio_odontologico] ON  PRIMARY 
( NAME = N'db_consultorio_odontologico', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\db_consultorio_odontologico.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_consultorio_odontologico_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\db_consultorio_odontologico_log.LDF' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_consultorio_odontologico] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_consultorio_odontologico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_consultorio_odontologico] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET ANSI_NULLS OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET ANSI_PADDING OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET ARITHABORT OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET AUTO_CLOSE ON
GO
ALTER DATABASE [db_consultorio_odontologico] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [db_consultorio_odontologico] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [db_consultorio_odontologico] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [db_consultorio_odontologico] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET  ENABLE_BROKER
GO
ALTER DATABASE [db_consultorio_odontologico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [db_consultorio_odontologico] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [db_consultorio_odontologico] SET  READ_WRITE
GO
ALTER DATABASE [db_consultorio_odontologico] SET RECOVERY SIMPLE
GO
ALTER DATABASE [db_consultorio_odontologico] SET  MULTI_USER
GO
ALTER DATABASE [db_consultorio_odontologico] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [db_consultorio_odontologico] SET DB_CHAINING OFF
GO
USE [db_consultorio_odontologico]
GO
/****** Object:  Table [dbo].[Odontologos]    Script Date: 11/13/2017 21:50:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Odontologos](
	[legajo] [int] IDENTITY(1,1) NOT NULL,
	[dniOdontologo] [int] NULL,
	[apellido] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[sexo] [nchar](10) NULL,
	[fechaNacimiento] [date] NULL,
	[eMail] [varchar](50) NULL,
	[domicilio] [varchar](50) NULL,
	[nroMatricula] [int] NULL,
	[fechaIngreso] [date] NULL,
	[activo] [nchar](10) NULL,
	[telContacto] [varchar](50) NULL,
 CONSTRAINT [PK_Odontologos] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Odontologos] ON
INSERT [dbo].[Odontologos] ([legajo], [dniOdontologo], [apellido], [nombre], [sexo], [fechaNacimiento], [eMail], [domicilio], [nroMatricula], [fechaIngreso], [activo], [telContacto]) VALUES (1, 20828842, N'Gonzalez', N'Walter', N'M         ', CAST(0x60FD0A00 AS Date), N'wallygonzalez72@gmail.com', N'Pueyrredon 86 6A', 19687985, CAST(0x623D0B00 AS Date), N'T         ', N'351958882')
INSERT [dbo].[Odontologos] ([legajo], [dniOdontologo], [apellido], [nombre], [sexo], [fechaNacimiento], [eMail], [domicilio], [nroMatricula], [fechaIngreso], [activo], [telContacto]) VALUES (2, 34928551, N'Efron', N'Zac', N'M         ', CAST(0x9D120B00 AS Date), N'soytroybolton@gmail.com', N'East High', 589656256, CAST(0x623D0B00 AS Date), N'T         ', N'3519879855')
INSERT [dbo].[Odontologos] ([legajo], [dniOdontologo], [apellido], [nombre], [sexo], [fechaNacimiento], [eMail], [domicilio], [nroMatricula], [fechaIngreso], [activo], [telContacto]) VALUES (3, 35682558, N'Alonso', N'Adriana', N'F         ', CAST(0x83190B00 AS Date), N'', N'Achával Rodríguez 587', 985985984, CAST(0x633D0B00 AS Date), N'T         ', N'351695558')
INSERT [dbo].[Odontologos] ([legajo], [dniOdontologo], [apellido], [nombre], [sexo], [fechaNacimiento], [eMail], [domicilio], [nroMatricula], [fechaIngreso], [activo], [telContacto]) VALUES (4, 34851128, N'Álvarez', N'Guillermo', N'M         ', CAST(0xA5170B00 AS Date), N'guillealvarez991@gmail.com', N'Bv Illia 593 9B', 89598566, CAST(0x633D0B00 AS Date), N'T         ', N'351996654')
INSERT [dbo].[Odontologos] ([legajo], [dniOdontologo], [apellido], [nombre], [sexo], [fechaNacimiento], [eMail], [domicilio], [nroMatricula], [fechaIngreso], [activo], [telContacto]) VALUES (5, 33551289, N'Acosta', N'Felipe', N'M         ', CAST(0xFA160B00 AS Date), N'', N'Obispo Oro 52 9D', 9562525, CAST(0x633D0B00 AS Date), N'T         ', N'351995320')
INSERT [dbo].[Odontologos] ([legajo], [dniOdontologo], [apellido], [nombre], [sexo], [fechaNacimiento], [eMail], [domicilio], [nroMatricula], [fechaIngreso], [activo], [telContacto]) VALUES (6, 29285005, N'Weasley', N'Ron', N'M         ', CAST(0xBA070B00 AS Date), N'rongryffindor@hotmail.com', N'La Madriguera', 589451, CAST(0x633D0B00 AS Date), N'T         ', N'351323058')
INSERT [dbo].[Odontologos] ([legajo], [dniOdontologo], [apellido], [nombre], [sexo], [fechaNacimiento], [eMail], [domicilio], [nroMatricula], [fechaIngreso], [activo], [telContacto]) VALUES (7, 18689950, N'Umbridge', N'Dolores', N'M         ', CAST(0x4DF70A00 AS Date), N'supremaInquisidoraDeHogwarts@gmail.com', N'Ministerio de Magia', 5968459, CAST(0x633D0B00 AS Date), N'T         ', N'351020523')
INSERT [dbo].[Odontologos] ([legajo], [dniOdontologo], [apellido], [nombre], [sexo], [fechaNacimiento], [eMail], [domicilio], [nroMatricula], [fechaIngreso], [activo], [telContacto]) VALUES (8, 37512085, N'Vega', N'Alejandro', N'M         ', CAST(0xAB180B00 AS Date), N'ale.vega586@gmail.com', N'Buenos Aires 514', 16501222, CAST(0x7A3D0B00 AS Date), N'T         ', N'3513580804')
SET IDENTITY_INSERT [dbo].[Odontologos] OFF
/****** Object:  Table [dbo].[Ubicacion]    Script Date: 11/13/2017 21:50:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ubicacion](
	[idUbicacion] [int] NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Ubicaciones] PRIMARY KEY CLUSTERED 
(
	[idUbicacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Ubicacion] ([idUbicacion], [descripcion]) VALUES (0, N'Todos')
INSERT [dbo].[Ubicacion] ([idUbicacion], [descripcion]) VALUES (1, N'Superior derecho')
INSERT [dbo].[Ubicacion] ([idUbicacion], [descripcion]) VALUES (2, N'Superior izquierdo')
INSERT [dbo].[Ubicacion] ([idUbicacion], [descripcion]) VALUES (3, N'Inferior izquierdo')
INSERT [dbo].[Ubicacion] ([idUbicacion], [descripcion]) VALUES (4, N'Inferior derecho')
/****** Object:  Table [dbo].[Turno]    Script Date: 11/13/2017 21:50:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Turno](
	[legajoOdontologo] [int] NOT NULL,
	[idPaciente] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [varchar](5) NOT NULL,
	[idPrestacion] [int] NOT NULL,
	[idEstado] [int] NOT NULL,
	[descripcion] [varchar](1000) NULL,
	[costo] [float] NULL,
	[facturado] [varchar](5) NULL,
 CONSTRAINT [PK_Turno_1] PRIMARY KEY CLUSTERED 
(
	[legajoOdontologo] ASC,
	[fecha] ASC,
	[hora] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 37639493, CAST(0x7E3D0B00 AS Date), N'10:00', 8, 1, N'Extracción dental', 420, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 37639493, CAST(0x7E3D0B00 AS Date), N'10:20', 8, 1, N'Extracción dental', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 37639493, CAST(0x7E3D0B00 AS Date), N'10:40', 8, 1, N'Extracción dental', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 22597545, CAST(0x7E3D0B00 AS Date), N'11:00', 9, 1, N'Dolor punzante en encía post implante (hace 2 semanas).', 500, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 16604677, CAST(0x7E3D0B00 AS Date), N'11:40', 9, 1, N'', 500, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 39904648, CAST(0x7E3D0B00 AS Date), N'14:20', 7, 1, N'Blanqueamiento con láser', 600, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 39904648, CAST(0x7E3D0B00 AS Date), N'14:40', 7, 1, N'Blanqueamiento con láser', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 39223936, CAST(0x7E3D0B00 AS Date), N'15:40', 11, 1, N'Extracción dentaria convencional ', 300, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 39223936, CAST(0x7E3D0B00 AS Date), N'16:00', 11, 1, N'Extracción dentaria convencional ', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 37257910, CAST(0x7E3D0B00 AS Date), N'16:20', 9, 1, N'Dolor e inflamación post extraccion (hace 10 días)', 200, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 26676116, CAST(0x7E3D0B00 AS Date), N'17:00', 3, 1, N'Implantología transmucosa', 1600, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 26676116, CAST(0x7E3D0B00 AS Date), N'17:20', 3, 1, N'Implantología transmucosa', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 26676116, CAST(0x7E3D0B00 AS Date), N'17:40', 3, 1, N'Implantología transmucosa', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 37195692, CAST(0x7E3D0B00 AS Date), N'18:20', 9, 1, N'Sensibilidad horrible en los molares superiores derechos al comer o tomar algo frío o caliente.', 500, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 16711537, CAST(0x7E3D0B00 AS Date), N'19:00', 9, 1, N'Dientes con manchas blancas post ortodoncia.', 320, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 41123468, CAST(0x7E3D0B00 AS Date), N'19:20', 1, 1, N'', 150, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 36120565, CAST(0x7E3D0B00 AS Date), N'19:40', 9, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 26804338, CAST(0x7E3D0B00 AS Date), N'20:00', 9, 1, N'', 500, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 16604677, CAST(0x7F3D0B00 AS Date), N'10:00', 7, 1, N'', 100, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 16604677, CAST(0x7F3D0B00 AS Date), N'10:20', 7, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 29105471, CAST(0x7F3D0B00 AS Date), N'11:00', 9, 1, N'', 320, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 39560415, CAST(0x7F3D0B00 AS Date), N'11:20', 9, 1, N'', 500, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 26804338, CAST(0x7F3D0B00 AS Date), N'14:00', 7, 1, N'', 600, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 26804338, CAST(0x7F3D0B00 AS Date), N'14:20', 7, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 29529976, CAST(0x7F3D0B00 AS Date), N'15:00', 4, 1, N'Realizar limpieza dental profunda.', 600, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 29529976, CAST(0x7F3D0B00 AS Date), N'15:20', 4, 1, N'Realizar limpieza dental profunda.', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 35890922, CAST(0x7F3D0B00 AS Date), N'16:00', 9, 1, N'Segundo molar flojo.', 500, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 22508036, CAST(0x7F3D0B00 AS Date), N'16:20', 3, 1, N'Implantología post-extracción.', 1600, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 22508036, CAST(0x7F3D0B00 AS Date), N'16:40', 3, 1, N'Implantología post-extracción.', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 22508036, CAST(0x7F3D0B00 AS Date), N'17:00', 3, 1, N'Implantología post-extracción.', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 16051019, CAST(0x7F3D0B00 AS Date), N'18:00', 9, 1, N'Inflamación y sangrado de la encía.', 200, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 41115251, CAST(0x7F3D0B00 AS Date), N'19:00', 3, 1, N'', 1600, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 41115251, CAST(0x7F3D0B00 AS Date), N'19:20', 3, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 41115251, CAST(0x7F3D0B00 AS Date), N'19:40', 3, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 22240430, CAST(0x803D0B00 AS Date), N'10:00', 5, 1, N'Prótesis dental fija', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 22240430, CAST(0x803D0B00 AS Date), N'10:20', 5, 1, N'Prótesis dental fija', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 39180386, CAST(0x803D0B00 AS Date), N'11:00', 11, 1, N'', 300, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 39180386, CAST(0x803D0B00 AS Date), N'11:20', 11, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 29899058, CAST(0x803D0B00 AS Date), N'14:00', 9, 1, N'Encías inflamadas.', 500, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 37602832, CAST(0x803D0B00 AS Date), N'14:40', 2, 1, N'', 1200, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 37602832, CAST(0x803D0B00 AS Date), N'15:00', 2, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 42154151, CAST(0x803D0B00 AS Date), N'16:00', 2, 1, N'', 2400, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 42154151, CAST(0x803D0B00 AS Date), N'16:20', 2, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 42154151, CAST(0x803D0B00 AS Date), N'16:40', 2, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 22721684, CAST(0x803D0B00 AS Date), N'17:00', 9, 1, N'No se le ha ido el efecto de la anestesia colocada hace 3 días en un empaste.', 320, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 41123468, CAST(0x803D0B00 AS Date), N'17:40', 11, 1, N'', 300, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 41123468, CAST(0x803D0B00 AS Date), N'18:00', 11, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 41123468, CAST(0x803D0B00 AS Date), N'18:20', 11, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 39595432, CAST(0x803D0B00 AS Date), N'19:00', 5, 1, N'', 200, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 39595432, CAST(0x803D0B00 AS Date), N'19:20', 5, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 39595432, CAST(0x803D0B00 AS Date), N'19:40', 5, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 22653682, CAST(0x803D0B00 AS Date), N'20:00', 9, 1, N'Sarro en los dientes', 500, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 36335969, CAST(0x803D0B00 AS Date), N'20:20', 9, 1, N'Placa sobre la encía', 500, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 35772609, CAST(0x813D0B00 AS Date), N'11:00', 2, 1, N'', 3000, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 35772609, CAST(0x813D0B00 AS Date), N'11:20', 2, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 35772609, CAST(0x813D0B00 AS Date), N'11:40', 2, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 36120565, CAST(0x813D0B00 AS Date), N'14:00', 3, 1, N'', 1600, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 36120565, CAST(0x813D0B00 AS Date), N'14:20', 3, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 36120565, CAST(0x813D0B00 AS Date), N'14:40', 3, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 16607196, CAST(0x813D0B00 AS Date), N'15:00', 9, 1, N'Dolor en muela superior izquierda.', 500, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 47081519, CAST(0x813D0B00 AS Date), N'15:20', 4, 1, N'', 600, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 47081519, CAST(0x813D0B00 AS Date), N'15:40', 4, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 36991833, CAST(0x813D0B00 AS Date), N'16:00', 5, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 36991833, CAST(0x813D0B00 AS Date), N'16:20', 5, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 36991833, CAST(0x813D0B00 AS Date), N'16:40', 5, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 16051019, CAST(0x813D0B00 AS Date), N'17:00', 7, 1, N'', 600, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 16051019, CAST(0x813D0B00 AS Date), N'17:20', 7, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 30811529, CAST(0x813D0B00 AS Date), N'18:00', 10, 1, N'', 600, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 30811529, CAST(0x813D0B00 AS Date), N'18:20', 10, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 30811529, CAST(0x813D0B00 AS Date), N'18:40', 10, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 47486402, CAST(0x813D0B00 AS Date), N'19:00', 9, 1, N'Dolor en muelas de juicio inferiores.', 500, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 16027718, CAST(0x813D0B00 AS Date), N'19:20', 7, 1, N'', 600, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 16027718, CAST(0x813D0B00 AS Date), N'19:40', 7, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 93720820, CAST(0x823D0B00 AS Date), N'10:40', 4, 4, N'', 600, N'T')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 93720820, CAST(0x823D0B00 AS Date), N'11:00', 4, 4, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 93720820, CAST(0x823D0B00 AS Date), N'11:20', 4, 4, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 93720820, CAST(0x853D0B00 AS Date), N'10:00', 6, 4, N'', 700, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 93720820, CAST(0x853D0B00 AS Date), N'10:20', 6, 4, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (1, 93720820, CAST(0x853D0B00 AS Date), N'10:40', 6, 4, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (2, 93720820, CAST(0x2A3D0B00 AS Date), N'11:00', 8, 4, N'', 600, N'T')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (2, 93720820, CAST(0x2A3D0B00 AS Date), N'11:20', 8, 4, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (2, 93720820, CAST(0x2A3D0B00 AS Date), N'11:40', 8, 4, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (2, 93720820, CAST(0x793D0B00 AS Date), N'10:20', 2, 4, N'', 1000, N'T')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (2, 93720820, CAST(0x793D0B00 AS Date), N'10:40', 2, 4, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (2, 42154151, CAST(0x7E3D0B00 AS Date), N'10:20', 7, 1, N'', 600, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (2, 42154151, CAST(0x7E3D0B00 AS Date), N'10:40', 7, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (4, 93720820, CAST(0x8F3D0B00 AS Date), N'14:00', 7, 4, N'', 600, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (4, 93720820, CAST(0x8F3D0B00 AS Date), N'14:20', 7, 4, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (5, 93720820, CAST(0x713D0B00 AS Date), N'10:40', 1, 4, N'', 150, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (5, 93720820, CAST(0x713D0B00 AS Date), N'11:00', 1, 4, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (6, 93720820, CAST(0x623D0B00 AS Date), N'11:00', 5, 4, N'Se revento la boca', 1200, N'T')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (6, 93720820, CAST(0x623D0B00 AS Date), N'11:20', 5, 4, N'Se revento la boca', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (6, 93720820, CAST(0x623D0B00 AS Date), N'11:40', 5, 4, N'Se revento la boca', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (6, 93720820, CAST(0xA93D0B00 AS Date), N'10:00', 9, 1, N'', 0, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (8, 93720820, CAST(0xCF3D0B00 AS Date), N'14:00', 5, 1, N'', 1200, N'F')
INSERT [dbo].[Turno] ([legajoOdontologo], [idPaciente], [fecha], [hora], [idPrestacion], [idEstado], [descripcion], [costo], [facturado]) VALUES (8, 93720820, CAST(0xCF3D0B00 AS Date), N'14:20', 5, 1, N'', 0, N'F')
/****** Object:  Table [dbo].[TipoDiente]    Script Date: 11/13/2017 21:50:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoDiente](
	[idTipo] [int] NOT NULL,
	[nombre] [varchar](100) NULL,
 CONSTRAINT [PK_TipoDiente] PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TipoDiente] ([idTipo], [nombre]) VALUES (0, N'Todos')
INSERT [dbo].[TipoDiente] ([idTipo], [nombre]) VALUES (1, N'Incisivo central')
INSERT [dbo].[TipoDiente] ([idTipo], [nombre]) VALUES (2, N'Incisivo lateral')
INSERT [dbo].[TipoDiente] ([idTipo], [nombre]) VALUES (3, N'Canino')
INSERT [dbo].[TipoDiente] ([idTipo], [nombre]) VALUES (4, N'Primer premolar')
INSERT [dbo].[TipoDiente] ([idTipo], [nombre]) VALUES (5, N'Segundo premolar')
INSERT [dbo].[TipoDiente] ([idTipo], [nombre]) VALUES (6, N'Primer molar')
INSERT [dbo].[TipoDiente] ([idTipo], [nombre]) VALUES (7, N'Segundo molar')
INSERT [dbo].[TipoDiente] ([idTipo], [nombre]) VALUES (8, N'Tercer molar')
/****** Object:  Table [dbo].[Medicamentos]    Script Date: 11/13/2017 21:50:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Medicamentos](
	[idMedicamento] [int] IDENTITY(1,1) NOT NULL,
	[droga] [varchar](50) NULL,
	[laboratorio] [varchar](50) NULL,
	[restricciones] [varchar](1000) NULL,
 CONSTRAINT [PK_dbo.Medicamentos] PRIMARY KEY CLUSTERED 
(
	[idMedicamento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Medicamentos] ON
INSERT [dbo].[Medicamentos] ([idMedicamento], [droga], [laboratorio], [restricciones]) VALUES (1, N'Cristalmina 10 mg/ml', N'SALVAT, S.A.', N'No utilizar si es alérgico al digluconato de clorhexidina.')
INSERT [dbo].[Medicamentos] ([idMedicamento], [droga], [laboratorio], [restricciones]) VALUES (2, N'Cristalmina 10 mg/ml', N'SALVAT, S.A.', N'No utilizar si es alérgico al digluconato de clorhexidina.')
INSERT [dbo].[Medicamentos] ([idMedicamento], [droga], [laboratorio], [restricciones]) VALUES (3, N'Bucasmol Plus', N'FECOFAR', N'Anetésico Local, Antibiótico Local, Antiséptico')
INSERT [dbo].[Medicamentos] ([idMedicamento], [droga], [laboratorio], [restricciones]) VALUES (4, N'Elgydium antiplaca', N'ROVAFARM', N'Se aconseja su utilización dos veces al día.')
INSERT [dbo].[Medicamentos] ([idMedicamento], [droga], [laboratorio], [restricciones]) VALUES (5, N'Periodent Enjuague Bucal', N'Raysan S.A.', N'No utilizar en personas con hipersensibilidad a la Clorhexidina. No ingerir. No utilizar en menores de 6 años.')
INSERT [dbo].[Medicamentos] ([idMedicamento], [droga], [laboratorio], [restricciones]) VALUES (6, N'Klepp Eugenol', N'Raysan S.A.', N'No debe ser utilizado en pacientes alérgicos.')
INSERT [dbo].[Medicamentos] ([idMedicamento], [droga], [laboratorio], [restricciones]) VALUES (7, N'OrtoLacer', N'LACER', N'Cuidado diario para personas portadoras de ORTODONCIA')
INSERT [dbo].[Medicamentos] ([idMedicamento], [droga], [laboratorio], [restricciones]) VALUES (8, N'LACERPRO', N'LACER', N'Para dentaduras postizas.')
INSERT [dbo].[Medicamentos] ([idMedicamento], [droga], [laboratorio], [restricciones]) VALUES (9, N'XeroLacer', N'LACER', N'Para el cuidado de la boca seca.')
INSERT [dbo].[Medicamentos] ([idMedicamento], [droga], [laboratorio], [restricciones]) VALUES (10, N'AMOXIDAL DÚO', N'ROEMMERS', N'RESTRICCIONES DE USO DURANTE EL EMBARAZO Y LA LACTANCIA')
INSERT [dbo].[Medicamentos] ([idMedicamento], [droga], [laboratorio], [restricciones]) VALUES (11, N'ACTRON 600', N'BAYER', N'Analgésico.Antiinflamatorio.Antifebril.Antidismenorreico')
INSERT [dbo].[Medicamentos] ([idMedicamento], [droga], [laboratorio], [restricciones]) VALUES (12, N'Scaflam', N'MSD', N'Se recomienda administrar después de una comida.')
INSERT [dbo].[Medicamentos] ([idMedicamento], [droga], [laboratorio], [restricciones]) VALUES (13, N'LISTERINE', N'LISTERINE®', N'No usar en niños menores a 12 años de edad.No debe ingerirse.')
INSERT [dbo].[Medicamentos] ([idMedicamento], [droga], [laboratorio], [restricciones]) VALUES (14, N'Vibramicina', N'Pfizer', N'Restricciones de uso durante el embarazo y la lactancia.')
INSERT [dbo].[Medicamentos] ([idMedicamento], [droga], [laboratorio], [restricciones]) VALUES (15, N'Alibi Spray', N'', N'')
INSERT [dbo].[Medicamentos] ([idMedicamento], [droga], [laboratorio], [restricciones]) VALUES (16, N'ACICLOVIR - ZOVIRAX', N'Glaxosmithkline', N'Puede presentarse sensación de quemadura, eritema o escozor transitorios.')
SET IDENTITY_INSERT [dbo].[Medicamentos] OFF
/****** Object:  Table [dbo].[ObraSocial]    Script Date: 11/13/2017 21:50:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ObraSocial](
	[idOS] [int] IDENTITY(0,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_dbo.ObraSocial] PRIMARY KEY CLUSTERED 
(
	[idOS] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ObraSocial] ON
INSERT [dbo].[ObraSocial] ([idOS], [nombre]) VALUES (0, N'N/T')
INSERT [dbo].[ObraSocial] ([idOS], [nombre]) VALUES (1, N'OSPE')
INSERT [dbo].[ObraSocial] ([idOS], [nombre]) VALUES (2, N'OSDE')
INSERT [dbo].[ObraSocial] ([idOS], [nombre]) VALUES (3, N'DASPU')
INSERT [dbo].[ObraSocial] ([idOS], [nombre]) VALUES (4, N'Sancor Salud')
INSERT [dbo].[ObraSocial] ([idOS], [nombre]) VALUES (5, N'Federada Salud')
INSERT [dbo].[ObraSocial] ([idOS], [nombre]) VALUES (6, N'OSFATUN')
INSERT [dbo].[ObraSocial] ([idOS], [nombre]) VALUES (7, N'PAMI')
INSERT [dbo].[ObraSocial] ([idOS], [nombre]) VALUES (8, N'Swiss Medical')
INSERT [dbo].[ObraSocial] ([idOS], [nombre]) VALUES (9, N'Medicus')
INSERT [dbo].[ObraSocial] ([idOS], [nombre]) VALUES (10, N'Galeno')
INSERT [dbo].[ObraSocial] ([idOS], [nombre]) VALUES (11, N'Medifé')
SET IDENTITY_INSERT [dbo].[ObraSocial] OFF
/****** Object:  Table [dbo].[Alergias]    Script Date: 11/13/2017 21:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Alergias](
	[idAlergia] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](1000) NULL,
 CONSTRAINT [PK_dbo.Alergias] PRIMARY KEY CLUSTERED 
(
	[idAlergia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Alergias] ON
INSERT [dbo].[Alergias] ([idAlergia], [nombre], [descripcion]) VALUES (1, N'Penicilina', N'Respuesta desmedida del sistema inmune a medicamentos y antibióticos relacionados')
INSERT [dbo].[Alergias] ([idAlergia], [nombre], [descripcion]) VALUES (2, N'Manzana', N'Hormigueo, picazón o hinchazón en labios, lengua o garganta')
INSERT [dbo].[Alergias] ([idAlergia], [nombre], [descripcion]) VALUES (3, N'Cítricos', N'Causada por la profilina, proteína que se encuentra en las frutas cítricas')
INSERT [dbo].[Alergias] ([idAlergia], [nombre], [descripcion]) VALUES (4, N'Insectos', N'Reacciones alérgicas como urticaria, dificultad para respirar, pulso rápido y anafilaxia')
INSERT [dbo].[Alergias] ([idAlergia], [nombre], [descripcion]) VALUES (5, N'Látex', N'Especial cuidado con guantes y preservativos médicos.')
INSERT [dbo].[Alergias] ([idAlergia], [nombre], [descripcion]) VALUES (6, N'Ácaros', N'Presentes en polvo, almohadas y colchones.')
INSERT [dbo].[Alergias] ([idAlergia], [nombre], [descripcion]) VALUES (7, N'Polen', N'')
INSERT [dbo].[Alergias] ([idAlergia], [nombre], [descripcion]) VALUES (8, N'Pelo de animales', N'Evitar el contacto y mantener buena limpieza.')
INSERT [dbo].[Alergias] ([idAlergia], [nombre], [descripcion]) VALUES (9, N'Aspirina', N'Alergia o sensibilidad a la aspirina')
INSERT [dbo].[Alergias] ([idAlergia], [nombre], [descripcion]) VALUES (10, N'Cucarachas', N'Consecuencia de las proteínas que se desprenden de sus heces.')
SET IDENTITY_INSERT [dbo].[Alergias] OFF
/****** Object:  Table [dbo].[Enfermedades]    Script Date: 11/13/2017 21:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Enfermedades](
	[idEnfermedades] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](1000) NULL,
 CONSTRAINT [PK_dbo.Enfermedades] PRIMARY KEY CLUSTERED 
(
	[idEnfermedades] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Enfermedades] ON
INSERT [dbo].[Enfermedades] ([idEnfermedades], [nombre], [descripcion]) VALUES (13, N'Caries', N'Áreas permanentemente dañadas de los dientes donde se forman pequeños orificios.')
INSERT [dbo].[Enfermedades] ([idEnfermedades], [nombre], [descripcion]) VALUES (14, N'Gingivitis', N'Tipo de enfermedad periodontal que provoca encías inflamadas.')
INSERT [dbo].[Enfermedades] ([idEnfermedades], [nombre], [descripcion]) VALUES (15, N'Periodontitis', N'Infección gingival aguda que daña las encías y puede lesionar la mandíbula.')
INSERT [dbo].[Enfermedades] ([idEnfermedades], [nombre], [descripcion]) VALUES (16, N'Cáncer bucal', N'Cáncer que se desarrolla en cualquier parte de la boca.')
INSERT [dbo].[Enfermedades] ([idEnfermedades], [nombre], [descripcion]) VALUES (17, N'Halitosis', N'Fetidez del aliento.')
INSERT [dbo].[Enfermedades] ([idEnfermedades], [nombre], [descripcion]) VALUES (18, N'Bruxismo', N'Hábito inconsciente de apretar o rechinar los dientes que puede provocar molestias en diferentes partes de la cabeza.')
INSERT [dbo].[Enfermedades] ([idEnfermedades], [nombre], [descripcion]) VALUES (19, N'Herpes Labiales', N'Infección provocada por el virus del herpes simple en la comisura de los labios')
INSERT [dbo].[Enfermedades] ([idEnfermedades], [nombre], [descripcion]) VALUES (20, N'Dientes Rotos', N'Dientes rotos u astillados')
INSERT [dbo].[Enfermedades] ([idEnfermedades], [nombre], [descripcion]) VALUES (21, N'Candidiasis', N'Infección fúngica ocasionada por el hongo Cándida que se presenta generalmente en la piel o las membranas mucosas.')
INSERT [dbo].[Enfermedades] ([idEnfermedades], [nombre], [descripcion]) VALUES (22, N'Llagas Bucales', N'Llagas pequeña y superficiales dentro de la boca en la base de las encías.')
INSERT [dbo].[Enfermedades] ([idEnfermedades], [nombre], [descripcion]) VALUES (23, N'Pulpitis', N'Inflamación de la pulpa dental.')
INSERT [dbo].[Enfermedades] ([idEnfermedades], [nombre], [descripcion]) VALUES (24, N'Piorrea', N'Periodontitis agravada en la que además de los síntomas normales nos encontramos con supuración de pus.')
INSERT [dbo].[Enfermedades] ([idEnfermedades], [nombre], [descripcion]) VALUES (25, N'Sequedad bucal', N'Provocada por una escasa producción de saliva.')
SET IDENTITY_INSERT [dbo].[Enfermedades] OFF
/****** Object:  Table [dbo].[EstadoTurnos]    Script Date: 11/13/2017 21:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoTurnos](
	[idEstado] [int] NOT NULL,
	[nombre] [nchar](20) NULL,
 CONSTRAINT [PK_EstadoTurnos] PRIMARY KEY CLUSTERED 
(
	[idEstado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[EstadoTurnos] ([idEstado], [nombre]) VALUES (1, N'Asignado            ')
INSERT [dbo].[EstadoTurnos] ([idEstado], [nombre]) VALUES (2, N'En espera           ')
INSERT [dbo].[EstadoTurnos] ([idEstado], [nombre]) VALUES (3, N'Atendiendo          ')
INSERT [dbo].[EstadoTurnos] ([idEstado], [nombre]) VALUES (4, N'Atendido            ')
/****** Object:  Table [dbo].[Especialidad]    Script Date: 11/13/2017 21:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Especialidad](
	[idEspecialidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](1000) NULL,
 CONSTRAINT [PK_dbo.Especialidad] PRIMARY KEY CLUSTERED 
(
	[idEspecialidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Especialidad] ON
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (1, N'Periodoncia', N'Diagnóstico y tratamiento de las enfermedades')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (2, N'Odontopediatría', N'Trata niños')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (3, N'Ortodoncia', N'tratamiento de malposiciones en piezas dentales')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (4, N'Cariología', N'Especializada en caries y su tratamiento')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (5, N'Gnatología', N'Estudio de la función del aparato masticador')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (6, N'Endodoncia', N'Extirpación y sustitución de la pulpa dental')
SET IDENTITY_INSERT [dbo].[Especialidad] OFF
/****** Object:  Table [dbo].[Pacientes]    Script Date: 11/13/2017 21:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pacientes](
	[dniPaciente] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[sexo] [nchar](10) NULL,
	[fechaNacimiento] [date] NULL,
	[telContacto] [varchar](50) NULL,
	[activo] [nchar](10) NULL,
 CONSTRAINT [PK_dbo.Pacientes] PRIMARY KEY CLUSTERED 
(
	[dniPaciente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (16027718, N'Susana', N'Campos', N'F         ', CAST(0x60ED0A00 AS Date), N'3510206983', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (16051019, N'Guillermo', N'Canales', N'M         ', CAST(0xCDED0A00 AS Date), N'3518963499', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (16200904, N'Ana Isabel', N'Cruz', N'F         ', CAST(0xDDEE0A00 AS Date), N'3511855499', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (16299684, N'Luis Alberto', N'Batista', N'M         ', CAST(0xDEED0A00 AS Date), N'3518367461', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (16306548, N'Juan Carlos', N'Baker', N'M         ', CAST(0x66EE0A00 AS Date), N'3515553131', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (16446207, N'Armando', N'Matos', N'M         ', CAST(0x22EF0A00 AS Date), N'3517627047', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (16604677, N'Alicia', N'Basualdo', N'F         ', CAST(0x33EF0A00 AS Date), N'3518903566', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (16607196, N'Mercedes', N'Miralles', N'F         ', CAST(0x7BEE0A00 AS Date), N'3511432511', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (16711537, N'Amanda', N'Estévez', N'F         ', CAST(0xD2EE0A00 AS Date), N'3518137330', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (16738740, N'José Luis', N'Mendoza', N'M         ', CAST(0xA5F00A00 AS Date), N'3514098961', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (16759792, N'Gustavo', N'Sánchez', N'M         ', CAST(0xEBEE0A00 AS Date), N'3517600549', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (22085255, N'Priscilla', N'Osborne', N'F         ', CAST(0xA5FD0A00 AS Date), N'3517595299', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (22213873, N'Virginia', N'Zamorano', N'F         ', CAST(0x0CFC0A00 AS Date), N'3513683826', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (22240430, N'Gabriel', N'Contreras', N'M         ', CAST(0x46FD0A00 AS Date), N'3512612024', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (22340939, N'Abril', N'Clark', N'F         ', CAST(0x9AFC0A00 AS Date), N'3517608931', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (22508036, N'Esteban', N'López', N'M         ', CAST(0xA9FB0A00 AS Date), N'3510510677', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (22597545, N'Joel', N'Hernández', N'M         ', CAST(0xC3FB0A00 AS Date), N'3514734740', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (22653682, N'Marina', N'Vazquez', N'F         ', CAST(0xD9FE0A00 AS Date), N'3516352174', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (22660063, N'Germán', N'Jiménez', N'M         ', CAST(0xA6FE0A00 AS Date), N'3513943824', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (22696350, N'María', N'Villalba', N'F         ', CAST(0x9DFC0A00 AS Date), N'3514296851', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (22721684, N'Ian', N'Camacho', N'M         ', CAST(0x07FC0A00 AS Date), N'3515197329', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (22913431, N'Sofía', N'Russo', N'F         ', CAST(0x49FE0A00 AS Date), N'3512008828', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (26208782, N'Juan Manuel', N'Flores', N'M         ', CAST(0xDD050B00 AS Date), N'3511643960', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (26263887, N'Julia', N'Peña', N'F         ', CAST(0x65040B00 AS Date), N'3514386489', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (26362770, N'Sergio', N'Fernandez', N'M         ', CAST(0x1E070B00 AS Date), N'3517638431', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (26470643, N'Eric', N'Cardenas', N'M         ', CAST(0xD8060B00 AS Date), N'3517982848', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (26508351, N'Paula', N'Cisneros', N'F         ', CAST(0x0E040B00 AS Date), N'3519271573', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (26628855, N'Jose Luis', N'Robles', N'M         ', CAST(0x2C060B00 AS Date), N'3512023203', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (26676116, N'Nicole', N'Barrientos', N'F         ', CAST(0xB6030B00 AS Date), N'3513034680', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (26744522, N'María', N'Córdoba', N'F         ', CAST(0x09030B00 AS Date), N'3518988878', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (26758665, N'Brian', N'Sánchez', N'M         ', CAST(0x35070B00 AS Date), N'3519679887', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (26804338, N'Alexandra', N'Colombo', N'F         ', CAST(0x8A030B00 AS Date), N'3516179934', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (26837873, N'María Laura', N'Wells', N'F         ', CAST(0xDD030B00 AS Date), N'3511230443', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (26866748, N'Marta', N'Riddle', N'F         ', CAST(0xDA030B00 AS Date), N'3512733977', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (26872031, N'Jonathan', N'Vargas', N'M         ', CAST(0x0F060B00 AS Date), N'3518259158', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (26943751, N'Camila', N'Anderson', N'F         ', CAST(0x5E040B00 AS Date), N'3514270442', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (26945915, N'Sofía', N'García', N'F         ', CAST(0x1C030B00 AS Date), N'3519739274', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (26987753, N'Camila', N'Barrios', N'F         ', CAST(0x0D030B00 AS Date), N'3516132053', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (29022121, N'Mercedes', N'Alvarado', N'F         ', CAST(0xFF0A0B00 AS Date), N'3515274270', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (29105471, N'Lucía', N'Benavidez', N'F         ', CAST(0x360A0B00 AS Date), N'3516983636', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (29470088, N'Walter', N'Gallardo', N'M         ', CAST(0x4F0A0B00 AS Date), N'3515247933', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (29502200, N'Fabian', N'González Rivera', N'M         ', CAST(0xC30B0B00 AS Date), N'3512928749', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (29515614, N'Tobias', N'Esquivel', N'M         ', CAST(0x760B0B00 AS Date), N'3518584738', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (29529976, N'Diego', N'Navarro', N'M         ', CAST(0xDF0A0B00 AS Date), N'3513052705', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (29554696, N'Carmela', N'Díaz', N'F         ', CAST(0x0E0B0B00 AS Date), N'3519698302', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (29644494, N'Lara', N'Crespo', N'F         ', CAST(0x3B0B0B00 AS Date), N'3519021196', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (29665192, N'Erica', N'Cervantes', N'F         ', CAST(0xB80A0B00 AS Date), N'3517381010', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (29899058, N'Stella', N'Alonso', N'F         ', CAST(0xDA090B00 AS Date), N'3519519356', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (29905043, N'José Joaquín', N'Fernández', N'M         ', CAST(0x560B0B00 AS Date), N'3512793529', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (30073791, N'Camila', N'Costa', N'F         ', CAST(0x750D0B00 AS Date), N'3512714485', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (30323257, N'Jonathan', N'Ramirez', N'M         ', CAST(0x2A0D0B00 AS Date), N'3513198547', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (30471440, N'Catalina', N'Martínez', N'F         ', CAST(0x130D0B00 AS Date), N'3513973770', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (30474035, N'Paolo', N'Ortiz', N'M         ', CAST(0x370D0B00 AS Date), N'3518217470', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (30649055, N'Benjamín', N'Melendez', N'M         ', CAST(0x110E0B00 AS Date), N'3517310476', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (30811529, N'Alexandra', N'Maciel', N'F         ', CAST(0xD10C0B00 AS Date), N'3517354926', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (33039207, N'Serena', N'Romero', N'F         ', CAST(0x7E110B00 AS Date), N'3513634973', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (33049254, N'Julio', N'Morton', N'M         ', CAST(0xD4120B00 AS Date), N'3519012298', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (33055513, N'Víctor', N'Russo', N'M         ', CAST(0x33110B00 AS Date), N'3511589186', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (33114113, N'Regina', N'Ramírez', N'F         ', CAST(0x78110B00 AS Date), N'3513319617', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (33248122, N'Leonor', N'Mayer', N'F         ', CAST(0x23110B00 AS Date), N'3512980025', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (33547700, N'Leonardo', N'Palacio', N'M         ', CAST(0xDB110B00 AS Date), N'3518290107', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (33608248, N'Ana Laura', N'Ibarra', N'F         ', CAST(0x33110B00 AS Date), N'3514210228', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (33645901, N'Julián', N'Ávila', N'M         ', CAST(0x1D110B00 AS Date), N'3515785637', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (33729635, N'Sandra', N'Lima', N'F         ', CAST(0x86120B00 AS Date), N'3516212158', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (35046675, N'Emmanuel', N'Zubeldia', N'M         ', CAST(0x7F150B00 AS Date), N'3514903432', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (35165239, N'Gabriel', N'Rosario', N'M         ', CAST(0x72140B00 AS Date), N'3519124086', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (35207742, N'Melisa', N'Medina', N'F         ', CAST(0x46150B00 AS Date), N'3516601287', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (35244310, N'Joaquín', N'Valdivielso', N'M         ', CAST(0xC1150B00 AS Date), N'3518869484', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (35270956, N'Alejandro', N'Serrano', N'M         ', CAST(0x11180B00 AS Date), N'3514850839', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (35511189, N'Paul', N'Lopez', N'M         ', CAST(0x9F150B00 AS Date), N'3517903288', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (35772609, N'Adrian', N'Zúñiga', N'M         ', CAST(0x00170B00 AS Date), N'3514369503', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (35779783, N'Jennifer', N'Morrison', N'F         ', CAST(0xA3140B00 AS Date), N'3512637064', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (35782990, N'Rosario', N'Delgado', N'F         ', CAST(0x6B150B00 AS Date), N'3519137962', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (35824458, N'Fernando', N'Vargas', N'M         ', CAST(0xDF170B00 AS Date), N'3516395497', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (35890922, N'Mara', N'Rodriguez', N'F         ', CAST(0xFB130B00 AS Date), N'3512687874', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (35972467, N'Ramon', N'Reyes', N'M         ', CAST(0x2C170B00 AS Date), N'3512309556', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (35977433, N'Manuel', N'Álvarez', N'M         ', CAST(0x5E170B00 AS Date), N'3514030990', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (35991122, N'Gonzalo', N'Bauer', N'M         ', CAST(0x90160B00 AS Date), N'3516036291', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (36120565, N'Tomás', N'Mancilla', N'M         ', CAST(0x48190B00 AS Date), N'3519718248', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (36274753, N'Nicolás', N'Aguirre', N'M         ', CAST(0x8C180B00 AS Date), N'3512650022', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (36298485, N'Emmanuel', N'Báez', N'M         ', CAST(0x38190B00 AS Date), N'3511121850', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (36335969, N'Cecilia', N'Tejada', N'F         ', CAST(0xFE180B00 AS Date), N'3514805068', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (36355879, N'Marcelo', N'Acosta', N'M         ', CAST(0xBD170B00 AS Date), N'3517021772', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (36363752, N'Anastasia', N'Torres', N'F         ', CAST(0x2B190B00 AS Date), N'3510046291', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (36488284, N'Isabella', N'Viña', N'F         ', CAST(0x7F170B00 AS Date), N'3515984176', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (36606424, N'Sergio', N'Allende', N'M         ', CAST(0xA3170B00 AS Date), N'3512006736', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (36692211, N'Paloma', N'Cabrera', N'F         ', CAST(0xD5180B00 AS Date), N'3511234288', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (36796879, N'Yolanda', N'Villa', N'F         ', CAST(0x97170B00 AS Date), N'3515769603', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (36886188, N'Augusto', N'Ferguson', N'M         ', CAST(0x53180B00 AS Date), N'3513208044', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (36991833, N'Andrea', N'Palermo', N'F         ', CAST(0xB4180B00 AS Date), N'3512734437', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (37030531, N'Eric', N'Moreno', N'M         ', CAST(0x0E1A0B00 AS Date), N'3513974479', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (37071019, N'Vanesa', N'Cuesta', N'F         ', CAST(0xA7190B00 AS Date), N'3513688178', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (37195692, N'Laura', N'Clay', N'F         ', CAST(0xEA1A0B00 AS Date), N'3515215794', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (37257910, N'Rebecca', N'González', N'F         ', CAST(0x5D1A0B00 AS Date), N'3516259132', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (37398074, N'Gonzalo', N'Gould', N'M         ', CAST(0x581B0B00 AS Date), N'3514581891', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (37527993, N'Dolores', N'Holman', N'F         ', CAST(0xD3190B00 AS Date), N'3515509430', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (37602832, N'Christian', N'Vaughn', N'M         ', CAST(0xC01A0B00 AS Date), N'3511076029', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (37622735, N'Eliana', N'Ortiz', N'F         ', CAST(0xCD190B00 AS Date), N'3513202472', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (37639493, N'Flavia', N'Figueroa', N'F         ', CAST(0x6E1A0B00 AS Date), N'3511894742', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (37700482, N'Hector', N'Medina', N'M         ', CAST(0x6A1A0B00 AS Date), N'3517053041', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (39051700, N'Christian', N'Castillo', N'M         ', CAST(0x781F0B00 AS Date), N'3511444730', N'T         ')
GO
print 'Processed 100 total records'
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (39180386, N'Damián', N'Arteaga', N'M         ', CAST(0xFE1D0B00 AS Date), N'3514388636', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (39210493, N'Nicolas', N'Andrade', N'M         ', CAST(0x5F1F0B00 AS Date), N'3514973684', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (39223936, N'Franco', N'Araujo', N'M         ', CAST(0xFB1C0B00 AS Date), N'3515256367', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (39412915, N'Enzo', N'Silva', N'M         ', CAST(0xDE1D0B00 AS Date), N'3519990702', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (39456204, N'Ulises', N'Barbosa', N'M         ', CAST(0xBD1F0B00 AS Date), N'3517489979', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (39560415, N'Nahuel', N'Gross', N'M         ', CAST(0xDA1E0B00 AS Date), N'3510060311', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (39595432, N'Leonardo', N'Hayes', N'M         ', CAST(0x44200B00 AS Date), N'3516796728', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (39611001, N'Luis', N'Pereira', N'M         ', CAST(0xB41E0B00 AS Date), N'3512631482', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (39904648, N'Kevin', N'Banega', N'M         ', CAST(0xAF1F0B00 AS Date), N'3518007194', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (41063466, N'Bianca', N'Vargas', N'F         ', CAST(0x91210B00 AS Date), N'3512726086', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (41115251, N'Braian', N'Buchanan', N'M         ', CAST(0x71220B00 AS Date), N'3511578646', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (41123468, N'Joana', N'Valencia', N'F         ', CAST(0xCF1F0B00 AS Date), N'3518622817', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (41243308, N'Alan', N'Urrutia', N'M         ', CAST(0x5C200B00 AS Date), N'3519545733', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (41251573, N'Francesca', N'Hunt', N'F         ', CAST(0x78230B00 AS Date), N'3513477179', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (41571757, N'Facundo', N'Valencia', N'M         ', CAST(0xAF220B00 AS Date), N'3513128961', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (41600093, N'Ezequiel', N'Molina', N'M         ', CAST(0x6E200B00 AS Date), N'3513685128', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (41706964, N'Carla', N'Livingston', N'F         ', CAST(0x90200B00 AS Date), N'3510885229', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (41794354, N'Maximiliano', N'Morales', N'M         ', CAST(0x26200B00 AS Date), N'3518198197', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (41919430, N'Clara', N'Cardenas', N'F         ', CAST(0xC9220B00 AS Date), N'3513262655', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (41944355, N'Santiago', N'Browning', N'M         ', CAST(0x20230B00 AS Date), N'3516151635', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (41980415, N'Matías', N'Hickman', N'M         ', CAST(0x41210B00 AS Date), N'3518282014', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (41993010, N'Guido', N'Weiss', N'M         ', CAST(0x9A200B00 AS Date), N'3513558426', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (42154151, N'Matías', N'Vega', N'M         ', CAST(0x50240B00 AS Date), N'3512882283', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (42247864, N'Laura', N'Benton', N'F         ', CAST(0x3B260B00 AS Date), N'3514243362', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (42285945, N'Felipe', N'Valdivia', N'M         ', CAST(0x8C260B00 AS Date), N'3516427221', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (42288852, N'Kevin', N'Torres', N'M         ', CAST(0x3B260B00 AS Date), N'351468587', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (42465961, N'Cynthia', N'Hanson', N'M         ', CAST(0xBA250B00 AS Date), N'3513356092', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (42551058, N'Julia', N'Perez', N'M         ', CAST(0x8C260B00 AS Date), N'3516945537', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (42658851, N'Alexis', N'Vásquez', N'M         ', CAST(0xBA250B00 AS Date), N'3516455540', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (42974927, N'Paula', N'Mendez', N'M         ', CAST(0x50240B00 AS Date), N'3511499083', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (47081519, N'Lucía', N'Ibáñez', N'F         ', CAST(0x2F2D0B00 AS Date), N'3512617971', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (47103328, N'Rodrigo', N'Meyer', N'M         ', CAST(0x7F2C0B00 AS Date), N'3517426958', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (47119789, N'Manuel', N'Estrada', N'M         ', CAST(0xAB2C0B00 AS Date), N'3515888246', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (47273343, N'Daniela', N'Figueroa', N'F         ', CAST(0x5B2D0B00 AS Date), N'3519625727', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (47357896, N'Dayana', N'Gonzales', N'F         ', CAST(0xBB2C0B00 AS Date), N'3510587381', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (47466024, N'Diego', N'Fuller', N'M         ', CAST(0x442D0B00 AS Date), N'3512081804', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (47479139, N'Mercedes', N'Cortés', N'F         ', CAST(0x822C0B00 AS Date), N'3513229949', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (47486402, N'Abel', N'Leguizamón', N'M         ', CAST(0x512D0B00 AS Date), N'3514692234', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (47655038, N'Laura', N'Garré', N'F         ', CAST(0x712D0B00 AS Date), N'3515336885', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (47673360, N'Daniel', N'Valdez', N'M         ', CAST(0x8D2D0B00 AS Date), N'3511048969', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (47752245, N'Pablo Nicolás', N'Bonner', N'M         ', CAST(0x802C0B00 AS Date), N'3510558691', N'T         ')
INSERT [dbo].[Pacientes] ([dniPaciente], [nombre], [apellido], [sexo], [fechaNacimiento], [telContacto], [activo]) VALUES (93720820, N'Mickaela', N'Crespo', N'F         ', CAST(0x05200B00 AS Date), N'3515100391', N'T         ')
/****** Object:  Table [dbo].[Prestaciones]    Script Date: 11/13/2017 21:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Prestaciones](
	[idPrestacion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](1000) NULL,
	[precio] [float] NULL,
	[duracion] [int] NULL,
 CONSTRAINT [PK_dbo.Prestaciones] PRIMARY KEY CLUSTERED 
(
	[idPrestacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Prestaciones] ON
INSERT [dbo].[Prestaciones] ([idPrestacion], [nombre], [descripcion], [precio], [duracion]) VALUES (1, N'Radiología', N'Presencia de caries, infecciones y fracturas', 150, 1)
INSERT [dbo].[Prestaciones] ([idPrestacion], [nombre], [descripcion], [precio], [duracion]) VALUES (2, N'Ortodoncia', N'Reposicionar piezas dentales incorrectas', 3000, 20)
INSERT [dbo].[Prestaciones] ([idPrestacion], [nombre], [descripcion], [precio], [duracion]) VALUES (3, N'Implantología', N'Colocación de uno o varios implantes', 1600, 8)
INSERT [dbo].[Prestaciones] ([idPrestacion], [nombre], [descripcion], [precio], [duracion]) VALUES (4, N'Periodoncia', N'Diagnóstico y tratamiento de encías', 600, 3)
INSERT [dbo].[Prestaciones] ([idPrestacion], [nombre], [descripcion], [precio], [duracion]) VALUES (5, N'Prótesis', N'Restaura la anatomía de una o mas piezas dentarias', 1200, 4)
INSERT [dbo].[Prestaciones] ([idPrestacion], [nombre], [descripcion], [precio], [duracion]) VALUES (6, N'Endodoncia', N'Tratamiento de conductos', 700, 4)
INSERT [dbo].[Prestaciones] ([idPrestacion], [nombre], [descripcion], [precio], [duracion]) VALUES (7, N'Blanqueamiento  dental', N'Permite eliminar manchas y oscurecimientos', 600, 1)
INSERT [dbo].[Prestaciones] ([idPrestacion], [nombre], [descripcion], [precio], [duracion]) VALUES (8, N'Cirugía', N'Extracción de la pieza dentaria', 600, 2)
INSERT [dbo].[Prestaciones] ([idPrestacion], [nombre], [descripcion], [precio], [duracion]) VALUES (9, N'Consulta', N'Revisión y diagnóstico del paciente', 500, 1)
INSERT [dbo].[Prestaciones] ([idPrestacion], [nombre], [descripcion], [precio], [duracion]) VALUES (10, N'Arreglo estético', N'Le arreglamos la boca', 600, 1)
INSERT [dbo].[Prestaciones] ([idPrestacion], [nombre], [descripcion], [precio], [duracion]) VALUES (11, N'Extraccion', N'', 300, 1)
SET IDENTITY_INSERT [dbo].[Prestaciones] OFF
/****** Object:  Table [dbo].[Planes]    Script Date: 11/13/2017 21:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Planes](
	[idPlan] [int] NOT NULL,
	[idObraSocial] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_dbo.Plan] PRIMARY KEY CLUSTERED 
(
	[idPlan] ASC,
	[idObraSocial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (0, 0, N'N/T')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (1, 1, N'Plan 300')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (1, 2, N'Plan 210')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (1, 3, N'DASPU')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (1, 4, N'Plan 500')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (1, 5, N'Plan 1000')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (1, 6, N'Básico')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (1, 7, N'PAMI')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (1, 8, N'SMG01')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (1, 9, N'Plan Azul')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (1, 10, N'Plan 220')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (1, 11, N'Plan Bronce')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (2, 1, N'Plan 400')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (2, 2, N'Plan 310')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (2, 4, N'Plan 1000')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (2, 5, N'Plan 2000')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (2, 6, N'Integral')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (2, 8, N'SMG02')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (2, 9, N'Plan Celeste')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (2, 10, N'Plan 330')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (2, 11, N'Plan Plata')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (3, 1, N'Plan 500')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (3, 2, N'Plan 410')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (3, 4, N'Plan 2000')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (3, 5, N'Plan 3000')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (3, 6, N'Premium')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (3, 8, N'SMG10')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (3, 9, N'Plan One')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (3, 10, N'Plan 440')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (3, 11, N'Plan Oro')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (4, 1, N'Plan 600')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (4, 2, N'Plan 450')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (4, 4, N'Plan 3000')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (4, 5, N'Plan 4000')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (4, 6, N'No Docente')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (4, 8, N'SMG20')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (4, 9, N'Plan One R')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (4, 10, N'Plan 550')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (4, 11, N'Plan Platinum')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (5, 1, N'Plan 700')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (5, 2, N'Plan 510')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (5, 4, N'Plan 5000')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (5, 8, N'SMG30')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (5, 9, N'Plan Integra')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (6, 2, N'Plan NEO')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (6, 8, N'SMG40')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (7, 4, N'C CORDOBA')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (7, 8, N'SMG50')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (8, 8, N'SMG60')
INSERT [dbo].[Planes] ([idPlan], [idObraSocial], [nombre]) VALUES (9, 8, N'SMG70')
/****** Object:  StoredProcedure [dbo].[odontologosPorTurnos]    Script Date: 11/13/2017 21:51:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[odontologosPorTurnos]
AS
SELECT *, (O.apellido + ' ' + O.nombre) AS 'Nombre_Completo' FROM Turno T JOIN Odontologos O ON (T.legajoOdontologo = O.legajo) JOIN Prestaciones P ON (P.idPrestacion = T.idPrestacion)
GO
/****** Object:  Table [dbo].[EnfermedadesXPaciente]    Script Date: 11/13/2017 21:51:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EnfermedadesXPaciente](
	[dniPaciente] [int] NOT NULL,
	[idEnfermedad] [int] NOT NULL,
	[descripcion] [varchar](1000) NULL,
 CONSTRAINT [PK_dbo.EnfermedadesXPaciente] PRIMARY KEY CLUSTERED 
(
	[dniPaciente] ASC,
	[idEnfermedad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MedicosXEspecialidad]    Script Date: 11/13/2017 21:51:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicosXEspecialidad](
	[idEspecialidad] [int] NOT NULL,
	[idMedico] [int] NOT NULL,
 CONSTRAINT [PK_MedicosXEspecialidad] PRIMARY KEY CLUSTERED 
(
	[idEspecialidad] ASC,
	[idMedico] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (1, 5)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (2, 1)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (2, 2)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (2, 3)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (2, 5)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (2, 7)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (3, 1)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (3, 3)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (3, 5)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (3, 6)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (3, 7)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (3, 8)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (4, 1)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (4, 2)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (4, 5)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (4, 6)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (4, 7)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (4, 8)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (5, 2)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (5, 4)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (5, 6)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (6, 4)
INSERT [dbo].[MedicosXEspecialidad] ([idEspecialidad], [idMedico]) VALUES (6, 7)
/****** Object:  Table [dbo].[HistoriaClinica]    Script Date: 11/13/2017 21:51:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HistoriaClinica](
	[dniPaciente] [int] NOT NULL,
	[idPrestacion] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[idUbicacion] [int] NULL,
	[idTipo] [int] NULL,
	[observaciones] [varchar](1000) NULL,
 CONSTRAINT [PK_dbo.HistoriaClinica] PRIMARY KEY CLUSTERED 
(
	[dniPaciente] ASC,
	[idPrestacion] ASC,
	[fecha] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Receta]    Script Date: 11/13/2017 21:51:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Receta](
	[legajoOdontologo] [int] NOT NULL,
	[dniPaciente] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[idMedicamento] [int] NOT NULL,
	[observaciones] [varchar](1000) NULL,
 CONSTRAINT [PK_Receta_1] PRIMARY KEY CLUSTERED 
(
	[legajoOdontologo] ASC,
	[dniPaciente] ASC,
	[fecha] ASC,
	[idMedicamento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AlergiasXPaciente]    Script Date: 11/13/2017 21:51:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AlergiasXPaciente](
	[dniPaciente] [int] NULL,
	[idAlergia] [int] NULL,
	[descripcion] [varchar](1000) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ObraSocialXPaciente]    Script Date: 11/13/2017 21:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObraSocialXPaciente](
	[idNroAfiliado] [int] NOT NULL,
	[idPlan] [int] NOT NULL,
	[idObraSocial] [int] NOT NULL,
	[dniPaciente] [int] NOT NULL,
 CONSTRAINT [PK_ObraSocialXPaciente] PRIMARY KEY CLUSTERED 
(
	[idNroAfiliado] ASC,
	[idPlan] ASC,
	[idObraSocial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (0, 0, 0, 47479139)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (1, 1, 2, 93720820)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (312, 1, 6, 26744522)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (487, 4, 5, 35977433)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (578, 2, 5, 16027718)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (986, 4, 4, 33049254)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (1039, 5, 4, 39560415)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (1807, 1, 2, 37030531)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (2968, 1, 7, 36991833)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (4087, 4, 5, 26943751)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (5354, 1, 5, 16607196)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (5781, 1, 5, 36274753)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (5899, 1, 9, 35972467)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (6701, 1, 10, 26263887)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (6986, 4, 4, 47081519)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (7764, 1, 5, 39210493)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (7775, 0, 0, 16306548)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (7834, 6, 2, 26208782)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (7851, 0, 0, 36335969)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (7865, 1, 5, 33055513)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (9897, 4, 9, 33645901)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (12968, 1, 4, 36298485)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (14039, 2, 11, 35772609)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (14765, 3, 5, 16711537)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (25758, 4, 5, 39051700)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (27558, 1, 7, 35991122)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (27764, 0, 0, 35046675)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (28042, 1, 3, 29515614)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (28403, 5, 8, 29022121)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (28971, 2, 5, 37257910)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (29111, 1, 7, 42288852)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (29111, 5, 8, 42247864)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (31582, 1, 6, 35511189)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (34228, 5, 1, 22660063)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (34712, 1, 1, 39223936)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (36646, 1, 7, 22240430)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (41185, 1, 3, 35270956)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (44958, 1, 3, 29899058)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (45185, 3, 6, 39611001)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (45725, 3, 11, 47273343)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (47240, 1, 4, 36363752)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (47884, 4, 1, 41794354)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (54854, 0, 0, 33547700)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (56768, 1, 7, 30474035)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (57851, 0, 0, 36886188)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (57858, 7, 8, 16200904)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (58687, 0, 0, 30471440)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (61689, 4, 5, 39595432)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (61689, 5, 4, 35165239)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (64530, 1, 3, 35782990)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (64869, 2, 8, 26837873)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (65465, 1, 3, 16604677)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (67071, 3, 10, 35244310)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (67751, 8, 8, 42465961)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (68754, 1, 5, 30073791)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (68925, 1, 6, 30649055)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (71087, 4, 6, 39412915)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (85141, 2, 10, 22508036)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (86925, 1, 7, 47486402)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (87111, 1, 7, 36488284)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (88899, 2, 5, 39904648)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (93894, 0, 0, 36692211)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (94740, 1, 4, 42551058)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (100807, 4, 1, 37398074)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (102127, 8, 8, 35207742)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (104174, 9, 8, 47103328)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (134743, 1, 10, 22653682)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (140739, 2, 1, 41571757)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (140851, 4, 5, 35890922)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (148231, 4, 8, 33608248)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (148578, 3, 8, 47655038)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (149970, 2, 10, 26362770)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (154039, 2, 2, 26676116)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (158411, 1, 6, 16299684)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (179096, 0, 0, 22213873)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (189154, 1, 1, 26628855)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (208225, 4, 11, 33248122)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (257558, 1, 7, 26804338)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (277764, 0, 0, 41243308)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (283210, 1, 7, 22913431)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (287164, 1, 4, 26470643)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (291111, 0, 0, 36796879)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (310638, 4, 4, 33729635)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (359911, 0, 0, 47466024)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (386590, 0, 0, 26872031)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (400403, 1, 4, 37622735)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (421272, 6, 2, 37602832)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (440826, 3, 6, 22597545)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (451450, 4, 9, 37195692)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (473270, 3, 10, 47119789)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (482742, 4, 2, 41993010)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (487554, 4, 5, 41123468)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (528065, 0, 0, 26758665)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (533258, 3, 5, 22721684)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (541364, 3, 4, 37527993)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (563446, 4, 5, 29529976)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (565515, 7, 4, 29502200)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (567911, 0, 0, 30323257)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (579521, 1, 4, 16738740)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (591891, 2, 5, 35779783)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (604869, 1, 5, 39180386)
GO
print 'Processed 100 total records'
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (613037, 4, 5, 16759792)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (617689, 1, 4, 26945915)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (635122, 2, 5, 22085255)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (637494, 6, 8, 29554696)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (670228, 3, 5, 29105471)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (670709, 9, 8, 47673360)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (677851, 4, 8, 42658851)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (719733, 7, 4, 29665192)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (720433, 4, 10, 16051019)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (733702, 0, 0, 22340939)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (736746, 0, 0, 29905043)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (754033, 2, 10, 16446207)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (777573, 3, 11, 37071019)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (817950, 6, 8, 33114113)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (822445, 1, 6, 30811529)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (842666, 5, 4, 33039207)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (847453, 5, 2, 22696350)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (887550, 5, 8, 47357896)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (893768, 8, 8, 47752245)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (917080, 4, 11, 29644494)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (933894, 3, 6, 42974927)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (946047, 1, 5, 29470088)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (947240, 2, 4, 42285945)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (973591, 1, 3, 37639493)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (1405739, 2, 1, 41706964)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (2447240, 1, 4, 36606424)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (2547764, 2, 1, 26866748)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (4157185, 0, 0, 41919430)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (4521185, 1, 3, 26987753)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (4827587, 0, 0, 41600093)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (4877554, 0, 0, 41980415)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (6168789, 5, 1, 41251573)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (6485769, 9, 8, 35824458)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (8586701, 7, 8, 39456204)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (8793894, 1, 2, 36120565)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (8885899, 3, 9, 26508351)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (9332894, 2, 6, 42154151)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (9365484, 0, 0, 37700482)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (24291111, 1, 3, 36355879)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (26168789, 3, 1, 41115251)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (27758764, 0, 0, 41063466)
INSERT [dbo].[ObraSocialXPaciente] ([idNroAfiliado], [idPlan], [idObraSocial], [dniPaciente]) VALUES (84157185, 0, 0, 41944355)
/****** Object:  Table [dbo].[PrestacionesPorPlan]    Script Date: 11/13/2017 21:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrestacionesPorPlan](
	[idPlan] [int] NOT NULL,
	[idObraSocial] [int] NOT NULL,
	[idPrestacion] [int] NOT NULL,
	[montoCubierto] [float] NULL,
 CONSTRAINT [PK_dbo.PrestacionesXPlan] PRIMARY KEY CLUSTERED 
(
	[idPlan] ASC,
	[idObraSocial] ASC,
	[idPrestacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 1, 7, 190)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 1, 9, 250)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 2, 2, 2000)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 2, 9, 500)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 3, 4, 490)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 3, 7, 500)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 3, 8, 180)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 4, 5, 1000)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 4, 7, 600)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 6, 4, 280)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 6, 7, 180)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 6, 8, 200)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 7, 1, 150)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 7, 5, 1200)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 7, 8, 480)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 7, 10, 480)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 7, 11, 270)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 8, 6, 600)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 9, 2, 800)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 9, 3, 800)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 9, 5, 400)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 9, 6, 600)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 9, 9, 200)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 9, 10, 400)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 10, 3, 300)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 10, 5, 800)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 11, 4, 500)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 11, 5, 830)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 11, 6, 300)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (1, 11, 10, 300)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 1, 7, 220)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 1, 9, 315)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 2, 9, 250)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 4, 1, 150)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 4, 2, 3000)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 4, 7, 600)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 5, 9, 300)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 6, 2, 600)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 6, 5, 950)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 6, 6, 500)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 8, 6, 600)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 9, 2, 800)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 10, 4, 300)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 10, 5, 800)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 11, 3, 810)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 11, 6, 500)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (2, 11, 7, 300)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 1, 5, 500)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 1, 6, 280)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 1, 7, 450)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 1, 9, 200)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 1, 11, 200)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 2, 2, 2200)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 2, 3, 1000)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 2, 5, 900)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 4, 2, 2000)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 4, 9, 300)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 5, 3, 860)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 5, 5, 580)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 5, 6, 200)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 5, 9, 180)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 6, 1, 150)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 6, 6, 670)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 6, 7, 480)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 6, 10, 380)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 8, 1, 150)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 8, 4, 400)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 9, 5, 800)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 9, 9, 400)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 9, 10, 600)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 10, 5, 1200)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 10, 6, 300)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 11, 3, 500)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (3, 11, 5, 300)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 1, 2, 810)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 1, 3, 800)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 1, 4, 480)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 1, 5, 800)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 1, 9, 500)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 2, 3, 1000)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 2, 5, 850)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 2, 7, 400)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 4, 2, 3000)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 4, 7, 600)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 4, 9, 200)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 5, 5, 1000)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 6, 2, 400)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 6, 5, 380)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 6, 6, 200)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 8, 1, 500)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 9, 2, 600)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 9, 6, 400)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 10, 3, 1200)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 10, 9, 300)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 11, 4, 500)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (4, 11, 7, 300)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (5, 1, 3, 1500)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (5, 1, 7, 300)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (5, 1, 10, 190)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (5, 2, 3, 1600)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (5, 2, 4, 450)
GO
print 'Processed 100 total records'
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (5, 2, 5, 1000)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (5, 4, 5, 500)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (5, 9, 2, 400)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (5, 9, 4, 600)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (6, 2, 2, 1800)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (6, 2, 3, 1600)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (6, 2, 4, 550)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (6, 2, 6, 610)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (6, 2, 7, 500)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (6, 2, 8, 480)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (6, 2, 9, 200)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (7, 4, 2, 3000)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (7, 4, 5, 800)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (7, 4, 7, 600)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (7, 8, 1, 130)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (8, 8, 3, 400)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (8, 8, 9, 100)
INSERT [dbo].[PrestacionesPorPlan] ([idPlan], [idObraSocial], [idPrestacion], [montoCubierto]) VALUES (9, 8, 1, 100)
/****** Object:  Table [dbo].[Factura]    Script Date: 11/13/2017 21:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[nroFactura] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[dniPaciente] [int] NOT NULL,
	[idObraSocial] [int] NOT NULL,
	[idPlan] [int] NOT NULL,
	[monto] [float] NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[nroFactura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Factura] ON
INSERT [dbo].[Factura] ([nroFactura], [fecha], [dniPaciente], [idObraSocial], [idPlan], [monto]) VALUES (2, CAST(0x833D0B00 AS Date), 93720820, 2, 1, 2200)
INSERT [dbo].[Factura] ([nroFactura], [fecha], [dniPaciente], [idObraSocial], [idPlan], [monto]) VALUES (3, CAST(0x833D0B00 AS Date), 93720820, 2, 1, 1600)
INSERT [dbo].[Factura] ([nroFactura], [fecha], [dniPaciente], [idObraSocial], [idPlan], [monto]) VALUES (4, CAST(0x833D0B00 AS Date), 93720820, 2, 1, 600)
SET IDENTITY_INSERT [dbo].[Factura] OFF
/****** Object:  StoredProcedure [dbo].[estadisticasObraSocial]    Script Date: 11/13/2017 21:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[estadisticasObraSocial]
AS
BEGIN
SELECT OS.idOS, OS.nombre, COUNT(OSP.idNroAfiliado) AS 'Cantidad_Pacientes' 
FROM ObraSocial OS JOIN Planes  Pl ON (OS.idOS = Pl.idObraSocial) JOIN 
ObraSocialXPaciente OSP ON (Pl.idObraSocial = OSP.idObraSocial AND Pl.idPlan = OSP.idPlan) 
JOIN Pacientes P ON (P.dniPaciente = OSP.dniPaciente) 
GROUP BY OS.idOS, OS.nombre
END
GO
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 11/13/2017 21:51:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[nroFactura] [int] NOT NULL,
	[idPrestacion] [int] NOT NULL,
	[monto] [float] NOT NULL,
	[legajoOdontologo] [int] NOT NULL,
 CONSTRAINT [PK_DetalleFactura] PRIMARY KEY CLUSTERED 
(
	[nroFactura] ASC,
	[idPrestacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DetalleFactura] ([nroFactura], [idPrestacion], [monto], [legajoOdontologo]) VALUES (2, 2, 1000, 2)
INSERT [dbo].[DetalleFactura] ([nroFactura], [idPrestacion], [monto], [legajoOdontologo]) VALUES (2, 8, 600, 2)
INSERT [dbo].[DetalleFactura] ([nroFactura], [idPrestacion], [monto], [legajoOdontologo]) VALUES (3, 4, 600, 1)
/****** Object:  ForeignKey [PlanesPorObraSocial]    Script Date: 11/13/2017 21:50:58 ******/
ALTER TABLE [dbo].[Planes]  WITH CHECK ADD  CONSTRAINT [PlanesPorObraSocial] FOREIGN KEY([idObraSocial])
REFERENCES [dbo].[ObraSocial] ([idOS])
GO
ALTER TABLE [dbo].[Planes] CHECK CONSTRAINT [PlanesPorObraSocial]
GO
/****** Object:  ForeignKey [FK_dbo.EnfermedadesPorPaciente_dbo.Enfermedades]    Script Date: 11/13/2017 21:51:17 ******/
ALTER TABLE [dbo].[EnfermedadesXPaciente]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EnfermedadesPorPaciente_dbo.Enfermedades] FOREIGN KEY([idEnfermedad])
REFERENCES [dbo].[Enfermedades] ([idEnfermedades])
GO
ALTER TABLE [dbo].[EnfermedadesXPaciente] CHECK CONSTRAINT [FK_dbo.EnfermedadesPorPaciente_dbo.Enfermedades]
GO
/****** Object:  ForeignKey [FK_dbo.EnfermedadesPorPaciente_dbo.Pacientes]    Script Date: 11/13/2017 21:51:17 ******/
ALTER TABLE [dbo].[EnfermedadesXPaciente]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EnfermedadesPorPaciente_dbo.Pacientes] FOREIGN KEY([dniPaciente])
REFERENCES [dbo].[Pacientes] ([dniPaciente])
GO
ALTER TABLE [dbo].[EnfermedadesXPaciente] CHECK CONSTRAINT [FK_dbo.EnfermedadesPorPaciente_dbo.Pacientes]
GO
/****** Object:  ForeignKey [FK_MedicosXEspecialidad_Especialidades]    Script Date: 11/13/2017 21:51:17 ******/
ALTER TABLE [dbo].[MedicosXEspecialidad]  WITH CHECK ADD  CONSTRAINT [FK_MedicosXEspecialidad_Especialidades] FOREIGN KEY([idEspecialidad])
REFERENCES [dbo].[Especialidad] ([idEspecialidad])
GO
ALTER TABLE [dbo].[MedicosXEspecialidad] CHECK CONSTRAINT [FK_MedicosXEspecialidad_Especialidades]
GO
/****** Object:  ForeignKey [FK_dbo.HistoriaClinica_dbo.Paciente]    Script Date: 11/13/2017 21:51:17 ******/
ALTER TABLE [dbo].[HistoriaClinica]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HistoriaClinica_dbo.Paciente] FOREIGN KEY([dniPaciente])
REFERENCES [dbo].[Pacientes] ([dniPaciente])
GO
ALTER TABLE [dbo].[HistoriaClinica] CHECK CONSTRAINT [FK_dbo.HistoriaClinica_dbo.Paciente]
GO
/****** Object:  ForeignKey [FK_dbo.HistoriaClinica_dbo.Prestaciones]    Script Date: 11/13/2017 21:51:17 ******/
ALTER TABLE [dbo].[HistoriaClinica]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HistoriaClinica_dbo.Prestaciones] FOREIGN KEY([idPrestacion])
REFERENCES [dbo].[Prestaciones] ([idPrestacion])
GO
ALTER TABLE [dbo].[HistoriaClinica] CHECK CONSTRAINT [FK_dbo.HistoriaClinica_dbo.Prestaciones]
GO
/****** Object:  ForeignKey [FK_HistoriaClinica_TipoDiente]    Script Date: 11/13/2017 21:51:17 ******/
ALTER TABLE [dbo].[HistoriaClinica]  WITH CHECK ADD  CONSTRAINT [FK_HistoriaClinica_TipoDiente] FOREIGN KEY([idTipo])
REFERENCES [dbo].[TipoDiente] ([idTipo])
GO
ALTER TABLE [dbo].[HistoriaClinica] CHECK CONSTRAINT [FK_HistoriaClinica_TipoDiente]
GO
/****** Object:  ForeignKey [FK_HistoriaClinica_Ubicacion]    Script Date: 11/13/2017 21:51:17 ******/
ALTER TABLE [dbo].[HistoriaClinica]  WITH CHECK ADD  CONSTRAINT [FK_HistoriaClinica_Ubicacion] FOREIGN KEY([idUbicacion])
REFERENCES [dbo].[Ubicacion] ([idUbicacion])
GO
ALTER TABLE [dbo].[HistoriaClinica] CHECK CONSTRAINT [FK_HistoriaClinica_Ubicacion]
GO
/****** Object:  ForeignKey [FK_Receta_Odontologos]    Script Date: 11/13/2017 21:51:17 ******/
ALTER TABLE [dbo].[Receta]  WITH CHECK ADD  CONSTRAINT [FK_Receta_Odontologos] FOREIGN KEY([legajoOdontologo])
REFERENCES [dbo].[Odontologos] ([legajo])
GO
ALTER TABLE [dbo].[Receta] CHECK CONSTRAINT [FK_Receta_Odontologos]
GO
/****** Object:  ForeignKey [FK_Receta_Pacientes]    Script Date: 11/13/2017 21:51:17 ******/
ALTER TABLE [dbo].[Receta]  WITH CHECK ADD  CONSTRAINT [FK_Receta_Pacientes] FOREIGN KEY([dniPaciente])
REFERENCES [dbo].[Pacientes] ([dniPaciente])
GO
ALTER TABLE [dbo].[Receta] CHECK CONSTRAINT [FK_Receta_Pacientes]
GO
/****** Object:  ForeignKey [FK_dbo.AlergiasPorPaciente_dbo.Alergias]    Script Date: 11/13/2017 21:51:17 ******/
ALTER TABLE [dbo].[AlergiasXPaciente]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AlergiasPorPaciente_dbo.Alergias] FOREIGN KEY([idAlergia])
REFERENCES [dbo].[Alergias] ([idAlergia])
GO
ALTER TABLE [dbo].[AlergiasXPaciente] CHECK CONSTRAINT [FK_dbo.AlergiasPorPaciente_dbo.Alergias]
GO
/****** Object:  ForeignKey [FK_dbo.AlergiasPorPaciente_dbo.Pacientes]    Script Date: 11/13/2017 21:51:17 ******/
ALTER TABLE [dbo].[AlergiasXPaciente]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AlergiasPorPaciente_dbo.Pacientes] FOREIGN KEY([dniPaciente])
REFERENCES [dbo].[Pacientes] ([dniPaciente])
GO
ALTER TABLE [dbo].[AlergiasXPaciente] CHECK CONSTRAINT [FK_dbo.AlergiasPorPaciente_dbo.Pacientes]
GO
/****** Object:  ForeignKey [FK_ObraSocialXPaciente_Pacientes]    Script Date: 11/13/2017 21:51:18 ******/
ALTER TABLE [dbo].[ObraSocialXPaciente]  WITH CHECK ADD  CONSTRAINT [FK_ObraSocialXPaciente_Pacientes] FOREIGN KEY([dniPaciente])
REFERENCES [dbo].[Pacientes] ([dniPaciente])
GO
ALTER TABLE [dbo].[ObraSocialXPaciente] CHECK CONSTRAINT [FK_ObraSocialXPaciente_Pacientes]
GO
/****** Object:  ForeignKey [FK_ObraSocialXPaciente_Planes]    Script Date: 11/13/2017 21:51:18 ******/
ALTER TABLE [dbo].[ObraSocialXPaciente]  WITH CHECK ADD  CONSTRAINT [FK_ObraSocialXPaciente_Planes] FOREIGN KEY([idPlan], [idObraSocial])
REFERENCES [dbo].[Planes] ([idPlan], [idObraSocial])
GO
ALTER TABLE [dbo].[ObraSocialXPaciente] CHECK CONSTRAINT [FK_ObraSocialXPaciente_Planes]
GO
/****** Object:  ForeignKey [PrestacionesXPlan]    Script Date: 11/13/2017 21:51:18 ******/
ALTER TABLE [dbo].[PrestacionesPorPlan]  WITH CHECK ADD  CONSTRAINT [PrestacionesXPlan] FOREIGN KEY([idPlan], [idObraSocial])
REFERENCES [dbo].[Planes] ([idPlan], [idObraSocial])
GO
ALTER TABLE [dbo].[PrestacionesPorPlan] CHECK CONSTRAINT [PrestacionesXPlan]
GO
/****** Object:  ForeignKey [FK_Factura_Paciente]    Script Date: 11/13/2017 21:51:18 ******/
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Paciente] FOREIGN KEY([dniPaciente])
REFERENCES [dbo].[Pacientes] ([dniPaciente])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Paciente]
GO
/****** Object:  ForeignKey [FK_Factura_PrestacionesXPlan]    Script Date: 11/13/2017 21:51:18 ******/
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_PrestacionesXPlan] FOREIGN KEY([idPlan], [idObraSocial])
REFERENCES [dbo].[Planes] ([idPlan], [idObraSocial])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_PrestacionesXPlan]
GO
/****** Object:  ForeignKey [FK_DetalleFactura_Facturas]    Script Date: 11/13/2017 21:51:18 ******/
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Facturas] FOREIGN KEY([nroFactura])
REFERENCES [dbo].[Factura] ([nroFactura])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Facturas]
GO
/****** Object:  ForeignKey [FK_DetalleFactura_Odontologos]    Script Date: 11/13/2017 21:51:18 ******/
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Odontologos] FOREIGN KEY([legajoOdontologo])
REFERENCES [dbo].[Odontologos] ([legajo])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Odontologos]
GO
/****** Object:  ForeignKey [FK_DetalleFactura_Prestaciones]    Script Date: 11/13/2017 21:51:18 ******/
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Prestaciones] FOREIGN KEY([idPrestacion])
REFERENCES [dbo].[Prestaciones] ([idPrestacion])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Prestaciones]
GO
