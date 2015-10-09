
using MailApp2.RequestDTO;
using MailApp2.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace MailApp2.Helper
{
    public class MailHelper
    {
        internal Response SendMail(Request obj)
        {
            Response respObj = new Response();

            try
            {
                MailMessage mMailMessage = new MailMessage();
                mMailMessage.To.Add(new MailAddress(obj.sendTo));

                mMailMessage.From = new MailAddress(obj.sendFrom);

                mMailMessage.Subject = obj.subject;

                StringBuilder desc = new StringBuilder();
                desc.Append("<html><body>");
                desc.Append("<h1>" + obj .message+ "</h1>");
       
                desc.Append("</body></html>");
                mMailMessage.Body = desc.ToString();
                mMailMessage.IsBodyHtml = true;
                SmtpClient mSmtpClient = new SmtpClient();
                mSmtpClient.Send(mMailMessage);

                respObj.isSuccess = true;
              
            }
            catch (Exception ex)
            {

                respObj.isSuccess = false;
               
            }


            return respObj;
        }

        internal Response SendMailTest(Request obj)
        {
            Response respObj = new Response();

           // respObj = RestServiceUtils.makeRestCall<Request, Response>(obj, "/provider/entity/locationVerfied", "www.google.com");

            return respObj;
        }
    }


}