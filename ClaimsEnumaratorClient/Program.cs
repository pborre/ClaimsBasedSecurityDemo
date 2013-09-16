using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClaimsEnumaratorClient.ClaimsEnumeratorSVC;
using System.Net;
using System.Net.Security;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Security;
using System.ServiceModel.Security.Tokens;
using Microsoft.IdentityModel.Protocols.WSTrust;
using Microsoft.IdentityModel.Protocols.WSTrust.Bindings;
using Microsoft.IdentityModel.SecurityTokenService;
using System.IdentityModel.Tokens;


namespace ClaimsEnumaratorClient
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                
                //GetToken();
                ConsoleColor defaultcolor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Calling the service over transport security...");
                Console.ForegroundColor = defaultcolor;
                using (ClaimsEnumeratorClient proxy = new ClaimsEnumeratorClient("FedTransportSecurity")) 
                {
                    proxy.ClientCredentials.SupportInteractive = false;

                    ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(
                    delegate
                    {
                        return true;
                    });



                    ClaimItem[] claims = proxy.EnumerateMyClaims();

                    foreach (ClaimItem item in claims)
                        Console.WriteLine(item.ClaimType + " : " + item.ClaimValue);

                    
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Calling the service over message security...");
                Console.ForegroundColor = defaultcolor;
                using (ClaimsEnumeratorClient proxy2 = new ClaimsEnumeratorClient("FedMessageSecurity")) 
                {
                    proxy2.ClientCredentials.SupportInteractive = false;

                    //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(
                    //delegate
                    //{
                    //    return true;
                    //});

                    
                    ClaimItem[] claims = proxy2.EnumerateMyClaims();

                    foreach (ClaimItem item in claims)
                        Console.WriteLine(item.ClaimType + " : " + item.ClaimValue);


                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Calling the BizTalk service over message security...");
                Console.ForegroundColor = defaultcolor;
                using(BizTalkClaimsEnumerator.ClaimsBizTalkService_ClaimEnumerator_ClaimsBizTalkServicePortClient proxy3 = new BizTalkClaimsEnumerator.ClaimsBizTalkService_ClaimEnumerator_ClaimsBizTalkServicePortClient("BizTalkFedMessageSecurity"))
                {
                    BizTalkClaimsEnumerator.ClaimsRequest btsReq = new BizTalkClaimsEnumerator.ClaimsRequest();
                    BizTalkClaimsEnumerator.ClaimsResponse btsResp = new BizTalkClaimsEnumerator.ClaimsResponse();
                    btsReq.output = "test";
                    btsResp = proxy3.CaimsOrchestration(btsReq);

                    Console.WriteLine("BizTalk response: " + btsResp.input);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static SecurityToken GetToken()
        {
            string stsEndpoint = "https://win-beju5ai4tp7.pbdev.codit.eu/adfs/services/trust/2005/windowstransport";
            // Windows authentication over transport security
            var factory = new WSTrustChannelFactory(
                new WindowsWSTrustBinding(SecurityMode.Transport),
                stsEndpoint);
            factory.TrustVersion = TrustVersion.WSTrustFeb2005;

            var rst = new RequestSecurityToken
            {
                RequestType = RequestTypes.Issue,
                AppliesTo = new EndpointAddress("https://localhost:8732/ClaimsEnumeratorService/"),
                KeyType = KeyTypes.Symmetric
            };

            var channel = factory.CreateChannel();
            SecurityToken tk = channel.Issue(rst);

            Console.WriteLine(tk.Id);
            foreach (var key in tk.SecurityKeys)
            {
                Console.WriteLine(key.KeySize.ToString());
            }
            Console.WriteLine(tk.ValidFrom);
            Console.WriteLine(tk.ValidTo);

            return tk;
        }
    }
}
