CREATE TABLE [dbo].[EmployeeTitle] (
    [EmployeeTitleID] INT            IDENTITY (1, 1) NOT NULL,
    [Descr]           NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([EmployeeTitleID] ASC)
);

