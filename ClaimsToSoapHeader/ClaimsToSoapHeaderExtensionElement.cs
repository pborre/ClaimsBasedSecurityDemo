using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Configuration;

namespace ClaimsToSoapHeader
{
    class ClaimsToSoapHeaderExtensionElement : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get
            {
                return typeof(ClaimsToSoapHeaderEndpointBehavior);
            }
        }

        protected override object CreateBehavior()
        {
            return new ClaimsToSoapHeaderEndpointBehavior();
        }
    }
}
