using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ClaimsToSoapHeader
{
    class ClaimsToSoapHeaderEndpointBehavior : IEndpointBehavior
    {

        public void AddBindingParameters(ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            return;
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime)
        {
            return;
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher)
        {
             var messageInspector = new ClaimsToSoapHeaderInspector();
             endpointDispatcher.DispatchRuntime.MessageInspectors.Add(messageInspector);
        }

        public void Validate(ServiceEndpoint endpoint)
        {
            return;
        }
    }
}
