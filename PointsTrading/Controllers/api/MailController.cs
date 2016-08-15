using PointsTradingBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PointsTrading.Controllers.api
{
    public class MailController : ApiController
    {
        [HttpPost]
        public IHttpActionResult InsertMailId(Mail mail)
        {
            if (mail != null)
            {
                string result = string.Empty;
                MailManager mailManager = new MailManager();
                result = mailManager.SubscribeMail(mail.MailId);

                return Json(result);
            }
            else
            {
                return Json("null");
            }
        }
    }

    public class Mail
    {
        public string MailId { get; set; }
    }
}
