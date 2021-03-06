USE [Employees]
GO
/****** Object:  StoredProcedure [dbo].[usp_Staff_Update]    Script Date: 11/29/2020 1:14:44 PM ******/
DROP PROCEDURE [dbo].[usp_Staff_Update]
GO
/****** Object:  StoredProcedure [dbo].[usp_Staff_SelectList]    Script Date: 11/29/2020 1:14:44 PM ******/
DROP PROCEDURE [dbo].[usp_Staff_SelectList]
GO
/****** Object:  StoredProcedure [dbo].[usp_Staff_Select]    Script Date: 11/29/2020 1:14:44 PM ******/
DROP PROCEDURE [dbo].[usp_Staff_Select]
GO
/****** Object:  StoredProcedure [dbo].[usp_Staff_Insert]    Script Date: 11/29/2020 1:14:44 PM ******/
DROP PROCEDURE [dbo].[usp_Staff_Insert]
GO
/****** Object:  StoredProcedure [dbo].[usp_Staff_Delete]    Script Date: 11/29/2020 1:14:44 PM ******/
DROP PROCEDURE [dbo].[usp_Staff_Delete]
GO
/****** Object:  StoredProcedure [dbo].[grantUser]    Script Date: 11/29/2020 1:14:44 PM ******/
DROP PROCEDURE [dbo].[grantUser]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 11/29/2020 1:14:44 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Staff]') AND type in (N'U'))
DROP TABLE [dbo].[Staff]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 11/29/2020 1:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[MiddLeName] [varchar](50) NULL,
	[FirstName] [varchar](50) NOT NULL,
	[Gender] [char](1) NULL,
	[Position] [varchar](150) NULL,
	[HiredDate] [date] NOT NULL,
	[Salary] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([StaffID], [LastName], [MiddLeName], [FirstName], [Gender], [Position], [HiredDate], [Salary]) VALUES (1, N'Doe', N'D', N'John', N'M', N'App Developer', CAST(N'2015-01-01' AS Date), CAST(7000.00 AS Decimal(18, 2)))
INSERT [dbo].[Staff] ([StaffID], [LastName], [MiddLeName], [FirstName], [Gender], [Position], [HiredDate], [Salary]) VALUES (3, N'Doe', N'J', N'Jannet', N'F', N'Database Developer', CAST(N'2015-01-01' AS Date), CAST(6000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Staff] OFF
GO
/****** Object:  StoredProcedure [dbo].[grantUser]    Script Date: 11/29/2020 1:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[grantUser]
AS
	DECLARE curProcedure CURSOR FOR SELECT
		name
	FROM sysobjects
	WHERE type = 'P'
	ORDER BY name

	OPEN curProcedure
	DECLARE @procedurename VARCHAR(100)
	DECLARE @printline NVARCHAR(200)

	FETCH NEXT FROM curProcedure INTO @procedurename
	WHILE @@fetch_status = 0
	BEGIN
	SET @printline = 'GRANT EXEC ON ' + @procedurename + ' to EmployeeUser'
	EXEC SP_EXECUTESQL @printline
	PRINT @printline
	FETCH NEXT FROM curProcedure INTO @procedurename
	END

	CLOSE curProcedure
	DEALLOCATE curProcedure

GO
/****** Object:  StoredProcedure [dbo].[usp_Staff_Delete]    Script Date: 11/29/2020 1:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[usp_Staff_Delete]
(
	@StaffID  int
)

as

set nocount on

delete from [Staff]
where [StaffID] = @StaffID
GO
/****** Object:  StoredProcedure [dbo].[usp_Staff_Insert]    Script Date: 11/29/2020 1:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[usp_Staff_Insert]
(
	
	@LastName  varchar(50),
	@MiddLeName  varchar(50) = NULL,
	@FirstName  varchar(50),
	@Gender  char(1) = NULL,
	@Position  varchar(150) = NULL,
	@HiredDate  date,
	@Salary  decimal(18, 0) = NULL
)

as

set nocount on

insert into [Staff]
(
	
	[LastName],
	[MiddLeName],
	[FirstName],
	[Gender],
	[Position],
	[HiredDate],
	[Salary]
)
values
(
	
	@LastName,
	@MiddLeName,
	@FirstName,
	@Gender,
	@Position,
	@HiredDate,
	@Salary
)
GO
/****** Object:  StoredProcedure [dbo].[usp_Staff_Select]    Script Date: 11/29/2020 1:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[usp_Staff_Select]
(
	@StaffID  int
)

as

set nocount on

select [StaffID],
	[LastName],
	[MiddLeName],
	[FirstName],
	[Gender],
	[Position],
	[HiredDate],
	[Salary]
from [Staff]
where [StaffID] = @StaffID
GO
/****** Object:  StoredProcedure [dbo].[usp_Staff_SelectList]    Script Date: 11/29/2020 1:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[usp_Staff_SelectList]

as

set nocount on

select [StaffID],
	[LastName],
	[MiddLeName],
	[FirstName],
	[Gender],
	[Position],
	[HiredDate],
	[Salary]
from [Staff]

GO
/****** Object:  StoredProcedure [dbo].[usp_Staff_Update]    Script Date: 11/29/2020 1:14:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[usp_Staff_Update]
(
	@StaffID  int,
	@LastName  varchar(50),
	@MiddLeName  varchar(50) = NULL,
	@FirstName  varchar(50),
	@Gender  char(1) = NULL,
	@Position  varchar(150) = NULL,
	@HiredDate  date,
	@Salary  decimal(18, 0) = NULL
)

as

set nocount on

update [Staff]
set [LastName] = @LastName,
	[MiddLeName] = @MiddLeName,
	[FirstName] = @FirstName,
	[Gender] = @Gender,
	[Position] = @Position,
	[HiredDate] = @HiredDate,
	[Salary] = @Salary
where [StaffID] = @StaffID
GO
