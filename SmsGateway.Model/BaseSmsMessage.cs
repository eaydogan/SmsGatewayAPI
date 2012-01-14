using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DreamToolsSmsGateway.SmsGateway.Model
{
    public abstract class BaseSmsMessage
    {
        public virtual IList<string> Recievers
        {
            get;
            set;
        }
        public virtual IList<string> MessageBody
        {
            get;
            set;
        }
        public virtual string Sender
        {
            get;
            set;
        }
        public virtual string ShortNumber
        {
            get;
            set;
        }
        public virtual string ExpryDate
        {
            get;
            set;
        }
        public virtual string SendDate
        {
            get;
            set;
        }
    }
}
