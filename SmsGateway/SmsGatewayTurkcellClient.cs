using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DreamToolsSmsGateway.SmsGateway
{
    public class SmsGatewayTurkcellClient : SmsGatewayClientBase
    {
        private static SmsGatewayTurkcell.SmsGatewayTurkcellClient _client;
        public SmsGatewayTurkcellClient()
        {
            _client = new SmsGatewayTurkcell.SmsGatewayTurkcellClient();
        }

        public override SmsGateway.Model.SmsMessageOutPut SendSmsMessage(Model.BaseSmsMessage message)
        {
            var outPut = _client.Send(message);
            return new Model.SmsMessageOutPut()
            {
                ErrorCode = outPut.errorCode,
                ErrorDescription = outPut.errorDescription,
                StatusCode = outPut.statusCode
            };
        }
        public override Model.WapPushMessageOutPut SendWapPushMessage(Model.WapPushMessage message)
        {
            var outPut = _client.Send(message);
            return new Model.WapPushMessageOutPut()
            {
                ErrorCode = outPut.errorCode,
                ErrorDescription = outPut.errorDescription,
                StatusCode = outPut.statusCode
            };
        }
        public override Model.MmsMessageOutPut SendMmsMessage(Model.MmsMessage message)
        {
            var outPut = _client.Send(message);
            return new Model.MmsMessageOutPut()
            {
                ErrorCode = outPut.errorCode,
                ErrorDescription = outPut.errorDescription,
                StatusCode = outPut.statusCode
            };
        }
    }
}
