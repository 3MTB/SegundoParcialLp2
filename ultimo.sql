USE [master]
GO
/****** Object:  Database [Ambar]    Script Date: 11/03/2024 06:53:23 p. m. ******/
CREATE DATABASE [Ambar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ambar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Ambar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ambar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Ambar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Ambar] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ambar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ambar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ambar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ambar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ambar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ambar] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ambar] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Ambar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ambar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ambar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ambar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ambar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ambar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ambar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ambar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ambar] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Ambar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ambar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ambar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ambar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ambar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ambar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ambar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ambar] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Ambar] SET  MULTI_USER 
GO
ALTER DATABASE [Ambar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ambar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ambar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ambar] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ambar] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ambar] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Ambar] SET QUERY_STORE = ON
GO
ALTER DATABASE [Ambar] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Ambar]
GO
/****** Object:  Table [dbo].[CxC]    Script Date: 11/03/2024 06:53:24 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CxC](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[TotalCxC] [decimal](18, 2) NOT NULL,
	[FechaPrestamo] [date] NOT NULL,
 CONSTRAINT [PK__CxC__3214EC079373AA3A] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 11/03/2024 06:53:24 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](30) NOT NULL,
	[Cedula] [varchar](12) NOT NULL,
	[Departamento] [varchar](30) NOT NULL,
	[Cargo] [varchar](20) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Sueldo] [decimal](18, 2) NOT NULL,
	[FechaContratado] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gasto]    Script Date: 11/03/2024 06:53:24 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gasto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NumeroCaja] [int] NOT NULL,
	[ConceptoGasto] [varchar](500) NOT NULL,
	[TotalGasto] [decimal](18, 2) NOT NULL,
	[QuienAutoriza] [varchar](30) NOT NULL,
	[QuienRecibe] [varchar](30) NOT NULL,
	[Fecha] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nomina]    Script Date: 11/03/2024 06:53:24 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nomina](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TipoNomina] [varchar](15) NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[AFP] [decimal](18, 2) NOT NULL,
	[IdCxC] [int] NOT NULL,
	[SeguroSocial] [decimal](18, 2) NOT NULL,
	[SueldoNeto] [decimal](18, 2) NOT NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK__Nomina__3214EC07EDBA75BB] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CxC] ON 

INSERT [dbo].[CxC] ([Id], [IdEmpleado], [TotalCxC], [FechaPrestamo]) VALUES (1, 1, CAST(900.00 AS Decimal(18, 2)), CAST(N'2024-11-03' AS Date))
SET IDENTITY_INSERT [dbo].[CxC] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Cedula], [Departamento], [Cargo], [Email], [Telefono], [Direccion], [Sueldo], [FechaContratado]) VALUES (1, N'Eury', N'Tejada', N'40211111111', N'Contabilidad', N'Tecnico', N'eury@gmail.com', N'809-774-5404', N'Las canas', CAST(20000.00 AS Decimal(18, 2)), CAST(N'2024-11-03' AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Cedula], [Departamento], [Cargo], [Email], [Telefono], [Direccion], [Sueldo], [FechaContratado]) VALUES (2, N'Franlu', N'Leonardo', N'40212222222', N'Administracion', N'Tecnico', N'franly@gmail.com', N'809-999-9999', N'Fantino', CAST(3000.00 AS Decimal(18, 2)), CAST(N'2024-11-03' AS Date))
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[Gasto] ON 

INSERT [dbo].[Gasto] ([Id], [NumeroCaja], [ConceptoGasto], [TotalGasto], [QuienAutoriza], [QuienRecibe], [Fecha]) VALUES (1, 1, N'PAGO NOMINA CORRESPONDIENTE Al EMPLEADO: 1', CAST(-780.00 AS Decimal(18, 2)), N'DILONE', N'Eury', CAST(N'2024-11-03T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Gasto] OFF
GO
SET IDENTITY_INSERT [dbo].[Nomina] ON 

INSERT [dbo].[Nomina] ([Id], [TipoNomina], [IdEmpleado], [AFP], [IdCxC], [SeguroSocial], [SueldoNeto], [Fecha]) VALUES (1, N'Semanal', 1, CAST(0.60 AS Decimal(18, 2)), 1, CAST(0.00 AS Decimal(18, 2)), CAST(-780.00 AS Decimal(18, 2)), CAST(N'2024-03-11' AS Date))
SET IDENTITY_INSERT [dbo].[Nomina] OFF
GO
ALTER TABLE [dbo].[CxC]  WITH CHECK ADD  CONSTRAINT [FK_CxC_Empleado] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleado] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CxC] CHECK CONSTRAINT [FK_CxC_Empleado]
GO
ALTER TABLE [dbo].[Nomina]  WITH CHECK ADD  CONSTRAINT [FK_Nomina_ToEmpleado] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleado] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nomina] CHECK CONSTRAINT [FK_Nomina_ToEmpleado]
GO
/****** Object:  StoredProcedure [dbo].[GeneraRegistroNomina]    Script Date: 11/03/2024 06:53:24 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GeneraRegistroNomina]
@IdCxc as int ,
@IdEmpleado as int,
@TipoNomina as varchar(15),
@SeguroSocial as decimal(18,2),
@AFP as decimal(18,2)
As

	Declare
		@sueldoBrutoEmpleado decimal(18,2),
		@DescontarCxc decimal(18,2),
		@SueldoNeto decimal(18,2)

	set @sueldoBrutoEmpleado = (select sueldo from Empleado where Id=@IdEmpleado);
	set @DescontarCxc = (select Sum(TotalCxC )from CxC where IdEmpleado=@IdEmpleado);
	set @SueldoNeto	 = ( @sueldoBrutoEmpleado * ((@AFP+@SeguroSocial) /100) ) - @DescontarCxc;

	INSERT INTO [dbo].[Nomina]
           ([TipoNomina]
           ,[IdEmpleado]
           ,[AFP]
           ,[IdCxC]
           ,[SeguroSocial]
           ,[SueldoNeto]
           ,[Fecha])
		   values(@TipoNomina,@IdEmpleado,@AFP,@IdCxc,@SeguroSocial,@SueldoNeto,GETDATE());
GO
USE [master]
GO
ALTER DATABASE [Ambar] SET  READ_WRITE 
GO
