CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;

EXEC sp_InsertEmployee 
    @FirstName = 'Debojyoti',
    @LastName = 'Jha',
    @DepartmentID = 3,
    @Salary = 8500.00,
    @JoinDate = '2023-05-01';
