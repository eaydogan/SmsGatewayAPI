using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DreamToolsSmsGateway.SmsGateway
{
    public class SmsGatewayClientCreator : SmsGatewayClient
    {
        public override Model.SmsMessageOutPut SendSmsMessage(Model.BaseSmsMessage message)
        {
            return Client.SendSmsMessage(message);
        }
        public override Model.WapPushMessageOutPut SendWapPushMessage(Model.WapPushMessage message)
        {
            return Client.SendWapPushMessage(message);
        }
        public override Model.MmsMessageOutPut SendMmsMessage(Model.MmsMessage message)
        {
            return Client.SendMmsMessage(message);
        }
    }
}
