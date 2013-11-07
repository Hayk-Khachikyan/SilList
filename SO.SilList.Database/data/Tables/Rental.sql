﻿CREATE TABLE [data].[Rental] (
    [propertyId]            UNIQUEIDENTIFIER NOT NULL,
    [title]                 NVARCHAR (50)    NULL,
    [description]           NVARCHAR (MAX)   NULL,
    [propertyTypeId]        INT              NULL,
    [propertyListingTypeId] INT              NULL,
    [siteId]                INT              NULL,
    [bedrooms]              INT              NULL,
    [bathrooms]             INT              NULL,
    [price]                 DECIMAL (18)     NULL,
    [size]                  INT              NULL,
    [lotSize]               INT              NULL,
    [acceptsSection8]       BIT              NULL,
    [address]               NVARCHAR (MAX)   NULL,
    [cityTypeId]            INT              NULL,
    [stateTypeId]           INT              NULL,
    [countryTypeId]         INT              NULL,
    [zip]                   INT              NULL,
    [phone]                 NVARCHAR (50)    NULL,
    [fax]                   NVARCHAR (50)    NULL,
    [startDate]             DATE             NOT NULL,
    [endDate]               DATE             NOT NULL,
    [isApproved]            BIT              CONSTRAINT [DF__tmp_ms_xx__isApp__75586032] DEFAULT ((0)) NOT NULL,
    [modifiedBy]            INT              NULL,
    [modified]              DATETIME         CONSTRAINT [DF_Rental_modified] DEFAULT (getdate()) NOT NULL,
    [createdBy]             INT              NULL,
    [created]               DATETIME         CONSTRAINT [DF_Rental_created] DEFAULT (getdate()) NOT NULL,
    [isActive]              BIT              CONSTRAINT [DF_Rental_isActive] DEFAULT ((1)) NOT NULL,
    [statusTypeId]          INT              NULL,
    [isPetAllowed]          BIT              NOT NULL,
    CONSTRAINT [PK__tmp_ms_x__0164732E4C94D603] PRIMARY KEY CLUSTERED ([propertyId] ASC),
    CONSTRAINT [FK_Rental_CityType] FOREIGN KEY ([cityTypeId]) REFERENCES [app].[CityType] ([cityTypeId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Rental_CountryType] FOREIGN KEY ([countryTypeId]) REFERENCES [app].[CountryType] ([countryTypeId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Rental_PropertyType] FOREIGN KEY ([propertyTypeId]) REFERENCES [app].[PropertyType] ([propertyTypeId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Rental_Site] FOREIGN KEY ([siteId]) REFERENCES [app].[Site] ([siteId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Rental_StateType] FOREIGN KEY ([stateTypeId]) REFERENCES [app].[StateType] ([stateTypeId]) ON DELETE CASCADE ON UPDATE CASCADE
);

















