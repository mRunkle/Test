CREATE TABLE Products
(
	ProductID int NOT NULL PRIMARY KEY,

	ProductName varchar(255) NOT NULL,
	SupplierID int FOREIGN KEY REFERENCES Suppliers(SupplierID),
	CategoryID int FOREIGN KEY REFERENCES Categories(CategoryID),
	QuantityPerUnit int NULL,
	UnitPrice money NOT NULL,
	UnitsInStock int NULL,
	UnitsOnOrder int NULL,
	ReorderLevel int NULL,
	Discontinued varchar(255) NULL
);