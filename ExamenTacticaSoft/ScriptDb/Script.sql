USE [master]
GO
/****** Object:  Database [pruebademo]    Script Date: 4/7/2025 11:14:36 ******/
CREATE DATABASE [pruebademo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pruebademo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\pruebademo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'pruebademo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\pruebademo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [pruebademo] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pruebademo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pruebademo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pruebademo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pruebademo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pruebademo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pruebademo] SET ARITHABORT OFF 
GO
ALTER DATABASE [pruebademo] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [pruebademo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pruebademo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pruebademo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pruebademo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pruebademo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pruebademo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pruebademo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pruebademo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pruebademo] SET  ENABLE_BROKER 
GO
ALTER DATABASE [pruebademo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pruebademo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pruebademo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pruebademo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pruebademo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pruebademo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [pruebademo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pruebademo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [pruebademo] SET  MULTI_USER 
GO
ALTER DATABASE [pruebademo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pruebademo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pruebademo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pruebademo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [pruebademo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [pruebademo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [pruebademo] SET QUERY_STORE = ON
GO
ALTER DATABASE [pruebademo] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [pruebademo]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 4/7/2025 11:14:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Cliente] [varchar](255) NOT NULL,
	[Telefono] [varchar](255) NULL,
	[Correo] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 4/7/2025 11:14:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Precio] [float] NULL,
	[Categoria] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ventas]    Script Date: 4/7/2025 11:14:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDCliente] [int] NOT NULL,
	[Fecha] [datetime] NULL,
	[Total] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ventasitems]    Script Date: 4/7/2025 11:14:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventasitems](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDVenta] [int] NOT NULL,
	[IDProducto] [int] NOT NULL,
	[PrecioUnitario] [float] NULL,
	[Cantidad] [float] NULL,
	[PrecioTotal] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 

INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (1, N'Juan Pérez', N'1123456789', N'juanperez@gmail.com')
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (2, N'María García', N'1134567890', N'mariag@gmail.com')
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (3, N'Carlos Rodríguez', N'1145678901', N'carlosr@hotmail.com')
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (4, N'Ana López', N'1156789012', N'analopez@yahoo.com')
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (5, N'Pedro Fernández', N'1167890123', N'pfernandez@gmail.com')
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (6, N'Lucía Gómez', N'1178901234', N'lucia.gomez@gmail.com')
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (7, N'Martín Ruiz', N'1189012345', N'martinruiz@yahoo.com.ar')
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (8, N'Sofía Herrera', N'1190123456', N'sofia.herrera@outlook.com')
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (9, N'Diego Morales', N'1201234567', N'diegom@gmail.com')
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (10, N'Valentina Ríos', N'1212345678', N'valen.rios@hotmail.com')
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (11, N'Juan Pérez', N'1123456789', N'juan@example.com')
SET IDENTITY_INSERT [dbo].[clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[productos] ON 

INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (1, N'Notebook Lenovo 15.6"', 450000, N'Tecnología')
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (2, N'Mouse Logitech M170', 8500, N'Accesorios')
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (3, N'Teclado Redragon Kumara', 18999, N'Periféricos')
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (4, N'Monitor LG 24"', 125000, N'Pantallas')
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (5, N'Silla Gamer Cougar', 155000, N'Muebles')
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (6, N'Disco SSD 1TB Kingston', 69000, N'Almacenamiento')
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (7, N'Memoria RAM 16GB DDR4', 42000, N'Componentes')
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (8, N'Impresora HP Deskjet 2375', 53000, N'Oficina')
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (9, N'Auriculares JBL Tune 500', 17500, N'Audio')
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (10, N'Cámara Web Logitech C920', 74000, N'Accesorios')
SET IDENTITY_INSERT [dbo].[productos] OFF
GO
SET IDENTITY_INSERT [dbo].[ventas] ON 

INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (1, 1, CAST(N'2025-07-03T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (2, 1, CAST(N'2025-07-02T01:48:52.257' AS DateTime), 6250000)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (3, 4, CAST(N'2025-07-02T01:52:50.663' AS DateTime), 22500000)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (4, 1, CAST(N'2025-07-02T13:45:30.677' AS DateTime), 5400000)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (5, 1, CAST(N'2025-07-02T15:40:33.070' AS DateTime), 420000)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (6, 3, CAST(N'2025-07-02T20:10:39.957' AS DateTime), 2250000)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (7, 11, CAST(N'2025-07-02T20:11:23.517' AS DateTime), 1221992)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (8, 1, CAST(N'2025-07-03T14:35:22.570' AS DateTime), 601992)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (10, 1, CAST(N'2025-07-03T20:30:11.157' AS DateTime), 999.99)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (11, 1, CAST(N'2025-07-02T00:00:00.000' AS DateTime), 5000)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (12, 1, CAST(N'2025-07-03T17:15:02.477' AS DateTime), 14400000)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (14, 1, CAST(N'2025-07-03T17:18:31.973' AS DateTime), 0)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (15, 1, CAST(N'2025-07-03T17:22:16.707' AS DateTime), 0)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (16, 1, CAST(N'2025-07-03T17:22:51.363' AS DateTime), 24750000)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (17, 1, CAST(N'2025-07-03T17:35:48.637' AS DateTime), 0)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (18, 1, CAST(N'2025-07-03T17:42:40.170' AS DateTime), 0)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (19, 1, CAST(N'2025-07-03T17:43:52.913' AS DateTime), 0)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (20, 1, CAST(N'2025-07-03T17:44:19.623' AS DateTime), 0)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (21, 1, CAST(N'2025-07-03T19:33:17.993' AS DateTime), 0)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (23, 1, CAST(N'2025-07-03T19:39:36.277' AS DateTime), 2250000)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (24, 1, CAST(N'2025-07-03T19:40:09.367' AS DateTime), 0)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (25, 1, CAST(N'2025-07-03T19:43:30.337' AS DateTime), 0)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (26, 1, CAST(N'2025-07-03T19:48:10.487' AS DateTime), 0)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (28, 1, CAST(N'2025-07-03T00:00:00.000' AS DateTime), 500)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (29, 1, CAST(N'2025-07-03T19:56:17.790' AS DateTime), 22500000)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (30, 1, CAST(N'2025-07-03T19:57:33.200' AS DateTime), 36000000)
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (32, 1, CAST(N'2025-07-03T20:49:02.950' AS DateTime), 25500000)
SET IDENTITY_INSERT [dbo].[ventas] OFF
GO
SET IDENTITY_INSERT [dbo].[ventasitems] ON 

INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (1, 1, 1, 450000, 50, 22500000)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (2, 2, 4, 125000, 50, 6250000)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (3, 2, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (4, 3, 1, 450000, 50, 22500000)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (5, 3, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (6, 4, 1, 450000, 12, 5400000)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (7, 4, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (8, 5, 7, 42000, 10, 420000)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (9, 5, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (10, 6, 1, 450000, 5, 2250000)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (11, 6, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (12, 7, 4, 125000, 8, 1000000)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (13, 7, 3, 18999, 8, 151992)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (14, 7, 9, 17500, 4, 70000)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (15, 7, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (16, 8, 1, 450000, 1, 450000)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (17, 8, 3, 18999, 8, 151992)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (18, 8, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (20, 10, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (21, 11, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (22, 12, 1, 450000, 32, 14400000)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (23, 12, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (25, 14, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (26, 16, 1, 450000, 55, 24750000)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (27, 16, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (28, 17, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (29, 20, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (30, 21, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (32, 23, 1, 450000, 5, 2250000)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (33, 23, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (34, 24, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (35, 25, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (36, 26, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (38, 28, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (39, 29, 1, 450000, 50, 22500000)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (40, 29, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (41, 30, 1, 450000, 80, 36000000)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (42, 30, 0, 0, 0, 0)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (44, 32, 1, 450000, 40, 18000000)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (45, 32, 4, 125000, 60, 7500000)
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (46, 32, 0, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[ventasitems] OFF
GO
USE [master]
GO
ALTER DATABASE [pruebademo] SET  READ_WRITE 
GO
