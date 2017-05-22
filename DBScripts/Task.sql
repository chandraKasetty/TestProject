USE [AP16]
GO

/****** Object:  Table [dbo].[Task]    Script Date: 19/05/2017 13:16:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Task](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](10) NOT NULL,
	[Description] [varchar](max) NULL,
	[StatusId] [int] NOT NULL,
	[AssigneeId] [int] NOT NULL,
	[DueDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Assignee] FOREIGN KEY([AssigneeId])
REFERENCES [dbo].[Assignees] ([Id])
GO

ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Assignee]
GO

ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([Id])
GO

ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Status]
GO


