using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DreamToolsSmsGateway.SmsGateway.Model
{
    public class WapPushMessage:BaseSmsMessage
    {
        public string [] MessageUrl
        {
            get;
            set;
        }
    }
}
