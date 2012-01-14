using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmsGatewayTurkcell
{
    public class SmsGatewayTurkcellAuthenticationService : ISmsGatewayTurkcellAuthenticationService
    {
        private string _activeSession;
        private AuthenticationService.Authentication _authentication;
        public SmsGatewayTurkcellAuthenticationService()
        {
           // _authenticationClient = new AuthenticationService.AuthenticationClient();
          
        }
        #region Authentication Members

        public string CreateSession(string spId, string serviceVariantId, string password)
        {
            if (_authentication == null)
            {
                _authentication = new AuthenticationService.AuthenticationClient();
                _activeSession = _authentication.createSession(spId, serviceVariantId, password);
            }
            _activeSession = _authentication.createSession(spId,serviceVariantId,password);
            return _activeSession;
        }

        public string GetSession
        {
            get
            {

                return _activeSession;
            }
        }
        public void CloseSession()
        {
            ((AuthenticationService.AuthenticationClient)_authentication).Close();
        }
        #endregion
    }
}
