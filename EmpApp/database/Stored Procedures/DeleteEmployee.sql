CREATE PROCEDURE DeleteEmployee
    @EmployeeID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Employee
    WHERE EmployeeID = @EmployeeID;
END