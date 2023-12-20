CREATE TABLE [dbo].Wrapper
(
	[Wrapper_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FK_User] INT NOT NULL, 
    [FK_Statistic] INT NOT NULL, 
    [Date] DATE NOT NULL, 
    [Time] INT NOT NULL, 
    CONSTRAINT [User_FK] FOREIGN KEY (FK_User) REFERENCES User1(User_ID), 
    CONSTRAINT [Statistic_FK] FOREIGN KEY (FK_Statistic) REFERENCES Statistic(Statistic_ID)
)
