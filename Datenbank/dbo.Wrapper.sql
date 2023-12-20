CREATE TABLE [dbo].[Wrapper] (
    [Wrapper_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
	[User_ID]      INT  NOT NULL,
    [Statistic_ID] INT  NOT NULL,
    [Date]         DATE NOT NULL,
    [Time]         INT  NOT NULL,
    CONSTRAINT [Nutzer_FK] FOREIGN KEY ([User_ID]) REFERENCES [dbo].[Nutzer] ([User_ID]),
    CONSTRAINT [Statistic_FK] FOREIGN KEY ([Statistic_ID]) REFERENCES [dbo].[Statistic] ([Statistic_ID])
);

