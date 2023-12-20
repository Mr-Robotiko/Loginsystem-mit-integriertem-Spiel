CREATE TABLE [dbo].[Statistic] (
    [Statistic_ID] INT IDENTITY (1, 1) NOT NULL,
    [Game_ID]      INT NOT NULL,
    [Total_time]   INT NOT NULL,
    [Highscore]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Statistic_ID] ASC)
);

