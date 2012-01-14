using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DreamToolsSmsGateway.SmsGateway.Model
{
    public class TurkcellSmsMessage : BaseSmsMessage
    {
        public string SendDate
        {
            get;
            set;
        }
        public TurkcellSmsMessage()
        { 
        
        }
       
    }
}
