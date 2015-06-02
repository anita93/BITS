SET IDENTITY_INSERT [dbo].[Students] ON
INSERT INTO [dbo].[Students] ([ID], [Name], [JoiningDate], [Branch], [CPI]) VALUES (1, N'alex', N'2003-02-01 00:00:00', N'cse', CAST(8.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Students] OFF
