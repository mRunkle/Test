CREATE TABLE Employees
(
	EmployeeID int NOT NULL PRIMARY KEY,
	
	LastName varchar(255) NOT NULL,
	FirstName varchar(255) NULL,
	Title varchar(255) NULL,
	TitleOfCourtesy varchar(255) NULL,
	BirthDate date NULL,
	HireDate date NOT NULL,
	StreetAddress varchar(255) NULL,
	City varchar(255) NULL,
	Region varchar(255) NULL,
	PostalCode varchar(255) NULL,
	Country varchar(255) NULL,
	HomePhone varchar(255) NULL,
	Extension varchar(255) NULL,
	Photo image NULL,
	Notes text NULL,
	ReportsTo int FOREIGN KEY REFERENCES Employees(EmployeeID),
	PhotoPath varchar(255) NULL,
);