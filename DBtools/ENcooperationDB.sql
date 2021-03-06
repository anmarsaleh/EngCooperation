use ENcooperationDB
/****** Object:  ForeignKey [FK_Acounting_EngCV]    Script Date: 03/01/2011 20:13:12 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Acounting_EngCV]') AND parent_object_id = OBJECT_ID(N'[dbo].[Acounting]'))
ALTER TABLE [dbo].[Acounting] DROP CONSTRAINT [FK_Acounting_EngCV]
GO
/****** Object:  ForeignKey [FK_DetailsAcounting_Acounting]    Script Date: 03/01/2011 20:13:13 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DetailsAcounting_Acounting]') AND parent_object_id = OBJECT_ID(N'[dbo].[DetailsAcounting]'))
ALTER TABLE [dbo].[DetailsAcounting] DROP CONSTRAINT [FK_DetailsAcounting_Acounting]
GO
/****** Object:  ForeignKey [FK_DetailsAcounting_Classes]    Script Date: 03/01/2011 20:13:13 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DetailsAcounting_Classes]') AND parent_object_id = OBJECT_ID(N'[dbo].[DetailsAcounting]'))
ALTER TABLE [dbo].[DetailsAcounting] DROP CONSTRAINT [FK_DetailsAcounting_Classes]
GO
/****** Object:  Check [CK_Classes_1]    Script Date: 03/01/2011 20:13:13 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_Classes_1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Classes]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_Classes_1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Classes]'))
ALTER TABLE [dbo].[Classes] DROP CONSTRAINT [CK_Classes_1]

END
GO
/****** Object:  Table [dbo].[DetailsAcounting]    Script Date: 03/01/2011 20:13:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DetailsAcounting]') AND type in (N'U'))
DROP TABLE [dbo].[DetailsAcounting]
GO
/****** Object:  Table [dbo].[Acounting]    Script Date: 03/01/2011 20:13:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Acounting]') AND type in (N'U'))
DROP TABLE [dbo].[Acounting]
GO
/****** Object:  Table [dbo].[AppSettings]    Script Date: 03/01/2011 20:13:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AppSettings]') AND type in (N'U'))
DROP TABLE [dbo].[AppSettings]
GO
/****** Object:  Table [dbo].[Batchs]    Script Date: 03/01/2011 20:13:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Batchs]') AND type in (N'U'))
DROP TABLE [dbo].[Batchs]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 03/01/2011 20:13:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Classes]') AND type in (N'U'))
DROP TABLE [dbo].[Classes]
GO
/****** Object:  Table [dbo].[CVs]    Script Date: 03/01/2011 20:13:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CVs]') AND type in (N'U'))
DROP TABLE [dbo].[CVs]
GO
/****** Object:  Table [dbo].[EngCV]    Script Date: 03/01/2011 20:13:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EngCV]') AND type in (N'U'))
DROP TABLE [dbo].[EngCV]
GO
/****** Object:  StoredProcedure [dbo].[GenerateScript]    Script Date: 03/01/2011 20:13:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GenerateScript]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GenerateScript]
GO
/****** Object:  Table [dbo].[OldCVs]    Script Date: 03/01/2011 20:13:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OldCVs]') AND type in (N'U'))
DROP TABLE [dbo].[OldCVs]
GO
/****** Object:  Table [dbo].[UsersInfo]    Script Date: 03/01/2011 20:13:13 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UsersInfo]') AND type in (N'U'))
DROP TABLE [dbo].[UsersInfo]
GO
/****** Object:  Default [DF_Acounting_AcountStatus]    Script Date: 03/01/2011 20:13:12 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Acounting_AcountStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[Acounting]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Acounting_AcountStatus]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Acounting] DROP CONSTRAINT [DF_Acounting_AcountStatus]
END


End
GO
/****** Object:  Default [DF_Acounting_Total]    Script Date: 03/01/2011 20:13:12 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Acounting_Total]') AND parent_object_id = OBJECT_ID(N'[dbo].[Acounting]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Acounting_Total]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Acounting] DROP CONSTRAINT [DF_Acounting_Total]
END


End
GO
/****** Object:  Default [DF_Acounting_TotalBay]    Script Date: 03/01/2011 20:13:12 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Acounting_TotalBay]') AND parent_object_id = OBJECT_ID(N'[dbo].[Acounting]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Acounting_TotalBay]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Acounting] DROP CONSTRAINT [DF_Acounting_TotalBay]
END


End
GO
/****** Object:  Default [DF_Acounting_TotalRest]    Script Date: 03/01/2011 20:13:12 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Acounting_TotalRest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Acounting]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Acounting_TotalRest]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Acounting] DROP CONSTRAINT [DF_Acounting_TotalRest]
END


End
GO
/****** Object:  Default [DF_Acounting_IsCancel]    Script Date: 03/01/2011 20:13:12 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Acounting_IsCancel]') AND parent_object_id = OBJECT_ID(N'[dbo].[Acounting]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Acounting_IsCancel]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Acounting] DROP CONSTRAINT [DF_Acounting_IsCancel]
END


End
GO
/****** Object:  Default [DF_Batchs_Payed]    Script Date: 03/01/2011 20:13:13 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Batchs_Payed]') AND parent_object_id = OBJECT_ID(N'[dbo].[Batchs]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Batchs_Payed]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Batchs] DROP CONSTRAINT [DF_Batchs_Payed]
END


End
GO
/****** Object:  Default [DF_EngCV_DateOFjointly]    Script Date: 03/01/2011 20:13:13 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_EngCV_DateOFjointly]') AND parent_object_id = OBJECT_ID(N'[dbo].[EngCV]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_EngCV_DateOFjointly]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EngCV] DROP CONSTRAINT [DF_EngCV_DateOFjointly]
END


End
GO
/****** Object:  Default [DF_EngCV_CVModified]    Script Date: 03/01/2011 20:13:13 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_EngCV_CVModified]') AND parent_object_id = OBJECT_ID(N'[dbo].[EngCV]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_EngCV_CVModified]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EngCV] DROP CONSTRAINT [DF_EngCV_CVModified]
END


End
GO
/****** Object:  Table [dbo].[UsersInfo]    Script Date: 03/01/2011 20:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UsersInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UsersInfo](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[AllowCV] [bit] NULL,
	[AllowAcount] [bit] NULL,
	[AllowBox] [bit] NULL,
	[UserName] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[UserPW] [nvarchar](25) COLLATE Arabic_CI_AS NULL,
	[IsAdmin] [bit] NULL,
 CONSTRAINT [PK_UsersInfo] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[OldCVs]    Script Date: 03/01/2011 20:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OldCVs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[OldCVs](
	[الرقم] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
	[الرقم الفرعي] [int] NULL,
	[الرقم التقاعدي] [int] NULL,
	[الاسم] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[الكنية] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[اسم الأب] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[اسم الأم] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[مكان الولادة] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[تاريخ الولادة] [int] NULL,
	[الجنسية] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[الخانة ورقمها] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[الجنس] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[القسم] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[الاختصاص] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[سنة التخرج] [int] NULL,
	[اسم الجامعة] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[مقر الجامعة] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[الشطب] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
	[العمل] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[تاريخ الانتساب] [datetime] NULL,
	[رقم قرار الانتساب] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[تاريخ النقل] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[قرار وتاريخ اعادة التسجيل] [datetime] NULL,
	[العنوان] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[الذمة المالية] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
	[سنوات التأخير] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
	[ملاحظات مالية] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
	[العمل الفرعي] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
	[الهاتف] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[ملاحظات] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[قرار المجلس] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[عام التكريم] [datetime] NULL,
	[الهوية] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[الوضع] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
	[تدقيق 2] [nvarchar](255) COLLATE Arabic_CI_AS NULL
)
END
GO
/****** Object:  StoredProcedure [dbo].[GenerateScript]    Script Date: 03/01/2011 20:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GenerateScript]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[GenerateScript] (            
@tableName varchar(100))      
AS

If exists (Select * from Information_Schema.COLUMNS where Table_Name= @tableName)            
Begin            
declare @sql varchar(8000)            
declare @table varchar(100)            
declare @cols table (datatype varchar(50))          
insert into @cols values(''bit'')          
insert into @cols values(''binary'')          
insert into @cols values(''bigint'')          
insert into @cols values(''int'')          
insert into @cols values(''float'')          
insert into @cols values(''datetime'')          
insert into @cols values(''text'')          
insert into @cols values(''image'')          
insert into @cols values(''uniqueidentifier'')          
insert into @cols values(''smalldatetime'')          
insert into @cols values(''tinyint'')          
insert into @cols values(''smallint'')          
insert into @cols values(''sql_variant'')          
          
set @sql=''''            
Select @sql=@sql+             
case when charindex(''('',@sql,1)<=0 then ''('' else '''' end +Column_Name + '' '' +Data_Type +             
case when Data_Type in (Select datatype from @cols) then '''' else  ''('' end+
case when data_type in (''real'',''money'',''decimal'',''numeric'')  then cast(isnull(numeric_precision,'''') as varchar)+'',''+
case when data_type in (''real'',''money'',''decimal'',''numeric'') then cast(isnull(Numeric_Scale,'''') as varchar) end
when data_type in (''char'',''nvarchar'',''varchar'',''nchar'') then cast(isnull(Character_Maximum_Length,'''') as varchar)       else '''' end+
case when Data_Type in (Select datatype from @cols)then '''' else  '')'' end+
case when Is_Nullable=''No'' then '' Null,'' else '' Not null,'' end            
from Information_Schema.COLUMNS where Table_Name=@tableName            

 
select  @table=  ''Create table '' + table_Name from Information_Schema.COLUMNS where table_Name=@tableName            
select @sql=@table + substring(@sql,1,len(@sql)-1) +'' )''            
select @sql  as DDL         
 
End            

Else        
 Select ''The table ''+@tableName + '' does not exist''            


' 
END
GO
/****** Object:  Table [dbo].[EngCV]    Script Date: 03/01/2011 20:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EngCV]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EngCV](
	[EngID] [int] NOT NULL,
	[Fname] [nvarchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[Mname] [nvarchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[Lname] [nvarchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[FullName]  AS (((([fname]+' ')+[mname])+' ')+[lname]),
	[IdCard] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[MotherName] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[BirthdayOfLoc] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[Gender] [nvarchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[Entry] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[integrity] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[Certificate] [nvarchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[DateOFbirthday] [date] NOT NULL,
	[DateOfgraduation] [date] NOT NULL,
	[DateOFjointly] [date] NOT NULL,
	[EngBitmap] [image] NULL,
	[HomeAddress] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[WorkAddress] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[HomePhone] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[WorkPhone] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[CellPhone] [nvarchar](15) COLLATE Arabic_CI_AS NULL,
	[EmailEn] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[PoBox] [nvarchar](20) COLLATE Arabic_CI_AS NULL,
	[Fax] [nvarchar](20) COLLATE Arabic_CI_AS NULL,
	[CVModified] [date] NULL,
	[EngStatus] [nvarchar](20) COLLATE Arabic_CI_AS NOT NULL,
	[EngRetail] [bit] NULL,
	[EngDeath] [bit] NULL,
	[National] [nvarchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[EngMove] [bit] NULL,
	[EngCancel] [bit] NULL,
	[EngRemarks] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[Section] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[UniName] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[UniLocation] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[EngWork] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[IDjoind] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[MoveDate] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[ReJoind] [datetime] NULL,
	[Desesion] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[RetailID] [int] NULL,
	[RemarksCV] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
 CONSTRAINT [PK_EngCV] PRIMARY KEY CLUSTERED 
(
	[EngID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'EngID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'الرقم الذاتي' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'EngID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'Fname'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'الإسم الأول' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'Fname'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'Mname'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'إسم الأب' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'Mname'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'Lname'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'النسبة' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'Lname'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'FullName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'الإسم الكامل' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'FullName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'IdCard'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'رقم الهوية' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'IdCard'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'MotherName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'إسم الأم' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'MotherName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'BirthdayOfLoc'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'مكان الولادة' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'BirthdayOfLoc'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'Gender'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'الجنس' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'Gender'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'Entry'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'القيد' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'Entry'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'integrity'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'الأمانة' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'integrity'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'Section'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'القسم' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'Section'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'IDjoind'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'رقم قرار الإنتساب' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'IDjoind'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'MoveDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'تاريخ النقل' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'MoveDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'ReJoind'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'قرار وتاريخ إعادة التسجيل' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'ReJoind'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'Desesion'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'قرار المجلس' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'Desesion'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', N'COLUMN',N'RetailID'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'الرقم التقاعدي' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV', @level2type=N'COLUMN',@level2name=N'RetailID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'EngCV', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EngCV'
GO
/****** Object:  Table [dbo].[CVs]    Script Date: 03/01/2011 20:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CVs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CVs](
	[الرقم] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
	[الرقم الفرعي] [int] NULL,
	[الرقم التقاعدي] [int] NULL,
	[الاسم] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[الكنية] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[اسم الأب] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[اسم الأم] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[مكان الولادة] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[تاريخ الولادة] [int] NULL,
	[الجنسية] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[الخانة ورقمها] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[الجنس] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[القسم] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[الاختصاص] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[سنة التخرج] [int] NULL,
	[اسم الجامعة] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[مقر الجامعة] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[الشطب] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
	[العمل] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[تاريخ الانتساب] [date] NULL,
	[رقم قرار الانتساب] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[تاريخ النقل] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[قرار وتاريخ اعادة التسجيل] [datetime] NULL,
	[العنوان] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[الذمة المالية] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
	[سنوات التأخير] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
	[ملاحظات مالية] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
	[العمل الفرعي] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
	[الهاتف] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[ملاحظات] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[قرار المجلس] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[عام التكريم] [datetime] NULL,
	[الهوية] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[الوضع] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
	[تدقيق 2] [nvarchar](255) COLLATE Arabic_CI_AS NULL
)
END
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 03/01/2011 20:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Classes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Classes](
	[ClassID] [int] IDENTITY(1,1) NOT NULL,
	[Kind] [nvarchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[Cost] [money] NOT NULL,
	[Status] [nvarchar](20) COLLATE Arabic_CI_AS NOT NULL,
	[Remarks] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[ClassModified] [date] NULL,
	[ClassCancel] [bit] NULL,
	[y1980] [int] NULL,
	[y1981] [int] NULL,
	[y1982] [int] NULL,
	[y1983] [int] NULL,
	[y1984] [int] NULL,
	[y1985] [int] NULL,
	[y1986] [int] NULL,
	[y1987] [int] NULL,
	[y1988] [int] NULL,
	[y1989] [int] NULL,
	[y1990] [int] NULL,
	[y1991] [int] NULL,
	[y1992] [int] NULL,
	[y1993] [int] NULL,
	[y1994] [int] NULL,
	[y1995] [int] NULL,
	[y1996] [int] NULL,
	[y1997] [int] NULL,
	[y1998] [int] NULL,
	[y1999] [int] NULL,
	[y2000] [int] NULL,
	[y2001] [int] NULL,
	[y2002] [int] NULL,
	[y2003] [int] NULL,
	[y2004] [int] NULL,
	[y2005] [int] NULL,
	[y2006] [int] NULL,
	[y2007] [int] NULL,
	[y2008] [int] NULL,
	[y2009] [int] NULL,
	[y2010] [int] NULL,
	[y2011] [int] NULL,
	[y2012] [int] NULL,
	[y2013] [int] NULL,
	[y2014] [int] NULL,
	[y2015] [int] NULL,
	[y2016] [int] NULL,
	[y2017] [int] NULL,
	[y2018] [int] NULL,
	[y2019] [int] NULL,
	[y2020] [int] NULL,
	[y2021] [int] NULL,
	[y2022] [int] NULL,
	[y2023] [int] NULL,
	[y2024] [int] NULL,
	[y2025] [int] NULL,
 CONSTRAINT [PK_Classes] PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Batchs]    Script Date: 03/01/2011 20:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Batchs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Batchs](
	[Bid] [int] IDENTITY(1,1) NOT NULL,
	[AcountID] [int] NOT NULL,
	[EngID] [int] NOT NULL,
	[BatchDate] [date] NOT NULL,
	[Total] [money] NOT NULL,
	[Payed] [bit] NOT NULL,
	[Remark] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
 CONSTRAINT [PK_Batchs] PRIMARY KEY CLUSTERED 
(
	[Bid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[AppSettings]    Script Date: 03/01/2011 20:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AppSettings]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AppSettings](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IFlate] [int] NOT NULL,
	[IFlateDeath] [int] NOT NULL,
	[MaxAllow] [int] NOT NULL,
	[Retail] [int] NOT NULL,
	[JoinY] [int] NOT NULL,
	[JoinY1] [int] NOT NULL,
	[JoinY2] [int] NOT NULL,
 CONSTRAINT [PK_AppSettings] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Acounting]    Script Date: 03/01/2011 20:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Acounting]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Acounting](
	[AcountID] [int] NOT NULL,
	[EngID] [int] NOT NULL,
	[AcountDate] [date] NOT NULL,
	[AcountStatus] [nvarchar](30) COLLATE Arabic_CI_AS NOT NULL,
	[AcountModified] [date] NOT NULL,
	[Remarks] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[Total] [money] NOT NULL,
	[TotalBay] [money] NOT NULL,
	[TotalRest] [money] NOT NULL,
	[RestAcountID] [int] NOT NULL,
	[RestAcountStat] [bit] NOT NULL,
	[EndAcountDate] [date] NOT NULL,
	[IsCancel] [bit] NOT NULL,
 CONSTRAINT [PK_Acounting] PRIMARY KEY CLUSTERED 
(
	[AcountID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[DetailsAcounting]    Script Date: 03/01/2011 20:13:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DetailsAcounting]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DetailsAcounting](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AcountID] [int] NOT NULL,
	[ClassID] [int] NOT NULL,
	[Cost] [money] NOT NULL,
	[Remarks] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[RealCost] [money] NULL,
	[RestCost] [money] NULL,
 CONSTRAINT [PK_DetailsAcounting] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Default [DF_Acounting_AcountStatus]    Script Date: 03/01/2011 20:13:12 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Acounting_AcountStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[Acounting]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Acounting_AcountStatus]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Acounting] ADD  CONSTRAINT [DF_Acounting_AcountStatus]  DEFAULT (N'InWait') FOR [AcountStatus]
END


End
GO
/****** Object:  Default [DF_Acounting_Total]    Script Date: 03/01/2011 20:13:12 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Acounting_Total]') AND parent_object_id = OBJECT_ID(N'[dbo].[Acounting]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Acounting_Total]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Acounting] ADD  CONSTRAINT [DF_Acounting_Total]  DEFAULT ((0)) FOR [Total]
END


End
GO
/****** Object:  Default [DF_Acounting_TotalBay]    Script Date: 03/01/2011 20:13:12 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Acounting_TotalBay]') AND parent_object_id = OBJECT_ID(N'[dbo].[Acounting]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Acounting_TotalBay]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Acounting] ADD  CONSTRAINT [DF_Acounting_TotalBay]  DEFAULT ((0)) FOR [TotalBay]
END


End
GO
/****** Object:  Default [DF_Acounting_TotalRest]    Script Date: 03/01/2011 20:13:12 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Acounting_TotalRest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Acounting]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Acounting_TotalRest]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Acounting] ADD  CONSTRAINT [DF_Acounting_TotalRest]  DEFAULT ((0)) FOR [TotalRest]
END


End
GO
/****** Object:  Default [DF_Acounting_IsCancel]    Script Date: 03/01/2011 20:13:12 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Acounting_IsCancel]') AND parent_object_id = OBJECT_ID(N'[dbo].[Acounting]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Acounting_IsCancel]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Acounting] ADD  CONSTRAINT [DF_Acounting_IsCancel]  DEFAULT ((0)) FOR [IsCancel]
END


End
GO
/****** Object:  Default [DF_Batchs_Payed]    Script Date: 03/01/2011 20:13:13 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Batchs_Payed]') AND parent_object_id = OBJECT_ID(N'[dbo].[Batchs]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Batchs_Payed]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Batchs] ADD  CONSTRAINT [DF_Batchs_Payed]  DEFAULT ((0)) FOR [Payed]
END


End
GO
/****** Object:  Default [DF_EngCV_DateOFjointly]    Script Date: 03/01/2011 20:13:13 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_EngCV_DateOFjointly]') AND parent_object_id = OBJECT_ID(N'[dbo].[EngCV]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_EngCV_DateOFjointly]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EngCV] ADD  CONSTRAINT [DF_EngCV_DateOFjointly]  DEFAULT (getdate()) FOR [DateOFjointly]
END


End
GO
/****** Object:  Default [DF_EngCV_CVModified]    Script Date: 03/01/2011 20:13:13 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_EngCV_CVModified]') AND parent_object_id = OBJECT_ID(N'[dbo].[EngCV]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_EngCV_CVModified]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EngCV] ADD  CONSTRAINT [DF_EngCV_CVModified]  DEFAULT (getdate()) FOR [CVModified]
END


End
GO
/****** Object:  Check [CK_Classes_1]    Script Date: 03/01/2011 20:13:13 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_Classes_1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Classes]'))
ALTER TABLE [dbo].[Classes]  WITH CHECK ADD  CONSTRAINT [CK_Classes_1] CHECK  (([Status]='رسم سنوي' OR [Status]='رسوم أخرى' OR [Status]='أمانات'))
GO
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_Classes_1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Classes]'))
ALTER TABLE [dbo].[Classes] CHECK CONSTRAINT [CK_Classes_1]
GO
/****** Object:  ForeignKey [FK_Acounting_EngCV]    Script Date: 03/01/2011 20:13:12 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Acounting_EngCV]') AND parent_object_id = OBJECT_ID(N'[dbo].[Acounting]'))
ALTER TABLE [dbo].[Acounting]  WITH CHECK ADD  CONSTRAINT [FK_Acounting_EngCV] FOREIGN KEY([EngID])
REFERENCES [dbo].[EngCV] ([EngID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Acounting_EngCV]') AND parent_object_id = OBJECT_ID(N'[dbo].[Acounting]'))
ALTER TABLE [dbo].[Acounting] CHECK CONSTRAINT [FK_Acounting_EngCV]
GO
/****** Object:  ForeignKey [FK_DetailsAcounting_Acounting]    Script Date: 03/01/2011 20:13:13 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DetailsAcounting_Acounting]') AND parent_object_id = OBJECT_ID(N'[dbo].[DetailsAcounting]'))
ALTER TABLE [dbo].[DetailsAcounting]  WITH CHECK ADD  CONSTRAINT [FK_DetailsAcounting_Acounting] FOREIGN KEY([AcountID])
REFERENCES [dbo].[Acounting] ([AcountID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DetailsAcounting_Acounting]') AND parent_object_id = OBJECT_ID(N'[dbo].[DetailsAcounting]'))
ALTER TABLE [dbo].[DetailsAcounting] CHECK CONSTRAINT [FK_DetailsAcounting_Acounting]
GO
/****** Object:  ForeignKey [FK_DetailsAcounting_Classes]    Script Date: 03/01/2011 20:13:13 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DetailsAcounting_Classes]') AND parent_object_id = OBJECT_ID(N'[dbo].[DetailsAcounting]'))
ALTER TABLE [dbo].[DetailsAcounting]  WITH CHECK ADD  CONSTRAINT [FK_DetailsAcounting_Classes] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Classes] ([ClassID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DetailsAcounting_Classes]') AND parent_object_id = OBJECT_ID(N'[dbo].[DetailsAcounting]'))
ALTER TABLE [dbo].[DetailsAcounting] CHECK CONSTRAINT [FK_DetailsAcounting_Classes]
GO
