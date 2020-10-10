USE master
GO
CREATE DATABASE [FemiFriendsDB]
GO

USE [FemiFriendsDB]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 10/10/2020 10:44:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genders]    Script Date: 10/10/2020 10:44:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genders](
	[GenderID] [int] IDENTITY(1,1) NOT NULL,
	[GenderName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Genders] PRIMARY KEY CLUSTERED 
(
	[GenderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MyFriends]    Script Date: 10/10/2020 10:44:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MyFriends](
	[FriendID] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[OtherNames] [nvarchar](101) NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[GenderID] [int] NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[ResidentialAddress] [ntext] NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[CountryID] [int] NOT NULL,
	[StateID] [int] NULL,
	[WhatsappNumber] [nvarchar](50) NULL,
	[OtherPhoneNumber] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Photo] [nvarchar](max) NULL,
 CONSTRAINT [PK_MyFriends] PRIMARY KEY CLUSTERED 
(
	[FriendID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[States]    Script Date: 10/10/2020 10:44:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[States](
	[StateID] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [nvarchar](50) NOT NULL,
	[CountryID] [int] NULL,
 CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED 
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (1, N'Afghanistan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (2, N'Albania ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (3, N'Algeria ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (4, N'American Samoa ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (5, N'Andorra ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (6, N'Angola ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (7, N'Anguilla ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (8, N'Antigua & Barbuda ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (9, N'Argentina ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (10, N'Armenia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (11, N'Aruba ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (12, N'Australia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (13, N'Austria ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (14, N'Azerbaijan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (15, N'Bahamas, The ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (16, N'Bahrain ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (17, N'Bangladesh ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (18, N'Barbados ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (19, N'Belarus ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (20, N'Belgium ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (21, N'Belize ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (22, N'Benin ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (23, N'Bermuda ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (24, N'Bhutan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (25, N'Bolivia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (26, N'Bosnia & Herzegovina ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (27, N'Botswana ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (28, N'Brazil ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (29, N'British Virgin Is. ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (30, N'Brunei ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (31, N'Bulgaria ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (32, N'Burkina Faso ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (33, N'Burma ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (34, N'Burundi ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (35, N'Cambodia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (36, N'Cameroon ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (37, N'Canada ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (38, N'Cape Verde ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (39, N'Cayman Islands ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (40, N'Central African Rep. ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (41, N'Chad ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (42, N'Chile ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (43, N'China ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (44, N'Colombia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (45, N'Comoros ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (46, N'Congo, Dem. Rep. ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (47, N'Congo, Repub. of the ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (48, N'Cook Islands ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (49, N'Costa Rica ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (50, N'Cote d''Ivoire ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (51, N'Croatia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (52, N'Cuba ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (53, N'Cyprus ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (54, N'Czech Republic ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (55, N'Denmark ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (56, N'Djibouti ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (57, N'Dominica ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (58, N'Dominican Republic ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (59, N'East Timor ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (60, N'Ecuador ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (61, N'Egypt ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (62, N'El Salvador ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (63, N'Equatorial Guinea ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (64, N'Eritrea ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (65, N'Estonia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (66, N'Ethiopia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (67, N'Faroe Islands ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (68, N'Fiji ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (69, N'Finland ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (70, N'France ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (71, N'French Guiana ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (72, N'French Polynesia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (73, N'Gabon ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (74, N'Gambia, The ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (75, N'Gaza Strip ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (76, N'Georgia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (77, N'Germany ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (78, N'Ghana ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (79, N'Gibraltar ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (80, N'Greece ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (81, N'Greenland ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (82, N'Grenada ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (83, N'Guadeloupe ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (84, N'Guam ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (85, N'Guatemala ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (86, N'Guernsey ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (87, N'Guinea ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (88, N'Guinea-Bissau ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (89, N'Guyana ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (90, N'Haiti ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (91, N'Honduras ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (92, N'Hong Kong ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (93, N'Hungary ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (94, N'Iceland ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (95, N'India ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (96, N'Indonesia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (97, N'Iran ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (98, N'Iraq ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (99, N'Ireland ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (100, N'Isle of Man ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (101, N'Israel ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (102, N'Italy ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (103, N'Jamaica ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (104, N'Japan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (105, N'Jersey ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (106, N'Jordan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (107, N'Kazakhstan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (108, N'Kenya ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (109, N'Kiribati ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (110, N'Korea, North ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (111, N'Korea, South ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (112, N'Kuwait ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (113, N'Kyrgyzstan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (114, N'Laos ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (115, N'Latvia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (116, N'Lebanon ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (117, N'Lesotho ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (118, N'Liberia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (119, N'Libya ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (120, N'Liechtenstein ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (121, N'Lithuania ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (122, N'Luxembourg ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (123, N'Macau ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (124, N'Macedonia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (125, N'Madagascar ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (126, N'Malawi ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (127, N'Malaysia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (128, N'Maldives ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (129, N'Mali ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (130, N'Malta ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (131, N'Marshall Islands ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (132, N'Martinique ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (133, N'Mauritania ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (134, N'Mauritius ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (135, N'Mayotte ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (136, N'Mexico ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (137, N'Micronesia, Fed. St. ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (138, N'Moldova ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (139, N'Monaco ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (140, N'Mongolia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (141, N'Montserrat ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (142, N'Morocco ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (143, N'Mozambique ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (144, N'Namibia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (145, N'Nauru ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (146, N'Nepal ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (147, N'Netherlands ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (148, N'Netherlands Antilles ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (149, N'New Caledonia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (150, N'New Zealand ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (151, N'Nicaragua ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (152, N'Niger ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (153, N'Nigeria ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (154, N'N. Mariana Islands ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (155, N'Norway ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (156, N'Oman ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (157, N'Pakistan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (158, N'Palau ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (159, N'Panama ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (160, N'Papua New Guinea ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (161, N'Paraguay ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (162, N'Peru ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (163, N'Philippines ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (164, N'Poland ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (165, N'Portugal ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (166, N'Puerto Rico ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (167, N'Qatar ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (168, N'Reunion ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (169, N'Romania ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (170, N'Russia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (171, N'Rwanda ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (172, N'Saint Helena ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (173, N'Saint Kitts & Nevis ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (174, N'Saint Lucia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (175, N'St Pierre & Miquelon ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (176, N'Saint Vincent and the Grenadines ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (177, N'Samoa ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (178, N'San Marino ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (179, N'Sao Tome & Principe ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (180, N'Saudi Arabia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (181, N'Senegal ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (182, N'Serbia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (183, N'Seychelles ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (184, N'Sierra Leone ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (185, N'Singapore ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (186, N'Slovakia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (187, N'Slovenia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (188, N'Solomon Islands ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (189, N'Somalia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (190, N'South Africa ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (191, N'Spain ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (192, N'Sri Lanka ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (193, N'Sudan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (194, N'Suriname ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (195, N'Swaziland ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (196, N'Sweden ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (197, N'Switzerland ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (198, N'Syria ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (199, N'Taiwan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (200, N'Tajikistan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (201, N'Tanzania ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (202, N'Thailand ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (203, N'Togo ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (204, N'Tonga ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (205, N'Trinidad & Tobago ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (206, N'Tunisia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (207, N'Turkey ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (208, N'Turkmenistan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (209, N'Turks & Caicos Is ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (210, N'Tuvalu ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (211, N'Uganda ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (212, N'Ukraine ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (213, N'United Arab Emirates ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (214, N'United Kingdom ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (215, N'United States ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (216, N'Uruguay ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (217, N'Uzbekistan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (218, N'Vanuatu ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (219, N'Venezuela ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (220, N'Vietnam ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (221, N'Virgin Islands ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (222, N'Wallis and Futuna ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (223, N'West Bank ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (224, N'Western Sahara ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (225, N'Yemen ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (226, N'Zambia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (227, N'Zimbabwe ')
GO
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[Genders] ON 
GO
INSERT [dbo].[Genders] ([GenderID], [GenderName]) VALUES (3, N'Bi-sexual')
GO
INSERT [dbo].[Genders] ([GenderID], [GenderName]) VALUES (2, N'Female')
GO
INSERT [dbo].[Genders] ([GenderID], [GenderName]) VALUES (4, N'Heterosexual')
GO
INSERT [dbo].[Genders] ([GenderID], [GenderName]) VALUES (1, N'Male')
GO
SET IDENTITY_INSERT [dbo].[Genders] OFF
GO
SET IDENTITY_INSERT [dbo].[MyFriends] ON 
GO
INSERT [dbo].[MyFriends] ([FriendID], [FirstName], [OtherNames], [Surname], [GenderID], [DateOfBirth], [ResidentialAddress], [City], [CountryID], [StateID], [WhatsappNumber], [OtherPhoneNumber], [Email], [Photo]) VALUES (1, N'Baba', NULL, N'Tope', 1, CAST(N'1978-05-12T00:00:00.000' AS DateTime), N'4 Iyalaje Street', N'Lagos', 153, 4, N'+374874847847', N'+234705187099', N'benmuyiwa@yahoo.com', NULL)
GO
SET IDENTITY_INSERT [dbo].[MyFriends] OFF
GO
SET IDENTITY_INSERT [dbo].[States] ON 
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (1, N'Kano State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (2, N'Lagos State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (3, N'Kaduna State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (4, N'Katsina State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (5, N'Oyo State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (6, N'Rivers State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (7, N'Bauchi State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (8, N'Jigawa State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (9, N'Benue State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (10, N'Anambra State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (11, N'Borno State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (12, N'Delta State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (13, N'Imo State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (14, N'Niger State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (15, N'Akwa Ibom State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (16, N'Ogun State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (17, N'Sokoto State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (18, N'Ondo State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (19, N'Osun State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (20, N'Kogi State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (21, N'Zamfara State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (22, N'Enugu State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (23, N'Kebbi State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (24, N'Edo State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (25, N'Plateau State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (26, N'Adamawa State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (27, N'Cross River State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (28, N'Abia State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (29, N'Ekiti State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (30, N'Kwara State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (31, N'Gombe State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (32, N'Yobe State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (33, N'Taraba State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (34, N'Ebonyi State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (35, N'Nasarawa State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (36, N'Bayelsa State', 153)
GO
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (37, N'Abuja Federal Capital Territory', 153)
GO
SET IDENTITY_INSERT [dbo].[States] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Genders]    Script Date: 10/10/2020 10:44:41 PM ******/
ALTER TABLE [dbo].[Genders] ADD  CONSTRAINT [IX_Genders] UNIQUE NONCLUSTERED 
(
	[GenderName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_States]    Script Date: 10/10/2020 10:44:41 PM ******/
ALTER TABLE [dbo].[States] ADD  CONSTRAINT [IX_States] UNIQUE NONCLUSTERED 
(
	[StateName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MyFriends]  WITH CHECK ADD  CONSTRAINT [FK_MyFriends_Countries] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Countries] ([CountryID])
GO
ALTER TABLE [dbo].[MyFriends] CHECK CONSTRAINT [FK_MyFriends_Countries]
GO
ALTER TABLE [dbo].[MyFriends]  WITH CHECK ADD  CONSTRAINT [FK_MyFriends_Genders] FOREIGN KEY([GenderID])
REFERENCES [dbo].[Genders] ([GenderID])
GO
ALTER TABLE [dbo].[MyFriends] CHECK CONSTRAINT [FK_MyFriends_Genders]
GO
ALTER TABLE [dbo].[MyFriends]  WITH CHECK ADD  CONSTRAINT [FK_MyFriends_States] FOREIGN KEY([StateID])
REFERENCES [dbo].[States] ([StateID])
GO
ALTER TABLE [dbo].[MyFriends] CHECK CONSTRAINT [FK_MyFriends_States]
GO
