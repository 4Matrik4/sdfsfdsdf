CREATE TABLE [dbo].[Employee] (
    [ID]         INT         IDENTITY (1, 1) NOT NULL,
    [Surname]    NCHAR (100) NOT NULL,
    [Name]       NCHAR (100) NULL,
    [Patronymic] NCHAR (100) NULL,
    [BirstDate]  DATE        NULL,
    [Telephone]  NCHAR (10)  NULL,
    [Email]      NCHAR (30)  NULL,
    [TitleID]    INT         NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Employee_ToTitle] FOREIGN KEY ([TitleID]) REFERENCES [dbo].[Title] ([Id])
);

