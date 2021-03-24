CREATE TABLE [dbo].[Authorization](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Login] [nvarchar](MAX) NOT NULL,
	[Password] [nvarchar](MAX) NOT NULL,
)

SET IDENTITY_INSERT [dbo].[Authorization] ON
INSERT [dbo].[Authorization] ([ID], [Login], [Password]) VALUES (1, N'Admin', N'123')
INSERT [dbo].[Authorization] ([ID], [Login], [Password]) VALUES (2, N'ssmlnsk', N'12345')
SET IDENTITY_INSERT [dbo].[Authorization] OFF