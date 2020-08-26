using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;

namespace PortfolioApp_Backend.Controllers
{
    
    [ApiController]
    [Route("api/download")]
    [EnableCors("EnableCors")]
    public class DownloadController : ControllerBase
    {
        [HttpGet]
        public IActionResult Download()
        {
            string fileName = "Piotr_Kochanowski_ENG_1.pdf";
            string filePath = $"../assets/{fileName}";
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "application/octet-stream");

        }
    }
}