CREATE PROCEDURE UpdateTitle
    @EmployeeTitleID INT,
    @Descr NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE EmployeeTitle
    SET Descr = @Descr
    WHERE EmployeeTitleID = @EmployeeTitleID;
END