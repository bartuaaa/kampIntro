using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CatergoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitInStock = 3;

Product product2 = new Product {Id = 2, CatergoryId = 5,
    UnitInStock = 5, ProductName="kalem", UnitPrice = 35};

ProductManager productManager = new ProductManager();
productManager.Add(product1);

