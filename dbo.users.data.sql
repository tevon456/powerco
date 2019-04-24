SET IDENTITY_INSERT [dbo].[users] ON
INSERT INTO [dbo].[users] ([Id], [username], [password], [isAdmin]) VALUES (1, N'admin', N'12345678  ', 1)
INSERT INTO [dbo].[users] ([Id], [username], [password], [isAdmin]) VALUES (2, N'clunie', N'12345678  ', 0)
INSERT INTO [dbo].[users] ([Id], [username], [password], [isAdmin]) VALUES (3, N'test', NULL, NULL)
SET IDENTITY_INSERT [dbo].[users] OFF
