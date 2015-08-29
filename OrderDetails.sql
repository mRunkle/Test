CREATE TABLE OrderDetails
(
	OrderID int FOREIGN KEY REFERENCES Orders(OrderID),
	ProductID int FOREIGN KEY REFERENCES Products(ProductID),

	UnitPrice money NOT NULL,
	Quantity int NOT NULL,
	Discount varchar(255) NULL,

	PRIMARY KEY (OrderID, ProductID)
);