-- Select Employees with Titles (including those with NULL title)
CREATE PROCEDURE GetEmployeesWithTitles
AS
SELECT e.EmployeeID, e.FirstName, e.LastName, e.DOB, e.IsActive, e.EmployeeTitleID, t.[Descr] AS EmployeeTitle
FROM Employee e
LEFT JOIN EmployeeTitle t ON e.EmployeeTitleID = t.EmployeeTitleID;