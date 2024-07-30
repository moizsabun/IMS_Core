using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Core.DA
{
    public class orcl_DbContext :DbContext
    {
        public orcl_DbContext(DbContextOptions<orcl_DbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          
        }
    }
}
