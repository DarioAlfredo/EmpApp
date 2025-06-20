CREATE PROCEDURE GetTitleById
    @EmployeeTitleID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT EmployeeTitleID, Descr
    FROM EmployeeTitle
    WHERE EmployeeTitleID = @EmployeeTitleID;
END