USE [master]
GO
/****** Object:  Database [BugTrackerExt]    Script Date: 13/11/2020 07:42:27 p.m. ******/
CREATE DATABASE [BugTrackerExt]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BugTrackerExt', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BugTrackerExt.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BugTrackerExt_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BugTrackerExt_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BugTrackerExt] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BugTrackerExt].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BugTrackerExt] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BugTrackerExt] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BugTrackerExt] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BugTrackerExt] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BugTrackerExt] SET ARITHABORT OFF 
GO
ALTER DATABASE [BugTrackerExt] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BugTrackerExt] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BugTrackerExt] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BugTrackerExt] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BugTrackerExt] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BugTrackerExt] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BugTrackerExt] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BugTrackerExt] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BugTrackerExt] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BugTrackerExt] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BugTrackerExt] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BugTrackerExt] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BugTrackerExt] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BugTrackerExt] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BugTrackerExt] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BugTrackerExt] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BugTrackerExt] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BugTrackerExt] SET RECOVERY FULL 
GO
ALTER DATABASE [BugTrackerExt] SET  MULTI_USER 
GO
ALTER DATABASE [BugTrackerExt] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BugTrackerExt] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BugTrackerExt] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BugTrackerExt] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BugTrackerExt] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BugTrackerExt', N'ON'
GO
ALTER DATABASE [BugTrackerExt] SET QUERY_STORE = OFF
GO
USE [BugTrackerExt]
GO
/****** Object:  Table [dbo].[Asignaciones]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignaciones](
	[id_asignacion] [int] NOT NULL,
	[n_asignacion] [varchar](40) NOT NULL,
	[monto] [numeric](10, 2) NOT NULL,
 CONSTRAINT [pk_asignacion] PRIMARY KEY CLUSTERED 
(
	[id_asignacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AsistenciaUsuarios]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AsistenciaUsuarios](
	[id_usuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[hora_ingreso] [time](7) NULL,
	[hora_salida] [time](7) NULL,
	[id_estado_asistencia] [int] NULL,
	[comentario] [varchar](500) NULL,
 CONSTRAINT [pk_asistencia] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Barrios]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrios](
	[id_barrio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Barrios] PRIMARY KEY CLUSTERED 
(
	[id_barrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bugs]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bugs](
	[id_bug] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](100) NOT NULL,
	[descripcion] [varchar](1000) NULL,
	[fecha_alta] [date] NOT NULL,
	[id_usuario_responsable] [int] NULL,
	[id_usuario_asignado] [int] NULL,
	[id_producto] [int] NULL,
	[id_prioridad] [int] NULL,
	[id_criticidad] [int] NULL,
	[id_estado] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Bugs] PRIMARY KEY CLUSTERED 
(
	[id_bug] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BugsHistorico]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BugsHistorico](
	[id_bug_historico] [int] IDENTITY(1,1) NOT NULL,
	[fecha_historico] [date] NULL,
	[titulo] [varchar](100) NOT NULL,
	[descripcion] [varchar](1000) NULL,
	[id_bug] [int] NOT NULL,
	[id_usuario_responsable] [int] NULL,
	[id_usuario_asignado] [int] NULL,
	[id_producto] [int] NULL,
	[id_prioridad] [int] NULL,
	[id_criticidad] [int] NULL,
	[id_estado] [int] NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_BugsHistorico] PRIMARY KEY CLUSTERED 
(
	[id_bug_historico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Caracteristicas]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Caracteristicas](
	[id_caracteristica] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [pk_idCaracteristica] PRIMARY KEY CLUSTERED 
(
	[id_caracteristica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CasosDePrueba]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CasosDePrueba](
	[id_caso_prueba] [int] IDENTITY(1,1) NOT NULL,
	[id_plan_prueba] [int] NOT NULL,
	[titulo] [varchar](50) NULL,
	[descripcion] [varchar](200) NULL,
	[id_responsable] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_CasosDePrueba_1] PRIMARY KEY CLUSTERED 
(
	[id_caso_prueba] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[id_categoria] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [nvarchar](50) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CiclosPrueba]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CiclosPrueba](
	[id_ciclo_prueba] [int] NOT NULL,
	[fecha_inicio_ejecucion] [datetime] NULL,
	[fecha_fin_ejecucion] [datetime] NULL,
	[id_responsable] [int] NULL,
	[id_plan_prueba] [int] NULL,
	[aceptado] [bit] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_CiclosPrueba] PRIMARY KEY CLUSTERED 
(
	[id_ciclo_prueba] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CiclosPruebaDetalle]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CiclosPruebaDetalle](
	[id_ciclo_prueba_detalle] [int] NOT NULL,
	[id_ciclo_prueba] [int] NULL,
	[id_caso_prueba] [int] NULL,
	[id_usuario_tester] [int] NULL,
	[cantidad_horas] [decimal](18, 0) NULL,
	[fecha_ejecucion] [datetime] NULL,
	[aceptado] [bit] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_CiclosPruebaDetalle] PRIMARY KEY CLUSTERED 
(
	[id_ciclo_prueba_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[cuit] [varchar](50) NULL,
	[razon_social] [varchar](50) NULL,
	[borrado] [bit] NULL,
	[calle] [varchar](500) NULL,
	[numero] [varchar](50) NULL,
	[fecha_alta] [datetime] NULL,
	[id_barrio] [int] NULL,
	[id_contacto] [int] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contactos]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contactos](
	[id_contacto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Contactos] PRIMARY KEY CLUSTERED 
(
	[id_contacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Criticidades]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Criticidades](
	[id_criticidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Criticidades] PRIMARY KEY CLUSTERED 
(
	[id_criticidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[id_curso] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [nvarchar](50) NULL,
	[fecha_vigencia] [datetime] NULL,
	[id_categoria] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Cursos] PRIMARY KEY CLUSTERED 
(
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Descuentos]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Descuentos](
	[id_descuento] [int] NOT NULL,
	[n_descuento] [varchar](40) NOT NULL,
	[monto] [numeric](10, 2) NULL,
 CONSTRAINT [pk_descuento] PRIMARY KEY CLUSTERED 
(
	[id_descuento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadosAsistencia]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadosAsistencia](
	[id_estado_asistencia] [int] NOT NULL,
	[n_estados_asistencia] [varchar](20) NOT NULL,
 CONSTRAINT [pk_estados_asistencia] PRIMARY KEY CLUSTERED 
(
	[id_estado_asistencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadosUsuarios]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadosUsuarios](
	[id_estado_usuario] [int] NOT NULL,
	[n_estado_usuario] [varchar](20) NOT NULL,
 CONSTRAINT [estado_u_pk] PRIMARY KEY CLUSTERED 
(
	[id_estado_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[numero_factura] [varchar](50) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_usuario_creador] [int] NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturasDetalle]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturasDetalle](
	[id_detalle_factura] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NULL,
	[numero_orden] [int] NULL,
	[id_producto] [int] NULL,
	[id_proyecto] [int] NULL,
	[id_ciclo_prueba] [int] NULL,
	[precio] [decimal](18, 0) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_FacturaDetalles] PRIMARY KEY CLUSTERED 
(
	[id_detalle_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Formularios]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formularios](
	[id_formulario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Formularios] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Objetivos]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Objetivos](
	[id_objetivo] [int] NOT NULL,
	[nombre_corto] [varchar](50) NULL,
	[nombre_largo] [varchar](100) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Objetivos] PRIMARY KEY CLUSTERED 
(
	[id_objetivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ObjetivosCursos]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObjetivosCursos](
	[id_objetivo] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[puntos] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_ObjetivosCursos] PRIMARY KEY CLUSTERED 
(
	[id_objetivo] ASC,
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfiles](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[id_formulario] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
	[borrado] [int] NULL,
 CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC,
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanesDePrueba]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanesDePrueba](
	[id_plan_prueba] [int] IDENTITY(1,1) NOT NULL,
	[id_proyecto] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[id_responsable] [int] NULL,
	[descripcion] [varchar](100) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_PlanesDePrueba] PRIMARY KEY CLUSTERED 
(
	[id_plan_prueba] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prioridades]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prioridades](
	[id_prioridad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Prioridades] PRIMARY KEY CLUSTERED 
(
	[id_prioridad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proyectos]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proyectos](
	[id_proyecto] [int] NOT NULL,
	[id_producto] [int] NULL,
	[descripcion] [varchar](50) NULL,
	[version] [varchar](50) NULL,
	[alcance] [varchar](50) NULL,
	[id_responsable] [int] NULL,
	[borrado] [nchar](10) NULL,
 CONSTRAINT [PK_Proyectos] PRIMARY KEY CLUSTERED 
(
	[id_proyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SueldoAsignaciones]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SueldoAsignaciones](
	[id_usuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[id_asignacion] [int] NOT NULL,
	[monto] [numeric](10, 2) NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [pk_sueldoasignacion] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[fecha] ASC,
	[id_asignacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SueldoDescuentos]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SueldoDescuentos](
	[id_usuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[id_descuento] [int] NOT NULL,
	[cantidad] [int] NULL,
	[monto] [numeric](10, 2) NULL,
 CONSTRAINT [pk_sueldoDescuento] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[fecha] ASC,
	[id_descuento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SueldoPerfilHistorico]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SueldoPerfilHistorico](
	[id_perfil] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[sueldo] [numeric](10, 2) NOT NULL,
 CONSTRAINT [pk_sueldoPerfil] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC,
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sueldos]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sueldos](
	[id_usuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[sueldo_bruto] [numeric](10, 2) NOT NULL,
 CONSTRAINT [pk_sueldo] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[estado] [varchar](1) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosCurso]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosCurso](
	[id_usuario] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[puntuacion] [int] NULL,
	[observaciones] [varchar](150) NULL,
	[fecha_inicio] [datetime] NULL,
	[fecha_fin] [datetime] NULL,
 CONSTRAINT [PK_UsuariosCurso] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosCursoAvance]    Script Date: 13/11/2020 07:42:28 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosCursoAvance](
	[id_usuario] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[inicio] [datetime] NOT NULL,
	[fin] [datetime] NULL,
	[porc_avance] [int] NULL,
 CONSTRAINT [PK_UsuariosCursoAvance] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[id_curso] ASC,
	[inicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto]) VALUES (1, N'Presentismo', CAST(10000.00 AS Numeric(10, 2)))
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto]) VALUES (2, N'Hijos', CAST(3000.00 AS Numeric(10, 2)))
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto]) VALUES (3, N'Título Universitario', CAST(12000.00 AS Numeric(10, 2)))
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto]) VALUES (4, N'Título Terciario', CAST(8000.00 AS Numeric(10, 2)))
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto]) VALUES (5, N'Título Técnico', CAST(6000.00 AS Numeric(10, 2)))
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto]) VALUES (6, N'Permanencia', CAST(10800.00 AS Numeric(10, 2)))
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto]) VALUES (7, N'Productividad', CAST(20000.00 AS Numeric(10, 2)))
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto]) VALUES (8, N'Horas Extras', CAST(500.00 AS Numeric(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[Bugs] ON 

INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [fecha_alta], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado], [borrado]) VALUES (2, N'Validaci??n de campos', N'No valida que los campos obligatorios tengan valor', CAST(N'2019-02-02' AS Date), 1, 2, 1, 1, 1, 1, 0)
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [fecha_alta], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado], [borrado]) VALUES (3, N'Carga de grilla', N'La grilla no carga valores correctos', CAST(N'2019-03-03' AS Date), 1, 2, 2, 1, 1, 2, 0)
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [fecha_alta], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado], [borrado]) VALUES (5, N'Carga de combos', N'No muestra descripci??n en el combo', CAST(N'2019-03-02' AS Date), 2, 4, 3, 2, 3, 3, 0)
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [fecha_alta], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado], [borrado]) VALUES (6, N'Grabado de objetos', N'No graba todos los datos del registro', CAST(N'2019-10-07' AS Date), 2, 4, 4, 2, 2, 1, 0)
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [fecha_alta], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado], [borrado]) VALUES (7, N'Transacci??n', N'Graba mas de un registro sin contemplar transacci??n', CAST(N'2019-10-07' AS Date), 5, 5, 3, 3, 2, 1, 0)
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [fecha_alta], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado], [borrado]) VALUES (8, N'C??lculos', N'Calcula mal el total', CAST(N'2019-10-07' AS Date), 4, 5, 4, 2, 2, 2, 0)
SET IDENTITY_INSERT [dbo].[Bugs] OFF
GO
SET IDENTITY_INSERT [dbo].[BugsHistorico] ON 

INSERT [dbo].[BugsHistorico] ([id_bug_historico], [fecha_historico], [titulo], [descripcion], [id_bug], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado], [borrado]) VALUES (10, CAST(N'2019-10-07' AS Date), N'probando transaccion', N'probando transaccion insert en bug e insert en historico', 6, NULL, NULL, 1, 2, 1, 1, 0)
INSERT [dbo].[BugsHistorico] ([id_bug_historico], [fecha_historico], [titulo], [descripcion], [id_bug], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado], [borrado]) VALUES (11, CAST(N'2019-10-07' AS Date), N'probando transaccion', N'probando transaccion', 7, NULL, NULL, 1, 1, 1, 1, 0)
SET IDENTITY_INSERT [dbo].[BugsHistorico] OFF
GO
SET IDENTITY_INSERT [dbo].[Caracteristicas] ON 

INSERT [dbo].[Caracteristicas] ([id_caracteristica], [nombre], [descripcion], [borrado]) VALUES (1, N'Software web', N'pagina web ', 0)
INSERT [dbo].[Caracteristicas] ([id_caracteristica], [nombre], [descripcion], [borrado]) VALUES (2, N'Sistema', N'Sistema de escritorio', 0)
INSERT [dbo].[Caracteristicas] ([id_caracteristica], [nombre], [descripcion], [borrado]) VALUES (3, N'Reporte', N'Reportes y estadisticas', 0)
INSERT [dbo].[Caracteristicas] ([id_caracteristica], [nombre], [descripcion], [borrado]) VALUES (4, N'Prueba', N'Columna de prueba1', 0)
INSERT [dbo].[Caracteristicas] ([id_caracteristica], [nombre], [descripcion], [borrado]) VALUES (5, N'Prueba2', N'Columna de prueba 2', 0)
SET IDENTITY_INSERT [dbo].[Caracteristicas] OFF
GO
SET IDENTITY_INSERT [dbo].[CasosDePrueba] ON 

INSERT [dbo].[CasosDePrueba] ([id_caso_prueba], [id_plan_prueba], [titulo], [descripcion], [id_responsable], [borrado]) VALUES (3, 1, N'Internet', N'Prueba de internet', 1, 0)
INSERT [dbo].[CasosDePrueba] ([id_caso_prueba], [id_plan_prueba], [titulo], [descripcion], [id_responsable], [borrado]) VALUES (4, 1, N'HW2', N'Prueba de hardware', 2, 0)
INSERT [dbo].[CasosDePrueba] ([id_caso_prueba], [id_plan_prueba], [titulo], [descripcion], [id_responsable], [borrado]) VALUES (10, 1, N'1', N'111', 1, 0)
INSERT [dbo].[CasosDePrueba] ([id_caso_prueba], [id_plan_prueba], [titulo], [descripcion], [id_responsable], [borrado]) VALUES (11, 1, N'Pruebaaaa123', N'Prueba', 1, 0)
SET IDENTITY_INSERT [dbo].[CasosDePrueba] OFF
GO
INSERT [dbo].[CiclosPrueba] ([id_ciclo_prueba], [fecha_inicio_ejecucion], [fecha_fin_ejecucion], [id_responsable], [id_plan_prueba], [aceptado], [borrado]) VALUES (55, CAST(N'2020-10-16T00:46:01.140' AS DateTime), CAST(N'2020-10-16T00:46:01.137' AS DateTime), 1, 1, 0, 0)
INSERT [dbo].[CiclosPrueba] ([id_ciclo_prueba], [fecha_inicio_ejecucion], [fecha_fin_ejecucion], [id_responsable], [id_plan_prueba], [aceptado], [borrado]) VALUES (56, CAST(N'2020-10-16T15:18:56.057' AS DateTime), CAST(N'2020-10-16T15:18:56.053' AS DateTime), 5, 1, 0, 0)
INSERT [dbo].[CiclosPrueba] ([id_ciclo_prueba], [fecha_inicio_ejecucion], [fecha_fin_ejecucion], [id_responsable], [id_plan_prueba], [aceptado], [borrado]) VALUES (57, CAST(N'2020-10-16T15:18:56.057' AS DateTime), CAST(N'2020-10-16T15:18:56.053' AS DateTime), 2, 1, 0, 0)
INSERT [dbo].[CiclosPrueba] ([id_ciclo_prueba], [fecha_inicio_ejecucion], [fecha_fin_ejecucion], [id_responsable], [id_plan_prueba], [aceptado], [borrado]) VALUES (58, CAST(N'2020-10-16T15:20:29.207' AS DateTime), CAST(N'2020-10-16T15:20:29.203' AS DateTime), 1, 1, 0, 0)
INSERT [dbo].[CiclosPrueba] ([id_ciclo_prueba], [fecha_inicio_ejecucion], [fecha_fin_ejecucion], [id_responsable], [id_plan_prueba], [aceptado], [borrado]) VALUES (59, CAST(N'2020-10-16T15:22:16.360' AS DateTime), CAST(N'2020-10-16T15:22:16.357' AS DateTime), 4, 1, 0, 0)
INSERT [dbo].[CiclosPrueba] ([id_ciclo_prueba], [fecha_inicio_ejecucion], [fecha_fin_ejecucion], [id_responsable], [id_plan_prueba], [aceptado], [borrado]) VALUES (60, CAST(N'2020-10-16T20:25:42.557' AS DateTime), CAST(N'2020-10-16T20:25:42.557' AS DateTime), 1, 2, 0, 0)
INSERT [dbo].[CiclosPrueba] ([id_ciclo_prueba], [fecha_inicio_ejecucion], [fecha_fin_ejecucion], [id_responsable], [id_plan_prueba], [aceptado], [borrado]) VALUES (61, CAST(N'2020-10-15T20:25:42.557' AS DateTime), CAST(N'2020-10-16T20:25:42.557' AS DateTime), 5, 1, 0, 0)
INSERT [dbo].[CiclosPrueba] ([id_ciclo_prueba], [fecha_inicio_ejecucion], [fecha_fin_ejecucion], [id_responsable], [id_plan_prueba], [aceptado], [borrado]) VALUES (62, CAST(N'2020-10-16T20:35:42.813' AS DateTime), CAST(N'2020-10-16T20:35:42.810' AS DateTime), 1, 1, 0, 0)
GO
INSERT [dbo].[CiclosPruebaDetalle] ([id_ciclo_prueba_detalle], [id_ciclo_prueba], [id_caso_prueba], [id_usuario_tester], [cantidad_horas], [fecha_ejecucion], [aceptado], [borrado]) VALUES (0, 55, 4, 2, CAST(0 AS Decimal(18, 0)), CAST(N'2020-10-16T00:46:01.120' AS DateTime), 1, 0)
INSERT [dbo].[CiclosPruebaDetalle] ([id_ciclo_prueba_detalle], [id_ciclo_prueba], [id_caso_prueba], [id_usuario_tester], [cantidad_horas], [fecha_ejecucion], [aceptado], [borrado]) VALUES (1, 56, 11, 2, CAST(0 AS Decimal(18, 0)), CAST(N'2020-10-16T15:18:56.043' AS DateTime), 1, 0)
INSERT [dbo].[CiclosPruebaDetalle] ([id_ciclo_prueba_detalle], [id_ciclo_prueba], [id_caso_prueba], [id_usuario_tester], [cantidad_horas], [fecha_ejecucion], [aceptado], [borrado]) VALUES (2, 57, 11, 2, CAST(0 AS Decimal(18, 0)), CAST(N'2020-10-16T15:18:56.043' AS DateTime), 1, 0)
INSERT [dbo].[CiclosPruebaDetalle] ([id_ciclo_prueba_detalle], [id_ciclo_prueba], [id_caso_prueba], [id_usuario_tester], [cantidad_horas], [fecha_ejecucion], [aceptado], [borrado]) VALUES (3, 57, 3, 4, CAST(0 AS Decimal(18, 0)), CAST(N'2020-10-16T15:18:56.043' AS DateTime), 1, 0)
INSERT [dbo].[CiclosPruebaDetalle] ([id_ciclo_prueba_detalle], [id_ciclo_prueba], [id_caso_prueba], [id_usuario_tester], [cantidad_horas], [fecha_ejecucion], [aceptado], [borrado]) VALUES (4, 57, 11, 5, CAST(0 AS Decimal(18, 0)), CAST(N'2020-10-16T15:18:56.043' AS DateTime), 1, 0)
INSERT [dbo].[CiclosPruebaDetalle] ([id_ciclo_prueba_detalle], [id_ciclo_prueba], [id_caso_prueba], [id_usuario_tester], [cantidad_horas], [fecha_ejecucion], [aceptado], [borrado]) VALUES (5, 58, 11, 4, CAST(0 AS Decimal(18, 0)), CAST(N'2020-10-16T15:20:29.187' AS DateTime), 1, 0)
INSERT [dbo].[CiclosPruebaDetalle] ([id_ciclo_prueba_detalle], [id_ciclo_prueba], [id_caso_prueba], [id_usuario_tester], [cantidad_horas], [fecha_ejecucion], [aceptado], [borrado]) VALUES (6, 58, 4, 2, CAST(0 AS Decimal(18, 0)), CAST(N'2020-10-16T15:20:29.187' AS DateTime), 1, 0)
INSERT [dbo].[CiclosPruebaDetalle] ([id_ciclo_prueba_detalle], [id_ciclo_prueba], [id_caso_prueba], [id_usuario_tester], [cantidad_horas], [fecha_ejecucion], [aceptado], [borrado]) VALUES (7, 58, 4, 2, CAST(1 AS Decimal(18, 0)), CAST(N'2020-10-16T15:20:29.187' AS DateTime), 1, 0)
INSERT [dbo].[CiclosPruebaDetalle] ([id_ciclo_prueba_detalle], [id_ciclo_prueba], [id_caso_prueba], [id_usuario_tester], [cantidad_horas], [fecha_ejecucion], [aceptado], [borrado]) VALUES (8, 59, 11, 4, CAST(0 AS Decimal(18, 0)), CAST(N'2020-10-16T15:22:16.347' AS DateTime), 1, 0)
INSERT [dbo].[CiclosPruebaDetalle] ([id_ciclo_prueba_detalle], [id_ciclo_prueba], [id_caso_prueba], [id_usuario_tester], [cantidad_horas], [fecha_ejecucion], [aceptado], [borrado]) VALUES (9, 60, 10, 4, CAST(0 AS Decimal(18, 0)), CAST(N'2020-10-16T20:25:42.550' AS DateTime), 1, 0)
INSERT [dbo].[CiclosPruebaDetalle] ([id_ciclo_prueba_detalle], [id_ciclo_prueba], [id_caso_prueba], [id_usuario_tester], [cantidad_horas], [fecha_ejecucion], [aceptado], [borrado]) VALUES (10, 61, 4, 4, CAST(0 AS Decimal(18, 0)), CAST(N'2020-10-16T20:25:42.550' AS DateTime), 1, 0)
INSERT [dbo].[CiclosPruebaDetalle] ([id_ciclo_prueba_detalle], [id_ciclo_prueba], [id_caso_prueba], [id_usuario_tester], [cantidad_horas], [fecha_ejecucion], [aceptado], [borrado]) VALUES (11, 62, 4, 2, CAST(0 AS Decimal(18, 0)), CAST(N'2020-10-16T20:35:42.797' AS DateTime), 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Criticidades] ON 

INSERT [dbo].[Criticidades] ([id_criticidad], [nombre], [borrado]) VALUES (1, N'LEVE', 0)
INSERT [dbo].[Criticidades] ([id_criticidad], [nombre], [borrado]) VALUES (2, N'GRAVE', 0)
INSERT [dbo].[Criticidades] ([id_criticidad], [nombre], [borrado]) VALUES (3, N'INVALIDANTE', 0)
SET IDENTITY_INSERT [dbo].[Criticidades] OFF
GO
SET IDENTITY_INSERT [dbo].[Estados] ON 

INSERT [dbo].[Estados] ([id_estado], [nombre], [borrado]) VALUES (1, N'Nuevo', 0)
INSERT [dbo].[Estados] ([id_estado], [nombre], [borrado]) VALUES (2, N'Asignado', 0)
INSERT [dbo].[Estados] ([id_estado], [nombre], [borrado]) VALUES (3, N'Cerrado', 0)
INSERT [dbo].[Estados] ([id_estado], [nombre], [borrado]) VALUES (4, N'En testing', 0)
SET IDENTITY_INSERT [dbo].[Estados] OFF
GO
INSERT [dbo].[EstadosAsistencia] ([id_estado_asistencia], [n_estados_asistencia]) VALUES (1, N'Presente')
INSERT [dbo].[EstadosAsistencia] ([id_estado_asistencia], [n_estados_asistencia]) VALUES (2, N'Ausente')
INSERT [dbo].[EstadosAsistencia] ([id_estado_asistencia], [n_estados_asistencia]) VALUES (3, N'Carpeta Médica')
INSERT [dbo].[EstadosAsistencia] ([id_estado_asistencia], [n_estados_asistencia]) VALUES (4, N'Licencia x Estudios')
INSERT [dbo].[EstadosAsistencia] ([id_estado_asistencia], [n_estados_asistencia]) VALUES (5, N'Licencia Vacaciones')
GO
INSERT [dbo].[EstadosUsuarios] ([id_estado_usuario], [n_estado_usuario]) VALUES (1, N'Activo')
INSERT [dbo].[EstadosUsuarios] ([id_estado_usuario], [n_estado_usuario]) VALUES (2, N'A prueba')
INSERT [dbo].[EstadosUsuarios] ([id_estado_usuario], [n_estado_usuario]) VALUES (3, N'Inactivo')
INSERT [dbo].[EstadosUsuarios] ([id_estado_usuario], [n_estado_usuario]) VALUES (4, N'Baja')
INSERT [dbo].[EstadosUsuarios] ([id_estado_usuario], [n_estado_usuario]) VALUES (5, N'Suspendido')
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON 

INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (1, N'Administrador', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (2, N'Tester', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (3, N'Desarrollador', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (4, N'Responsable de Reportes', 0)
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
GO
SET IDENTITY_INSERT [dbo].[PlanesDePrueba] ON 

INSERT [dbo].[PlanesDePrueba] ([id_plan_prueba], [id_proyecto], [nombre], [id_responsable], [descripcion], [borrado]) VALUES (1, 1, N'Bugs', 1, N'Busqueda de Bugs', 0)
INSERT [dbo].[PlanesDePrueba] ([id_plan_prueba], [id_proyecto], [nombre], [id_responsable], [descripcion], [borrado]) VALUES (2, 2, N'Analisis', 2, N'Analisis de bugs', 0)
INSERT [dbo].[PlanesDePrueba] ([id_plan_prueba], [id_proyecto], [nombre], [id_responsable], [descripcion], [borrado]) VALUES (3, 2, N'Solucion', 4, N'Disenio de soluciones', 0)
INSERT [dbo].[PlanesDePrueba] ([id_plan_prueba], [id_proyecto], [nombre], [id_responsable], [descripcion], [borrado]) VALUES (106, 4, N'Prueba', 5, N'Prueba 4 ', 0)
SET IDENTITY_INSERT [dbo].[PlanesDePrueba] OFF
GO
SET IDENTITY_INSERT [dbo].[Prioridades] ON 

INSERT [dbo].[Prioridades] ([id_prioridad], [nombre], [borrado]) VALUES (1, N'BAJA', 0)
INSERT [dbo].[Prioridades] ([id_prioridad], [nombre], [borrado]) VALUES (2, N'MEDIA', 0)
INSERT [dbo].[Prioridades] ([id_prioridad], [nombre], [borrado]) VALUES (3, N'ALTA', 0)
INSERT [dbo].[Prioridades] ([id_prioridad], [nombre], [borrado]) VALUES (4, N'URGENTE', 0)
SET IDENTITY_INSERT [dbo].[Prioridades] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([id_producto], [nombre], [borrado]) VALUES (1, N'Software de Gesti??n', 1)
INSERT [dbo].[Productos] ([id_producto], [nombre], [borrado]) VALUES (2, N'Soft. de Gestion de Identidad', 0)
INSERT [dbo].[Productos] ([id_producto], [nombre], [borrado]) VALUES (3, N'Software de Auditor??a', 0)
INSERT [dbo].[Productos] ([id_producto], [nombre], [borrado]) VALUES (4, N'Soft. Vulnerabilidades', 0)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
INSERT [dbo].[Proyectos] ([id_proyecto], [id_producto], [descripcion], [version], [alcance], [id_responsable], [borrado]) VALUES (1, 1, N'Software vulnerabilidades', N'2', N'Seguridad', 1, N'false     ')
INSERT [dbo].[Proyectos] ([id_proyecto], [id_producto], [descripcion], [version], [alcance], [id_responsable], [borrado]) VALUES (2, 2, N'Software gestion', N'1', N'Gestion ', 2, N'false     ')
INSERT [dbo].[Proyectos] ([id_proyecto], [id_producto], [descripcion], [version], [alcance], [id_responsable], [borrado]) VALUES (3, 4, N'Prueba de proyecto', N'1', N'Pruebas', 4, N'false     ')
INSERT [dbo].[Proyectos] ([id_proyecto], [id_producto], [descripcion], [version], [alcance], [id_responsable], [borrado]) VALUES (4, 3, N'Software de Bugs', N'3', N'Analisis de bug', 5, N'false     ')
GO
INSERT [dbo].[SueldoPerfilHistorico] ([id_perfil], [fecha], [sueldo]) VALUES (1, CAST(N'2020-08-01' AS Date), CAST(100000.00 AS Numeric(10, 2)))
INSERT [dbo].[SueldoPerfilHistorico] ([id_perfil], [fecha], [sueldo]) VALUES (2, CAST(N'2020-08-01' AS Date), CAST(50000.00 AS Numeric(10, 2)))
INSERT [dbo].[SueldoPerfilHistorico] ([id_perfil], [fecha], [sueldo]) VALUES (3, CAST(N'2020-08-01' AS Date), CAST(80000.00 AS Numeric(10, 2)))
INSERT [dbo].[SueldoPerfilHistorico] ([id_perfil], [fecha], [sueldo]) VALUES (4, CAST(N'2020-08-01' AS Date), CAST(49000.00 AS Numeric(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (1, 1, N'administrador', N'12345', N'admin@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (2, 2, N'Tester Ariel', N'12345', N'ariel@gmail.com', N'N', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (4, 3, N'Tester Miguel', N'12345', N'miguel@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (5, 2, N'Tester Ana', N'12345', N'ana@gmail.com', N'N', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (6, 3, N'Tester Diego', N'12345', N'diego@gmail.com', N'N', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (7, 4, N'Tester Micaela', N'12345', N'mica@gmail.com', N'S', 0)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[BugsHistorico] ADD  CONSTRAINT [DF_BugsHistorico_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Criticidades] ADD  CONSTRAINT [DF_Criticidades_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Estados] ADD  CONSTRAINT [DF_Estados_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Formularios] ADD  CONSTRAINT [DF_Formularios_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Perfiles] ADD  CONSTRAINT [DF_Perfiles_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Prioridades] ADD  CONSTRAINT [DF_Prioridades_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF_Productos_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[AsistenciaUsuarios]  WITH CHECK ADD  CONSTRAINT [fk_id_estado_asistencia] FOREIGN KEY([id_estado_asistencia])
REFERENCES [dbo].[EstadosAsistencia] ([id_estado_asistencia])
GO
ALTER TABLE [dbo].[AsistenciaUsuarios] CHECK CONSTRAINT [fk_id_estado_asistencia]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Criticidades] FOREIGN KEY([id_criticidad])
REFERENCES [dbo].[Criticidades] ([id_criticidad])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Criticidades]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Estados] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estados] ([id_estado])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Estados]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Prioridades] FOREIGN KEY([id_prioridad])
REFERENCES [dbo].[Prioridades] ([id_prioridad])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Prioridades]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Productos]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Usuarios] FOREIGN KEY([id_usuario_asignado])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Usuarios]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Usuarios1] FOREIGN KEY([id_usuario_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Usuarios1]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Bugs] FOREIGN KEY([id_bug])
REFERENCES [dbo].[Bugs] ([id_bug])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Bugs]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Criticidades] FOREIGN KEY([id_criticidad])
REFERENCES [dbo].[Criticidades] ([id_criticidad])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Criticidades]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Estados] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estados] ([id_estado])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Estados]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Prioridades] FOREIGN KEY([id_prioridad])
REFERENCES [dbo].[Prioridades] ([id_prioridad])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Prioridades]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Productos]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Usuarios] FOREIGN KEY([id_usuario_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Usuarios]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Usuarios1] FOREIGN KEY([id_usuario_asignado])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Usuarios1]
GO
ALTER TABLE [dbo].[CasosDePrueba]  WITH CHECK ADD  CONSTRAINT [FK_CasosDePrueba_PlanesDePrueba] FOREIGN KEY([id_plan_prueba])
REFERENCES [dbo].[PlanesDePrueba] ([id_plan_prueba])
GO
ALTER TABLE [dbo].[CasosDePrueba] CHECK CONSTRAINT [FK_CasosDePrueba_PlanesDePrueba]
GO
ALTER TABLE [dbo].[CiclosPrueba]  WITH CHECK ADD  CONSTRAINT [FK_CiclosPrueba_PlanesDePrueba] FOREIGN KEY([id_plan_prueba])
REFERENCES [dbo].[PlanesDePrueba] ([id_plan_prueba])
GO
ALTER TABLE [dbo].[CiclosPrueba] CHECK CONSTRAINT [FK_CiclosPrueba_PlanesDePrueba]
GO
ALTER TABLE [dbo].[CiclosPrueba]  WITH CHECK ADD  CONSTRAINT [FK_CiclosPrueba_Usuarios] FOREIGN KEY([id_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[CiclosPrueba] CHECK CONSTRAINT [FK_CiclosPrueba_Usuarios]
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CiclosPruebaDetalle_CasosDePrueba] FOREIGN KEY([id_caso_prueba])
REFERENCES [dbo].[CasosDePrueba] ([id_caso_prueba])
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle] CHECK CONSTRAINT [FK_CiclosPruebaDetalle_CasosDePrueba]
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CiclosPruebaDetalle_CiclosPrueba] FOREIGN KEY([id_ciclo_prueba])
REFERENCES [dbo].[CiclosPrueba] ([id_ciclo_prueba])
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle] CHECK CONSTRAINT [FK_CiclosPruebaDetalle_CiclosPrueba]
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CiclosPruebaDetalle_Usuarios] FOREIGN KEY([id_usuario_tester])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle] CHECK CONSTRAINT [FK_CiclosPruebaDetalle_Usuarios]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Barrios] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrios] ([id_barrio])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Barrios]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Contactos] FOREIGN KEY([id_contacto])
REFERENCES [dbo].[Contactos] ([id_contacto])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Contactos]
GO
ALTER TABLE [dbo].[Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_Categorias] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categorias] ([id_categoria])
GO
ALTER TABLE [dbo].[Cursos] CHECK CONSTRAINT [FK_Cursos_Categorias]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Clientes]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Usuarios] FOREIGN KEY([id_usuario_creador])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Usuarios]
GO
ALTER TABLE [dbo].[FacturasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDetalle_CiclosPrueba] FOREIGN KEY([id_ciclo_prueba])
REFERENCES [dbo].[CiclosPrueba] ([id_ciclo_prueba])
GO
ALTER TABLE [dbo].[FacturasDetalle] CHECK CONSTRAINT [FK_FacturasDetalle_CiclosPrueba]
GO
ALTER TABLE [dbo].[FacturasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDetalle_Facturas] FOREIGN KEY([id_factura])
REFERENCES [dbo].[Facturas] ([id_factura])
GO
ALTER TABLE [dbo].[FacturasDetalle] CHECK CONSTRAINT [FK_FacturasDetalle_Facturas]
GO
ALTER TABLE [dbo].[FacturasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDetalle_Productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[FacturasDetalle] CHECK CONSTRAINT [FK_FacturasDetalle_Productos]
GO
ALTER TABLE [dbo].[FacturasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDetalle_Proyectos] FOREIGN KEY([id_proyecto])
REFERENCES [dbo].[Proyectos] ([id_proyecto])
GO
ALTER TABLE [dbo].[FacturasDetalle] CHECK CONSTRAINT [FK_FacturasDetalle_Proyectos]
GO
ALTER TABLE [dbo].[ObjetivosCursos]  WITH CHECK ADD  CONSTRAINT [FK_ObjetivosCursos_Cursos] FOREIGN KEY([id_curso])
REFERENCES [dbo].[Cursos] ([id_curso])
GO
ALTER TABLE [dbo].[ObjetivosCursos] CHECK CONSTRAINT [FK_ObjetivosCursos_Cursos]
GO
ALTER TABLE [dbo].[ObjetivosCursos]  WITH CHECK ADD  CONSTRAINT [FK_ObjetivosCursos_Objetivos] FOREIGN KEY([id_objetivo])
REFERENCES [dbo].[Objetivos] ([id_objetivo])
GO
ALTER TABLE [dbo].[ObjetivosCursos] CHECK CONSTRAINT [FK_ObjetivosCursos_Objetivos]
GO
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Formularios] FOREIGN KEY([id_formulario])
REFERENCES [dbo].[Formularios] ([id_formulario])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Formularios]
GO
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Perfiles]
GO
ALTER TABLE [dbo].[PlanesDePrueba]  WITH CHECK ADD  CONSTRAINT [FK_PlanesDePrueba_Proyectos] FOREIGN KEY([id_proyecto])
REFERENCES [dbo].[Proyectos] ([id_proyecto])
GO
ALTER TABLE [dbo].[PlanesDePrueba] CHECK CONSTRAINT [FK_PlanesDePrueba_Proyectos]
GO
ALTER TABLE [dbo].[PlanesDePrueba]  WITH CHECK ADD  CONSTRAINT [FK_PlanesDePrueba_Usuarios] FOREIGN KEY([id_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[PlanesDePrueba] CHECK CONSTRAINT [FK_PlanesDePrueba_Usuarios]
GO
ALTER TABLE [dbo].[Proyectos]  WITH CHECK ADD  CONSTRAINT [FK_Proyectos_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[Proyectos] CHECK CONSTRAINT [FK_Proyectos_Producto]
GO
ALTER TABLE [dbo].[Proyectos]  WITH CHECK ADD  CONSTRAINT [FK_Proyectos_Responsable] FOREIGN KEY([id_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Proyectos] CHECK CONSTRAINT [FK_Proyectos_Responsable]
GO
ALTER TABLE [dbo].[SueldoAsignaciones]  WITH CHECK ADD  CONSTRAINT [fk_seldoAsig_asignacion] FOREIGN KEY([id_asignacion])
REFERENCES [dbo].[Asignaciones] ([id_asignacion])
GO
ALTER TABLE [dbo].[SueldoAsignaciones] CHECK CONSTRAINT [fk_seldoAsig_asignacion]
GO
ALTER TABLE [dbo].[SueldoAsignaciones]  WITH CHECK ADD  CONSTRAINT [fk_sueldo_asig] FOREIGN KEY([id_usuario], [fecha])
REFERENCES [dbo].[Sueldos] ([id_usuario], [fecha])
GO
ALTER TABLE [dbo].[SueldoAsignaciones] CHECK CONSTRAINT [fk_sueldo_asig]
GO
ALTER TABLE [dbo].[SueldoDescuentos]  WITH CHECK ADD  CONSTRAINT [fk_seldoDesc_descuento] FOREIGN KEY([id_descuento])
REFERENCES [dbo].[Descuentos] ([id_descuento])
GO
ALTER TABLE [dbo].[SueldoDescuentos] CHECK CONSTRAINT [fk_seldoDesc_descuento]
GO
ALTER TABLE [dbo].[SueldoDescuentos]  WITH CHECK ADD  CONSTRAINT [fk_sueldo_desc] FOREIGN KEY([id_usuario], [fecha])
REFERENCES [dbo].[Sueldos] ([id_usuario], [fecha])
GO
ALTER TABLE [dbo].[SueldoDescuentos] CHECK CONSTRAINT [fk_sueldo_desc]
GO
ALTER TABLE [dbo].[SueldoPerfilHistorico]  WITH CHECK ADD  CONSTRAINT [fk_sueldoPerfil_permfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[SueldoPerfilHistorico] CHECK CONSTRAINT [fk_sueldoPerfil_permfiles]
GO
ALTER TABLE [dbo].[Sueldos]  WITH CHECK ADD  CONSTRAINT [fk_sueldo_usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Sueldos] CHECK CONSTRAINT [fk_sueldo_usuarios]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Perfiles]
GO
ALTER TABLE [dbo].[UsuariosCurso]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosCurso_Cursos] FOREIGN KEY([id_curso])
REFERENCES [dbo].[Cursos] ([id_curso])
GO
ALTER TABLE [dbo].[UsuariosCurso] CHECK CONSTRAINT [FK_UsuariosCurso_Cursos]
GO
ALTER TABLE [dbo].[UsuariosCurso]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosCurso_Usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[UsuariosCurso] CHECK CONSTRAINT [FK_UsuariosCurso_Usuarios]
GO
ALTER TABLE [dbo].[UsuariosCursoAvance]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosCursoAvance_UsuariosCurso] FOREIGN KEY([id_usuario], [id_curso])
REFERENCES [dbo].[UsuariosCurso] ([id_usuario], [id_curso])
GO
ALTER TABLE [dbo].[UsuariosCursoAvance] CHECK CONSTRAINT [FK_UsuariosCursoAvance_UsuariosCurso]
GO
USE [master]
GO
ALTER DATABASE [BugTrackerExt] SET  READ_WRITE 
GO
