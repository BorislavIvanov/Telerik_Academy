USE [master]
GO
/****** Object:  Database [Continents_DB]    Script Date: 22/8/2014 21:54:54 ******/
CREATE DATABASE [Continents_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Continents_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Continents_DB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Continents_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Continents_DB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Continents_DB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Continents_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Continents_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Continents_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Continents_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Continents_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Continents_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Continents_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Continents_DB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Continents_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Continents_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Continents_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Continents_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Continents_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Continents_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Continents_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Continents_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Continents_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Continents_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Continents_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Continents_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Continents_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Continents_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Continents_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Continents_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Continents_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [Continents_DB] SET  MULTI_USER 
GO
ALTER DATABASE [Continents_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Continents_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Continents_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Continents_DB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Continents_DB', N'ON'
GO
USE [Continents_DB]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 22/8/2014 21:54:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[AddressID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[AddressText] [ntext] NOT NULL,
	[TownID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continents]    Script Date: 22/8/2014 21:54:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[ContinentID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[ContinentName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[ContinentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countrys]    Script Date: 22/8/2014 21:54:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countrys](
	[CountryID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[CountryName] [nvarchar](50) NOT NULL,
	[ContinentID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Countrys] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 22/8/2014 21:54:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PersonID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AddressID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Towns]    Script Date: 22/8/2014 21:54:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[TownID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[TownName] [nvarchar](50) NOT NULL,
	[CountryID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[TownID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Addresses] ([AddressID], [AddressText], [TownID]) VALUES (N'e06e070d-c162-48ce-8f92-b14b490ed54d', N'abcdef abcdef abcdef abcdef abcdef ', N'68513491-f4ae-4181-8f43-92665e2d5595')
INSERT [dbo].[Continents] ([ContinentID], [ContinentName]) VALUES (N'2b607484-5328-4c72-8b8a-bde377b09022', N'Europe')
INSERT [dbo].[Countrys] ([CountryID], [CountryName], [ContinentID]) VALUES (N'0931661a-89fb-4eed-80d9-f1e74d49531b', N'Spain', N'2b607484-5328-4c72-8b8a-bde377b09022')
INSERT [dbo].[Person] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (N'174acdc8-466d-4964-89d2-1ece1b4e25dc', N'Kiril', N'Metodiev', N'e06e070d-c162-48ce-8f92-b14b490ed54d')
INSERT [dbo].[Towns] ([TownID], [TownName], [CountryID]) VALUES (N'68513491-f4ae-4181-8f43-92665e2d5595', N'Santander', N'0931661a-89fb-4eed-80d9-f1e74d49531b')
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_Continent_ContinentName]    Script Date: 22/8/2014 21:54:54 ******/
ALTER TABLE [dbo].[Continents] ADD  CONSTRAINT [UK_Continent_ContinentName] UNIQUE NONCLUSTERED 
(
	[ContinentName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UK_Country_CountryName]    Script Date: 22/8/2014 21:54:54 ******/
ALTER TABLE [dbo].[Countrys] ADD  CONSTRAINT [UK_Country_CountryName] UNIQUE NONCLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UK_Towns_TownName]    Script Date: 22/8/2014 21:54:54 ******/
ALTER TABLE [dbo].[Towns] ADD  CONSTRAINT [UK_Towns_TownName] UNIQUE NONCLUSTERED 
(
	[TownID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Addresses] ADD  CONSTRAINT [DF_Addresses_AddressID]  DEFAULT (newid()) FOR [AddressID]
GO
ALTER TABLE [dbo].[Continents] ADD  CONSTRAINT [DF_Continents_ContinentID]  DEFAULT (newid()) FOR [ContinentID]
GO
ALTER TABLE [dbo].[Countrys] ADD  CONSTRAINT [DF_Countrys_CountryID]  DEFAULT (newid()) FOR [CountryID]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_PersonID]  DEFAULT (newid()) FOR [PersonID]
GO
ALTER TABLE [dbo].[Towns] ADD  CONSTRAINT [DF_Towns_TownID]  DEFAULT (newid()) FOR [TownID]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Towns] FOREIGN KEY([TownID])
REFERENCES [dbo].[Towns] ([TownID])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Towns]
GO
ALTER TABLE [dbo].[Countrys]  WITH CHECK ADD  CONSTRAINT [FK_Countrys_Continents] FOREIGN KEY([ContinentID])
REFERENCES [dbo].[Continents] ([ContinentID])
GO
ALTER TABLE [dbo].[Countrys] CHECK CONSTRAINT [FK_Countrys_Continents]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Addresses] FOREIGN KEY([AddressID])
REFERENCES [dbo].[Addresses] ([AddressID])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Addresses]
GO
ALTER TABLE [dbo].[Towns]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Countrys] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Countrys] ([CountryID])
GO
ALTER TABLE [dbo].[Towns] CHECK CONSTRAINT [FK_Towns_Countrys]
GO
USE [master]
GO
ALTER DATABASE [Continents_DB] SET  READ_WRITE 
GO
