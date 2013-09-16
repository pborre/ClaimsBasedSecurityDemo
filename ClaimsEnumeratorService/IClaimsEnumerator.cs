using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ClaimsEnumeratorService
{
    [ServiceContract]
    public interface IClaimsEnumerator
    {
        [OperationContract]
        List<ClaimItem> EnumerateMyClaims();

    }

    [DataContract]
    public class ClaimItem
    {
        string claimType = "";
        string claimValue = "";

        [DataMember]
        public string ClaimType
        {
            get { return claimType; }
            set { claimType = value; }
        }

        [DataMember]
        public string ClaimValue
        {
            get { return claimValue; }
            set { claimValue = value; }
        }
    }
}
