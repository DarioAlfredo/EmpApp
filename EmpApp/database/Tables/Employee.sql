CREATE TABLE [dbo].[Employee] (
    [EmployeeID]      INT           IDENTITY (1, 1) NOT NULL,
    [EmployeeTitleID] INT           NULL,
    [FirstName]       NVARCHAR (50) NOT NULL,
    [LastName]        NVARCHAR (50) NOT NULL,
    [DOB]             DATE          NOT NULL,
    [IsActive]        BIT           DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC),
    CONSTRAINT [FK_Employee_EmployeeTitle] FOREIGN KEY ([EmployeeTitleID]) REFERENCES [dbo].[EmployeeTitle] ([EmployeeTitleID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Employee_EmployeeTitleID]
    ON [dbo].[Employee]([EmployeeTitleID] ASC);

