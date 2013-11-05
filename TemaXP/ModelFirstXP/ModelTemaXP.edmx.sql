
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/05/2013 09:42:38
-- Generated from EDMX file: C:\Users\chrome\Documents\MyProjects\TemaXP\TemaXP\ModelFirstXP\ModelTemaXP.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dmaa0212a_6];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AuctionArtwork]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AuctionSet] DROP CONSTRAINT [FK_AuctionArtwork];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AuctionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AuctionSet];
GO
IF OBJECT_ID(N'[dbo].[ArtworkSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArtworkSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Auctions'
CREATE TABLE [dbo].[Auctions] (
    [AuctionId] int IDENTITY(1,1) NOT NULL,
    [startingBid] float  NOT NULL,
    [startDate] datetime  NOT NULL,
    [endDate] datetime  NOT NULL,
    [itemText] nvarchar(max)  NOT NULL,
    [Artwork_artworkId] int  NOT NULL
);
GO

-- Creating table 'Artworks'
CREATE TABLE [dbo].[Artworks] (
    [artworkId] int IDENTITY(1,1) NOT NULL,
    [artistName] nvarchar(max)  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [year] nvarchar(max)  NOT NULL,
    [height] float  NOT NULL,
    [width] float  NOT NULL,
    [location] nvarchar(max)  NOT NULL,
    [imageName] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AuctionId] in table 'Auctions'
ALTER TABLE [dbo].[Auctions]
ADD CONSTRAINT [PK_Auctions]
    PRIMARY KEY CLUSTERED ([AuctionId] ASC);
GO

-- Creating primary key on [artworkId] in table 'Artworks'
ALTER TABLE [dbo].[Artworks]
ADD CONSTRAINT [PK_Artworks]
    PRIMARY KEY CLUSTERED ([artworkId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Artwork_artworkId] in table 'Auctions'
ALTER TABLE [dbo].[Auctions]
ADD CONSTRAINT [FK_AuctionArtwork]
    FOREIGN KEY ([Artwork_artworkId])
    REFERENCES [dbo].[Artworks]
        ([artworkId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AuctionArtwork'
CREATE INDEX [IX_FK_AuctionArtwork]
ON [dbo].[Auctions]
    ([Artwork_artworkId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------