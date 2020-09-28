CREATE DATABASE Shop;

USE Shop;

CREATE TABLE Products
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(30) NOT NULL UNIQUE
);	

CREATE TABLE Category
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(30) NOT NULL UNIQUE
);	

CREATE TABLE Link
(
    Id INT PRIMARY KEY IDENTITY,
    ProductId INT,
    CategoryId INT,
    FOREIGN KEY (ProductId) REFERENCES Products(Id),
    FOREIGN KEY (CategoryId) REFERENCES Category(Id)
);

-- Drink
INSERT Products VALUES ('Milk'); -- 1
INSERT Products VALUES ('Lemonade'); -- 2
INSERT Products VALUES ('Water'); -- 3
INSERT Products VALUES ('Tea'); -- 4
INSERT Products VALUES ('Cocoa'); -- 5
INSERT Products VALUES ('Coffee'); -- 6

-- Fruit
INSERT Products VALUES ('Apple'); -- 7
INSERT Products VALUES ('Pineapple'); -- 8
INSERT Products VALUES ('Banana'); -- 9
INSERT Products VALUES ('Avocado'); -- 10
INSERT Products VALUES ('Mango'); -- 11

-- Vegetables
INSERT Products VALUES ('Potato'); -- 12
INSERT Products VALUES ('Tomato'); -- 13
INSERT Products VALUES ('Carrot'); -- 14
INSERT Products VALUES ('Pepper'); -- 15

-- Сandy
INSERT Products VALUES ('Lollipop'); -- 16
INSERT Products VALUES ('Cookies'); -- 17
INSERT Products VALUES ('Pie'); -- 18

INSERT Products VALUES ('Bread');
INSERT Products VALUES ('Ketchup');
INSERT Products VALUES ('Lasagne');

-- Healthy 
INSERT Products VALUES ('Milk'); -- 1
INSERT Products VALUES ('Apple'); -- 7
INSERT Products VALUES ('Pineapple'); -- 8
INSERT Products VALUES ('Banana'); -- 9
INSERT Products VALUES ('Avocado'); -- 10
INSERT Products VALUES ('Mango'); -- 11
INSERT Products VALUES ('Potato'); -- 12
INSERT Products VALUES ('Tomato'); -- 13
INSERT Products VALUES ('Carrot'); -- 14
INSERT Products VALUES ('Pepper'); -- 15

-- Сandy
INSERT Products VALUES ('Lemonade'); -- 2
INSERT Products VALUES ('Cocoa'); -- 5
INSERT Products VALUES ('Mango'); -- 11

-- Category
INSERT Category VALUES('Drink');
INSERT Category VALUES('Fruit');
INSERT Category VALUES('Vegetables');
INSERT Category VALUES('Сandy');
INSERT Category VALUES('Healthy');

-- Drink
INSERT Link VALUES (1,1);
INSERT Link VALUES (2,1);
INSERT Link VALUES (3,1);
INSERT Link VALUES (4,1);
INSERT Link VALUES (5,1);
INSERT Link VALUES (6,1);

-- Fruit
INSERT Link VALUES (7,2);
INSERT Link VALUES (8,2);
INSERT Link VALUES (9,2);
INSERT Link VALUES (10,2);
INSERT Link VALUES (11,2);

-- Vegetables
INSERT Link VALUES (12,3);
INSERT Link VALUES (13,3);
INSERT Link VALUES (14,3);
INSERT Link VALUES (15,3);

-- Сandy
INSERT Link VALUES (16,4);
INSERT Link VALUES (17,4);
INSERT Link VALUES (18,4);

-- Healthy
INSERT Link VALUES (1,5);
INSERT Link VALUES (7,5);
INSERT Link VALUES (8,5);
INSERT Link VALUES (9,5);
INSERT Link VALUES (10,5);
INSERT Link VALUES (11,5);
INSERT Link VALUES (12,5);
INSERT Link VALUES (13,5);
INSERT Link VALUES (14,5);
INSERT Link VALUES (15,5);

-- Сandy
INSERT Link VALUES (2,4);
INSERT Link VALUES (5,4);
INSERT Link VALUES (11,4);

INSERT Link VALUES (19, NULL);
INSERT Link VALUES (20, NULL);
INSERT Link VALUES (21, NULL);
