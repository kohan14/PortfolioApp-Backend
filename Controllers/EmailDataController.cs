using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PortfolioApp_Backend
{
    [ApiController]
    [Route("api/emaildata")]

    public class EmailDataController : ControllerBase
    {

        [HttpPost]
        public EmailDataModel SaveEmail(EmailDataModel email)
        {
            MailAddress fromTo = new MailAddress("kohan696969@gmail.com");
            EmailService emailService = new EmailService(email, fromTo);
            emailService.SendEmail();
            return email;
        }

        [HttpGet]
        public int GetEmails()
        {
            return 0;
        }

    }
}
