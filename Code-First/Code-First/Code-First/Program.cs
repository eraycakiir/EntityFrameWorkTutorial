
using Code_First.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using(var _context = new AppDbContext())
{
    var product = await _context.Product.ToListAsync();
    product.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} : {p.Name} - {p.Price} -{p.Stock} ");
    });
}
