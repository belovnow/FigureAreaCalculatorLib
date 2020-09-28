SELECT Products.Name, Category.Name FROM Link 
LEFT JOIN Products 
ON Link.ProductId = Products.Id
LEFT JOIN Category
ON Link.CategoryId = Category.Id;
