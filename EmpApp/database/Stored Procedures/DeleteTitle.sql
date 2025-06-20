CREATE PROCEDURE DeleteTitle
    @EmployeeTitleID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM EmployeeTitle
    WHERE EmployeeTitleID = @EmployeeTitleID;
END