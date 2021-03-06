USE [master]
GO
/****** Object:  Database [NorthWindContacts]    Script Date: 6/6/2020 4:57:51 AM ******/
CREATE DATABASE [NorthWindContacts]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NorthWindContacts', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\NorthWindContacts.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NorthWindContacts_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\NorthWindContacts_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [NorthWindContacts] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NorthWindContacts].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NorthWindContacts] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NorthWindContacts] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NorthWindContacts] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NorthWindContacts] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NorthWindContacts] SET ARITHABORT OFF 
GO
ALTER DATABASE [NorthWindContacts] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NorthWindContacts] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NorthWindContacts] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NorthWindContacts] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NorthWindContacts] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NorthWindContacts] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NorthWindContacts] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NorthWindContacts] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NorthWindContacts] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NorthWindContacts] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NorthWindContacts] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NorthWindContacts] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NorthWindContacts] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NorthWindContacts] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NorthWindContacts] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NorthWindContacts] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NorthWindContacts] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NorthWindContacts] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NorthWindContacts] SET  MULTI_USER 
GO
ALTER DATABASE [NorthWindContacts] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NorthWindContacts] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NorthWindContacts] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NorthWindContacts] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NorthWindContacts] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NorthWindContacts] SET QUERY_STORE = OFF
GO
USE [NorthWindContacts]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 6/6/2020 4:57:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[ContactId] [int] NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactType]    Script Date: 6/6/2020 4:57:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactType](
	[ContactTypeIdentifier] [int] NOT NULL,
	[ContactTitle] [nvarchar](max) NULL,
 CONSTRAINT [PK_ContactType] PRIMARY KEY CLUSTERED 
(
	[ContactTypeIdentifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (1, N'Maria', N'Anders', 1)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (2, N'Ana', N'Trujillo', 1)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (3, N'Antonio', N'Moreno', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (4, N'Thomas', N'Hardy', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (5, N'Christina', N'Berglund', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (6, N'Hanna', N'Moos', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (7, N'Frédérique', N'Citeaux', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (8, N'Martín', N'Sommer', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (9, N'Laurence', N'Lebihan', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (10, N'Victoria', N'Ashworth', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (11, N'Patricio', N'Simpson', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (12, N'Francisco', N'Chang', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (13, N'Yang', N'Wang', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (14, N'Elizabeth', N'Brown', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (15, N'Sven', N'Ottlieb', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (16, N'Janine', N'Labrune', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (17, N'Ann', N'Devon', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (18, N'Roland', N'Mendel', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (19, N'Diego', N'Roel', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (20, N'Martine', N'Rancé', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (21, N'Maria', N'Larsson', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (22, N'Peter', N'Franken', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (23, N'Carine', N'Schmitt', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (24, N'Paolo', N'Accorti', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (25, N'Lino', N'Rodriguez', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (26, N'Eduardo', N'Saavedra', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (27, N'José', N'Pedro Freyre', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (28, N'Philip', N'Cramer', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (29, N'Daniel', N'Tonini', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (30, N'Annette', N'Roulet', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (31, N'Renate', N'Messner', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (32, N'Giovanni', N'Rovelli', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (33, N'Catherine', N'Dewey', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (34, N'Alexander', N'Feuer', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (35, N'Simon', N'Crowther', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (36, N'Yvonne', N'Moncada', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (37, N'Henriette', N'Pfalzheim', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (38, N'Marie', N'Bertrand', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (39, N'Guillermo', N'Fernández', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (40, N'Georg', N'Pipps', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (41, N'Isabel', N'de Castro', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (42, N'Horst', N'Kloss', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (43, N'Sergio', N'Gutiérrez', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (44, N'Maurizio', N'Moroni', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (45, N'Michael', N'Holz', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (46, N'Alejandra', N'Camino', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (47, N'Jonas', N'Bergulfsen', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (48, N'Hari', N'Kumar', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (49, N'Jytte', N'Petersen', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (50, N'Dominique', N'Perrier', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (51, N'Pascale', N'Cartrain', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (52, N'Karin', N'Josephs', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (53, N'Miguel', N'Angel Paolino', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (54, N'Palle', N'Ibsen', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (55, N'Mary', N'Saveley', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (56, N'Paul', N'Henriot', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (57, N'Rita', N'Müller', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (58, N'Pirkko', N'Koskitalo', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (59, N'Matti', N'Karttunen', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (60, N'Zbyszek', N'Piestrzeniewicz', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (61, N'Rene', N'Phillips', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (62, N'Elizabeth', N'Lincoln', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (63, N'Yoshi', N'Tannamuri', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (64, N'Jaime', N'Yorres', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (65, N'Patricia', N'McKenna', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (66, N'Manuel', N'Pereira', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (67, N'Jose', N'Pavarotti', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (68, N'Helen', N'Bennett', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (69, N'Carlos', N'González', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (70, N'Liu', N'Wong', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (71, N'Paula', N'Wilson', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (72, N'Felipe', N'Izquierdo', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (73, N'Howard', N'Snyder', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (74, N'Yoshi', N'Latimer', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (75, N'Fran', N'Wilson', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (76, N'Liz', N'Nixon', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (77, N'Jean', N'Fresnière', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (78, N'Mario', N'Pontes', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (79, N'Bernardo', N'Batista', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (80, N'Janete', N'Limeira', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (81, N'Pedro', N'Afonso', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (82, N'Aria', N'Cruz', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (83, N'André', N'Fonseca', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (84, N'Lúcia', N'Carvalho', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (85, N'Anabela', N'Domingues', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (86, N'Paula', N'Parente', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (87, N'Carlos', N'Hernández', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (88, N'John', N'Steel', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (89, N'Helvetius', N'Nagy', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (90, N'Karl', N'Jablonski', 0)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [IsDeleted]) VALUES (91, N'Art', N'Braunschweiger', 0)
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (1, N'Accounting Manager')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (2, N'Assistant Sales Agent')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (3, N'Assistant Sales Representative')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (4, N'Marketing Assistant')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (5, N'Marketing Manager')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (6, N'Order Administrator')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (7, N'Owner')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (8, N'Owner/Marketing Assistant')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (9, N'Sales Agent')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (10, N'Sales Associate')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (11, N'Sales Manager')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (12, N'Sales Representative')
USE [master]
GO
ALTER DATABASE [NorthWindContacts] SET  READ_WRITE 
GO
