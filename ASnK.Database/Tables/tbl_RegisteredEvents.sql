CREATE TABLE [dbo].[tbl_RegisteredEvents]
(
	[RegisteredEventId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EventId] INT NOT NULL, 
    [Email] VARCHAR(100) NOT NULL, 
    [Firstname] VARCHAR(50) NOT NULL, 
    [Lastname] VARCHAR(50) NOT NULL, 
    [Country] VARCHAR(50) NOT NULL, 
    [ArivalDate] DATE NOT NULL, 
    [ArivalTime] TIME NOT NULL, 
    [RegistrationDate] DATE NOT NULL, 
    CONSTRAINT [FK_tbl_RegisteredEvents_ToTable] FOREIGN KEY ([EventId]) REFERENCES [tbl_Events]([EventId]) 
)
