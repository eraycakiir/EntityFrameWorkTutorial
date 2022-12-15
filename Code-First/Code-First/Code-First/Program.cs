
using Code_First.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using(var _context = new AppDbContext())
{
    _context.Product.Add(new() { Name = "Kalem 1", Price = 200, Stock = 100, Barcode = 123 });
    _context.Product.Add(new() { Name = "Kalem 1", Price = 200, Stock = 100, Barcode = 123 });
    _context.Product.Add(new() { Name = "Kalem 1", Price = 200, Stock = 100, Barcode = 123 });
    _context.SaveChanges();
    
    
    
    
    
    
    
    
    
    
    /* var product = await _context.Product.ToListAsync();
    product.ForEach(p =>
    {
        var state = _context.Entry(p).State;
        Console.WriteLine($"{p.Id} : {p.Name} - {p.Price} -{p.Stock} state:{state}");
    }); */
}
