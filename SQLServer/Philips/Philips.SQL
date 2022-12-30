Select decode(trunc((manufacturer_number-1)/10), 0, 'AVERAGE', 1, 'GOOD', 2, 'EXCELENT', 'Unknown')
From Dual

/*==================================================*/

Create Or Replace Function func(f Varchar2)
Return PLS_Integer
Is
begin
  if NVL(Length(f), 1) = 1 then
    Return InStr('0123456789ABCDEF', f) -1;
  else
    Return 16 * func(SubStr(f, 1, Length(f) - 1)) + InStr('0123456789ABCDEF', SubStr(f, -1)) - 1;
  end if;
end;

Select func(21) Valor
From Dual;

/*==================================================*/

Create Table Department
(DepartmentId Integer,
 DepartmentName Varchar(50));

Insert Into Department
(DepartmentId, DepartmentName)
Values(1, 'IT');

Insert Into Department
(DepartmentId, DepartmentName)
Values(2, 'HR');

Insert Into Department
(DepartmentId, DepartmentName)
Values(3, 'Payroll');

Insert Into Department
(DepartmentId, DepartmentName)
Values(4, 'Admin');

Select *
From Department;

Create Table Employee
(EmployeeId Integer,
 EmployeeName Varchar(50),
 DepartmentId Int);

Insert Into Employee
(EmployeeId, EmployeeName, DepartmentId)
Values(1, 'Mark', 1);

Insert Into Employee
(EmployeeId, EmployeeName, DepartmentId)
Values(2, 'John', 1);

Insert Into Employee
(EmployeeId, EmployeeName, DepartmentId)
Values(3, 'Mike', 1);

Insert Into Employee
(EmployeeId, EmployeeName, DepartmentId)
Values(4, 'Mary', 2);

Insert Into Employee
(EmployeeId, EmployeeName, DepartmentId)
Values(5, 'Stacy', 2);

/*==================================================*/

Grant Select, Update, Insert On CampoProvas to Employee;

/*==================================================*/

Create Table Teste
(Codigo Number,
 Valor Decimal(12, 2),
 Longo Long);
 
 Select Codigo, Sum(Valor) Total
 From Teste
 Group By Longo;

/*==================================================*/

Select DepartmentName, EmployeeName
From Employee
Join Department On Department.DepartmentId = Employee.DepartmentId;

Select DepartmentName, EmployeeName
From Employee
Left Join Department On Department.DepartmentId = Employee.DepartmentId;

Select DepartmentName, EmployeeName
From Employee
Right Join Department On Department.DepartmentId = Employee.DepartmentId;

/*==================================================*/

Select (10 + 20) As Addition
From Dual;

/*==================================================*/

Select (2 * 2)
From Dual;

/*==================================================*/

Select Trim(' texto ') Valor
From Dual;

/*==================================================*/

Select Upper('23')
From Dual;

/*==================================================*/

Select RPad('administrator', 15, '*'),
       RPad('computer', 15, '*#')
From Dual;

/*==================================================*/

Create Or Replace View ViewFunc
As
  Select func(21) Valor
  From Dual;

Select *
From ViewFunc;

/*==================================================*/

Create Table Employee_Earnings
(EmployeeId Varchar(50),
 FirstName Varchar(50),
 LastName Varchar(50),
 Salary Integer,
 Department Varchar(50),
 Gender Varchar(50));

Insert Into Employee_Earnings
(EmployeeId, FirstName, LastName, Salary, Department, Gender)
Values(1, 'Bob', 'Johnson', 600000, 'IT', 'Male');

Insert Into Employee_Earnings
(EmployeeId, FirstName, LastName, Salary, Department, Gender)
Values(3, 'Betty', 'Davis', 1000000, 'IT', 'Female');

Insert Into Employee_Earnings
(EmployeeId, FirstName, LastName, Salary, Department, Gender)
Values(4, 'Tara', 'Brown', 480000, 'HR', 'Female');

Insert Into Employee_Earnings
(EmployeeId, FirstName, LastName, Salary, Department, Gender)
Values(5, 'John', 'Moore', 500000, 'Payroll', 'Male');

Insert Into Employee_Earnings
(EmployeeId, FirstName, LastName, Salary, Department, Gender)
Values(6, 'Mike', 'Jones', 530000, 'HR', 'Male');

Select *
From Employee_Earnings;

Select EmployeeId, Salary
From Employee_Earnings
Where Salary = (Select Max(Salary)
                From Employee_Earnings);

/*==================================================*/

Delete From Employee_Earnings;

Insert Into Employee_Earnings
(EmployeeId, FirstName, LastName, Salary, Department, Gender)
Values(1, 'Bob', 'Claude', 600000, 'IT', 'Male');

Insert Into Employee_Earnings
(EmployeeId, FirstName, LastName, Salary, Department, Gender)
Values(2, 'Lisa', 'Todd', 530000, 'HR', 'Female');

Insert Into Employee_Earnings
(EmployeeId, FirstName, LastName, Salary, Department, Gender)
Values(3, 'Rick', 'Cyril', 1000000, 'IT', 'Male');

Insert Into Employee_Earnings
(EmployeeId, FirstName, LastName, Salary, Department, Gender)
Values(4, 'Richard', 'Blake', 480000, 'HR', 'Male');

Insert Into Employee_Earnings
(EmployeeId, FirstName, LastName, Salary, Department, Gender)
Values(5, 'James', 'Conrad', 500000, 'Payroll', 'Male');

Insert Into Employee_Earnings
(EmployeeId, FirstName, LastName, Salary, Department, Gender)
Values(6, 'Olivia', 'Ashley', 300000, 'Payroll', 'Female');

Select *
From Employee_Earnings;

Select a.Department, b.FirstName, b.LastName, a.Salary
From (Select Department, Max(Salary) Salary
      From Employee_Earnings
      Group By Department) a
Join Employee_Earnings b On a.Department = b.Department And
                            a.Salary     = b.Salary;

/*==================================================*/

Create Table Customer
(CustomerId Integer,
 CustomerName Varchar(50));

Insert Into Customer
(CustomerId, CustomerName)
Values(1, 'A');

Insert Into Customer
(CustomerId, CustomerName)
Values(2, 'B');

Select *
From Customer;

Create Table Products
(ProductId Integer,
 CustomerId Varchar(50),
 ProductName Varchar(50));

Insert Into Products
(ProductId, CustomerId, ProductName)
Values(1, '1', 'X');

Insert Into Products
(ProductId, CustomerId, ProductName)
Values(2, '1', 'Y');

Insert Into Products
(ProductId, CustomerId, ProductName)
Values(3, '2', 'Z');

Select *
From Products;

Select CustomerName
From (Select CustomerId, Count(*) Total
       From Products
       Group By CustomerId) a
Join Customer b On a.CustomerId = b.CustomerId
Where a.Total <= 1;

/*==================================================*/
