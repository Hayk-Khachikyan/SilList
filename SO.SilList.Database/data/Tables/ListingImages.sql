﻿CREATE TABLE [data].[ListingImages]
(
	[listingImagesId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [imageId] UNIQUEIDENTIFIER NULL, 
    [listingId] UNIQUEIDENTIFIER NULL
)
