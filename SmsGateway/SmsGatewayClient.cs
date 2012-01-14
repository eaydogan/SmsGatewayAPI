using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DreamToolsSmsGateway.SmsGateway.Model;

namespace DreamToolsSmsGateway.SmsGateway
{
    public abstract class SmsGatewayClient
    {
        private SmsGatewayClientBase _client;
        public void SetGatewayClient(SmsGatewayClientBase client)
        {
            _client = client;
        }
        protected SmsGatewayClientBase Client
        {
            get
            {
                return _client;
            }
        }
        public abstract Model.SmsMessageOutPut SendSmsMessage(BaseSmsMessage message);
        public abstract WapPushMessageOutPut SendWapPushMessage(WapPushMessage message);
        public abstract Model.MmsMessageOutPut SendMmsMessage(MmsMessage message);
    }
}
