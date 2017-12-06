USE [master]
GO
/****** Object:  Database [jewdb]    Script Date: 5/12/2017 9:23:58 p. m. ******/
CREATE DATABASE [jewdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'jewdb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\jewdb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'jewdb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\jewdb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [jewdb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [jewdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [jewdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [jewdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [jewdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [jewdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [jewdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [jewdb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [jewdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [jewdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [jewdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [jewdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [jewdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [jewdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [jewdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [jewdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [jewdb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [jewdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [jewdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [jewdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [jewdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [jewdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [jewdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [jewdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [jewdb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [jewdb] SET  MULTI_USER 
GO
ALTER DATABASE [jewdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [jewdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [jewdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [jewdb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [jewdb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [jewdb] SET QUERY_STORE = OFF
GO
USE [jewdb]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [jewdb]
GO
/****** Object:  Table [dbo].[alerta]    Script Date: 5/12/2017 9:23:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alerta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[tipo] [nvarchar](50) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[completado] [tinyint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 5/12/2017 9:23:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo] [int] NOT NULL,
	[id_tipo_docid] [int] NOT NULL,
	[docid] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[direccion] [nvarchar](100) NULL,
	[telefono] [nchar](10) NULL,
	[correo] [nvarchar](50) NULL,
	[nac_dia] [tinyint] NULL,
	[nac_mes] [tinyint] NULL,
	[nac_ano] [int] NULL,
 CONSTRAINT [cliente_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente_tipo]    Script Date: 5/12/2017 9:23:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente_tipo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](255) NOT NULL,
 CONSTRAINT [cliente_tipo_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 5/12/2017 9:23:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_rol] [int] NOT NULL,
	[id_tipo_docid] [int] NOT NULL,
	[docid] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[telefono] [nchar](10) NULL,
	[correo] [nvarchar](50) NULL,
	[password] [nvarchar](255) NOT NULL,
 CONSTRAINT [empleado_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura]    Script Date: 5/12/2017 9:23:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_estado] [int] NOT NULL,
	[descripcion] [nvarchar](255) NULL,
	[fecha_creacion] [datetime] NOT NULL,
	[fecha_actualizacion] [datetime] NOT NULL,
	[fecha_despacho] [datetime] NOT NULL,
 CONSTRAINT [factura_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura_detalle]    Script Date: 5/12/2017 9:23:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura_detalle](
	[id_factura] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[id_vehiculo] [int] NULL,
	[id_empleado] [int] NOT NULL,
	[cantidad] [decimal](11, 2) NOT NULL,
	[precio] [decimal](11, 2) NOT NULL,
 CONSTRAINT [factura_detalle_pk] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC,
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura_estado]    Script Date: 5/12/2017 9:23:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura_estado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
 CONSTRAINT [factura_estado_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inventario]    Script Date: 5/12/2017 9:23:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventario](
	[id_producto] [int] NOT NULL,
	[cantidad_disponible] [decimal](11, 2) NOT NULL,
	[cantidad_minima] [decimal](11, 2) NOT NULL,
	[precio] [decimal](11, 2) NOT NULL,
 CONSTRAINT [inventario_pk] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permiso]    Script Date: 5/12/2017 9:23:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso](
	[id_rol] [int] NOT NULL,
	[id_tarea] [int] NOT NULL,
	[permitido] [tinyint] NOT NULL,
 CONSTRAINT [permiso_pk] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC,
	[id_tarea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 5/12/2017 9:23:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_categoria] [int] NOT NULL,
	[id_medida] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
 CONSTRAINT [producto_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto_categoria]    Script Date: 5/12/2017 9:23:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto_categoria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
 CONSTRAINT [producto_categoria_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto_medida]    Script Date: 5/12/2017 9:23:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto_medida](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
 CONSTRAINT [producto_medida_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rol]    Script Date: 5/12/2017 9:23:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rol](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
 CONSTRAINT [rol_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tarea]    Script Date: 5/12/2017 9:23:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tarea](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
 CONSTRAINT [tarea_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_docid]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_docid](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
 CONSTRAINT [tipo_docid_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vehiculo]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vehiculo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_marca] [int] NOT NULL,
	[id_modelo] [int] NOT NULL,
	[ano] [int] NOT NULL,
	[matricula] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
 CONSTRAINT [vehiculo_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [vehiculo_maricula_uq] UNIQUE NONCLUSTERED 
(
	[matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vehiculo_marca]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vehiculo_marca](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
 CONSTRAINT [vehiculo_marca_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vehiculo_modelo]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vehiculo_modelo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_marca] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
 CONSTRAINT [vehiculo_modelo_pk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[alerta] ADD  CONSTRAINT [DF_alerta_completado]  DEFAULT ((0)) FOR [completado]
GO
ALTER TABLE [dbo].[alerta]  WITH CHECK ADD  CONSTRAINT [FK_alerta_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id])
GO
ALTER TABLE [dbo].[alerta] CHECK CONSTRAINT [FK_alerta_cliente]
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [FK_cliente_cliente_tipo] FOREIGN KEY([id_tipo])
REFERENCES [dbo].[cliente_tipo] ([id])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK_cliente_cliente_tipo]
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [FK_cliente_tipo_docid] FOREIGN KEY([id_tipo_docid])
REFERENCES [dbo].[tipo_docid] ([id])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK_cliente_tipo_docid]
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [FK_empleado_rol] FOREIGN KEY([id_rol])
REFERENCES [dbo].[rol] ([id])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_empleado_rol]
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [FK_empleado_tipo_docid] FOREIGN KEY([id_tipo_docid])
REFERENCES [dbo].[tipo_docid] ([id])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_empleado_tipo_docid]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_cliente]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_factura_estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[factura_estado] ([id])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_factura_estado]
GO
ALTER TABLE [dbo].[factura_detalle]  WITH CHECK ADD  CONSTRAINT [FK_factura_detalle_empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[empleado] ([id])
GO
ALTER TABLE [dbo].[factura_detalle] CHECK CONSTRAINT [FK_factura_detalle_empleado]
GO
ALTER TABLE [dbo].[factura_detalle]  WITH CHECK ADD  CONSTRAINT [FK_factura_detalle_factura] FOREIGN KEY([id_factura])
REFERENCES [dbo].[factura] ([id])
GO
ALTER TABLE [dbo].[factura_detalle] CHECK CONSTRAINT [FK_factura_detalle_factura]
GO
ALTER TABLE [dbo].[factura_detalle]  WITH CHECK ADD  CONSTRAINT [FK_factura_detalle_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id])
GO
ALTER TABLE [dbo].[factura_detalle] CHECK CONSTRAINT [FK_factura_detalle_producto]
GO
ALTER TABLE [dbo].[factura_detalle]  WITH CHECK ADD  CONSTRAINT [FK_factura_detalle_vehiculo] FOREIGN KEY([id_vehiculo])
REFERENCES [dbo].[vehiculo] ([id])
GO
ALTER TABLE [dbo].[factura_detalle] CHECK CONSTRAINT [FK_factura_detalle_vehiculo]
GO
ALTER TABLE [dbo].[inventario]  WITH CHECK ADD  CONSTRAINT [FK_inventario_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id])
GO
ALTER TABLE [dbo].[inventario] CHECK CONSTRAINT [FK_inventario_producto]
GO
ALTER TABLE [dbo].[permiso]  WITH CHECK ADD  CONSTRAINT [FK_permiso_rol] FOREIGN KEY([id_rol])
REFERENCES [dbo].[rol] ([id])
GO
ALTER TABLE [dbo].[permiso] CHECK CONSTRAINT [FK_permiso_rol]
GO
ALTER TABLE [dbo].[permiso]  WITH CHECK ADD  CONSTRAINT [FK_permiso_tarea] FOREIGN KEY([id_tarea])
REFERENCES [dbo].[tarea] ([id])
GO
ALTER TABLE [dbo].[permiso] CHECK CONSTRAINT [FK_permiso_tarea]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_producto_categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[producto_categoria] ([id])
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_producto_categoria]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_producto_medida] FOREIGN KEY([id_medida])
REFERENCES [dbo].[producto_medida] ([id])
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_producto_medida]
GO
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_vehiculo_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id])
GO
ALTER TABLE [dbo].[vehiculo] CHECK CONSTRAINT [FK_vehiculo_cliente]
GO
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_vehiculo_vehiculo_marca] FOREIGN KEY([id_marca])
REFERENCES [dbo].[vehiculo_marca] ([id])
GO
ALTER TABLE [dbo].[vehiculo] CHECK CONSTRAINT [FK_vehiculo_vehiculo_marca]
GO
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_vehiculo_vehiculo_modelo] FOREIGN KEY([id_modelo])
REFERENCES [dbo].[vehiculo_modelo] ([id])
GO
ALTER TABLE [dbo].[vehiculo] CHECK CONSTRAINT [FK_vehiculo_vehiculo_modelo]
GO
ALTER TABLE [dbo].[vehiculo_modelo]  WITH CHECK ADD  CONSTRAINT [FK_vehiculo_modelo_vehiculo_marca] FOREIGN KEY([id_marca])
REFERENCES [dbo].[vehiculo_marca] ([id])
GO
ALTER TABLE [dbo].[vehiculo_modelo] CHECK CONSTRAINT [FK_vehiculo_modelo_vehiculo_marca]
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_factura_detalle]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_delete_factura_detalle]
	@FacturaId [int],
	@ProductoId [int]
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM
		[dbo].[factura_detalle]
	WHERE 
		[id_factura] = @FacturaId AND [id_producto] = @ProductoId
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_cliente]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*CREATE PROCEDURE sp_select_historial
AS
BEGIN
	SET NOCOUNT ON;
	
END
GO*/


CREATE PROCEDURE [dbo].[sp_insert_cliente]
	@TipoId [int],
	@TipoDocId [int],
	@DocId [nvarchar](50),
	@NombreCliente [nvarchar](50),
	@ApellidoCliente [nvarchar](50),
	@DireccionCliente [nvarchar](100),
	@TelefonoCliente [nchar](10),
	@CorreoCliente [nvarchar](50),
	@FechaNacDia [tinyint],
	@FechaNacMes [tinyint],
	@FechaNacAno [int]
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO
		[dbo].[cliente]
	(
		[id_tipo],
		[id_tipo_docid],
		[docid],
		[nombre],
		[apellido],
		[direccion],
		[telefono],
		[correo],
		[nac_dia],
		[nac_mes],
		[nac_ano]
	)
	VALUES
	(
		@TipoId,
		@TipoDocId,
		@DocId,
		@NombreCliente,
		@ApellidoCliente,
		@DireccionCliente,
		@TelefonoCliente,
		@CorreoCliente,
		@FechaNacDia,
		@FechaNacMes,
		@FechaNacAno
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_empleado]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_insert_empleado]
	@RolId [int],
	@TipoDocId [int],
	@DocId [nvarchar](50),
	@NombreEmpleado [nvarchar](50),
	@ApellidoEmpleado [nvarchar](50),
	@TelefonoEmpleado [nchar](10),
	@CorreoEmpleado [nvarchar](50),
	@PasswordEmpleado [nvarchar](255)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO
		[dbo].[empleado]
	(
		[id_rol],
		[id_tipo_docid],
		[docid],
		[nombre],
		[apellido],
		[telefono],
		[correo],
		[password]
	)
	VALUES
	(
		@RolId,
		@TipoDocId,
		@DocId,
		@NombreEmpleado,
		@ApellidoEmpleado,
		@TelefonoEmpleado,
		@CorreoEmpleado,
		@PasswordEmpleado
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_factura]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_insert_factura]
	@ClienteId [int],
	@EstadoId [int],
	@DescrFactura [nvarchar](255)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO
		[dbo].[factura]
	(
		[id_cliente],
		[id_estado],
		[descripcion]
	)
	VALUES
	(
		@ClienteId,
		@EstadoId,
		@DescrFactura
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_factura_detalle]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_insert_factura_detalle]
	@FacturaId [int],
	@ProductoId [int],
	@VehiculoId [int],
	@EmpleadoId [int],
	@Cantidad [decimal](11,2),
	@Precio [decimal](11,2)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO
		[dbo].[factura_detalle]
	(
		[id_factura],
		[id_producto],
		[id_vehiculo],
		[id_empleado],
		[cantidad],
		[precio]
	)
	VALUES
	(
		@FacturaId,
		@ProductoId,
		@VehiculoId,
		@EmpleadoId,
		@Cantidad,
		@Precio
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_vehiculo]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_insert_vehiculo]
	@ClienteId [int],
	@MarcaId [int],
	@ModeloId[int],
	@AnoVehiculo [int],
	@MatriculaVehiculo [nvarchar](50),
	@DescrVehiculo [nvarchar](255)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO
		[dbo].[vehiculo]
	(
		[id_cliente],
		[id_marca],
		[id_modelo],
		[ano],
		[matricula],
		[descripcion]
	)
	VALUES
	(
		@ClienteId,
		@MarcaId,
		@ModeloId,
		@AnoVehiculo,
		@MatriculaVehiculo,
		@DescrVehiculo
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_clientes]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_select_clientes]
	@ClienteId[int] = NULL
AS
BEGIN
	SET NOCOUNT ON;
	SELECT
		[id],
		[id_tipo],
		(SELECT [nombre] FROM [dbo].[cliente_tipo] WHERE [cliente_tipo].[id] = [cliente].[id_tipo]) AS nombre_tipo,
		[id_tipo_docid],
		(SELECT [nombre] FROM [dbo].[tipo_docid] WHERE [tipo_docid].[id] = [cliente].[id_tipo_docid]) AS nombre_docid,
		[docid],
		[nombre],
		[apellido],
		[direccion],
		[telefono],
		[correo],
		[nac_dia],
		[nac_mes],
		[nac_ano]
	FROM [dbo].[cliente]
	WHERE
	(
		@ClienteId is NULL OR [id] = @ClienteId
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_empleados]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_select_empleados]
	@EmpleadoId[int] = NULL
AS
BEGIN
	SET NOCOUNT ON;
	SELECT
		[id],
		[id_rol],
		(SELECT [nombre] FROM [dbo].[rol] WHERE [rol].[id] = [empleado].[id_rol]) AS nombre_rol,
		[id_tipo_docid],
		(SELECT [nombre] FROM [dbo].[tipo_docid] WHERE [tipo_docid].[id] = [empleado].[id_tipo_docid]) AS nombre_docid,
		[docid],
		[nombre],
		[apellido],
		[telefono],
		[correo],
		[password]
	FROM [dbo].[empleado]
	WHERE
	(
		@EmpleadoId is NULL OR [id] = @EmpleadoId
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_factura_detalle]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_select_factura_detalle]
	@FacturaId [int]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT
		[id_factura],
		[id_producto],
		(SELECT [nombre] FROM [dbo].[producto] WHERE [producto].[id] = [factura_detalle].[id_producto]) AS nombre_producto,
		[id_vehiculo],
		[id_empleado],
		[cantidad],
		[precio]
	FROM
		[dbo].[factura_detalle]
	WHERE
		[id_factura] = @FacturaId
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_facturas]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_select_facturas]
	@FacturaId[int] = NULL
	--@FechaIni [datetime],
	--@FechaFin [datetime]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT
		[id],
		[id_cliente],
		[id_estado],
		(SELECT [nombre] FROM [dbo].[cliente_tipo] WHERE [cliente_tipo].[id] = [factura].[id_estado]) AS nombre_estado,
		[descripcion],
		[fecha_creacion],
		[fecha_actualizacion],
		[fecha_despacho]
	FROM
		[dbo].[factura]
	WHERE
	(
		--[factura].[fecha_creacion] >= @FechaIni AND [factura].[fecha_creacion] <= @FechaFin
		@FacturaId is NULL OR [id] = @FacturaId
	)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_inventario]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_select_inventario]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT
		[id_producto],
		(SELECT [nombre] FROM [dbo].[producto] WHERE [producto].[id] = [inventario].[id_producto]) AS nombre_producto,
		[cantidad_disponible],
		[cantidad_minima],
		[precio]
	FROM [dbo].[inventario]
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_permisos]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_select_permisos]
	@UsuarioId [int]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT
		[id_tarea],
		(SELECT [nombre] FROM [dbo].[tarea] WHERE [tarea].[id] = [permiso].[id_tarea]) AS nombre_tarea
    FROM
		[dbo].[permiso]
    WHERE
		[id_rol] = (SELECT [id_rol] FROM [dbo].[empleado] WHERE [id] = @UsuarioId)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_productos]    Script Date: 5/12/2017 9:24:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_select_productos]
	@ProductoId[int] = NULL
AS
BEGIN  
	SET NOCOUNT ON;
	SELECT
		[id],
		[id_categoria],
		(SELECT [nombre] FROM [dbo].[producto_categoria] WHERE [producto_categoria].[id] = [producto].[id_categoria]) AS nombre_categoria,
		[id_medida],
		(SELECT [nombre] FROM [dbo].[producto_medida] WHERE [producto_medida].[id] = [producto].[id_medida]) AS nombre_medida,
		[nombre],
		[descripcion]
	FROM [dbo].[producto]
	WHERE
	(
		@ProductoId is NULL OR [id] = @ProductoId
	)
END
GO
USE [master]
GO
ALTER DATABASE [jewdb] SET  READ_WRITE 
GO
