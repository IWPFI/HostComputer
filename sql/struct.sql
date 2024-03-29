USE [host_computer]
GO
/****** Object:  Table [dbo].[devices]    Script Date: 2021/6/10 13:24:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[devices](
	[d_id] [varchar](50) NOT NULL,
	[d_name] [varchar](50) NULL,
	[d_sn] [varchar](50) NULL,
	[comm_type] [int] NULL,
 CONSTRAINT [PK_devices] PRIMARY KEY CLUSTERED 
(
	[d_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[monitor_values]    Script Date: 2021/6/10 13:24:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[monitor_values](
	[d_id] [varchar](50) NOT NULL,
	[v_id] [int] NOT NULL,
	[tag_name] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[data_type] [varchar](50) NULL,
	[unit] [varchar](50) NULL,
 CONSTRAINT [PK_monitor_values] PRIMARY KEY CLUSTERED 
(
	[d_id] ASC,
	[v_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[P_Modbus]    Script Date: 2021/6/10 13:24:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P_Modbus](
	[p_id] [varchar](50) NOT NULL,
	[d_id] [varchar](50) NOT NULL,
	[d_ip] [varchar](50) NULL,
	[d_port] [int] NULL,
	[baudrate] [int] NULL,
	[data_bit] [int] NULL,
	[stop] [int] NULL,
	[parity] [int] NULL,
	[slave_id] [nchar](10) NULL,
	[comm_mode] [int] NULL,
 CONSTRAINT [PK_P_Modbus] PRIMARY KEY CLUSTERED 
(
	[p_id] ASC,
	[d_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[P_S7]    Script Date: 2021/6/10 13:24:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[P_S7](
	[p_id] [varchar](50) NOT NULL,
	[d_id] [varchar](50) NOT NULL,
	[d_ip] [varchar](50) NULL,
	[d_port] [int] NULL,
	[d_rock] [int] NULL,
	[d_slot] [int] NULL,
 CONSTRAINT [PK_P_S7] PRIMARY KEY CLUSTERED 
(
	[p_id] ASC,
	[d_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 2021/6/10 13:24:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_id] [varchar](20) NOT NULL,
	[user_name] [varchar](20) NOT NULL,
	[real_name] [varchar](20) NOT NULL,
	[password] [varchar](40) NULL,
	[is_validation] [int] NOT NULL,
	[is_can_login] [int] NOT NULL,
	[is_teacher] [int] NOT NULL,
	[avatar] [varchar](200) NULL,
	[gender] [int] NULL
) ON [PRIMARY]
GO
