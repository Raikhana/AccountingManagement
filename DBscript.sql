USE [Staging1]
GO
/****** Object:  Table [dbo].[clients]    Script Date: 2019-06-08 3:36:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clients](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](50) NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[address] [varchar](50) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[country] [varchar](50) NOT NULL,
	[postal_code] [varchar](50) NOT NULL,
	[company] [varchar](50) NOT NULL,
	[phone] [varchar](50) NULL,
	[payment] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[created] [datetime] NULL,
	[updated] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 2019-06-08 3:36:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date] [datetime] NULL,
	[subtotal] [varchar](50) NOT NULL,
	[tax] [varchar](50) NOT NULL,
	[total] [varchar](50) NOT NULL,
	[status_order_id] [varchar](50) NOT NULL,
	[client_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders_products]    Script Date: 2019-06-08 3:36:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders_products](
	[order_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[amount] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders_status]    Script Date: 2019-06-08 3:36:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders_status](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product_status]    Script Date: 2019-06-08 3:36:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_status](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[status] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 2019-06-08 3:36:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](50) NOT NULL,
	[cost] [varchar](50) NOT NULL,
	[created] [datetime] NULL,
	[updated] [datetime] NULL,
	[status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 2019-06-08 3:36:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](50) NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[phone] [varchar](50) NULL,
	[password] [varchar](250) NULL,
	[role] [varchar](50) NOT NULL,
	[approved] [int] NOT NULL,
	[created] [datetime] NULL,
	[updated] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
