using IMS_Core.DA;
using IMS_Core.Models;
using IMS_Core.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Core.Services
{
    public class ClaimsServices : OrclBaseClass, IClaimsData
    {
        public ClaimsServices(orcl_DbContext oracleDBContext) : base(oracleDBContext)
        {
        }

        public List<Claims_Summary> getSummary()
        {
            try
            {
                return _OrclDBContext.CLAIMS_SUMMARY.ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
