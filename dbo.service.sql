CREATE TABLE [dbo].[service] (
    [id]          VARCHAR (50) NULL,
    [invoiceId]   INT          IDENTITY (1, 1) NOT NULL,
    [service]     VARCHAR (50) NULL,
    [price]       FLOAT (53)   NULL,
    [priority]    VARCHAR (20) NULL,
    [serviceDate] DATE         NULL,
	[name]		  VARCHAR (20) NULL
);

