USE [master]
GO
/****** Object:  Database [University_DB]    Script Date: 22/8/2014 22:59:05 ******/
CREATE DATABASE [University_DB]
GO
ALTER DATABASE [University_DB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [University_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [University_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [University_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [University_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [University_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [University_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [University_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [University_DB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [University_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [University_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [University_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [University_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [University_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [University_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [University_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [University_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [University_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [University_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [University_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [University_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [University_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [University_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [University_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [University_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [University_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [University_DB] SET  MULTI_USER 
GO
ALTER DATABASE [University_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [University_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [University_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [University_DB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'University_DB', N'ON'
GO
USE [University_DB]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 22/8/2014 22:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourceID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[CourceName] [nvarchar](50) NOT NULL,
	[DepartmentID] [uniqueidentifier] NOT NULL,
	[ProfessorID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CourceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departments]    Script Date: 22/8/2014 22:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[DepartmentID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[DepartmentName] [nvarchar](50) NOT NULL,
	[FacultieID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 22/8/2014 22:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[FacultieID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[FacultieName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[FacultieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professor_Titles]    Script Date: 22/8/2014 22:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor_Titles](
	[ProfesorID] [uniqueidentifier] NOT NULL,
	[TitleID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Professor_Titles] PRIMARY KEY CLUSTERED 
(
	[ProfesorID] ASC,
	[TitleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professors]    Script Date: 22/8/2014 22:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professors](
	[ProfessorID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[ProfessorName] [nvarchar](50) NOT NULL,
	[DepartmentID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Professors] PRIMARY KEY CLUSTERED 
(
	[ProfessorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student_Cources]    Script Date: 22/8/2014 22:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Cources](
	[CourceID] [uniqueidentifier] NOT NULL,
	[StudentID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Student_Cources] PRIMARY KEY CLUSTERED 
(
	[CourceID] ASC,
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 22/8/2014 22:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[FacultieID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Titles]    Script Date: 22/8/2014 22:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Titles](
	[TitleID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[TitleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[TitleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Index [UK_Departments_DepartmentName]    Script Date: 22/8/2014 22:59:05 ******/
ALTER TABLE [dbo].[Departments] ADD  CONSTRAINT [UK_Departments_DepartmentName] UNIQUE NONCLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UK_Faculties_FacultieName]    Script Date: 22/8/2014 22:59:05 ******/
ALTER TABLE [dbo].[Faculties] ADD  CONSTRAINT [UK_Faculties_FacultieName] UNIQUE NONCLUSTERED 
(
	[FacultieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Courses] ADD  CONSTRAINT [DF_Courses_CourceID]  DEFAULT (newid()) FOR [CourceID]
GO
ALTER TABLE [dbo].[Departments] ADD  CONSTRAINT [DF_Departments_DepartmentID]  DEFAULT (newid()) FOR [DepartmentID]
GO
ALTER TABLE [dbo].[Faculties] ADD  CONSTRAINT [DF_Faculties_FacultieID]  DEFAULT (newid()) FOR [FacultieID]
GO
ALTER TABLE [dbo].[Professors] ADD  CONSTRAINT [DF_Professors_ProfesorID]  DEFAULT (newid()) FOR [ProfessorID]
GO
ALTER TABLE [dbo].[Students] ADD  CONSTRAINT [DF_Students_StudentID]  DEFAULT (newid()) FOR [StudentID]
GO
ALTER TABLE [dbo].[Titles] ADD  CONSTRAINT [DF_Titles_TitleID]  DEFAULT (newid()) FOR [TitleID]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Departments] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Departments] ([DepartmentID])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Departments]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Professors] FOREIGN KEY([ProfessorID])
REFERENCES [dbo].[Professors] ([ProfessorID])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Professors]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Faculties] FOREIGN KEY([FacultieID])
REFERENCES [dbo].[Faculties] ([FacultieID])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Faculties]
GO
ALTER TABLE [dbo].[Professor_Titles]  WITH CHECK ADD  CONSTRAINT [FK_Professor_Titles_Professors] FOREIGN KEY([ProfesorID])
REFERENCES [dbo].[Professors] ([ProfessorID])
GO
ALTER TABLE [dbo].[Professor_Titles] CHECK CONSTRAINT [FK_Professor_Titles_Professors]
GO
ALTER TABLE [dbo].[Professor_Titles]  WITH CHECK ADD  CONSTRAINT [FK_Professor_Titles_Titles] FOREIGN KEY([TitleID])
REFERENCES [dbo].[Titles] ([TitleID])
GO
ALTER TABLE [dbo].[Professor_Titles] CHECK CONSTRAINT [FK_Professor_Titles_Titles]
GO
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD  CONSTRAINT [FK_Professors_Departments] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Departments] ([DepartmentID])
GO
ALTER TABLE [dbo].[Professors] CHECK CONSTRAINT [FK_Professors_Departments]
GO
ALTER TABLE [dbo].[Student_Cources]  WITH CHECK ADD  CONSTRAINT [FK_Student_Cources_Courses] FOREIGN KEY([CourceID])
REFERENCES [dbo].[Courses] ([CourceID])
GO
ALTER TABLE [dbo].[Student_Cources] CHECK CONSTRAINT [FK_Student_Cources_Courses]
GO
ALTER TABLE [dbo].[Student_Cources]  WITH CHECK ADD  CONSTRAINT [FK_Student_Cources_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([StudentID])
GO
ALTER TABLE [dbo].[Student_Cources] CHECK CONSTRAINT [FK_Student_Cources_Students]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Faculties] FOREIGN KEY([FacultieID])
REFERENCES [dbo].[Faculties] ([FacultieID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Faculties]
GO
USE [master]
GO
ALTER DATABASE [University_DB] SET  READ_WRITE 
GO
