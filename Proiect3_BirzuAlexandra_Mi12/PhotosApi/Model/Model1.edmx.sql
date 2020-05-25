
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/21/2020 14:12:17
-- Generated from EDMX file: C:\Users\Alexandra\source\repos\HostWCF\PhotosApi\Model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [myphotos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_resourcesatributes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[atributes] DROP CONSTRAINT [FK_resourcesatributes];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[resources]', 'U') IS NOT NULL
    DROP TABLE [dbo].[resources];
GO
IF OBJECT_ID(N'[dbo].[atributes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[atributes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'resources'
CREATE TABLE [dbo].[resources] (
    [resID] int IDENTITY(1,1) NOT NULL,
    [path] nvarchar(max)  NOT NULL,
    [added_at] nvarchar(max)  NOT NULL,
    [type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'atributes'
CREATE TABLE [dbo].[atributes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [resources_resID] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [resID] in table 'resources'
ALTER TABLE [dbo].[resources]
ADD CONSTRAINT [PK_resources]
    PRIMARY KEY CLUSTERED ([resID] ASC);
GO

-- Creating primary key on [Id] in table 'atributes'
ALTER TABLE [dbo].[atributes]
ADD CONSTRAINT [PK_atributes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [resources_resID] in table 'atributes'
ALTER TABLE [dbo].[atributes]
ADD CONSTRAINT [FK_resourcesatributes]
    FOREIGN KEY ([resources_resID])
    REFERENCES [dbo].[resources]
        ([resID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_resourcesatributes'
CREATE INDEX [IX_FK_resourcesatributes]
ON [dbo].[atributes]
    ([resources_resID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------