USE [AP16]
GO

/****** Object:  Table [dbo].[Attachments]    Script Date: 19/05/2017 13:15:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Attachments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TaskId] [int] NOT NULL,
	[Value] [varbinary](max) NOT NULL,
	[TypeId] [int] NOT NULL,
 CONSTRAINT [PK_Attachments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Attachments]  WITH CHECK ADD  CONSTRAINT [FK_Attachments_AttachmentTypes] FOREIGN KEY([TypeId])
REFERENCES [dbo].[AttachmentTypes] ([Id])
GO

ALTER TABLE [dbo].[Attachments] CHECK CONSTRAINT [FK_Attachments_AttachmentTypes]
GO

ALTER TABLE [dbo].[Attachments]  WITH CHECK ADD  CONSTRAINT [FK_Attachments_Task] FOREIGN KEY([TaskId])
REFERENCES [dbo].[Task] ([Id])
GO

ALTER TABLE [dbo].[Attachments] CHECK CONSTRAINT [FK_Attachments_Task]
GO


