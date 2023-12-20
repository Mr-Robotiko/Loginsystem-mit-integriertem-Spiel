CREATE TABLE [dbo].Statistic
(
	[Statistic_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Game_ID] INT NOT NULL, 
    [Total_time] INT NOT NULL, 
    [Highscore] INT NOT NULL
)
