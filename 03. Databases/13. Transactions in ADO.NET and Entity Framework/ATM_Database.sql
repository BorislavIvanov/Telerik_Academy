USE [ATM]
GO
/****** Object:  Table [dbo].[CardAccounts]    Script Date: 3/9/2014 23:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CardAccounts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CardNumber] [char](10) NOT NULL,
	[CardPIN] [char](4) NOT NULL,
	[CardCash] [money] NOT NULL,
 CONSTRAINT [PK_CardAccounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TransactionsHistory]    Script Date: 3/9/2014 23:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TransactionsHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CardNumber] [char](10) NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[Ammount] [money] NOT NULL,
 CONSTRAINT [PK_TransactionsHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CardAccounts] ON 

INSERT [dbo].[CardAccounts] ([Id], [CardNumber], [CardPIN], [CardCash]) VALUES (1, N'4758698412', N'4589', 10200.0000)
INSERT [dbo].[CardAccounts] ([Id], [CardNumber], [CardPIN], [CardCash]) VALUES (2, N'2347914865', N'9871', 500.0000)
INSERT [dbo].[CardAccounts] ([Id], [CardNumber], [CardPIN], [CardCash]) VALUES (3, N'3547895145', N'7416', 4850.0000)
SET IDENTITY_INSERT [dbo].[CardAccounts] OFF
/****** Object:  Index [UK_CardAccounts_CardNumber]    Script Date: 3/9/2014 23:01:19 ******/
ALTER TABLE [dbo].[CardAccounts] ADD  CONSTRAINT [UK_CardAccounts_CardNumber] UNIQUE NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
