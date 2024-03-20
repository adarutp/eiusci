// Create a new product object
Product product = new Product();
product.Name = "Laptop";
product.Price = 999.99;

// Add the product to the database context
repo.Products.Add(product);

// Save the changes to the database
repo.SaveChanges();
