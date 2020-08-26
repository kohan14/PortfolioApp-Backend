using System;
using System.Net;
using System.Net.Mail;

namespace PortfolioApp_Backend
{
    public class EmailDataModel
    {   
        public string Address { get; set; }
        public string Topic { get; set; }
        public string Message { get; set; }
    }
}
