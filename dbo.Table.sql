CREATE TABLE [dbo].[Employee] (
    [ID]         INT not null  Primary key identity,
    [Surname]    NCHAR (100) NOT NULL,
    [Name]       NCHAR (100) NULL,
    [Patronymic] NCHAR (100) NULL,
    [BirstDate]  DATE        NULL,
    [Telephone]  NCHAR (10)  NULL,
    [Email]      NCHAR (30)  NULL,
    [TitleID]    INT         NOT NULL,
);