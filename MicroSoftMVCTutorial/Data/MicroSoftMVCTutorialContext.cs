using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MicroSoftMVCTutorial.Models
{
    public class MicroSoftMVCTutorialContext : DbContext
    {
        public MicroSoftMVCTutorialContext (DbContextOptions<MicroSoftMVCTutorialContext> options)
            : base(options)
        {
        }

        public DbSet<MicroSoftMVCTutorial.Models.Movie> Movie { get; set; }
    }
}
