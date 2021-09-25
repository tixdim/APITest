using Microsoft.EntityFrameworkCore;
using Rubic_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic_test.Contexts
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> options) : base(options) {}

        public DbSet<Note> Notes { get; set; }
    }
}
