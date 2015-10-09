
using MailApp2.Helper;
using MailApp2.RequestDTO;
using MailApp2.ResponseDTO;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MailApp2.Services
{
    public class MailService : Service
    {
        public Response Any(Request RequestObj)
        {
            MailHelper obj = new MailHelper();
            return obj.SendMail(RequestObj);
        }
    }
}