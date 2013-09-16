using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Dispatcher;
using System.ServiceModel;
using System.Xml;
using System.Threading;
using Microsoft.IdentityModel;
using Microsoft.IdentityModel.Claims;
using System.IO;
using System.ServiceModel.Channels;

namespace ClaimsToSoapHeader
{
    public class ClaimsToSoapHeaderInspector : IDispatchMessageInspector
    { 
        /// <summary>
        /// This method will copy the incoming claims to the SOAP header (the WCF adapter will place these header elements in the context)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="channel"></param>
        /// <param name="instanceContext"></param>
        /// <returns></returns>
        public object  AfterReceiveRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel, System.ServiceModel.InstanceContext instanceContext)
        {
 	        const string WRITE_PROPERTIES_NAMESPACE =   "http://schemas.microsoft.com/BizTalk/2006/01/Adapters/WCF-properties/WriteToContext";
            const string PROMOTE_PROPERTIES_NAMESPACE = "http://schemas.microsoft.com/BizTalk/2006/01/Adapters/WCF-properties/Promote";
            const string CLAIMTYPE_TO_COPY = "http://ADFSWIF/claims";
 
            var context = OperationContext.Current;
            var properties = new List<KeyValuePair<XmlQualifiedName, object>>();

            IClaimsIdentity ici = context.ServiceSecurityContext.PrimaryIdentity as IClaimsIdentity; //Thread.CurrentPrincipal.Identity as IClaimsIdentity;

            string claimsString = string.Empty;

            foreach (Claim c in ici.Claims)
            {
                //properties.Add(new KeyValuePair<XmlQualifiedName,object>(new XmlQualifiedName(c.ClaimType), c.Value));
                claimsString += "Type : " + c.ClaimType + "  -  Value : " + c.ClaimType + Environment.NewLine;
                var header = MessageHeader.CreateHeader(c.ClaimType, CLAIMTYPE_TO_COPY, c.Value);
                request.Headers.Add(header);
            }

            //use WRITE_PROPERTIES_NAMESPACE or PROMOTE_PROPERTIES_NAMESPACE
            //request.Properties[PROMOTE_PROPERTIES_NAMESPACE] = properties;

            //MessageBuffer requestBuffer = request.CreateBufferedCopy(request.ToString().Length);
            //Message requestCopy = requestBuffer.CreateMessage();

            //MemoryStream ms = new MemoryStream();
            //XmlWriter writer = XmlWriter.Create(ms);
            //requestCopy.WriteMessage(writer); // the message was consumed here
            //writer.Flush();
            //ms.Position = 0;
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(ms);

            //XmlNode node = xmlDoc.SelectSingleNode("//*[local-name()='output']");
            //if (node != null)
            //{
            //    node.InnerText = claimsString;
            //}
           
            ////Now recreating the message
            //ms = new MemoryStream();
            //xmlDoc.Save(ms);
            //ms.Position = 0;
            //XmlReader reader = XmlReader.Create(ms);
            //Message newMessage = Message.CreateMessage(reader, int.MaxValue, requestCopy.Version);
            //newMessage.Properties.CopyProperties(requestCopy.Properties);
            //newMessage.Headers.CopyHeadersFrom(requestCopy);
            //request = newMessage;


 
            return null;
        }
        
        public void  BeforeSendReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
        }
    }

  
}
