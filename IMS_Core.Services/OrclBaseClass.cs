using IMS_Core.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Core.Services
{
    public class OrclBaseClass
    {
        protected readonly orcl_DbContext _OrclDBContext;
        public OrclBaseClass(orcl_DbContext oracleDBContext)
        {
            this._OrclDBContext = oracleDBContext;
        }
    }
}
