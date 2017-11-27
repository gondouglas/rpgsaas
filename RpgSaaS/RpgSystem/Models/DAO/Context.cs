using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgSystem.Models.DAO
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<AttributeBase> AttributesBase { get; set; }
        public DbSet<CharacterBase> Characters { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<ItemBase> Items { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Resistance> Resistances { get; set; }
        public DbSet<TypeItem> TypeItem { get; set; }
    }
}
