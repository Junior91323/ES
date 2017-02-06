using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public class ESDBContext : DbContext
    {
        public ESDBContext() : base("MVC_Test")
        {

        }

        public DbSet<Book> Books { get; set; }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
    }
}
