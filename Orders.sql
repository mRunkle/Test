CREATE TABLE Orders
(
	OrderID int NOT NULL PRIMARY KEY,

	CustomerID int FOREIGN KEY REFERENCES Customers(CustomerID),
	EmployeeID int FOREIGN KEY REFERENCES Employees(EmployeeID),
	OrderDate varchar(255) NOT NULL,
	RequiredDate varchar(255) NOT NULL,
	ShippedDate varchar(255) NULL,
	ShipVia int FOREIGN KEY REFERENCES Shippers(ShipperID),
	Freight varchar(255) NULL,
	ShipName varchar(255) NULL,
	ShipAddress varchar(255) NULL,
	ShipCity varchar(255) NULL,
	ShipRegion varchar(255) NULL,
	ShipPostalCode varchar(255) NULL,
	ShipCountry varchar(255) NULL
);