USE [master]
GO
/****** Object:  Database [18043_DB]    Script Date: 8/22/2018 12:00:13 PM ******/
CREATE DATABASE [18043_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'18043_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.PISERVER\MSSQL\DATA\18043_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'18043_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.PISERVER\MSSQL\DATA\18043_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [18043_DB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [18043_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [18043_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [18043_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [18043_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [18043_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [18043_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [18043_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [18043_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [18043_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [18043_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [18043_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [18043_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [18043_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [18043_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [18043_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [18043_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [18043_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [18043_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [18043_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [18043_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [18043_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [18043_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [18043_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [18043_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [18043_DB] SET  MULTI_USER 
GO
ALTER DATABASE [18043_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [18043_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [18043_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [18043_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [18043_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [18043_DB] SET QUERY_STORE = OFF
GO
USE [18043_DB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [18043_DB]
GO
/****** Object:  User [18043_User]    Script Date: 8/22/2018 12:00:14 PM ******/
CREATE USER [18043_User] FOR LOGIN [18043_User] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [18043_User]
GO
ALTER ROLE [db_datareader] ADD MEMBER [18043_User]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [18043_User]
GO
/****** Object:  Table [dbo].[UlogaDijela]    Script Date: 8/22/2018 12:00:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UlogaDijela](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UlogaDijela] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dio]    Script Date: 8/22/2018 12:00:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dio](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [varchar](50) NOT NULL,
	[duljina] [float] NOT NULL,
	[sirina] [float] NOT NULL,
	[visina] [float] NOT NULL,
	[slika] [varchar](100) NULL,
	[materijal] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Dio] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proizvod]    Script Date: 8/22/2018 12:00:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proizvod](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[duljina] [float] NOT NULL,
	[sirina] [float] NOT NULL,
	[visina] [float] NOT NULL,
	[slika] [varchar](200) NULL,
	[naziv] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Proizvod] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Komponenta]    Script Date: 8/22/2018 12:00:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Komponenta](
	[kolicina] [int] NOT NULL,
	[boja] [varchar](30) NULL,
	[kantiranost] [varchar](30) NULL,
	[id_uloga] [int] NOT NULL,
	[id_dio] [int] NOT NULL,
	[id_proizvod] [int] NOT NULL,
 CONSTRAINT [PK_Komponenta] PRIMARY KEY CLUSTERED 
(
	[id_uloga] ASC,
	[id_dio] ASC,
	[id_proizvod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[PogledDjelovaPoProoizvodu]    Script Date: 8/22/2018 12:00:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PogledDjelovaPoProoizvodu]
AS
SELECT        d.ID AS DioID, ud.ID AS UlogaID, d.naziv, d.duljina, d.sirina AS Širina, d.visina, d.slika, d.materijal, ud.naziv AS Uloga, k.kolicina AS Količina, k.boja, k.kantiranost, k.id_proizvod AS Proizvod
FROM            dbo.Dio AS d INNER JOIN
                         dbo.Komponenta AS k ON d.ID = k.id_dio INNER JOIN
                         dbo.Proizvod AS p ON k.id_proizvod = p.ID INNER JOIN
                         dbo.UlogaDijela AS ud ON k.id_uloga = ud.ID
GO
/****** Object:  Table [dbo].[Dobavljac]    Script Date: 8/22/2018 12:00:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dobavljac](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ime] [varchar](50) NOT NULL,
	[adresa] [varchar](100) NOT NULL,
	[email] [varchar](50) NULL,
	[kontaktBroj] [varchar](50) NULL,
 CONSTRAINT [PK_Dobavljac] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Element]    Script Date: 8/22/2018 12:00:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Element](
	[kolicina] [int] NOT NULL,
	[id_proizvod] [int] NOT NULL,
	[id_element] [int] NOT NULL,
 CONSTRAINT [PK_Element] PRIMARY KEY CLUSTERED 
(
	[id_proizvod] ASC,
	[id_element] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnik]    Script Date: 8/22/2018 12:00:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnik](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ime] [varchar](50) NOT NULL,
	[prezime] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[adresa] [varchar](50) NOT NULL,
	[korisnickoIme] [varchar](50) NOT NULL,
	[lozinka] [varchar](64) NOT NULL,
	[kontaktBroj] [varchar](50) NULL,
	[id_uloga] [int] NOT NULL,
 CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [Unique_Korisnik] UNIQUE NONCLUSTERED 
(
	[korisnickoIme] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Narudzba]    Script Date: 8/22/2018 12:00:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Narudzba](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[datum] [date] NOT NULL,
	[id_dobavljac] [int] NOT NULL,
	[id_korisnik] [int] NOT NULL,
 CONSTRAINT [PK_Narudzba] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StavkaNarudzbe]    Script Date: 8/22/2018 12:00:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StavkaNarudzbe](
	[kolicina] [int] NOT NULL,
	[id_dio] [int] NOT NULL,
	[id_narudzba] [int] NOT NULL,
 CONSTRAINT [PK_StavkaNarudzbe] PRIMARY KEY CLUSTERED 
(
	[id_dio] ASC,
	[id_narudzba] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UIElementi]    Script Date: 8/22/2018 12:00:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UIElementi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [varchar](50) NOT NULL,
	[roditelj] [int] NULL,
 CONSTRAINT [PK_UIElementi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UlogaKorisnika]    Script Date: 8/22/2018 12:00:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UlogaKorisnika](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [varchar](50) NOT NULL,
	[opis] [text] NULL,
 CONSTRAINT [PK_UlogaKorisnika] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VidiElement]    Script Date: 8/22/2018 12:00:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VidiElement](
	[id_uiElement] [int] NOT NULL,
	[id_uloga] [int] NOT NULL,
 CONSTRAINT [PK_VidiElement] PRIMARY KEY CLUSTERED 
(
	[id_uiElement] ASC,
	[id_uloga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Element]  WITH CHECK ADD  CONSTRAINT [FK_Element_Proizvod] FOREIGN KEY([id_proizvod])
REFERENCES [dbo].[Proizvod] ([ID])
GO
ALTER TABLE [dbo].[Element] CHECK CONSTRAINT [FK_Element_Proizvod]
GO
ALTER TABLE [dbo].[Element]  WITH CHECK ADD  CONSTRAINT [FK_Element_Proizvod1] FOREIGN KEY([id_element])
REFERENCES [dbo].[Proizvod] ([ID])
GO
ALTER TABLE [dbo].[Element] CHECK CONSTRAINT [FK_Element_Proizvod1]
GO
ALTER TABLE [dbo].[Komponenta]  WITH CHECK ADD  CONSTRAINT [FK_Komponenta_Dio] FOREIGN KEY([id_dio])
REFERENCES [dbo].[Dio] ([ID])
GO
ALTER TABLE [dbo].[Komponenta] CHECK CONSTRAINT [FK_Komponenta_Dio]
GO
ALTER TABLE [dbo].[Komponenta]  WITH CHECK ADD  CONSTRAINT [FK_Komponenta_Proizvod] FOREIGN KEY([id_proizvod])
REFERENCES [dbo].[Proizvod] ([ID])
GO
ALTER TABLE [dbo].[Komponenta] CHECK CONSTRAINT [FK_Komponenta_Proizvod]
GO
ALTER TABLE [dbo].[Komponenta]  WITH CHECK ADD  CONSTRAINT [FK_Komponenta_UlogaDijela] FOREIGN KEY([id_uloga])
REFERENCES [dbo].[UlogaDijela] ([ID])
GO
ALTER TABLE [dbo].[Komponenta] CHECK CONSTRAINT [FK_Komponenta_UlogaDijela]
GO
ALTER TABLE [dbo].[Korisnik]  WITH CHECK ADD  CONSTRAINT [FK_Korisnik_UlogaKorisnika] FOREIGN KEY([id_uloga])
REFERENCES [dbo].[UlogaKorisnika] ([ID])
GO
ALTER TABLE [dbo].[Korisnik] CHECK CONSTRAINT [FK_Korisnik_UlogaKorisnika]
GO
ALTER TABLE [dbo].[Narudzba]  WITH CHECK ADD  CONSTRAINT [FK_Narudzba_Dobavljac] FOREIGN KEY([id_dobavljac])
REFERENCES [dbo].[Dobavljac] ([ID])
GO
ALTER TABLE [dbo].[Narudzba] CHECK CONSTRAINT [FK_Narudzba_Dobavljac]
GO
ALTER TABLE [dbo].[Narudzba]  WITH CHECK ADD  CONSTRAINT [FK_Narudzba_Korisnik] FOREIGN KEY([id_korisnik])
REFERENCES [dbo].[Korisnik] ([ID])
GO
ALTER TABLE [dbo].[Narudzba] CHECK CONSTRAINT [FK_Narudzba_Korisnik]
GO
ALTER TABLE [dbo].[StavkaNarudzbe]  WITH CHECK ADD  CONSTRAINT [FK_StavkaNarudzbe_Dio] FOREIGN KEY([id_dio])
REFERENCES [dbo].[Dio] ([ID])
GO
ALTER TABLE [dbo].[StavkaNarudzbe] CHECK CONSTRAINT [FK_StavkaNarudzbe_Dio]
GO
ALTER TABLE [dbo].[StavkaNarudzbe]  WITH CHECK ADD  CONSTRAINT [FK_StavkaNarudzbe_Narudzba] FOREIGN KEY([id_narudzba])
REFERENCES [dbo].[Narudzba] ([ID])
GO
ALTER TABLE [dbo].[StavkaNarudzbe] CHECK CONSTRAINT [FK_StavkaNarudzbe_Narudzba]
GO
ALTER TABLE [dbo].[UIElementi]  WITH CHECK ADD  CONSTRAINT [FK_UIElementi_UIElementi] FOREIGN KEY([roditelj])
REFERENCES [dbo].[UIElementi] ([ID])
GO
ALTER TABLE [dbo].[UIElementi] CHECK CONSTRAINT [FK_UIElementi_UIElementi]
GO
ALTER TABLE [dbo].[VidiElement]  WITH CHECK ADD  CONSTRAINT [FK_VidiElement_UIElementi] FOREIGN KEY([id_uiElement])
REFERENCES [dbo].[UIElementi] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VidiElement] CHECK CONSTRAINT [FK_VidiElement_UIElementi]
GO
ALTER TABLE [dbo].[VidiElement]  WITH CHECK ADD  CONSTRAINT [FK_VidiElement_UlogaKorisnika] FOREIGN KEY([id_uloga])
REFERENCES [dbo].[UlogaKorisnika] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VidiElement] CHECK CONSTRAINT [FK_VidiElement_UlogaKorisnika]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "d"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "k"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "p"
            Begin Extent = 
               Top = 0
               Left = 559
               Bottom = 130
               Right = 729
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ud"
            Begin Extent = 
               Top = 152
               Left = 617
               Bottom = 248
               Right = 787
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 14
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PogledDjelovaPoProoizvodu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'    Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PogledDjelovaPoProoizvodu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'PogledDjelovaPoProoizvodu'
GO
USE [master]
GO
ALTER DATABASE [18043_DB] SET  READ_WRITE 
GO
