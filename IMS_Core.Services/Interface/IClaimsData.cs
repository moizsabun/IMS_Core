using IMS_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Core.Services.Interface
{
    public interface IClaimsData
    {
        public List<Claims_Summary> getSummary();
    }
}
