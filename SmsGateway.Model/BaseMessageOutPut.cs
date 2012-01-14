using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DreamToolsSmsGateway.SmsGateway.Model
{
   public abstract class BaseMessageOutPut
    {
        public string[] StatusCode
        {
            get;
            set;
        }
        public string[] ErrorCode
        {
            get;
            set;
        }
        public string[] ErrorDescription
        {
            get;
            set;
        }
    }
}
