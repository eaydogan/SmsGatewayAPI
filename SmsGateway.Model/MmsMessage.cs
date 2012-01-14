using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DreamToolsSmsGateway.SmsGateway.Model
{
    public class MmsMessage:BaseSmsMessage
    {
        public string Subject
        {
            get;
            set;
        }
        public string MimeData
        {
            get;
            set;
        }
    }
}
