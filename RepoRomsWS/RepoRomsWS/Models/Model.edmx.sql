
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/28/2020 19:46:27
-- Generated from EDMX file: C:\Users\Usuario\source\repos\RepoRomsWS\RepoRomsWS\Models\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RomsWSBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Emus_Consolas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Emus] DROP CONSTRAINT [FK_Emus_Consolas];
GO
IF OBJECT_ID(N'[dbo].[FK_Roms_Consolas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Roms] DROP CONSTRAINT [FK_Roms_Consolas];
GO
IF OBJECT_ID(N'[dbo].[FK_Emus_Plataformas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Emus] DROP CONSTRAINT [FK_Emus_Plataformas];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Consolas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Consolas];
GO
IF OBJECT_ID(N'[dbo].[Emus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Emus];
GO
IF OBJECT_ID(N'[dbo].[Plataformas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Plataformas];
GO
IF OBJECT_ID(N'[dbo].[Roms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roms];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Consolas'
CREATE TABLE [dbo].[Consolas] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] varchar(100)  NOT NULL,
    [cover] varbinary(max)  NULL,
    [fecha] datetime  NOT NULL
);
GO

-- Creating table 'Emus'
CREATE TABLE [dbo].[Emus] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] varchar(100)  NOT NULL,
    [info] varchar(250)  NOT NULL,
    [cover] varbinary(max)  NULL,
    [consolaId] int  NOT NULL,
    [PlataformaId] int  NOT NULL
);
GO

-- Creating table 'Plataformas'
CREATE TABLE [dbo].[Plataformas] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] varchar(100)  NOT NULL
);
GO

-- Creating table 'Roms'
CREATE TABLE [dbo].[Roms] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] varchar(100)  NOT NULL,
    [sinopsis] varchar(500)  NOT NULL,
    [cover] varbinary(max)  NULL,
    [fecha] datetime  NOT NULL,
    [video] varchar(250)  NULL,
    [consolaId] int  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Consolas'
ALTER TABLE [dbo].[Consolas]
ADD CONSTRAINT [PK_Consolas]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Emus'
ALTER TABLE [dbo].[Emus]
ADD CONSTRAINT [PK_Emus]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Plataformas'
ALTER TABLE [dbo].[Plataformas]
ADD CONSTRAINT [PK_Plataformas]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Roms'
ALTER TABLE [dbo].[Roms]
ADD CONSTRAINT [PK_Roms]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [consolaId] in table 'Emus'
ALTER TABLE [dbo].[Emus]
ADD CONSTRAINT [FK_Emus_Consolas]
    FOREIGN KEY ([consolaId])
    REFERENCES [dbo].[Consolas]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Emus_Consolas'
CREATE INDEX [IX_FK_Emus_Consolas]
ON [dbo].[Emus]
    ([consolaId]);
GO

-- Creating foreign key on [consolaId] in table 'Roms'
ALTER TABLE [dbo].[Roms]
ADD CONSTRAINT [FK_Roms_Consolas]
    FOREIGN KEY ([consolaId])
    REFERENCES [dbo].[Consolas]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Roms_Consolas'
CREATE INDEX [IX_FK_Roms_Consolas]
ON [dbo].[Roms]
    ([consolaId]);
GO

-- Creating foreign key on [PlataformaId] in table 'Emus'
ALTER TABLE [dbo].[Emus]
ADD CONSTRAINT [FK_Emus_Plataformas]
    FOREIGN KEY ([PlataformaId])
    REFERENCES [dbo].[Plataformas]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Emus_Plataformas'
CREATE INDEX [IX_FK_Emus_Plataformas]
ON [dbo].[Emus]
    ([PlataformaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------