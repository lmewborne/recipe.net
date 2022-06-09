using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Drawing;

namespace RecipeTest.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Steps { get; set; }

        public Recipe()
        {

        }
    }
    public class MachineDbContext : DbContext
    {
        public DbSet<Recipe> Machines { get; set; }
    }
}
