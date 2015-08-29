CREATE TABLE Suppliers
(
	SupplierID int NOT NULL PRIMARY KEY,

	CompanyName varchar(255) NOT NULL,
	ContactName varchar(255) NULL,
	ContactTitle varchar(255) NULL,
	StreetAddress varchar(255) NULL,
	City varchar(255) NULL,
	Region varchar(255) NULL,
	PostalCode varchar(255) NULL,
	Country varchar(255) NULL,
	Phone varchar(255) NULL,
	Fax varchar(255) NULL,
	HomePage varchar(255) NULL
);