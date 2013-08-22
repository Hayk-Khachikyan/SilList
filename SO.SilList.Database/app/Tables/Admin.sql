﻿CREATE TABLE [app].[Admin]
(
	[adminId]			INT IDENTITY (1, 1) NOT NULL,
    [firstName]         NVARCHAR (50) NULL,
    [lastName]          NVARCHAR (50) NULL,
    [email]             NVARCHAR (50) NULL,
    [username]          NVARCHAR (50) NULL,
    [password]          NVARCHAR (50) NULL,
    [phone]             NVARCHAR (50) NULL,
    [isEmailConfirmed]  BIT           DEFAULT ((0)) NULL,
	[isSuperAdmin]		BIT DEFAULT ((0)) NOT NULL,		
    [ipAddress]         NVARCHAR (50) NULL,
    [lastLogin]         DATETIME       NULL,
    [created]           DATETIME      DEFAULT (getdate()) NOT NULL,
    [modified]          DATETIME      DEFAULT (getdate()) NOT NULL,
    [createdBy]         INT           NULL,
    [modifiedBy]        INT           NULL,
    [isActive]          BIT           DEFAULT ((1)) NOT NULL, 
    CONSTRAINT [PK_Admin] PRIMARY KEY ([adminId]),
);
GO

CREATE TRIGGER [app].[Trigger_Admin_Delete]
    ON [app].[Admin]
    FOR DELETE
    AS
    BEGIN
        IF (0 = (SELECT count(*) FROM [app].[Admin] WHERE isSuperAdmin = 1))
		BEGIN
			ROLLBACK TRANSACTION
		END
    END;
GO