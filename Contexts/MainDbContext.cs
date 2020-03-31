
using Microsoft.EntityFrameworkCore;

namespace Contexts {
    public class MainDbContext : DbContext {

        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {}

        

    }
}