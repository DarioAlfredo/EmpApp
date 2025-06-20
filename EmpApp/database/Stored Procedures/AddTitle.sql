CREATE PROCEDURE AddTitle
    @Descr NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO EmployeeTitle (Descr)
    VALUES (@Descr);
END