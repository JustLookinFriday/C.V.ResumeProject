USE [C.V.Resume]
GO
/****** Object:  Table [dbo].[AdditionalInfo]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdditionalInfo](
	[IDAdditionalInfo] [int] NOT NULL,
	[MilitaryService] [bit] NOT NULL,
	[IDCategories] [int] NOT NULL,
	[IDSubcategories] [int] NOT NULL,
	[Recommendations] [nvarchar](max) NULL,
	[Hobby] [nvarchar](max) NULL,
	[PersonalQualities] [nvarchar](max) NULL,
 CONSTRAINT [PK_Additional_information] PRIMARY KEY CLUSTERED 
(
	[IDAdditionalInfo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BasicInfo]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BasicInfo](
	[IDBasicInfo] [int] NOT NULL,
	[Pic] [nvarchar](max) NULL,
	[Surname] [nvarchar](20) NOT NULL,
	[Name] [nvarchar](15) NOT NULL,
	[Patronymic] [nvarchar](15) NULL,
	[Post] [nvarchar](25) NULL,
	[DesiredSalary] [float] NOT NULL,
	[IDBusyness] [int] NOT NULL,
	[IDWorkPlan] [int] NOT NULL,
	[BusinessTrips] [bit] NOT NULL,
	[Phone] [nvarchar](12) NOT NULL,
	[Email] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_BasicInfo] PRIMARY KEY CLUSTERED 
(
	[IDBasicInfo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BusynessTable]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BusynessTable](
	[IDBusyness] [int] IDENTITY(1,1) NOT NULL,
	[Busyness] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_BusynessID] PRIMARY KEY CLUSTERED 
(
	[IDBusyness] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoriesTable]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriesTable](
	[IDCategories] [int] NOT NULL,
	[A] [bit] NOT NULL,
	[B] [bit] NOT NULL,
	[BE] [bit] NOT NULL,
	[C] [bit] NOT NULL,
	[CE] [bit] NOT NULL,
	[D] [bit] NOT NULL,
	[DE] [bit] NOT NULL,
	[M] [bit] NOT NULL,
	[TM] [bit] NOT NULL,
	[TB] [bit] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[IDCategories] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CousersAndTrainings]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CousersAndTrainings](
	[IDCousersAndTrainings] [int] NOT NULL,
	[Course] [nvarchar](45) NOT NULL,
	[Institution] [nvarchar](45) NOT NULL,
	[IDYearOfGraduction] [int] NOT NULL,
	[Duration] [nvarchar](max) NULL,
 CONSTRAINT [PK_CandTInfo] PRIMARY KEY CLUSTERED 
(
	[IDCousersAndTrainings] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Education]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Education](
	[IDEducation] [int] NOT NULL,
	[EducationalInstitution] [nvarchar](45) NOT NULL,
	[Faculty] [nvarchar](45) NOT NULL,
	[Specialization] [nvarchar](45) NULL,
	[IDYearOfGraduation] [int] NOT NULL,
	[IDEducationalForm] [int] NOT NULL,
 CONSTRAINT [PK_EduInfo] PRIMARY KEY CLUSTERED 
(
	[IDEducation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EducationFormTable]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationFormTable](
	[IDEducationForm] [int] IDENTITY(1,1) NOT NULL,
	[EducationForm] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_idEducationForm] PRIMARY KEY CLUSTERED 
(
	[IDEducationForm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Experience]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Experience](
	[IDExperience] [int] NOT NULL,
	[Hire] [date] NOT NULL,
	[Fire] [date] NOT NULL,
	[LastPost] [nvarchar](25) NOT NULL,
	[FullEmployment] [bit] NOT NULL,
	[Organization] [nvarchar](45) NOT NULL,
	[ResponsibilitiesAndAchievements] [nvarchar](max) NULL,
 CONSTRAINT [PK_ExpInfo] PRIMARY KEY CLUSTERED 
(
	[IDExperience] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FamilyStatusTable]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FamilyStatusTable](
	[IDFamilyStatus] [int] IDENTITY(1,1) NOT NULL,
	[FamilyStatus] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_idFamilyStatus] PRIMARY KEY CLUSTERED 
(
	[IDFamilyStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guest]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guest](
	[IDGuest] [int] NOT NULL,
	[IDBasicInfo] [int] NULL,
	[IDPersonalInfo] [int] NULL,
	[IDExperience] [int] NULL,
	[IDEducation] [int] NULL,
	[IDCousersAndTrainings] [int] NULL,
	[IDITSkills] [int] NULL,
	[IDAdditionalInfo] [int] NULL,
 CONSTRAINT [PK_Basic_Info] PRIMARY KEY CLUSTERED 
(
	[IDGuest] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ITSkills]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITSkills](
	[IDITSkills] [int] NOT NULL,
	[LanguageKnowledge] [nvarchar](max) NULL,
	[Documents] [bit] NOT NULL,
	[Internet] [bit] NOT NULL,
	[Email] [bit] NOT NULL,
	[MSWord] [bit] NOT NULL,
	[MSExcel] [bit] NOT NULL,
	[MSPowerPoint] [bit] NOT NULL,
	[Other] [nvarchar](max) NULL,
 CONSTRAINT [PK_IT_skills] PRIMARY KEY CLUSTERED 
(
	[IDITSkills] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LearningTable]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LearningTable](
	[IDLearning] [int] IDENTITY(1,1) NOT NULL,
	[Learning] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_idEducation] PRIMARY KEY CLUSTERED 
(
	[IDLearning] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovementTable]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovementTable](
	[IDMovement] [int] IDENTITY(1,1) NOT NULL,
	[Movement] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_idMovement] PRIMARY KEY CLUSTERED 
(
	[IDMovement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonalInfo]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalInfo](
	[IDPersonalInfo] [int] NOT NULL,
	[CityOfResidence] [nvarchar](30) NULL,
	[IDMovement] [int] NOT NULL,
	[Citizenship] [nvarchar](50) NULL,
	[Birthday] [date] NOT NULL,
	[IDSex] [int] NOT NULL,
	[IDFamilyStatus] [int] NOT NULL,
	[Kids] [bit] NOT NULL,
	[IDLearning] [int] NOT NULL,
 CONSTRAINT [PK_PersonalInfo] PRIMARY KEY CLUSTERED 
(
	[IDPersonalInfo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SexTable]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SexTable](
	[IDSex] [int] IDENTITY(1,1) NOT NULL,
	[Sex] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_idSex] PRIMARY KEY CLUSTERED 
(
	[IDSex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubcategoriesTable]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubcategoriesTable](
	[IDSubcategories] [int] NOT NULL,
	[A1] [bit] NOT NULL,
	[B1] [bit] NOT NULL,
	[C1] [bit] NOT NULL,
	[C1E] [bit] NOT NULL,
	[D1] [bit] NOT NULL,
	[D1E] [bit] NOT NULL,
 CONSTRAINT [PK_SubcategoriesTable] PRIMARY KEY CLUSTERED 
(
	[IDSubcategories] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkPlanTable]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkPlanTable](
	[IDWorkPlan] [int] IDENTITY(1,1) NOT NULL,
	[WorkPlan] [nvarchar](max) NULL,
 CONSTRAINT [PK_idWorkPlan] PRIMARY KEY CLUSTERED 
(
	[IDWorkPlan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YearOfGraduationTable]    Script Date: 04.06.2022 23:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YearOfGraduationTable](
	[IDYearOfGraduation] [int] IDENTITY(1,1) NOT NULL,
	[YearOfGraduation] [char](4) NOT NULL,
 CONSTRAINT [PK_YearOfGraduation] PRIMARY KEY CLUSTERED 
(
	[IDYearOfGraduation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BusynessTable] ON 

INSERT [dbo].[BusynessTable] ([IDBusyness], [Busyness]) VALUES (1, N'Full')
INSERT [dbo].[BusynessTable] ([IDBusyness], [Busyness]) VALUES (2, N'Partial')
INSERT [dbo].[BusynessTable] ([IDBusyness], [Busyness]) VALUES (3, N'Project')
INSERT [dbo].[BusynessTable] ([IDBusyness], [Busyness]) VALUES (4, N'Internship')
INSERT [dbo].[BusynessTable] ([IDBusyness], [Busyness]) VALUES (5, N'Volunteering')
SET IDENTITY_INSERT [dbo].[BusynessTable] OFF
GO
SET IDENTITY_INSERT [dbo].[EducationFormTable] ON 

INSERT [dbo].[EducationFormTable] ([IDEducationForm], [EducationForm]) VALUES (1, N'Internal')
INSERT [dbo].[EducationFormTable] ([IDEducationForm], [EducationForm]) VALUES (2, N'Internal-extramural (evening) ')
INSERT [dbo].[EducationFormTable] ([IDEducationForm], [EducationForm]) VALUES (3, N'Extramural')
INSERT [dbo].[EducationFormTable] ([IDEducationForm], [EducationForm]) VALUES (4, N'Distance')
SET IDENTITY_INSERT [dbo].[EducationFormTable] OFF
GO
SET IDENTITY_INSERT [dbo].[FamilyStatusTable] ON 

INSERT [dbo].[FamilyStatusTable] ([IDFamilyStatus], [FamilyStatus]) VALUES (1, N'Married')
INSERT [dbo].[FamilyStatusTable] ([IDFamilyStatus], [FamilyStatus]) VALUES (2, N'Single')
SET IDENTITY_INSERT [dbo].[FamilyStatusTable] OFF
GO
SET IDENTITY_INSERT [dbo].[LearningTable] ON 

INSERT [dbo].[LearningTable] ([IDLearning], [Learning]) VALUES (1, N'Secondary')
INSERT [dbo].[LearningTable] ([IDLearning], [Learning]) VALUES (2, N'Secondary incomplete')
INSERT [dbo].[LearningTable] ([IDLearning], [Learning]) VALUES (3, N'Secondary vocational')
INSERT [dbo].[LearningTable] ([IDLearning], [Learning]) VALUES (4, N'Higher incomplete')
SET IDENTITY_INSERT [dbo].[LearningTable] OFF
GO
SET IDENTITY_INSERT [dbo].[MovementTable] ON 

INSERT [dbo].[MovementTable] ([IDMovement], [Movement]) VALUES (1, N'Impossible')
INSERT [dbo].[MovementTable] ([IDMovement], [Movement]) VALUES (2, N'Possible')
INSERT [dbo].[MovementTable] ([IDMovement], [Movement]) VALUES (3, N'Undesirable')
INSERT [dbo].[MovementTable] ([IDMovement], [Movement]) VALUES (4, N'Desirable')
SET IDENTITY_INSERT [dbo].[MovementTable] OFF
GO
INSERT [dbo].[PersonalInfo] ([IDPersonalInfo], [CityOfResidence], [IDMovement], [Citizenship], [Birthday], [IDSex], [IDFamilyStatus], [Kids], [IDLearning]) VALUES (0, N'wqdwdqdqdwqdqw', 1, N'wdqwdqwdqwdqwdqwd', CAST(N'2022-06-21' AS Date), 3, 1, 0, 1)
INSERT [dbo].[PersonalInfo] ([IDPersonalInfo], [CityOfResidence], [IDMovement], [Citizenship], [Birthday], [IDSex], [IDFamilyStatus], [Kids], [IDLearning]) VALUES (1, N'fsfsfsaasaf', 1, N'fsasfaf', CAST(N'2022-06-23' AS Date), 1, 1, 0, 1)
GO
SET IDENTITY_INSERT [dbo].[SexTable] ON 

INSERT [dbo].[SexTable] ([IDSex], [Sex]) VALUES (1, N'Male')
INSERT [dbo].[SexTable] ([IDSex], [Sex]) VALUES (2, N'Female')
INSERT [dbo].[SexTable] ([IDSex], [Sex]) VALUES (3, N'Donkey')
INSERT [dbo].[SexTable] ([IDSex], [Sex]) VALUES (4, N'Helicopter')
INSERT [dbo].[SexTable] ([IDSex], [Sex]) VALUES (5, N'Nigger')
INSERT [dbo].[SexTable] ([IDSex], [Sex]) VALUES (6, N'No')
SET IDENTITY_INSERT [dbo].[SexTable] OFF
GO
SET IDENTITY_INSERT [dbo].[WorkPlanTable] ON 

INSERT [dbo].[WorkPlanTable] ([IDWorkPlan], [WorkPlan]) VALUES (1, N'Full day')
INSERT [dbo].[WorkPlanTable] ([IDWorkPlan], [WorkPlan]) VALUES (2, N'Shift schedule')
INSERT [dbo].[WorkPlanTable] ([IDWorkPlan], [WorkPlan]) VALUES (3, N'Flexible schedule')
INSERT [dbo].[WorkPlanTable] ([IDWorkPlan], [WorkPlan]) VALUES (4, N'Remote work')
INSERT [dbo].[WorkPlanTable] ([IDWorkPlan], [WorkPlan]) VALUES (5, N'Shift method')
SET IDENTITY_INSERT [dbo].[WorkPlanTable] OFF
GO
SET IDENTITY_INSERT [dbo].[YearOfGraduationTable] ON 

INSERT [dbo].[YearOfGraduationTable] ([IDYearOfGraduation], [YearOfGraduation]) VALUES (1, N'2020')
INSERT [dbo].[YearOfGraduationTable] ([IDYearOfGraduation], [YearOfGraduation]) VALUES (2, N'2021')
INSERT [dbo].[YearOfGraduationTable] ([IDYearOfGraduation], [YearOfGraduation]) VALUES (3, N'2022')
INSERT [dbo].[YearOfGraduationTable] ([IDYearOfGraduation], [YearOfGraduation]) VALUES (4, N'2023')
INSERT [dbo].[YearOfGraduationTable] ([IDYearOfGraduation], [YearOfGraduation]) VALUES (5, N'Next')
SET IDENTITY_INSERT [dbo].[YearOfGraduationTable] OFF
GO
ALTER TABLE [dbo].[AdditionalInfo]  WITH CHECK ADD  CONSTRAINT [FK_AdditionalInfo_Categories] FOREIGN KEY([IDCategories])
REFERENCES [dbo].[CategoriesTable] ([IDCategories])
GO
ALTER TABLE [dbo].[AdditionalInfo] CHECK CONSTRAINT [FK_AdditionalInfo_Categories]
GO
ALTER TABLE [dbo].[AdditionalInfo]  WITH CHECK ADD  CONSTRAINT [FK_AdditionalInfo_SubcategoriesTable] FOREIGN KEY([IDSubcategories])
REFERENCES [dbo].[SubcategoriesTable] ([IDSubcategories])
GO
ALTER TABLE [dbo].[AdditionalInfo] CHECK CONSTRAINT [FK_AdditionalInfo_SubcategoriesTable]
GO
ALTER TABLE [dbo].[BasicInfo]  WITH CHECK ADD  CONSTRAINT [FK_BasicInfo_BusynessTable] FOREIGN KEY([IDBusyness])
REFERENCES [dbo].[BusynessTable] ([IDBusyness])
GO
ALTER TABLE [dbo].[BasicInfo] CHECK CONSTRAINT [FK_BasicInfo_BusynessTable]
GO
ALTER TABLE [dbo].[BasicInfo]  WITH CHECK ADD  CONSTRAINT [FK_BasicInfo_WorkPlanTable] FOREIGN KEY([IDWorkPlan])
REFERENCES [dbo].[WorkPlanTable] ([IDWorkPlan])
GO
ALTER TABLE [dbo].[BasicInfo] CHECK CONSTRAINT [FK_BasicInfo_WorkPlanTable]
GO
ALTER TABLE [dbo].[CousersAndTrainings]  WITH CHECK ADD  CONSTRAINT [FK_CousersAndTrainings_YearOfGraduation] FOREIGN KEY([IDYearOfGraduction])
REFERENCES [dbo].[YearOfGraduationTable] ([IDYearOfGraduation])
GO
ALTER TABLE [dbo].[CousersAndTrainings] CHECK CONSTRAINT [FK_CousersAndTrainings_YearOfGraduation]
GO
ALTER TABLE [dbo].[Education]  WITH CHECK ADD  CONSTRAINT [FK_Education_YearOfGraduation] FOREIGN KEY([IDYearOfGraduation])
REFERENCES [dbo].[YearOfGraduationTable] ([IDYearOfGraduation])
GO
ALTER TABLE [dbo].[Education] CHECK CONSTRAINT [FK_Education_YearOfGraduation]
GO
ALTER TABLE [dbo].[Education]  WITH CHECK ADD  CONSTRAINT [FK_EduInfo_EducationForm] FOREIGN KEY([IDEducationalForm])
REFERENCES [dbo].[EducationFormTable] ([IDEducationForm])
GO
ALTER TABLE [dbo].[Education] CHECK CONSTRAINT [FK_EduInfo_EducationForm]
GO
ALTER TABLE [dbo].[Guest]  WITH CHECK ADD  CONSTRAINT [FK_Guest_AdditionalInfo] FOREIGN KEY([IDAdditionalInfo])
REFERENCES [dbo].[AdditionalInfo] ([IDAdditionalInfo])
GO
ALTER TABLE [dbo].[Guest] CHECK CONSTRAINT [FK_Guest_AdditionalInfo]
GO
ALTER TABLE [dbo].[Guest]  WITH CHECK ADD  CONSTRAINT [FK_Guest_BasicInfo] FOREIGN KEY([IDBasicInfo])
REFERENCES [dbo].[BasicInfo] ([IDBasicInfo])
GO
ALTER TABLE [dbo].[Guest] CHECK CONSTRAINT [FK_Guest_BasicInfo]
GO
ALTER TABLE [dbo].[Guest]  WITH CHECK ADD  CONSTRAINT [FK_Guest_CousersAndTrainings1] FOREIGN KEY([IDCousersAndTrainings])
REFERENCES [dbo].[CousersAndTrainings] ([IDCousersAndTrainings])
GO
ALTER TABLE [dbo].[Guest] CHECK CONSTRAINT [FK_Guest_CousersAndTrainings1]
GO
ALTER TABLE [dbo].[Guest]  WITH CHECK ADD  CONSTRAINT [FK_Guest_Education] FOREIGN KEY([IDEducation])
REFERENCES [dbo].[Education] ([IDEducation])
GO
ALTER TABLE [dbo].[Guest] CHECK CONSTRAINT [FK_Guest_Education]
GO
ALTER TABLE [dbo].[Guest]  WITH CHECK ADD  CONSTRAINT [FK_Guest_Experience] FOREIGN KEY([IDExperience])
REFERENCES [dbo].[Experience] ([IDExperience])
GO
ALTER TABLE [dbo].[Guest] CHECK CONSTRAINT [FK_Guest_Experience]
GO
ALTER TABLE [dbo].[Guest]  WITH CHECK ADD  CONSTRAINT [FK_Guest_ITSkills] FOREIGN KEY([IDITSkills])
REFERENCES [dbo].[ITSkills] ([IDITSkills])
GO
ALTER TABLE [dbo].[Guest] CHECK CONSTRAINT [FK_Guest_ITSkills]
GO
ALTER TABLE [dbo].[Guest]  WITH CHECK ADD  CONSTRAINT [FK_Guest_PersonalInfo] FOREIGN KEY([IDPersonalInfo])
REFERENCES [dbo].[PersonalInfo] ([IDPersonalInfo])
GO
ALTER TABLE [dbo].[Guest] CHECK CONSTRAINT [FK_Guest_PersonalInfo]
GO
ALTER TABLE [dbo].[PersonalInfo]  WITH CHECK ADD  CONSTRAINT [FK_PersonalInfo_FamilyStatusTable] FOREIGN KEY([IDFamilyStatus])
REFERENCES [dbo].[FamilyStatusTable] ([IDFamilyStatus])
GO
ALTER TABLE [dbo].[PersonalInfo] CHECK CONSTRAINT [FK_PersonalInfo_FamilyStatusTable]
GO
ALTER TABLE [dbo].[PersonalInfo]  WITH CHECK ADD  CONSTRAINT [FK_PersonalInfo_LearningTable] FOREIGN KEY([IDLearning])
REFERENCES [dbo].[LearningTable] ([IDLearning])
GO
ALTER TABLE [dbo].[PersonalInfo] CHECK CONSTRAINT [FK_PersonalInfo_LearningTable]
GO
ALTER TABLE [dbo].[PersonalInfo]  WITH CHECK ADD  CONSTRAINT [FK_PersonalInfo_MovementTable] FOREIGN KEY([IDMovement])
REFERENCES [dbo].[MovementTable] ([IDMovement])
GO
ALTER TABLE [dbo].[PersonalInfo] CHECK CONSTRAINT [FK_PersonalInfo_MovementTable]
GO
ALTER TABLE [dbo].[PersonalInfo]  WITH CHECK ADD  CONSTRAINT [FK_PersonalInfo_SexTable] FOREIGN KEY([IDSex])
REFERENCES [dbo].[SexTable] ([IDSex])
GO
ALTER TABLE [dbo].[PersonalInfo] CHECK CONSTRAINT [FK_PersonalInfo_SexTable]
GO
