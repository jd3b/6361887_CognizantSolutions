using Microsoft.EntityFrameworkCore;

var context = new AppDbContext();
await context.Database.EnsureCreatedAsync();
if (!await context.Categories.AnyAsync()) {
    var electronics = new Category { Name = "Electronics" };
    var groceries = new Category { Name = "Groceries" };
    await context.Categories.AddRangeAsync(electronics, groceries);

    var product1 = new Product { Name = "Laptop", Price = 75000m, Category = electronics };
    var product2 = new Product { Name = "Rice Bag", Price = 1200m, Category = groceries };
    await context.Products.AddRangeAsync(product1, product2);
    await context.SaveChangesAsync();

    Console.WriteLine("Initial data inserted.\n");
}
var products = await context.Products.ToListAsync();
Console.WriteLine("All Products:");
foreach (var p in products)
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
var productById = await context.Products.FindAsync(1);
Console.WriteLine($"\nFind by ID 1: {productById?.Name}");
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"\nExpensive Product: {expensive?.Name}");
