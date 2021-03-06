USE [db_applicant]
GO
/****** Object:  Table [dbo].[tbl_applicant]    Script Date: 03/07/2020 17:40:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_applicant](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[mobile_phone_number] [varchar](15) NOT NULL,
	[alternative_phone_number] [varchar](15) NULL,
	[email] [varchar](40) NOT NULL,
	[place_of_birth] [varchar](30) NOT NULL,
	[date_of_birth] [datetime] NOT NULL,
	[last_education] [varchar](10) NOT NULL,
	[college] [varchar](50) NOT NULL,
	[major] [varchar](40) NOT NULL,
	[position_apply] [varchar](40) NOT NULL,
	[source] [varchar](20) NOT NULL,
	[event] [varchar](50) NULL,
	[carrer_center] [varchar](50) NULL,
	[referrer_name] [varchar](50) NULL,
	[referrer_phone] [varchar](15) NULL,
	[referrer_email] [varchar](40) NULL,
	[is_active] [bit] NOT NULL,
 CONSTRAINT [PK_tbl_applicant] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_education]    Script Date: 03/07/2020 17:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_education](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[last_education] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tbl_education] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_source_information]    Script Date: 03/07/2020 17:40:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_source_information](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[source] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tbl_source_information] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_education] ON 

INSERT [dbo].[tbl_education] ([id], [last_education]) VALUES (1, N'SMU/SMK')
INSERT [dbo].[tbl_education] ([id], [last_education]) VALUES (2, N'D3')
INSERT [dbo].[tbl_education] ([id], [last_education]) VALUES (3, N'S1/D4')
INSERT [dbo].[tbl_education] ([id], [last_education]) VALUES (4, N'S2/S3')
SET IDENTITY_INSERT [dbo].[tbl_education] OFF
SET IDENTITY_INSERT [dbo].[tbl_source_information] ON 

INSERT [dbo].[tbl_source_information] ([id], [source]) VALUES (1, N'Event')
INSERT [dbo].[tbl_source_information] ([id], [source]) VALUES (2, N'Career Center')
INSERT [dbo].[tbl_source_information] ([id], [source]) VALUES (3, N'Referral Program')
SET IDENTITY_INSERT [dbo].[tbl_source_information] OFF
