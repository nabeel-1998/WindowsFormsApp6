
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/18/2022 11:52:50
-- Generated from EDMX file: C:\Users\HP\source\repos\WindowsFormsApp6\WindowsFormsApp6\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AMS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EMP_AMS_EMP_AMS1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EMP_AMS] DROP CONSTRAINT [FK_EMP_AMS_EMP_AMS1];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ADMIN_TABLE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ADMIN_TABLE];
GO
IF OBJECT_ID(N'[dbo].[ATTENDANCE_TABLE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ATTENDANCE_TABLE];
GO
IF OBJECT_ID(N'[dbo].[EMP_AMS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EMP_AMS];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ADMIN_TABLE'
CREATE TABLE [dbo].[ADMIN_TABLE] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [PASSWORD] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'ATTENDANCE_TABLE'
CREATE TABLE [dbo].[ATTENDANCE_TABLE] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [NAME] nvarchar(50)  NOT NULL,
    [STATUS] nvarchar(50)  NOT NULL,
    [ID_EMP] int  NOT NULL
);
GO

-- Creating table 'EMP_AMS'
CREATE TABLE [dbo].[EMP_AMS] (
    [ID_EMP] int IDENTITY(1,1) NOT NULL,
    [NAME] nvarchar(50)  NOT NULL,
    [EMAIL] nvarchar(50)  NOT NULL,
    [CONTACT] nvarchar(50)  NOT NULL,
    [BIKE] nvarchar(50)  NULL,
    [PASSWORK] nvarchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'ADMIN_TABLE'
ALTER TABLE [dbo].[ADMIN_TABLE]
ADD CONSTRAINT [PK_ADMIN_TABLE]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ATTENDANCE_TABLE'
ALTER TABLE [dbo].[ATTENDANCE_TABLE]
ADD CONSTRAINT [PK_ATTENDANCE_TABLE]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID_EMP] in table 'EMP_AMS'
ALTER TABLE [dbo].[EMP_AMS]
ADD CONSTRAINT [PK_EMP_AMS]
    PRIMARY KEY CLUSTERED ([ID_EMP] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ID_EMP] in table 'EMP_AMS'
ALTER TABLE [dbo].[EMP_AMS]
ADD CONSTRAINT [FK_EMP_AMS_EMP_AMS1]
    FOREIGN KEY ([ID_EMP])
    REFERENCES [dbo].[EMP_AMS]
        ([ID_EMP])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------