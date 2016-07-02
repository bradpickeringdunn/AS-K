CREATE TABLE [dbo].[tbl_Events]
(
	[EventId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(10) NOT NULL, 
    [Country] VARCHAR(50) NOT NULL, 
    [City] VARCHAR(50) NOT NULL, 
    [Date] DATETIME NOT NULL, 
    [StartTime] TIME NOT NULL, 
    [EndTime] TIME NOT NULL,
	[UTCOffSet] INT NOT NULL
)
