CREATE TABLE [dbo].[Statistic] (
    [Statistic_ID] INT IDENTITY (1, 1) NOT NULL,
    [Game_ID]      INT NOT NULL,
    [Total_time]   INT NOT NULL,
    [Highscore]    INT NOT NULL,
    [FK_User_ID] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Statistic_ID] ASC), 
    CONSTRAINT [User_ID_FK] FOREIGN KEY (FK_User_ID) REFERENCES User1(User_ID)
);

