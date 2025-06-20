CREATE PROCEDURE GetEmployeeByID
    @EmployeeID INT
    AS
    SELECT e.EmployeeID, e.FirstName, e.LastName, e.DOB, e.IsActive, e.EmployeeTitleID, t.[Descr] AS EmployeeTitle
    FROM Employee e
    LEFT JOIN EmployeeTitle t ON e.EmployeeTitleID = t.EmployeeTitleID
    WHERE e.EmployeeID = @EmployeeID;