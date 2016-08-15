using PointsTradingDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsTradingBusinessLayer
{
    public class MailManager
    {
        public string SubscribeMail(string mailId)
        {
            string result = string.Empty;
            using (var dbContext = new PointsTradingEntities())
            {
                dbContext.Subscribers.Add(new Subscriber() { Email_ID = mailId });
                result = "success";
                dbContext.SaveChanges();
            }
            return result;
        }
    }
}
