USE [master]
GO
/****** Object:  Database [GSB_gesAMM]    Script Date: 08/01/2023 21:26:58 ******/
CREATE DATABASE [GSB_gesAMM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GSB_gesAMM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GSB_gesAMM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GSB_gesAMM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GSB_gesAMM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GSB_gesAMM] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GSB_gesAMM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ARITHABORT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GSB_gesAMM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GSB_gesAMM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GSB_gesAMM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GSB_gesAMM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GSB_gesAMM] SET  MULTI_USER 
GO
ALTER DATABASE [GSB_gesAMM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GSB_gesAMM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GSB_gesAMM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GSB_gesAMM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GSB_gesAMM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GSB_gesAMM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GSB_gesAMM] SET QUERY_STORE = OFF
GO
USE [GSB_gesAMM]
GO
/****** Object:  Table [dbo].[DECISION]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DECISION](
	[DCS_ID] [int] NOT NULL,
	[DCS_LIBELLE] [varchar](500) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DCS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ETAPE]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ETAPE](
	[ETP_NUM] [int] NOT NULL,
	[ETP_LIBELLE] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ETP_NUM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EtapeNormee]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EtapeNormee](
	[ETP_ID] [int] NOT NULL,
	[ETP_NORME] [char](50) NULL,
	[ETP_DATE_NORMEE] [date] NOT NULL,
 CONSTRAINT [PK5] PRIMARY KEY CLUSTERED 
(
	[ETP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FAMILLE]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FAMILLE](
	[FAM_CODE] [varchar](500) NOT NULL,
	[FAM_LIBELLE] [varchar](500) NOT NULL,
	[FAM_NB_MEDI_AMM] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FAM_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historiqueEtapeNormee]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historiqueEtapeNormee](
	[idHisto] [int] IDENTITY(1,1) NOT NULL,
	[idEtape] [int] NOT NULL,
	[idUser] [int] NOT NULL,
	[dateModif] [datetime] NOT NULL,
	[ancienneNorme] [varchar](50) NULL,
	[nouvelleNorme] [varchar](50) NULL,
	[ancienneDateNorme] [date] NULL,
	[nouvelleDateNorme] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idHisto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICAMENT]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICAMENT](
	[MED_DEPOTLEGAL] [varchar](500) NOT NULL,
	[MED_NOMCOMMERCIAL] [varchar](500) NOT NULL,
	[MED_COMPOSITION] [varchar](500) NOT NULL,
	[MED_EFFETS] [varchar](500) NOT NULL,
	[MED_CONTREINDIC] [varchar](500) NOT NULL,
	[MED_AMM] [varchar](500) NULL,
	[MED_FAM_CODE] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[MED_DEPOTLEGAL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[utilisateurs]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[utilisateurs](
	[idUser] [int] IDENTITY(1,1) NOT NULL,
	[identifiant] [varchar](50) NOT NULL,
	[mdp] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WORKFLOW]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WORKFLOW](
	[WRK_DATE_DECISION] [date] NULL,
	[WRK_DCS_ID] [int] NULL,
	[WRK_ETP_NUM] [int] NOT NULL,
	[WRK_MED_DEPOTLEGAL] [varchar](500) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[WRK_ETP_NUM] ASC,
	[WRK_MED_DEPOTLEGAL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EtapeNormee]  WITH CHECK ADD  CONSTRAINT [FK5] FOREIGN KEY([ETP_ID])
REFERENCES [dbo].[ETAPE] ([ETP_NUM])
GO
ALTER TABLE [dbo].[EtapeNormee] CHECK CONSTRAINT [FK5]
GO
ALTER TABLE [dbo].[MEDICAMENT]  WITH CHECK ADD  CONSTRAINT [FK_MEDICAMENT_FAMILLE] FOREIGN KEY([MED_FAM_CODE])
REFERENCES [dbo].[FAMILLE] ([FAM_CODE])
GO
ALTER TABLE [dbo].[MEDICAMENT] CHECK CONSTRAINT [FK_MEDICAMENT_FAMILLE]
GO
ALTER TABLE [dbo].[WORKFLOW]  WITH CHECK ADD  CONSTRAINT [FK_Table_1_] FOREIGN KEY([WRK_DCS_ID])
REFERENCES [dbo].[DECISION] ([DCS_ID])
GO
ALTER TABLE [dbo].[WORKFLOW] CHECK CONSTRAINT [FK_Table_1_]
GO
ALTER TABLE [dbo].[WORKFLOW]  WITH CHECK ADD  CONSTRAINT [FK_WORKFLOW_ETAPE] FOREIGN KEY([WRK_ETP_NUM])
REFERENCES [dbo].[ETAPE] ([ETP_NUM])
GO
ALTER TABLE [dbo].[WORKFLOW] CHECK CONSTRAINT [FK_WORKFLOW_ETAPE]
GO
ALTER TABLE [dbo].[WORKFLOW]  WITH CHECK ADD  CONSTRAINT [FK_WORKFLOW_MEDICAMENT] FOREIGN KEY([WRK_MED_DEPOTLEGAL])
REFERENCES [dbo].[MEDICAMENT] ([MED_DEPOTLEGAL])
GO
ALTER TABLE [dbo].[WORKFLOW] CHECK CONSTRAINT [FK_WORKFLOW_MEDICAMENT]
GO
/****** Object:  StoredProcedure [dbo].[getDecision]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getDecision]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DCS_ID, DCS_LIBELLE from DECISION
END
GO
/****** Object:  StoredProcedure [dbo].[getEtape]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getEtape]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ETP_NUM, ETP_LIBELLE  from ETAPE
END
GO
/****** Object:  StoredProcedure [dbo].[getFamille]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getFamille]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT FAM_CODE, FAM_LIBELLE, FAM_NB_MEDI_AMM from FAMILLE
END
GO
/****** Object:  StoredProcedure [dbo].[getMedicaments]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getMedicaments]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT MED_DEPOTLEGAL, MED_NOMCOMMERCIAL, MED_COMPOSITION, MED_EFFETS, MED_CONTREINDIC, MED_AMM, MED_FAM_CODE from MEDICAMENT
END
GO
/****** Object:  StoredProcedure [dbo].[getWorkflow]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getWorkflow] (@depotLegal as varchar(500))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT WRK_DATE_DECISION, WRK_DCS_ID, WRK_ETP_NUM, WRK_MED_DEPOTLEGAL from WORKFLOW
		WHERE @depotLegal = WRK_MED_DEPOTLEGAL

END
GO
/****** Object:  StoredProcedure [dbo].[prc_afficherEtapeNormee]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        <Author,,Name>
-- Create date: <Create Date,,>
-- Description:    <Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_afficherEtapeNormee]
    -- Add the parameters for the stored procedure here
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT ETP_NORME, ETP_LIBELLE, ETP_ID, ETP_DATE_NORMEE FROM EtapeNormee INNER JOIN Etape ON ETP_ID = ETP_NUM;
END
GO
/****** Object:  StoredProcedure [dbo].[prc_afficherHistorique]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        <Author,,Name>
-- Create date: <Create Date,,>
-- Description:    <Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_afficherHistorique]
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT ETP_LIBELLE, identifiant, dateModif, ancienneNorme, nouvelleNorme, ancienneDateNorme, nouvelleDateNorme 
    FROM historiqueEtapeNormee
    INNER JOIN ETAPE on idEtape = ETP_NUM
    INNER JOIN utilisateurs on utilisateurs.idUser = historiqueEtapeNormee.idUser 
END
GO
/****** Object:  StoredProcedure [dbo].[prc_afficherWorkflowEtapeMedicament]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_afficherWorkflowEtapeMedicament] (@depotLegal as varchar(500))
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT WRK_ETP_NUM, ETP_LIBELLE, WRK_DATE_DECISION, WRK_MED_DEPOTLEGAL, decision.DCS_ID, DCS_LIBELLE FROM Etape
	INNER JOIN WORKFLOW on etape.ETP_NUM = WORKFLOW.WRK_ETP_NUM
	INNER JOIN Decision on DECISION.DCS_ID = WRK_DCS_ID
	WHERE @depotLegal = WRK_MED_DEPOTLEGAL
    
END
GO
/****** Object:  StoredProcedure [dbo].[prc_afficherWorkflowEtapeNormeesMedicament]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_afficherWorkflowEtapeNormeesMedicament] (@depotLegal as varchar(500))
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT WRK_ETP_NUM, ETP_LIBELLE, WRK_DATE_DECISION, WRK_MED_DEPOTLEGAL, decision.DCS_ID, DCS_LIBELLE, ETP_NORME, ETP_DATE_NORMEE FROM Etape
	INNER JOIN WORKFLOW on etape.ETP_NUM = WORKFLOW.WRK_ETP_NUM
	INNER JOIN Decision on DECISION.DCS_ID = WRK_DCS_ID
	INNER JOIN EtapeNormee on Etape.ETP_NUM = EtapeNormee.ETP_ID
	WHERE @depotLegal = WRK_MED_DEPOTLEGAL
    
END
GO
/****** Object:  StoredProcedure [dbo].[prc_decisionEtape]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        <Author,,Name>
-- Create date: <Create Date,,>
-- Description:    <Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_decisionEtape] (@med varchar(500),@etpNum int, @dateDecision date, @Decision int)
AS
BEGIN
    SET NOCOUNT ON;

 

        INSERT INTO WORKFLOW(WRK_MED_DEPOTLEGAL, WRK_DATE_DECISION, WRK_ETP_NUM, WRK_DCS_ID)
        VALUES (@med, @dateDecision, @etpNum, @Decision )
        PRINT('étape enregistré')
    

 

END
GO
/****** Object:  StoredProcedure [dbo].[prc_insererMedicament]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_insererMedicament] (@DEPOTLEGAL varchar(20), @NOMCOMMERCIAL varchar(50), @FAMCODE varchar(10), @MEDCOMPOSITION text, @EFFETS text, @CONTREINDIC text)
AS
BEGIN
	SET NOCOUNT ON;

	IF @DEPOTLEGAL IN (SELECT MED_DEPOTLEGAL FROM Medicament)
	BEGIN 
		PRINT('Le dépot légal existe déjà')
		RETURN
	END
	ELSE
	BEGIN
		INSERT INTO Medicament(MED_DEPOTLEGAL, MED_NOMCOMMERCIAL, MED_FAM_CODE, MED_COMPOSITION, MED_EFFETS, MED_CONTREINDIC)
		VALUES (@DEPOTLEGAL, @NOMCOMMERCIAL, @FAMCODE, @MEDCOMPOSITION, @EFFETS, @CONTREINDIC)
		PRINT('Médicament enregistré')
	END

END
GO
/****** Object:  StoredProcedure [dbo].[prc_listeTousMedicaments]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_listeTousMedicaments] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT * FROM Medicament
END

GO
/****** Object:  StoredProcedure [dbo].[prc_listeTousMedicamentsEnCours]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_listeTousMedicamentsEnCours] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT MED_DEPOTLEGAL, MED_NOMCOMMERCIAL, Famille.FAM_CODE, MED_COMPOSITION, MED_EFFETS, MED_CONTREINDIC, MED_AMM, FAM_LIBELLE, FAM_NB_MEDI_AMM FROM MEDICAMENT
	INNER JOIN FAMILLE on MED_FAM_CODE = Famille.FAM_CODE
	WHERE MED_FAM_CODE = Famille.FAM_CODE 
    
END
GO
/****** Object:  StoredProcedure [dbo].[prc_ListeTousUtilisateurs]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_ListeTousUtilisateurs]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select id, identifiant, mdp
	from UTILISATEUR
	order by id asc
END
GO
/****** Object:  StoredProcedure [dbo].[prc_modifEtapeNormee]    Script Date: 08/01/2023 21:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        <Author,,Name>
-- Create date: <Create Date,,>
-- Description:    <Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_modifEtapeNormee] (@ID_ETAPE int, @ID_USER int, @NORME varchar(50), @NEW_DATE_NORME date, @DATE_NORME date, @NEW_NORME varchar(50))

AS
BEGIN

    SET NOCOUNT ON;

    INSERT INTO historiqueEtapeNormee (idEtape, idUser, dateModif, ancienneNorme, nouvelleNorme, ancienneDateNorme, nouvelleDateNorme)
    VALUES (@ID_ETAPE, @ID_USER, GETDATE(), @NORME, @NEW_NORME, @DATE_NORME, @NEW_DATE_NORME)

    BEGIN TRANSACTION

        UPDATE EtapeNormee
        SET ETP_DATE_NORMEE = @NEW_DATE_NORME
        WHERE ETP_ID = @ID_ETAPE
        IF (@@ERROR<>0 OR @@ROWCOUNT=0)
        BEGIN
            PRINT 'Echec màj de la date'
            ROLLBACK
            RETURN
        END

        UPDATE EtapeNormee
        SET ETP_NORME = @NEW_NORME
        WHERE ETP_ID = @ID_ETAPE
        IF (@@ERROR<>0 OR @@ROWCOUNT=0)
        BEGIN
            PRINT 'Echec màj de la norme'
            ROLLBACK
            RETURN
        END

    COMMIT
END
GO
USE [master]
GO
ALTER DATABASE [GSB_gesAMM] SET  READ_WRITE 
GO
