using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MailApp2.RequestDTO
{
    [Route("/mail/send", "GET,POST")]
    public class Request
    {
        public string sendTo { get; set; }
        public string sendFrom { get; set; }
        public string message { get; set; }
        public string subject { get; set; }
    }

    //[Route("/hosp/list", "GET,POST")]
    //public class Request
    //{
    //    public string name1 { get; set; }
    //}
    //public class Response
    //{
    //    public bool isSuccess { get; set; }
    //}
}