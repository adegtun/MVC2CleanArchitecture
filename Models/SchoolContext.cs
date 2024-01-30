using Microsoft.EntityFrameworkCore;
using MVC2.Models;

namespace MVC2.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }
        

      

    }
}
