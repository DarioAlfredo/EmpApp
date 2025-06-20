CREATE PROCEDURE UpdateEmployee
    @EmployeeID INT,
    @EmployeeTitleID INT = NULL,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @DOB DATE,
    @IsActive BIT
AS
UPDATE Employee
SET EmployeeTitleID = @EmployeeTitleID,
    FirstName = @FirstName,
    LastName = @LastName,
    DOB = @DOB,
    IsActive = @IsActive
WHERE EmployeeID = @EmployeeID;