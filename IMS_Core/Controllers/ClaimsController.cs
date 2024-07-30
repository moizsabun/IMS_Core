using IMS_Core.Services.Interface;
using IMS_Core.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace IMS_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private readonly IClaimsData _Claims;
        public ClaimsController(IClaimsData Claims)
        {
            _Claims = Claims;
        }
        ResponseModel resp;
        [HttpGet()]
        public ResponseModel Get()
        {
            resp = new ResponseModel();
            try
            {
                resp.StatusMessage = "Sucessfull";
                resp.Data = _Claims.getSummary();
                resp.StatusCode = 200;
            }
            catch (Exception ex)
            {
                resp.StatusMessage = ex.Message;
                resp.Data = ex;
                resp.StatusCode = 400;
            }
            return resp;
        }
    }
}
