CREATE TABLE [dbo].[User1] (
    [User_ID]       INT            IDENTITY (1, 1) NOT NULL,
    [Prename]       NVARCHAR (50)  NOT NULL,
    [Name]          NVARCHAR (50)  NOT NULL,
    [Birthday]      DATE           NOT NULL,
    [Rights_Status] NCHAR (10)     NOT NULL,
    [Password]      NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([User_ID] ASC)
);

