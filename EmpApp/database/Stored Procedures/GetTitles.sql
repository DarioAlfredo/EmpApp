CREATE PROCEDURE GetTitles
AS
BEGIN
    SET NOCOUNT ON;
    SELECT EmployeeTitleID, Descr
    FROM EmployeeTitle
    ORDER BY Descr;
END