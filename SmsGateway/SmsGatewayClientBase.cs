using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DreamToolsSmsGateway.SmsGateway.Model;

namespace DreamToolsSmsGateway.SmsGateway
{
    public abstract class SmsGatewayClientBase
    {
        public abstract SmsMessageOutPut SendSmsMessage(BaseSmsMessage message);
        public abstract WapPushMessageOutPut SendWapPushMessage(WapPushMessage message);
        public abstract MmsMessageOutPut SendMmsMessage(MmsMessage message);
    }
}
