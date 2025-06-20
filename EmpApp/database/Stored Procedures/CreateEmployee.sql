CREATE PROCEDURE CreateEmployee
    @FirstName NVARCHAR(100),
    @LastName NVARCHAR(100),
    @DOB DATE,
    @IsActive BIT,
    @EmployeeTitleID INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Employee (FirstName, LastName, DOB, IsActive, EmployeeTitleID)
    VALUES (@FirstName, @LastName, @DOB, @IsActive, @EmployeeTitleID);
END