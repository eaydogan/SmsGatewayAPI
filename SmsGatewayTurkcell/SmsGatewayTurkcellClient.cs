using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DreamToolsSmsGateway.SmsGateway.Model;

namespace SmsGatewayTurkcell
{
    public class SmsGatewayTurkcellClient
    {
        SmsService.SendSMSInput _smsInput ;
        SmsService.SendSMSRequest _smsRequest ;
        SmsService.token _smsToken;
        SmsService.SendWAPPushInput _wapPushInput;
        SmsService.SendWAPPushRequest _wapPushRequest;
        SmsService.SendMMSInput _mmsInput;
        SmsService.SendMMSRequest _mmsRequest;
        SmsService.NIFSendMessagePortTypeClient _smsClient;
        string[] _transactionList;
      
        public SmsGatewayTurkcellClient()
        {
            _smsInput = new SmsService.SendSMSInput();
            _smsRequest = new SmsService.SendSMSRequest();
            _smsClient = new SmsService.NIFSendMessagePortTypeClient();
            _smsToken = new SmsService.token();
            _wapPushInput = new SmsService.SendWAPPushInput();
            _wapPushRequest = new SmsService.SendWAPPushRequest();
            _mmsInput = new SmsService.SendMMSInput();
            _mmsRequest = new SmsService.SendMMSRequest();
            _transactionList = new string[1];
            GetSession();
        }
        public SmsService.SendWAPPushOutput Send(WapPushMessage message)
        {
            //_smsInput.SHORT_NUMBER = "7023";
            _wapPushInput.SHORT_NUMBER = message.ShortNumber;
            int messageCount = message.Recievers.Count;
            _wapPushInput.TO_RECEIVERS = new string[messageCount];
            _wapPushInput.MESSAGE_BODY = new string[messageCount];
            _wapPushInput.SENDER = message.Sender;
            _wapPushInput.S_DATE = message.SendDate;
            _wapPushInput.EXPIRY_DATE = message.ExpryDate;
            _wapPushInput.MESSAGE_HREF = new string[1];
            for (int i = 0; i < messageCount; i++)
            {
                _wapPushInput.TO_RECEIVERS.SetValue(message.Recievers[i], i);
                // _smsInput.TO_RECEIVERS.SetValue("905330000000", 0);
                //_smsInput.MESSAGE_BODY.SetValue("Bu bir test mesajıdır!", 0);
                _wapPushInput.MESSAGE_BODY.SetValue(message.MessageBody[0], i);
                _wapPushInput.MESSAGE_HREF.SetValue(message.MessageUrl[0], i);
                _transactionList[0] = "64324423";
            }
            SmsGatewayTurkcell.SmsService.SendWAPPushOutput output = _smsClient.SendWAPPush(_smsToken, _transactionList, _wapPushInput);

            _smsClient.Close();
            return output;
        }
        public SmsService.SendMMSOutput Send(MmsMessage message)
        {
            //_smsInput.SHORT_NUMBER = "7023";
           
            _mmsInput.SHORT_NUMBER = message.ShortNumber;
            int messageCount = message.Recievers.Count;
            _mmsInput.TO_RECEIVERS = new string[messageCount];
            _mmsInput.MESSAGE_BODY = new string[messageCount];
            _mmsInput.SUBJECT = message.Subject;
            _mmsInput.S_DATE = message.SendDate;
            _mmsInput.EXPIRY_DATE = message.ExpryDate;
            _mmsInput.MIME_DATA = message.MimeData;
            
            for (int i = 0; i < messageCount; i++)
            {
                _mmsInput.TO_RECEIVERS.SetValue(message.Recievers[i], i);
                // _smsInput.TO_RECEIVERS.SetValue("905330000000", 0);
                //_smsInput.MESSAGE_BODY.SetValue("Bu bir test mesajıdır!", 0);
               // _wapPushInput.MESSAGE_BODY.SetValue(message.MessageBody[0], i);
               
                _transactionList[0] = "64324423";
            }
            SmsGatewayTurkcell.SmsService.SendMMSOutput output = _smsClient.SendMMS(_smsToken, _transactionList, _mmsInput);
           
            _smsClient.Close();
            return output;
        }
        public SmsService.SendSMSOutput Send(BaseSmsMessage smsMessage)
        {
            //_smsInput.SHORT_NUMBER = "7023";
            _smsInput.SHORT_NUMBER = smsMessage.ShortNumber;
            int messageCount = smsMessage.Recievers.Count;
            _smsInput.TO_RECEIVERS = new string[messageCount];
            _smsInput.MESSAGE_BODY = new string[messageCount];
            _smsInput.SENDER = smsMessage.Sender;
            _smsInput.S_DATE = smsMessage.SendDate;
            _smsInput.EXPIRY_DATE = smsMessage.ExpryDate;
            for (int i = 0; i < messageCount; i++)
            {
                _smsInput.TO_RECEIVERS.SetValue(smsMessage.Recievers[i], i);
                // _smsInput.TO_RECEIVERS.SetValue("905330000000", 0);
                //_smsInput.MESSAGE_BODY.SetValue("Bu bir test mesajıdır!", 0);
                _smsInput.MESSAGE_BODY.SetValue(smsMessage.MessageBody[0], i);
                _transactionList[0] = "64324423";
            }
            SmsGatewayTurkcell.SmsService.SendSMSOutput output = _smsClient.SendSMS(_smsToken, _transactionList, _smsInput);
            
            _smsClient.Close();
            return output;

        }

        private void GetSession()
        {
            ISmsGatewayTurkcellAuthenticationService i = new SmsGatewayTurkcellAuthenticationService();
            _smsToken.sessionId = i.CreateSession("905330000000", "12", "This is not a valid AuthenticationCode");
        }
    }
}
