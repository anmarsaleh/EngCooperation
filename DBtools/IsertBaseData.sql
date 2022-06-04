 use ENcooperationDB
 SET IDENTITY_INSERT [dbo].[Classes] ON
INSERT [dbo].[Classes] ([ClassID], [Kind], [Cost], [Status], [Remarks], [ClassModified], [ClassCancel]) VALUES (1, N'—”„ «‘ —«ﬂ', 250.0000, N'—”„ ”‰ÊÌ', NULL, CAST(0x8D330B00 AS Date), NULL)
INSERT [dbo].[Classes] ([ClassID], [Kind], [Cost], [Status], [Remarks], [ClassModified], [ClassCancel]) VALUES (2, N'—”„ „Ã·…', 75.0000, N'—”„ ”‰ÊÌ', NULL, CAST(0x8D330B00 AS Date), NULL)
INSERT [dbo].[Classes] ([ClassID], [Kind], [Cost], [Status], [Remarks], [ClassModified], [ClassCancel]) VALUES (3, N'—”„  ”ÃÌ·', 200.0000, N'—”„ ”‰ÊÌ', NULL, CAST(0x90330B00 AS Date), NULL)
INSERT [dbo].[Classes] ([ClassID], [Kind], [Cost], [Status], [Remarks], [ClassModified], [ClassCancel]) VALUES (4, N'—”„ Ê›«…', 4800.0000, N'—”„ ”‰ÊÌ', NULL, CAST(0x90330B00 AS Date), NULL)
INSERT [dbo].[Classes] ([ClassID], [Kind], [Cost], [Status], [Remarks], [ClassModified], [ClassCancel]) VALUES (5, N'—”„ ÂÊÌ…', 15.0000, N'—”„ ”‰ÊÌ', NULL, CAST(0x90330B00 AS Date), NULL)
INSERT [dbo].[Classes] ([ClassID], [Kind], [Cost], [Status], [Remarks], [ClassModified], [ClassCancel]) VALUES (6, N'„”«Â„… ÷„«‰', 100.0000, N'—”„ ”‰ÊÌ', NULL, CAST(0x90330B00 AS Date), NULL)
INSERT [dbo].[Classes] ([ClassID], [Kind], [Cost], [Status], [Remarks], [ClassModified], [ClassCancel]) VALUES (7, N'—”„  ﬁ«⁄œ', 300.0000, N'—”„ ”‰ÊÌ', NULL, CAST(0x93330B00 AS Date), NULL)
INSERT [dbo].[Classes] ([ClassID], [Kind], [Cost], [Status], [Remarks], [ClassModified], [ClassCancel]) VALUES (8, N'—”„  ﬂ«›·', 400.0000, N'—”„ ”‰ÊÌ', NULL, CAST(0x94330B00 AS Date), NULL)
INSERT [dbo].[Classes] ([ClassID], [Kind], [Cost], [Status], [Remarks], [ClassModified], [ClassCancel]) VALUES (9, N'—”„  √ÂÌ·', 1000.0000, N'—”Ê„ √Œ—Ï', NULL, CAST(0x94330B00 AS Date), NULL)
INSERT [dbo].[Classes] ([ClassID], [Kind], [Cost], [Status], [Remarks], [ClassModified], [ClassCancel]) VALUES (10, N'—”„ „ﬂ »', 350.0000, N'—”Ê„ √Œ—Ï', NULL, CAST(0x94330B00 AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Classes] OFF
--Object:  Table [dbo].[UsersInfo]    Script Date: 12/06/2010 14:53:05 ******/" & vbCrLf & _
SET IDENTITY_INSERT [dbo].[UsersInfo] ON
INSERT [dbo].[UsersInfo] ([UserID], [AllowCV], [AllowAcount], [AllowBox], [UserName], [UserPW], [IsAdmin]) VALUES (1, 1, 1, 1, N'Admin', N'11', 1)
SET IDENTITY_INSERT [dbo].[UsersInfo] OFF
SET IDENTITY_INSERT [dbo].[AppSettings] ON
INSERT [dbo].[AppSettings] ([ID], [IFlate], [IFlateDeath], [MaxAllow], [Retail],[JoinY],[JoinY1],[JoinY2]) VALUES (1, 50, 10, 9, 300,250,240,500)
SET IDENTITY_INSERT [dbo].[AppSettings] OFF