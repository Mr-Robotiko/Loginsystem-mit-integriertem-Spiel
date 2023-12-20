CREATE TABLE [dbo].Wrapper
(
	[User_ID] INT NOT NULL, 
    [Statistic_ID] INT NOT NULL, 
    [Date] DATE NOT NULL, 
    [Time] INT NOT NULL, 
    CONSTRAINT [Nutzer_FK] FOREIGN KEY (User_ID) REFERENCES Nutzer(User_ID), 
    CONSTRAINT [Statistic_FK] FOREIGN KEY (Statistic_ID) REFERENCES Statistic(Statistic_ID),

)
