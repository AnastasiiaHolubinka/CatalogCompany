CREATE DATABASE CompanyCatalog

GO

USE CompanyCatalog

GO

CREATE TABLE [dbo].Company (
    [Id]				INT IDENTITY (1, 1) NOT NULL,
    [CompanyName]			VARCHAR (40)  NOT NULL,
    [CompanyAddress]        		VARCHAR (100)  NOT NULL,
    [FoundationYear]			INT           NOT NULL,
    [AnnualRevenue]			INT           NOT NULL,
    [BusinessType]			VARCHAR (100) NOT NULL,

    PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT C_UNIQUE_ID UNIQUE(Id)
);

GO

INSERT INTO [dbo].[Company] ([CompanyName], [CompanyAddress], [FoundationYear], [AnnualRevenue], [BusinessType]) VALUES (N'epam ', N'вул. Угорська, 14', 1993, 12000, N'private')
INSERT INTO [dbo].[Company] ([CompanyName], [CompanyAddress], [FoundationYear], [AnnualRevenue], [BusinessType]) VALUES (N'softserve ', N'79000, вул. Героїв УПА, 72', 1993, 14000, N'public')
INSERT INTO [dbo].[Company] ([CompanyName], [CompanyAddress], [FoundationYear], [AnnualRevenue], [BusinessType]) VALUES (N'SOLEAD Software ', N'7D Naukova Str., 79060 ', 2019, 10000, N'non-profit')
INSERT INTO [dbo].[Company] ([CompanyName], [CompanyAddress], [FoundationYear], [AnnualRevenue], [BusinessType]) VALUES (N'DevRain ', N'вулиця Велика Васильківська, 72, Київ, 03150', 2011, 11000, N'venture capital')

GO

CREATE PROCEDURE [dbo].[addRecord]
	@pCompanyName varchar(40),
	@pCompanyAddress varchar(100),
	@pFoundationYear int,
	@pAnnualRevenue int,
	@pBusinessType VARCHAR(100)

AS
	INSERT INTO Company (CompanyName, CompanyAddress, FoundationYear, AnnualRevenue, BusinessType ) VALUES (@pCompanyName,@pCompanyAddress, @pFoundationYear,@pAnnualRevenue,@pBusinessType);

GO

CREATE PROCEDURE [dbo].[deleteRecord]
	@pID int
AS
	DELETE Company
	WHERE id = @pID;

GO

CREATE PROCEDURE dbo.[retRecords]
	@TitlePhrase varchar(40)
AS
	declare @param VARCHAR(40)
	set @param = '%' + @TitlePhrase + '%' 

	SELECT * FROM Company WHERE CompanyName LIKE @param;

GO

CREATE PROCEDURE [dbo].[updateRecord]
	@pID int,
	@pCompanyName varchar(40),
	@pCompanyAddress varchar(100),
	@pFoundationYear int,
	@pAnnualRevenue int,
	@pBusinessType VARCHAR(100)
AS
	UPDATE Company
	SET CompanyName = @pCompanyName, CompanyAddress = @pCompanyAddress, FoundationYear = @pFoundationYear, AnnualRevenue = @pAnnualRevenue, BusinessType = @pBusinessType
	WHERE id = @pID;

GO
