using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmsGatewayTurkcell
{
    public interface ISmsGatewayTurkcellAuthenticationService
    {
        string CreateSession(string spId, string serviceVariantID, string password);
        string GetSession
        {
            get;
        }
    }
}
