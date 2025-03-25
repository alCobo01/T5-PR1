using T5_PR1.Models;

namespace T5_PR1.Data
{
    public class DbInitializer
    {
        private readonly AppDbContext _context;

        public DbInitializer(AppDbContext context) => _context = context;

        public void Seed()
        {
            if (!_context.Simulacions.Any())
            {
                _context.Simulacions.AddRange();
            }

            _context.SaveChanges();
        }
    }
}
