USE [AS-KTechTest]
GO
SET IDENTITY_INSERT [dbo].[tbl_Events] ON 

GO
INSERT [dbo].[tbl_Events] ([EventId], [Name], [Country], [City], [Date], [StartTime], [EndTime], [UTCOffSet]) VALUES (1, N'U2        ', N'South Africa', N'Cape Town', CAST(N'2016-08-01 00:00:00.000' AS DateTime), CAST(N'22:00:00' AS Time), CAST(N'23:00:00' AS Time), 2)
GO
INSERT [dbo].[tbl_Events] ([EventId], [Name], [Country], [City], [Date], [StartTime], [EndTime], [UTCOffSet]) VALUES (2, N'U2        ', N'South Africa', N'PE', CAST(N'2016-07-01 00:00:00.000' AS DateTime), CAST(N'21:00:00' AS Time), CAST(N'23:00:00' AS Time), 2)
GO
INSERT [dbo].[tbl_Events] ([EventId], [Name], [Country], [City], [Date], [StartTime], [EndTime], [UTCOffSet]) VALUES (3, N'U2        ', N'South Africa', N'Durban', CAST(N'2016-08-23 00:00:00.000' AS DateTime), CAST(N'19:00:00' AS Time), CAST(N'23:00:00' AS Time), 2)
GO
INSERT [dbo].[tbl_Events] ([EventId], [Name], [Country], [City], [Date], [StartTime], [EndTime], [UTCOffSet]) VALUES (4, N'U2        ', N'UK', N'London', CAST(N'2016-08-01 00:00:00.000' AS DateTime), CAST(N'23:00:00' AS Time), CAST(N'23:00:00' AS Time), 0)
GO
INSERT [dbo].[tbl_Events] ([EventId], [Name], [Country], [City], [Date], [StartTime], [EndTime], [UTCOffSet]) VALUES (5, N'U2        ', N'UK', N'Manchester', CAST(N'2016-08-01 12:00:00.000' AS DateTime), CAST(N'22:00:00' AS Time), CAST(N'23:00:00' AS Time), 0)
GO
INSERT [dbo].[tbl_Events] ([EventId], [Name], [Country], [City], [Date], [StartTime], [EndTime], [UTCOffSet]) VALUES (6, N'Coldplay  ', N'UK', N'London', CAST(N'2016-10-01 00:00:00.000' AS DateTime), CAST(N'21:00:00' AS Time), CAST(N'23:00:00' AS Time), 0)
GO
SET IDENTITY_INSERT [dbo].[tbl_Events] OFF
GO
